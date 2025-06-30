using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArchivingSystemUserDesigned
{
    public partial class SearchRetrieveControl : UserControl
    {
        public TextBox txtSearch;
        public ComboBox cmbCategory, cmbDepartment;
        public Button btnSearch, btnClear;
        public DataGridView dgvResults;

        private List<Document> allDocs = new List<Document>();

        public SearchRetrieveControl()
        {
            InitializeComponent();
            BuildUI();
            LoadCategories();
            LoadDepartments();
            LoadDocuments();
        }

        private void BuildUI()
        {
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            var lblHeader = new Label()
            {
                Text = "Search Documents",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(30, 20),
                ForeColor = Color.White
            };
            this.Controls.Add(lblHeader);

            this.Controls.Add(new Label()
            {
                Text = "Search Term:",
                Location = new Point(30, 60),
                Size = new Size(120, 24),
                ForeColor = Color.White
            });

            txtSearch = new TextBox() { Location = new Point(150, 60), Size = new Size(260, 24) };
            this.Controls.Add(txtSearch);

            dgvResults = new DataGridView()
            {
                Location = new Point(30, 110),
                Font = new Font("Poppins", 9),
                Size = new Size(1100, 600),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                
                
            };
            dgvResults.Columns.Add("Title", "Title");
            dgvResults.Columns.Add("Author", "Author");
            dgvResults.Columns.Add("Category", "Category");
            dgvResults.Columns.Add("DateAdded", "Date Added");
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "View", Text = "View File", UseColumnTextForButtonValue = true });
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "Download", Text = "Download", UseColumnTextForButtonValue = true });
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "Details", Text = "View Details", UseColumnTextForButtonValue = true });
            dgvResults.CellContentClick += DgvResults_CellContentClick;
            dgvResults.ColumnHeadersHeight = 40;

            this.Controls.Add(dgvResults);

            // Initialize buttons BEFORE setting their properties/locations
            btnSearch = new Button()
            {
                Text = "Search",
                Size = new Size(90, 30),
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnClear = new Button()
            {
                Text = "Clear",
                Size = new Size(90, 30),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };

            int comboY = dgvResults.Location.Y + dgvResults.Height + 40;

            var lblCategory = new Label() { Text = "Category:", Location = new Point(30, comboY), Size = new Size(85, 24), ForeColor = Color.White };
            cmbCategory = new ComboBox() { Location = new Point(115, comboY), Size = new Size(220, 24), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblCategory);
            this.Controls.Add(cmbCategory);

            var lblDepartment = new Label() { Text = "Department:", Location = new Point(350, comboY), Size = new Size(105, 24), ForeColor = Color.White };
            cmbDepartment = new ComboBox() { Location = new Point(455, comboY), Size = new Size(220, 24), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblDepartment);
            this.Controls.Add(cmbDepartment);

            btnSearch.Location = new Point(705, comboY);
            btnClear.Location = new Point(805, comboY);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnClear);

            // Wire up events
            btnSearch.Click += (s, ev) => ApplyFilter();
            btnClear.Click += (s, ev) =>
            {
                txtSearch.Text = "";
                cmbCategory.SelectedIndex = 0;
                cmbDepartment.SelectedIndex = 0;
                LoadDocuments();
            };
            cmbCategory.SelectedIndexChanged += (s, ev) => ApplyFilter();
            cmbDepartment.SelectedIndexChanged += (s, ev) => ApplyFilter();
        }

        private void LoadCategories()
        {
            // Populate category dropdown from document types
            var repo = new DocumentRepository();
            var types = repo.GetAllDocumentTypes();
            types.Insert(0, new DocumentType() { Id = 0, TypeName = "All" });
            cmbCategory.DataSource = types;
            cmbCategory.DisplayMember = "TypeName";
            cmbCategory.ValueMember = "Id";
        }

        private void LoadDepartments()
        {
            var repo = new DocumentRepository();
            var departments = repo.GetAllDepartments();
            departments.Insert(0, new Department() { Id = 0, Name = "All" });
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        public void LoadDocuments()
        {
            var repo = new DocumentRepository();
            allDocs = repo.GetAllDocuments();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (allDocs == null) return;
            if (txtSearch == null) return; // Defensive: should never happen if BuildUI is called
            string search = txtSearch.Text.ToLower().Trim();

            int typeId = 0;
            if (cmbCategory.SelectedValue is int)
                typeId = (int)cmbCategory.SelectedValue;
            else if (int.TryParse(cmbCategory.SelectedValue?.ToString(), out int parsedType))
                typeId = parsedType;

            int deptId = 0;
            if (cmbDepartment.SelectedValue is int)
                deptId = (int)cmbDepartment.SelectedValue;
            else if (int.TryParse(cmbDepartment.SelectedValue?.ToString(), out int parsedDept))
                deptId = parsedDept;

            var filtered = allDocs.Where(d =>
                (string.IsNullOrEmpty(search) ||
                 (d.Title != null && d.Title.ToLower().Contains(search)) ||
                 (d.Authors != null && d.Authors.ToLower().Contains(search))
                ) &&
                (typeId == 0 || d.TypeId == typeId) &&
                (deptId == 0 || d.DepartmentId == deptId)
            ).ToList();

            dgvResults.Rows.Clear();
            foreach (var doc in filtered)
            {
                int rowIndex = dgvResults.Rows.Add(doc.Title, doc.Authors, doc.TypeName, doc.DateArchived.ToString("yyyy-MM-dd"), "View", "Download", "View Details");

                bool hasFile = !string.IsNullOrWhiteSpace(doc.FilePath);

                // Show/hide/enable buttons accordingly
              
                dgvResults.Rows[rowIndex].Cells["View"].Value = "View";
                dgvResults.Rows[rowIndex].Cells["Download"].Value = "Download";
                dgvResults.Rows[rowIndex].Cells["Details"].Value = "View Details";

                // Disable View and Download if no file
                dgvResults.Rows[rowIndex].Cells["View"].ReadOnly = !hasFile;
                dgvResults.Rows[rowIndex].Cells["Download"].ReadOnly = !hasFile;

                //  visually gray out these buttons for clarity
                if (!hasFile)
                {
                    dgvResults.Rows[rowIndex].Cells["View"].Style.ForeColor = Color.Gray;
                    dgvResults.Rows[rowIndex].Cells["Download"].Style.ForeColor = Color.Gray;

                    //show tooltip
                    dgvResults.Rows[rowIndex].Cells["View"].ToolTipText = "No file available";
                    dgvResults.Rows[rowIndex].Cells["Download"].ToolTipText = "No file available";
                }
                else
                {
                    dgvResults.Rows[rowIndex].Cells["View"].Style.ForeColor = Color.Black;
                    dgvResults.Rows[rowIndex].Cells["Download"].Style.ForeColor = Color.Black;
                    dgvResults.Rows[rowIndex].Cells["View"].ToolTipText = "";
                    dgvResults.Rows[rowIndex].Cells["Download"].ToolTipText = "";
                }
            }
        }

        private void DgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Get filtered list for current view (with dept filter too!)
            string search = txtSearch.Text.ToLower().Trim();
            int typeId = 0;
            if (cmbCategory.SelectedValue is int)
                typeId = (int)cmbCategory.SelectedValue;
            else if (int.TryParse(cmbCategory.SelectedValue?.ToString(), out int parsedType))
                typeId = parsedType;

            int deptId = 0;
            if (cmbDepartment.SelectedValue is int)
                deptId = (int)cmbDepartment.SelectedValue;
            else if (int.TryParse(cmbDepartment.SelectedValue?.ToString(), out int parsedDept))
                deptId = parsedDept;

            var filtered = allDocs.Where(d =>
                (string.IsNullOrEmpty(search) ||
                    (d.Title != null && d.Title.ToLower().Contains(search)) ||
                    (d.Authors != null && d.Authors.ToLower().Contains(search))
                ) &&
                (typeId == 0 || d.TypeId == typeId) &&
                (deptId == 0 || d.DepartmentId == deptId)
            ).ToList();

            if (e.RowIndex >= filtered.Count) return;

            var doc = filtered[e.RowIndex];

            if (e.ColumnIndex == dgvResults.Columns["View"].Index)
            {
                ViewDocument(doc.FilePath);
            }
            else if (e.ColumnIndex == dgvResults.Columns["Download"].Index)
            {
                DownloadDocument(doc.FilePath, doc.Title);
            }
            else if (e.ColumnIndex == dgvResults.Columns["Details"].Index)
            {
                // Show a MessageBox or your own details form
                MessageBox.Show(
                    $"Title: {doc.Title}\n" +
                    $"Authors: {doc.Authors}\n" +
                    $"Category: {doc.TypeName}\n" +
                    $"Department: {doc.DepartmentName}\n" +
                    $"Description: {doc.Description}\n" +
                    $"Date Archived: {doc.DateArchived:yyyy-MM-dd}",
                    "Document Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ViewDocument(string filePath)
        {
            try
            {
                // Open with default PDF viewer
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open file: " + ex.Message);
            }
        }

        private void DownloadDocument(string filePath, string title)
        {
            try
            {
                using (var sfd = new SaveFileDialog()
                {
                    FileName = title + ".pdf",
                    Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.Copy(filePath, sfd.FileName, true);
                        MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not download file: " + ex.Message);
            }
        }
    }
}