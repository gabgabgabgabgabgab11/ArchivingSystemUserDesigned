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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.IconBtnUploadQA);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(20, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 283);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(679, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Edit or delete existing\r\n documents in the  system";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(342, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search for and retrieve\r\n documents from archive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(5, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upload and archive a new \r\ndocument to the \r\nsystem";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(682, 49);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(324, 94);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Manage Documents";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(345, 49);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(324, 94);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Search Documents";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // IconBtnUploadQA
            // 
            this.IconBtnUploadQA.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.IconBtnUploadQA.IconColor = System.Drawing.Color.Black;
            this.IconBtnUploadQA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtnUploadQA.Location = new System.Drawing.Point(8, 49);
            this.IconBtnUploadQA.Name = "IconBtnUploadQA";
            this.IconBtnUploadQA.Size = new System.Drawing.Size(324, 94);
            this.IconBtnUploadQA.TabIndex = 2;
            this.IconBtnUploadQA.Text = "Add New Document";
            this.IconBtnUploadQA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconBtnUploadQA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconBtnUploadQA.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 33);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Actions";
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
            this.pnlStatsSection.Location = new System.Drawing.Point(20, 18);
            this.pnlStatsSection.Name = "pnlStatsSection";
            this.pnlStatsSection.Size = new System.Drawing.Size(1007, 190);
            this.pnlStatsSection.TabIndex = 3;
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lblOthers);
            this.gbOther.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbOther.Location = new System.Drawing.Point(757, 49);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(228, 120);
            this.gbOther.TabIndex = 5;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Others";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOthers.Location = new System.Drawing.Point(91, 48);
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
            this.pnlStatsHeaderBar.Name = "pnlStatsHeaderBar";
            this.pnlStatsHeaderBar.Size = new System.Drawing.Size(1005, 33);
            this.pnlStatsHeaderBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 8);
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
            this.gbOjt.Location = new System.Drawing.Point(512, 49);
            this.gbOjt.Name = "gbOjt";
            this.gbOjt.Size = new System.Drawing.Size(228, 120);
            this.gbOjt.TabIndex = 4;
            this.gbOjt.TabStop = false;
            this.gbOjt.Text = "OJT REPORT";
            // 
            // lblOjt
            // 
            this.lblOjt.AutoSize = true;
            this.lblOjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOjt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOjt.Location = new System.Drawing.Point(93, 48);
            this.lblOjt.Name = "lblOjt";
            this.lblOjt.Size = new System.Drawing.Size(39, 42);
            this.lblOjt.TabIndex = 10;
            this.lblOjt.Text = "0";
            // 
            // gbThesis
            // 
            this.gbThesis.Controls.Add(this.lblThesis);
            this.gbThesis.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbThesis.Location = new System.Drawing.Point(268, 49);
            this.gbThesis.Name = "gbThesis";
            this.gbThesis.Size = new System.Drawing.Size(228, 120);
            this.gbThesis.TabIndex = 3;
            this.gbThesis.TabStop = false;
            this.gbThesis.Text = "Research/Thesis";
            // 
            // lblThesis
            // 
            this.lblThesis.AutoSize = true;
            this.lblThesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThesis.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblThesis.Location = new System.Drawing.Point(92, 48);
            this.lblThesis.Name = "lblThesis";
            this.lblThesis.Size = new System.Drawing.Size(39, 42);
            this.lblThesis.TabIndex = 9;
            this.lblThesis.Text = "0";
            // 
            // gbTotalDocuments
            // 
            this.gbTotalDocuments.Controls.Add(this.lblDocuments);
            this.gbTotalDocuments.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbTotalDocuments.Location = new System.Drawing.Point(24, 49);
            this.gbTotalDocuments.Name = "gbTotalDocuments";
            this.gbTotalDocuments.Size = new System.Drawing.Size(228, 120);
            this.gbTotalDocuments.TabIndex = 2;
            this.gbTotalDocuments.TabStop = false;
            this.gbTotalDocuments.Text = "Total Documents";
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDocuments.Location = new System.Drawing.Point(96, 48);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(39, 42);
            this.lblDocuments.TabIndex = 8;
            this.lblDocuments.Text = "0";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStatsSection);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1588, 606);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
    }
}
