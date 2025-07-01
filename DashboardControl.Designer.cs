namespace ArchivingSystemUserDesigned
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecentActivity = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.IconBtnUploadQA = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStatsSection = new System.Windows.Forms.Panel();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.lblOthers = new System.Windows.Forms.Label();
            this.pnlStatsHeaderBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOjt = new System.Windows.Forms.GroupBox();
            this.lblOjt = new System.Windows.Forms.Label();
            this.gbThesis = new System.Windows.Forms.GroupBox();
            this.lblThesis = new System.Windows.Forms.Label();
            this.gbTotalDocuments = new System.Windows.Forms.GroupBox();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlStatsSection.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.pnlStatsHeaderBar.SuspendLayout();
            this.gbOjt.SuspendLayout();
            this.gbThesis.SuspendLayout();
            this.gbTotalDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvRecentActivity);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.IconBtnUploadQA);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(20, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 515);
            this.panel1.TabIndex = 4;
            // 
            // dgvRecentActivity
            // 
            this.dgvRecentActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentActivity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentActivity.Location = new System.Drawing.Point(129, 54);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.RowHeadersWidth = 51;
            this.dgvRecentActivity.RowTemplate.Height = 24;
            this.dgvRecentActivity.Size = new System.Drawing.Size(1155, 456);
            this.dgvRecentActivity.TabIndex = 5;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(8, 294);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(115, 97);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Manage Documents";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(8, 181);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(115, 105);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Search Documents";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // IconBtnUploadQA
            // 
            this.IconBtnUploadQA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.IconBtnUploadQA.FlatAppearance.BorderSize = 0;
            this.IconBtnUploadQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtnUploadQA.ForeColor = System.Drawing.Color.White;
            this.IconBtnUploadQA.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.IconBtnUploadQA.IconColor = System.Drawing.Color.White;
            this.IconBtnUploadQA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtnUploadQA.Location = new System.Drawing.Point(8, 70);
            this.IconBtnUploadQA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconBtnUploadQA.Name = "IconBtnUploadQA";
            this.IconBtnUploadQA.Size = new System.Drawing.Size(115, 103);
            this.IconBtnUploadQA.TabIndex = 2;
            this.IconBtnUploadQA.Text = "Add New Document";
            this.IconBtnUploadQA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconBtnUploadQA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconBtnUploadQA.UseVisualStyleBackColor = false;
            this.IconBtnUploadQA.Click += new System.EventHandler(this.IconBtnUploadQA_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1287, 47);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recent Activity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatsSection
            // 
            this.pnlStatsSection.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatsSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatsSection.Controls.Add(this.gbOther);
            this.pnlStatsSection.Controls.Add(this.pnlStatsHeaderBar);
            this.pnlStatsSection.Controls.Add(this.gbOjt);
            this.pnlStatsSection.Controls.Add(this.gbThesis);
            this.pnlStatsSection.Controls.Add(this.gbTotalDocuments);
            this.pnlStatsSection.Location = new System.Drawing.Point(20, 26);
            this.pnlStatsSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStatsSection.Name = "pnlStatsSection";
            this.pnlStatsSection.Size = new System.Drawing.Size(1285, 272);
            this.pnlStatsSection.TabIndex = 3;
            this.pnlStatsSection.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatsSection_Paint);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lblOthers);
            this.gbOther.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbOther.Location = new System.Drawing.Point(939, 68);
            this.gbOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOther.Name = "gbOther";
            this.gbOther.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOther.Size = new System.Drawing.Size(228, 172);
            this.gbOther.TabIndex = 5;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Others";
            this.gbOther.Enter += new System.EventHandler(this.gbOther_Enter);
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOthers.Location = new System.Drawing.Point(91, 69);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(39, 42);
            this.lblOthers.TabIndex = 11;
            this.lblOthers.Text = "0";
            // 
            // pnlStatsHeaderBar
            // 
            this.pnlStatsHeaderBar.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlStatsHeaderBar.Controls.Add(this.label2);
            this.pnlStatsHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.pnlStatsHeaderBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStatsHeaderBar.Name = "pnlStatsHeaderBar";
            this.pnlStatsHeaderBar.Size = new System.Drawing.Size(1283, 47);
            this.pnlStatsHeaderBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Document Archive Statistics";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbOjt
            // 
            this.gbOjt.Controls.Add(this.lblOjt);
            this.gbOjt.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbOjt.Location = new System.Drawing.Point(640, 68);
            this.gbOjt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOjt.Name = "gbOjt";
            this.gbOjt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOjt.Size = new System.Drawing.Size(228, 172);
            this.gbOjt.TabIndex = 4;
            this.gbOjt.TabStop = false;
            this.gbOjt.Text = "OJT REPORT";
            this.gbOjt.Enter += new System.EventHandler(this.gbOjt_Enter);
            // 
            // lblOjt
            // 
            this.lblOjt.AutoSize = true;
            this.lblOjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOjt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOjt.Location = new System.Drawing.Point(93, 69);
            this.lblOjt.Name = "lblOjt";
            this.lblOjt.Size = new System.Drawing.Size(39, 42);
            this.lblOjt.TabIndex = 10;
            this.lblOjt.Text = "0";
            // 
            // gbThesis
            // 
            this.gbThesis.Controls.Add(this.lblThesis);
            this.gbThesis.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbThesis.Location = new System.Drawing.Point(351, 68);
            this.gbThesis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThesis.Name = "gbThesis";
            this.gbThesis.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThesis.Size = new System.Drawing.Size(228, 172);
            this.gbThesis.TabIndex = 3;
            this.gbThesis.TabStop = false;
            this.gbThesis.Text = "Research/Thesis";
            this.gbThesis.Enter += new System.EventHandler(this.gbThesis_Enter);
            // 
            // lblThesis
            // 
            this.lblThesis.AutoSize = true;
            this.lblThesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThesis.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblThesis.Location = new System.Drawing.Point(92, 69);
            this.lblThesis.Name = "lblThesis";
            this.lblThesis.Size = new System.Drawing.Size(39, 42);
            this.lblThesis.TabIndex = 9;
            this.lblThesis.Text = "0";
            // 
            // gbTotalDocuments
            // 
            this.gbTotalDocuments.Controls.Add(this.lblDocuments);
            this.gbTotalDocuments.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbTotalDocuments.Location = new System.Drawing.Point(50, 68);
            this.gbTotalDocuments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTotalDocuments.Name = "gbTotalDocuments";
            this.gbTotalDocuments.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTotalDocuments.Size = new System.Drawing.Size(228, 172);
            this.gbTotalDocuments.TabIndex = 2;
            this.gbTotalDocuments.TabStop = false;
            this.gbTotalDocuments.Text = "Total Documents";
            this.gbTotalDocuments.Enter += new System.EventHandler(this.gbTotalDocuments_Enter);
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDocuments.Location = new System.Drawing.Point(96, 69);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(39, 42);
            this.lblDocuments.TabIndex = 8;
            this.lblDocuments.Text = "0";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BackgroundImage = global::ArchivingSystemUserDesigned.Properties.Resources.dark_blue_wide_background_with_radial_blurred_gradient_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStatsSection);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1588, 871);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlStatsSection.ResumeLayout(false);
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.pnlStatsHeaderBar.ResumeLayout(false);
            this.pnlStatsHeaderBar.PerformLayout();
            this.gbOjt.ResumeLayout(false);
            this.gbOjt.PerformLayout();
            this.gbThesis.ResumeLayout(false);
            this.gbThesis.PerformLayout();
            this.gbTotalDocuments.ResumeLayout(false);
            this.gbTotalDocuments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton IconBtnUploadQA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStatsSection;
        private System.Windows.Forms.Panel pnlStatsHeaderBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOjt;
        private System.Windows.Forms.GroupBox gbThesis;
        private System.Windows.Forms.GroupBox gbTotalDocuments;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblOjt;
        private System.Windows.Forms.Label lblThesis;
        private System.Windows.Forms.DataGridView dgvRecentActivity;
    }
}
