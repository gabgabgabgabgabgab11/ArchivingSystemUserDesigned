using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ArchivingSystemUserDesigned.DocumentRepository;

namespace ArchivingSystemUserDesigned
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            SetupRecentActivityGrid();
            LoadRecentActivities();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }

        public void LoadStats()
        {   
            var repo = new DocumentRepository();
            var stats = repo.GetDocumentStats();
            lblDocuments.Text = stats.total.ToString();
            lblThesis.Text = stats.byType.ContainsKey("RESEARCH/THESIS") ? stats.byType["RESEARCH/THESIS"].ToString() : "0";
            lblOjt.Text = stats.byType.ContainsKey("OJT TERMINAL REPORT") ? stats.byType["OJT TERMINAL REPORT"].ToString() : "0";
            lblOthers.Text = (stats.total - (stats.byType.ContainsKey("RESEARCH/THESIS") ? stats.byType["RESEARCH/THESIS"] : 0) -
                (stats.byType.ContainsKey("OJT TERMINAL REPORT") ? stats.byType["OJT TERMINAL REPORT"] : 0)
            ).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IconBtnUploadQA_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
                mainForm.ShowAddDocument();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
                mainForm.ShowSearchRetrieve();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
                mainForm.ShowManageDocuments();
        }

        private void SetupRecentActivityGrid()
        {
            dgvRecentActivity.Columns.Clear();
            dgvRecentActivity.Columns.Add("Timestamp", "Time");
            dgvRecentActivity.Columns.Add("Activity", "Activity");
            dgvRecentActivity.Columns.Add("Details", "Details");

            dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivity.Columns["Timestamp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRecentActivity.Columns["Activity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRecentActivity.Columns["Details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRecentActivity.RowHeadersVisible = false;
            dgvRecentActivity.ReadOnly = true;
            dgvRecentActivity.AllowUserToAddRows = false;
            dgvRecentActivity.AllowUserToDeleteRows = false;

            // Styling
            dgvRecentActivity.BorderStyle = BorderStyle.None;
            dgvRecentActivity.EnableHeadersVisualStyles = false;
            dgvRecentActivity.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvRecentActivity.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRecentActivity.DefaultCellStyle.SelectionBackColor = Color.FromArgb(66, 135, 245);
            dgvRecentActivity.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRecentActivity.DefaultCellStyle.BackColor = Color.White;
            dgvRecentActivity.DefaultCellStyle.ForeColor = Color.Black;
        }

        public void LoadRecentActivities()
        {
            dgvRecentActivity.Rows.Clear();
            var logs = ActivityRepository.GetRecentActivities(20); // get latest 20

            foreach (var log in logs)
            {
                string activity = $"{log.Username} {log.Action.ToLower()} '{log.DocumentTitle}' ({log.DocumentType})";
                dgvRecentActivity.Rows.Add(log.Timestamp.ToString("g"), activity, log.Details);
            }
        }

        private void pnlStatsSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbTotalDocuments_Enter(object sender, EventArgs e)
        {

        }

        private void gbThesis_Enter(object sender, EventArgs e)
        {

        }

        private void gbOjt_Enter(object sender, EventArgs e)
        {

        }

        private void gbOther_Enter(object sender, EventArgs e)
        {

        }
    }
}
