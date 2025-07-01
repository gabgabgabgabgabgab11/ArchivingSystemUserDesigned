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
    public partial class ManageDocumentsControl : UserControl
    {
      
        List<Document> allDocs;
        Document selectedDoc;
       
        private TextBox txtSearch, txtTitle, txtAuthors, txtDescription, txtFilePath;
        private ComboBox cmbFilterType, cmbFilterDept, cmbType, cmbDept;
        private Button btnSearch, btnRefresh, btnSave, btnDelete, btnClear;
        private DataGridView dgv;

        public ManageDocumentsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            BuildUI();
        }

        private void BuildUI()
        {
            this.BackColor = Color.FromArgb(38, 38, 72);

            int y = 20;

            // Search Controls
            Controls.Add(CreateLabel("Search:", new Point(20, y + 4), 70));
            txtSearch = new TextBox() { Location = new Point(90, y), Width = 200, Font = new Font("Segoe UI", 10) }; Controls.Add(txtSearch);

            Controls.Add(CreateLabel("Type:", new Point(310, y + 4), 50));
            cmbFilterType = new ComboBox() { Location = new Point(360, y), Width = 130, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) }; Controls.Add(cmbFilterType);

            Controls.Add(CreateLabel("Department:", new Point(510, y + 4), 110));
            cmbFilterDept = new ComboBox() { Location = new Point(620, y), Width = 130, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) }; Controls.Add(cmbFilterDept);

            btnSearch = new Button() { Text = "Filter", Location = new Point(760, y), Width = 70, Height = 35, BackColor = Color.RoyalBlue, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnRefresh = new Button() { Text = "Refresh", Location = new Point(850, y), Width = 90, Height = 35, BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            Controls.Add(btnSearch); Controls.Add(btnRefresh);

            y += 40;

            // DataGridView
            dgv = new DataGridView()
            {
                Location = new Point(20, y),
                Size = new Size(1100, 600),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoGenerateColumns = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(dgv);

            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", DataPropertyName = "Id", Width = 40 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Title", DataPropertyName = "Title", Width = 180 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Authors", DataPropertyName = "Authors", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Type", DataPropertyName = "TypeName", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Dept.", DataPropertyName = "DepartmentName", Width = 110 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Description", DataPropertyName = "Description", Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Year Published", DataPropertyName = "YearPublished", Width = 80 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "File Path", DataPropertyName = "FilePath", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Date Archived", DataPropertyName = "DateArchived", Width = 110, DefaultCellStyle = new DataGridViewCellStyle() { Format = "yyyy-MM-dd" } });
            dgv.ColumnHeadersHeight = 40;

            dgv.SelectionChanged += (s, e) => LoadSelectedDocument();

            y += 240;

            // --- Edit controls ---
            int editLabelW = 120, editFieldW = 200, columnSpacing = 40, rowH = 35;
            int formX1 = 20, formX2 = formX1 + editLabelW + editFieldW + columnSpacing;
            int formY = 400 + y;

            Controls.Add(CreateLabel("Title:", new Point(formX1, formY + 6), editLabelW));
            txtTitle = new TextBox() { Location = new Point(formX1  + editLabelW, formY), Width = editFieldW, Font = new Font("Segoe UI", 10) }; Controls.Add(txtTitle);

            Controls.Add(CreateLabel("Authors:", new Point(formX2, formY + 6), editLabelW));
            txtAuthors = new TextBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW + 70, Font = new Font("Segoe UI", 10) }; Controls.Add(txtAuthors);

            formY += rowH;

            Controls.Add(CreateLabel("Type:", new Point(formX1, formY + 6), editLabelW));
            cmbType = new ComboBox() { Location = new Point(formX1  + editLabelW, formY), Width = editFieldW, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) }; Controls.Add(cmbType);

            Controls.Add(CreateLabel("Department:", new Point(formX2, formY + 6), editLabelW));
            cmbDept = new ComboBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) }; Controls.Add(cmbDept);

            formY += rowH;

            Controls.Add(CreateLabel("Description:", new Point(formX1, formY + 6), editLabelW));
            txtDescription = new TextBox() { Location = new Point(formX1 + editLabelW, formY), Width = editFieldW, Height = rowH, Multiline = true, Font = new Font("Segoe UI", 8) }; Controls.Add(txtDescription);

            Controls.Add(CreateLabel("File Path:", new Point(formX2, formY + 6), editLabelW));
            txtFilePath = new TextBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW + 70, Font = new Font("Segoe UI", 10), ReadOnly = true, BackColor = Color.LightGray }; Controls.Add(txtFilePath);

            // Buttons 
            int btnY = formY + rowH + 10;
            btnSave = new Button() { Text = "Save", Location = new Point(formX2 + editLabelW, btnY), Width = 80, Height = 35, BackColor = Color.RoyalBlue, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnDelete = new Button() { Text = "Delete", Location = new Point(formX2 + editLabelW + 90, btnY), Width = 80, Height = 35, BackColor = Color.Red, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnClear = new Button() { Text = "Clear", Location = new Point(formX2 + editLabelW + 180, btnY), Width = 80, Height = 35, BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            Controls.Add(btnSave); Controls.Add(btnDelete); Controls.Add(btnClear);

            // Events
            btnSearch.Click += (s, e) => ApplyFilter();
            btnRefresh.Click += (s, e) => LoadDocuments();
            btnSave.Click += (s, e) => SaveDocument();
            btnDelete.Click += (s, e) => DeleteDocument();
            btnClear.Click += (s, e) => ClearEditFields();

            dgv.DoubleClick += (s, e) => LoadSelectedDocument();
        }

        // Helper to create white labels
        private Label CreateLabel(string text, Point location, int width = 70)
        {
            return new Label()
            {
                Text = text,
                Location = location,
                Width = width,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
        public void LoadDropdowns()
        {
            var repo = new DocumentRepository();

            // Filter dropdowns
            var types = repo.GetAllDocumentTypes();
            types.Insert(0, new DocumentType() { Id = 0, TypeName = "All" });
            cmbFilterType.DataSource = types.ToList();
            cmbFilterType.DisplayMember = "TypeName";
            cmbFilterType.ValueMember = "Id";

            var deps = repo.GetAllDepartments();
            deps.Insert(0, new Department() { Id = 0, Name = "All" });
            cmbFilterDept.DataSource = deps.ToList();
            cmbFilterDept.DisplayMember = "Name";
            cmbFilterDept.ValueMember = "Id";

            // Edit dropdowns
            cmbType.DataSource = repo.GetAllDocumentTypes();
            cmbType.DisplayMember = "TypeName";
            cmbType.ValueMember = "Id";
            cmbDept.DataSource = repo.GetAllDepartments();
            cmbDept.DisplayMember = "Name";
            cmbDept.ValueMember = "Id";
        }

        public void LoadDocuments()
        {
            var repo = new DocumentRepository();
            allDocs = repo.GetAllDocuments();
            dgv.DataSource = allDocs;
            ClearEditFields();
        }

        private void ApplyFilter()
        {
            if (allDocs == null) return;
            string search = txtSearch.Text.ToLower().Trim();
            int typeId = (int)cmbFilterType.SelectedValue;
            int deptId = (int)cmbFilterDept.SelectedValue;

            var filtered = allDocs.Where(d =>
                (string.IsNullOrEmpty(search) ||
                 (d.Title != null && d.Title.ToLower().Contains(search)) ||
                 (d.Authors != null && d.Authors.ToLower().Contains(search))
                ) &&
                (typeId == 0 || d.TypeId == typeId) &&
                (deptId == 0 || d.DepartmentId == deptId)
            ).ToList();
            dgv.DataSource = filtered;
        }

        private void LoadSelectedDocument()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                selectedDoc = null;
                ClearEditFields();
                return;
            }
            selectedDoc = dgv.SelectedRows[0].DataBoundItem as Document;
            if (selectedDoc == null) return;
            txtTitle.Text = selectedDoc.Title;
            txtAuthors.Text = selectedDoc.Authors;
            cmbType.SelectedValue = selectedDoc.TypeId;
            cmbDept.SelectedValue = selectedDoc.DepartmentId;
            txtDescription.Text = selectedDoc.Description;
            txtFilePath.Text = selectedDoc.FilePath;
        }

        private void SaveDocument()
        {
            if (selectedDoc == null)
            {
                MessageBox.Show("Select a document to edit.", "Notice");
                return;
            }
            try
            {
                selectedDoc.Title = txtTitle.Text;
                selectedDoc.Authors = txtAuthors.Text;
                selectedDoc.TypeId = (int)cmbType.SelectedValue;
                selectedDoc.DepartmentId = (int)cmbDept.SelectedValue;
                selectedDoc.Description = txtDescription.Text;
                selectedDoc.FilePath = txtFilePath.Text;

                var repo = new DocumentRepository();
                repo.UpdateDocument(selectedDoc);

                MessageBox.Show("Document updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving document: " + ex.Message);
            }
        }

        private void DeleteDocument()
        {
            if (selectedDoc == null)
            {
                MessageBox.Show("Select a document to delete.", "Notice");
                return;
            }
            if (MessageBox.Show("Delete selected document?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var repo = new DocumentRepository();
                repo.DeleteDocument(selectedDoc.Id);
                LoadDocuments();
            }
        }

        private void ClearEditFields()
        {
            txtTitle.Text = "";
            txtAuthors.Text = "";
            cmbType.SelectedIndex = 0;
            cmbDept.SelectedIndex = 0;
            txtDescription.Text = "";
            txtFilePath.Text = "";
            selectedDoc = null;
        }
    }
}
