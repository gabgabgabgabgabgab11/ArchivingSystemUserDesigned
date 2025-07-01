using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            BuildUI();          // Build the UI controls
            LoadCategories();   // Populate category dropdown
            LoadDepartments();  // Populate department dropdown
            LoadDocuments();    // Load all documents
        }

        /// <summary>
        /// Builds and lays out all controls for search/retrieve UI.
        /// </summary>
        private void BuildUI()
        {
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            // Header label
            var lblHeader = new Label()
            {
                Text = "Search Documents",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(30, 20),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };
            this.Controls.Add(lblHeader);

            // Search term label and textbox
            this.Controls.Add(new Label()
            {
                Text = "Search Term:",
                Location = new Point(30, 60),
                Size = new Size(120, 24),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            });

            txtSearch = new TextBox() { Location = new Point(150, 60), Size = new Size(260, 24) };
            this.Controls.Add(txtSearch);

            // Data grid view for displaying results
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
            dgvResults.Columns.Add("YearPublished", "Year Published"); // PATCH: Add Year Published column
            dgvResults.Columns.Add("DateAdded", "Date Added");
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "View", Text = "View File", UseColumnTextForButtonValue = true });
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "Download", Text = "Download", UseColumnTextForButtonValue = true });
            dgvResults.Columns.Add(new DataGridViewButtonColumn() { Name = "Details", Text = "View Details", UseColumnTextForButtonValue = true });
            dgvResults.CellContentClick += DgvResults_CellContentClick;
            dgvResults.ColumnHeadersHeight = 40;
            this.Controls.Add(dgvResults);

            // Search and Clear buttons
            btnSearch = new Button()
            {
                Text = "Search",
                Size = new Size(90, 30),
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSearch.FlatAppearance.BorderSize = 0; // Remove border
            btnClear = new Button()
            {
                Text = "Clear",
                Size = new Size(90, 30),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnClear.FlatAppearance.BorderSize = 0; // Remove border

            // Make search and clear buttons roundy
            MakeButtonRounded(btnSearch, 20);
            MakeButtonRounded(btnClear, 20);

            // Maintain roundness on resize
            btnSearch.Resize += (s, e) => MakeButtonRounded(btnSearch, 20);
            btnClear.Resize += (s, e) => MakeButtonRounded(btnClear, 20);

            // Category and Department filter dropdowns
            int comboY = dgvResults.Location.Y + dgvResults.Height + 40;
            var lblCategory = new Label() { Text = "Category:", Location = new Point(30, comboY), Size = new Size(85, 24), ForeColor = Color.White, BackColor = Color.Transparent };
            cmbCategory = new ComboBox() { Location = new Point(115, comboY), Size = new Size(220, 24), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblCategory);
            this.Controls.Add(cmbCategory);

            var lblDepartment = new Label() { Text = "Department:", Location = new Point(350, comboY), Size = new Size(105, 24), ForeColor = Color.White, BackColor = Color.Transparent };
            cmbDepartment = new ComboBox() { Location = new Point(455, comboY), Size = new Size(220, 24), DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblDepartment);
            this.Controls.Add(cmbDepartment);

            // Place buttons below ComboBoxes
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

        /// <summary>
        /// Helper to make a button have rounded corners.
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
        /// Loads document types (categories) into the category ComboBox.
        /// </summary>
        private void LoadCategories()
        {
            var repo = new DocumentRepository();
            var types = repo.GetAllDocumentTypes();
            types.Insert(0, new DocumentType() { Id = 0, TypeName = "All" });
            cmbCategory.DataSource = types;
            cmbCategory.DisplayMember = "TypeName";
            cmbCategory.ValueMember = "Id";
        }

        /// <summary>
        /// Loads department names into the department ComboBox.
        /// </summary>
        private void LoadDepartments()
        {
            var repo = new DocumentRepository();
            var departments = repo.GetAllDepartments();
            departments.Insert(0, new Department() { Id = 0, Name = "All" });
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        /// <summary>
        /// Loads all documents from the repository and applies the current filter.
        /// </summary>
        public void LoadDocuments()
        {
            var repo = new DocumentRepository();
            allDocs = repo.GetAllDocuments();
            ApplyFilter();
        }

        /// <summary>
        /// Filters and displays documents based on search term, category, and department.
        /// </summary>
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
                int rowIndex = dgvResults.Rows.Add(
                    doc.Title,
                    doc.Authors,
                    doc.TypeName,
                    doc.YearPublished > 0 ? doc.YearPublished.ToString() : "", // Display empty if not set
                    doc.DateArchived.ToString("yyyy-MM-dd"),
                    "View", "Download", "View Details"
                );

                bool hasFile = !string.IsNullOrWhiteSpace(doc.FilePath);

                // Show/hide/enable buttons accordingly
                dgvResults.Rows[rowIndex].Cells["View"].Value = "View";
                dgvResults.Rows[rowIndex].Cells["Download"].Value = "Download";
                dgvResults.Rows[rowIndex].Cells["Details"].Value = "View Details";

                // Disable View and Download if no file
                dgvResults.Rows[rowIndex].Cells["View"].ReadOnly = !hasFile;
                dgvResults.Rows[rowIndex].Cells["Download"].ReadOnly = !hasFile;

                // Visually gray out these buttons for clarity and show tooltip
                if (!hasFile)
                {
                    dgvResults.Rows[rowIndex].Cells["View"].Style.ForeColor = Color.Gray;
                    dgvResults.Rows[rowIndex].Cells["Download"].Style.ForeColor = Color.Gray;
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

        /// <summary>
        /// Handles clicks on the DataGridView's special button columns (View, Download, Details).
        /// </summary>
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

            // Handle View, Download, and Details button clicks
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
                MessageBox.Show(
                    $"Title: {doc.Title}\n" +
                    $"Authors: {doc.Authors}\n" +
                    $"Category: {doc.TypeName}\n" +
                    $"Department: {doc.DepartmentName}\n" +
                    $"Description: {doc.Description}\n" +
                    $"Year Published: {(doc.YearPublished > 0 ? doc.YearPublished.ToString() : "N/A")}\n" +
                    $"Date Archived: {doc.DateArchived:yyyy-MM-dd}",
                    "Document Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Opens the document file in the default PDF viewer.
        /// </summary>
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

        /// <summary>
        /// Allows user to download the document to a chosen path.
        /// </summary>
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