using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        /// <summary>
        /// Helper to make a button rounded with a given radius.
        /// </summary>
        private void MakeButtonRounded(Button btn, int radius = 20)
        {
            var rect = btn.ClientRectangle;
            using (var path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btn.Region = new Region(path);
            }
        }

        /// <summary>
        /// Build the UI for Manage Documents including search/filter, DataGridView, and edit area.
        /// </summary>
        private void BuildUI()
        {
            this.BackColor = Color.FromArgb(38, 38, 72);

            int y = 20;

            // --- Search Controls ---
            Controls.Add(CreateLabel("Search:", new Point(20, y + 4), 70));
            txtSearch = new TextBox() { Location = new Point(90, y), Width = 200, Font = new Font("Segoe UI", 10) };
            Controls.Add(txtSearch);

            Controls.Add(CreateLabel("Type:", new Point(310, y + 4), 50));
            cmbFilterType = new ComboBox()
            {
                Location = new Point(360, y),
                Width = 130,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            Controls.Add(cmbFilterType);

            Controls.Add(CreateLabel("Department:", new Point(510, y + 4), 110));
            cmbFilterDept = new ComboBox()
            {
                Location = new Point(620, y),
                Width = 130,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            Controls.Add(cmbFilterDept);

            // --- Filter and Refresh Buttons (Top Row) ---
            btnSearch = new Button()
            {
                Text = "Filter",
                Location = new Point(760, y),
                Width = 70,
                Height = 35,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnSearch.FlatAppearance.BorderSize = 0; // Remove border
            Controls.Add(btnSearch);

            btnRefresh = new Button()
            {
                Text = "Refresh",
                Location = new Point(850, y),
                Width = 90,
                Height = 35,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnRefresh.FlatAppearance.BorderSize = 0; // Remove border
            Controls.Add(btnRefresh);

            // Make top buttons roundy and keep them round on resize
            MakeButtonRounded(btnSearch, 18);
            MakeButtonRounded(btnRefresh, 18);
            btnSearch.Resize += (s, e) => MakeButtonRounded(btnSearch, 18);
            btnRefresh.Resize += (s, e) => MakeButtonRounded(btnRefresh, 18);

            y += 40;

            // --- DataGridView for listing documents ---
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

            // DataGridView columns setup
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

            // --- Edit controls area ---
            int editLabelW = 120, editFieldW = 200, columnSpacing = 40, rowH = 35;
            int formX1 = 20, formX2 = formX1 + editLabelW + editFieldW + columnSpacing;
            int formY = 400 + y;

            // Title
            Controls.Add(CreateLabel("Title:", new Point(formX1, formY + 6), editLabelW));
            txtTitle = new TextBox() { Location = new Point(formX1 + editLabelW, formY), Width = editFieldW, Font = new Font("Segoe UI", 10) };
            Controls.Add(txtTitle);

            // Authors
            Controls.Add(CreateLabel("Authors:", new Point(formX2, formY + 6), editLabelW));
            txtAuthors = new TextBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW + 70, Font = new Font("Segoe UI", 10) };
            Controls.Add(txtAuthors);

            formY += rowH;

            // Type
            Controls.Add(CreateLabel("Type:", new Point(formX1, formY + 6), editLabelW));
            cmbType = new ComboBox() { Location = new Point(formX1 + editLabelW, formY), Width = editFieldW, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) };
            Controls.Add(cmbType);

            // Department
            Controls.Add(CreateLabel("Department:", new Point(formX2, formY + 6), editLabelW));
            cmbDept = new ComboBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) };
            Controls.Add(cmbDept);

            formY += rowH;

            // Description
            Controls.Add(CreateLabel("Description:", new Point(formX1, formY + 6), editLabelW));
            txtDescription = new TextBox() { Location = new Point(formX1 + editLabelW, formY), Width = editFieldW, Height = rowH, Multiline = true, Font = new Font("Segoe UI", 8) };
            Controls.Add(txtDescription);

            // File Path
            Controls.Add(CreateLabel("File Path:", new Point(formX2, formY + 6), editLabelW));
            txtFilePath = new TextBox() { Location = new Point(formX2 + editLabelW, formY), Width = editFieldW + 70, Font = new Font("Segoe UI", 10), ReadOnly = true, BackColor = Color.LightGray };
            Controls.Add(txtFilePath);

            // --- Save, Delete, and Clear Buttons (Edit Area) ---
            int btnY = formY + rowH + 10;
            btnSave = new Button()
            {
                Text = "Save",
                Location = new Point(formX2 + editLabelW, btnY),
                Width = 80,
                Height = 35,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnSave.FlatAppearance.BorderSize = 0; // Remove border

            btnDelete = new Button()
            {
                Text = "Delete",
                Location = new Point(formX2 + editLabelW + 90, btnY),
                Width = 80,
                Height = 35,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnDelete.FlatAppearance.BorderSize = 0; // Remove border

            btnClear = new Button()
            {
                Text = "Clear",
                Location = new Point(formX2 + editLabelW + 180, btnY),
                Width = 80,
                Height = 35,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnClear.FlatAppearance.BorderSize = 0; // Remove border

            Controls.Add(btnSave); Controls.Add(btnDelete); Controls.Add(btnClear);

            // Make edit area buttons roundy and keep round on resize
            MakeButtonRounded(btnSave, 18);
            MakeButtonRounded(btnDelete, 18);
            MakeButtonRounded(btnClear, 18);
            btnSave.Resize += (s, e) => MakeButtonRounded(btnSave, 18);
            btnDelete.Resize += (s, e) => MakeButtonRounded(btnDelete, 18);
            btnClear.Resize += (s, e) => MakeButtonRounded(btnClear, 18);

            // --- Event Handlers for Buttons and DataGridView ---
            btnSearch.Click += (s, e) => ApplyFilter();
            btnRefresh.Click += (s, e) => LoadDocuments();
            btnSave.Click += (s, e) => SaveDocument();
            btnDelete.Click += (s, e) => DeleteDocument();
            btnClear.Click += (s, e) => ClearEditFields();

            dgv.DoubleClick += (s, e) => LoadSelectedDocument();
        }

        /// <summary>
        /// Helper to create white, transparent labels.
        /// </summary>
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

        /// <summary>
        /// Loads category/type and department dropdowns for both filter and edit areas.
        /// </summary>
        public void LoadDropdowns()
        {
            var repo = new DocumentRepository();

            // Filter dropdowns (top row)
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

            // Edit dropdowns (bottom form)
            cmbType.DataSource = repo.GetAllDocumentTypes();
            cmbType.DisplayMember = "TypeName";
            cmbType.ValueMember = "Id";
            cmbDept.DataSource = repo.GetAllDepartments();
            cmbDept.DisplayMember = "Name";
            cmbDept.ValueMember = "Id";
        }

        /// <summary>
        /// Loads all documents into the DataGridView and clears edit fields.
        /// </summary>
        public void LoadDocuments()
        {
            var repo = new DocumentRepository();
            allDocs = repo.GetAllDocuments();
            dgv.DataSource = allDocs;
            ClearEditFields();
        }

        /// <summary>
        /// Filters displayed documents based on search, category, and department.
        /// </summary>
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

        /// <summary>
        /// When a row is selected in the DataGridView, loads its data into the edit fields below.
        /// </summary>
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

        /// <summary>
        /// Saves the edited document details to the database.
        /// </summary>
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

        /// <summary>
        /// Deletes the selected document after confirmation.
        /// </summary>
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

        /// <summary>
        /// Clears all fields in the edit area.
        /// </summary>
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