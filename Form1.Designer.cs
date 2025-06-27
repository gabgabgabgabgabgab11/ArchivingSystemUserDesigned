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
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnSearchRetrieve = new FontAwesome.Sharp.IconButton();
            this.btnAddDocument = new FontAwesome.Sharp.IconButton();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardControl1 = new ArchivingSystemUserDesigned.DashboardControl();
            this.addDocumentControl1 = new ArchivingSystemUserDesigned.AddDocumentControl();
            this.searchRetrieveControl1 = new ArchivingSystemUserDesigned.SearchRetrieveControl();
            this.manageDocumentsControl1 = new ArchivingSystemUserDesigned.ManageDocumentsControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btnSearchRetrieve);
            this.panel1.Controls.Add(this.btnAddDocument);
            this.panel1.Controls.Add(this.imgHome);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 816);
            this.panel1.TabIndex = 0;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 436);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(230, 64);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "Settings";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 366);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(272, 64);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.Text = "Manage Documents";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
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
            this.btnSearchRetrieve.Location = new System.Drawing.Point(-3, 296);
            this.btnSearchRetrieve.Name = "btnSearchRetrieve";
            this.btnSearchRetrieve.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchRetrieve.Size = new System.Drawing.Size(291, 64);
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
            this.btnAddDocument.Location = new System.Drawing.Point(-3, 226);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddDocument.Size = new System.Drawing.Size(291, 64);
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
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(233, 160);
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
            this.btnDashboard.Location = new System.Drawing.Point(-3, 156);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(264, 64);
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
            this.panel2.Controls.Add(this.searchRetrieveControl1);
            this.panel2.Controls.Add(this.manageDocumentsControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 816);
            this.panel2.TabIndex = 1;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardControl1.AutoSize = true;
            this.dashboardControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dashboardControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(1600, 816);
            this.dashboardControl1.TabIndex = 1;
            this.dashboardControl1.Load += new System.EventHandler(this.dashboardControl1_Load);
            // 
            // addDocumentControl1
            // 
            this.addDocumentControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.addDocumentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDocumentControl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDocumentControl1.Location = new System.Drawing.Point(0, 0);
            this.addDocumentControl1.Name = "addDocumentControl1";
            this.addDocumentControl1.Size = new System.Drawing.Size(1600, 816);
            this.addDocumentControl1.TabIndex = 0;
            this.addDocumentControl1.Visible = false;
            // 
            // searchRetrieveControl1
            // 
            this.searchRetrieveControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.searchRetrieveControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRetrieveControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRetrieveControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchRetrieveControl1.Location = new System.Drawing.Point(0, 0);
            this.searchRetrieveControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchRetrieveControl1.Name = "searchRetrieveControl1";
            this.searchRetrieveControl1.Size = new System.Drawing.Size(1600, 816);
            this.searchRetrieveControl1.TabIndex = 3;
            this.searchRetrieveControl1.Visible = false;
            this.searchRetrieveControl1.Load += new System.EventHandler(this.searchRetrieveControl1_Load);
            // 
            // manageDocumentsControl1
            // 
            this.manageDocumentsControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.manageDocumentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageDocumentsControl1.Location = new System.Drawing.Point(0, 0);
            this.manageDocumentsControl1.Name = "manageDocumentsControl1";
            this.manageDocumentsControl1.Size = new System.Drawing.Size(1600, 816);
            this.manageDocumentsControl1.TabIndex = 2;
            this.manageDocumentsControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private SearchRetrieveControl searchRetrieveControl1;
        private ManageDocumentsControl manageDocumentsControl1;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnSearchRetrieve;
        private FontAwesome.Sharp.IconButton btnAddDocument;
        private System.Windows.Forms.PictureBox imgHome;
    }
}

