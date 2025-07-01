using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivingSystemUserDesigned
{
    public partial class AddDocumentControl : UserControl
    {
        TextBox txtTitle, txtAuthors, txtFilePath, txtDescription;
        ComboBox cmbCategory, cmbDepartment;
        Button btnBrowse, btnSubmit, btnClear;
        NumericUpDown nudYearPublished;
        string pdfFilePath = "";

        public AddDocumentControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            int y = 20, spacing = 38, labelW = 140, fieldW = 500;

            Controls.Add(HeaderLabel("Add New Document", 10, y)); y += 36;
            Controls.Add(L("Document Title:", 10, y)); txtTitle = TB(160, y, fieldW); Controls.Add(txtTitle); y += spacing;
            Controls.Add(L("Author(s):", 10, y)); txtAuthors = TB(160, y, fieldW); Controls.Add(txtAuthors); y += spacing;
            Controls.Add(L("Document Category:", 10, y));
            cmbCategory = new ComboBox()
            {
                Location = new Point(160, y),
                Width = fieldW,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbCategory.Items.AddRange(new string[] { "RESEARCH/THESIS", "OJT TERMINAL REPORT", "OTHERS" });
            cmbCategory.SelectedIndex = 0;
            Controls.Add(cmbCategory);
            y += spacing;

            Controls.Add(L("Department:", 10, y));
            cmbDepartment = new ComboBox()
            {
                Location = new Point(160, y),
                Width = fieldW,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDepartment.Items.AddRange(new string[] {
                        "Information Technology",
                        "Computer Engineering",
                        "Education",
                        "Office Management Technology",
                        "Hospitality Management",
                        "Bachelor of Science in Accountancy",
                        "ENTREPENEURSHIP"
                    });
            cmbDepartment.SelectedIndex = 0;
            Controls.Add(cmbDepartment);
            y += spacing;

            // Year Published field
            Controls.Add(L("Year Published:", 10, y));
            nudYearPublished = new NumericUpDown()
            {
                Location = new Point(160, y),
                Width = 120,
                Minimum = 1900,
                Maximum = 2100,
                Value = DateTime.Now.Year,
                Font = new Font("Segoe UI", 10)
            };
            Controls.Add(nudYearPublished);
            y += spacing;

            Controls.Add(L("Upload Document (PDF):", 10, y));
            txtFilePath = TB(160, y, fieldW - 110); txtFilePath.ReadOnly = true; Controls.Add(txtFilePath);
            btnBrowse = new Button() { Text = "Choose File", Location = new Point(160 + fieldW - 100, y), Width = 100, Height = 30 };
            Controls.Add(btnBrowse);
            y += spacing;

            Controls.Add(L("Description (Optional):", 10, y));
            txtDescription = new TextBox()
            {
                Location = new Point(160, y),
                Width = fieldW,
                Height = 60,
                Multiline = true
            };
            Controls.Add(txtDescription);
            y += 70;

            btnSubmit = new Button()
            {
                Text = "Submit Document",
                Location = new Point(160, y),
                Width = 150,
                Height = 40,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnClear = new Button()
            {
                Text = "Clear Form",
                Location = new Point(320, y),
                Width = 110,
                Height = 40,
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            Controls.Add(btnSubmit); Controls.Add(btnClear);

            btnBrowse.Click += BtnBrowse_Click;
            btnSubmit.Click += BtnSubmit_Click;
            btnClear.Click += (s, e) => ClearForm();
        }

        Label HeaderLabel(string t, int x, int y)
           => new Label() { Text = t, Location = new Point(x, y), Font = new Font("Segoe UI", 14, FontStyle.Bold), AutoSize = true };
        Label L(string t, int x, int y)
            => new Label() { Text = t, Location = new Point(x, y + 4), Width = 140, Font = new Font("Segoe UI", 10) };
        TextBox TB(int x, int y, int w)
            => new TextBox() { Location = new Point(x, y), Width = w };

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF files (*.pdf)|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pdfFilePath = ofd.FileName;
                    txtFilePath.Text = pdfFilePath;
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validation: only allow OJT to not require pdf file
            bool isOjt = cmbCategory.SelectedItem.ToString().ToUpper().Contains("OJT");

            if (string.IsNullOrWhiteSpace(txtTitle.Text)
                || string.IsNullOrWhiteSpace(txtAuthors.Text)
                || (!isOjt && (string.IsNullOrWhiteSpace(pdfFilePath) || !pdfFilePath.ToLower().EndsWith(".pdf"))))
            {
                MessageBox.Show(isOjt
                    ? "Please fill in all required fields."
                    : "Please fill in all required fields and select a PDF file.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // File handling variables
            string destFolder = @"C:\ArchivePDFs\";
            string fileName = "";
            string destPath = "";

            // Only copy file if there is one (non-OJT, or OJT with file)
            if (!string.IsNullOrWhiteSpace(pdfFilePath))
            {
                if (!System.IO.Directory.Exists(destFolder))
                    System.IO.Directory.CreateDirectory(destFolder);

                fileName = System.IO.Path.GetFileName(pdfFilePath);
                destPath = System.IO.Path.Combine(destFolder, fileName);
                // Check if file already exists in destination
                if (System.IO.File.Exists(destPath))
                {
                    MessageBox.Show("A file with the same name already exists in the archive. Upload aborted.", "Duplicate File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    System.IO.File.Copy(pdfFilePath, destPath, false); // false = do not overwrite
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to copy PDF file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Find type_id and department_id from names
            var repo = new DocumentRepository();
            int typeId = repo.GetTypeIdByName(cmbCategory.SelectedItem.ToString());
            int deptId = repo.GetDepartmentIdByName(cmbDepartment.SelectedItem.ToString());

            // Insert into database
            var doc = new Document()
            {
                Title = txtTitle.Text,
                Authors = txtAuthors.Text,
                TypeId = typeId,
                DepartmentId = deptId,
                FilePath = destPath, // Will be "" for OJT with no file
                Description = txtDescription.Text,
                DateArchived = DateTime.Now,
                YearPublished = (int)nudYearPublished.Value // <-- Save Year Published
            };
            try
            {
                repo.InsertDocument(doc);
                MessageBox.Show("Document submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save document: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtTitle.Text = "";
            txtAuthors.Text = "";
            cmbCategory.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            nudYearPublished.Value = DateTime.Now.Year;
            txtFilePath.Text = "";
            txtDescription.Text = "";
            pdfFilePath = "";
        }
    }
}