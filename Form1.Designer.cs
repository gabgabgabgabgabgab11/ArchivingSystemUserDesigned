namespace ArchivingSystemUserDesigned
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnManage = new FontAwesome.Sharp.IconButton();
            this.btnSearchRetrieve = new FontAwesome.Sharp.IconButton();
            this.btnAddDocument = new FontAwesome.Sharp.IconButton();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardControl1 = new ArchivingSystemUserDesigned.DashboardControl();
            this.addDocumentControl1 = new ArchivingSystemUserDesigned.AddDocumentControl();
            this.manageDocumentsControl1 = new ArchivingSystemUserDesigned.ManageDocumentsControl();
            this.searchRetrieveControl1 = new ArchivingSystemUserDesigned.SearchRetrieveControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Controls.Add(this.btnSearchRetrieve);
            this.panel1.Controls.Add(this.btnAddDocument);
            this.panel1.Controls.Add(this.imgHome);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1055);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 951);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(11, 0, 22, 0);
            this.btnLogout.Size = new System.Drawing.Size(259, 104);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManage.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnManage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManage.IconSize = 32;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 595);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(11, 0, 22, 0);
            this.btnManage.Size = new System.Drawing.Size(306, 104);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage Documents";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnSearchRetrieve
            // 
            this.btnSearchRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSearchRetrieve.FlatAppearance.BorderSize = 0;
            this.btnSearchRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRetrieve.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchRetrieve.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchRetrieve.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearchRetrieve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchRetrieve.IconSize = 32;
            this.btnSearchRetrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRetrieve.Location = new System.Drawing.Point(-3, 481);
            this.btnSearchRetrieve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchRetrieve.Name = "btnSearchRetrieve";
            this.btnSearchRetrieve.Padding = new System.Windows.Forms.Padding(11, 0, 22, 0);
            this.btnSearchRetrieve.Size = new System.Drawing.Size(327, 104);
            this.btnSearchRetrieve.TabIndex = 6;
            this.btnSearchRetrieve.Text = "Search/Retrieve";
            this.btnSearchRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchRetrieve.UseVisualStyleBackColor = true;
            this.btnSearchRetrieve.Click += new System.EventHandler(this.btnSearchRetrieve_Click_1);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAddDocument.FlatAppearance.BorderSize = 0;
            this.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDocument.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddDocument.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            this.btnAddDocument.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddDocument.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddDocument.IconSize = 32;
            this.btnAddDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDocument.Location = new System.Drawing.Point(-3, 367);
            this.btnAddDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Padding = new System.Windows.Forms.Padding(11, 0, 22, 0);
            this.btnAddDocument.Size = new System.Drawing.Size(327, 104);
            this.btnAddDocument.TabIndex = 5;
            this.btnAddDocument.Text = "Add Document";
            this.btnAddDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // imgHome
            // 
            this.imgHome.Image = ((System.Drawing.Image)(resources.GetObject("imgHome.Image")));
            this.imgHome.Location = new System.Drawing.Point(0, 0);
            this.imgHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(262, 260);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHome.TabIndex = 4;
            this.imgHome.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-3, 254);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(11, 0, 22, 0);
            this.btnDashboard.Size = new System.Drawing.Size(297, 104);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.dashboardControl1);
            this.panel2.Controls.Add(this.addDocumentControl1);
            this.panel2.Controls.Add(this.manageDocumentsControl1);
            this.panel2.Controls.Add(this.searchRetrieveControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 1055);
            this.panel2.TabIndex = 1;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardControl1.AutoSize = true;
            this.dashboardControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dashboardControl1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(1418, 1326);
            this.dashboardControl1.TabIndex = 1;
            this.dashboardControl1.Load += new System.EventHandler(this.dashboardControl1_Load);
            // 
            // addDocumentControl1
            // 
            this.addDocumentControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.addDocumentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDocumentControl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDocumentControl1.Location = new System.Drawing.Point(0, 0);
            this.addDocumentControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addDocumentControl1.Name = "addDocumentControl1";
            this.addDocumentControl1.Size = new System.Drawing.Size(1386, 1055);
            this.addDocumentControl1.TabIndex = 0;
            this.addDocumentControl1.Visible = false;
            // 
            // manageDocumentsControl1
            // 
            this.manageDocumentsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.manageDocumentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageDocumentsControl1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDocumentsControl1.Location = new System.Drawing.Point(0, 0);
            this.manageDocumentsControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageDocumentsControl1.Name = "manageDocumentsControl1";
            this.manageDocumentsControl1.Size = new System.Drawing.Size(1386, 1055);
            this.manageDocumentsControl1.TabIndex = 2;
            this.manageDocumentsControl1.Visible = false;
            // 
            // searchRetrieveControl1
            // 
            this.searchRetrieveControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.searchRetrieveControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRetrieveControl1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRetrieveControl1.Location = new System.Drawing.Point(0, 0);
            this.searchRetrieveControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.searchRetrieveControl1.Name = "searchRetrieveControl1";
            this.searchRetrieveControl1.Size = new System.Drawing.Size(1386, 1055);
            this.searchRetrieveControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AddDocumentControl addDocumentControl1;
        private DashboardControl dashboardControl1;
        private ManageDocumentsControl manageDocumentsControl1;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnManage;
        private FontAwesome.Sharp.IconButton btnSearchRetrieve;
        private FontAwesome.Sharp.IconButton btnAddDocument;
        private System.Windows.Forms.PictureBox imgHome;
        private SearchRetrieveControl searchRetrieveControl1;
    }
}

