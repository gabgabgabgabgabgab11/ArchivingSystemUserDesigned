using System;
using System.Windows.Forms;

namespace ArchivingSystemUserDesigned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowDashboard();

            // Optionally, you can load data on startup
            dashboardControl1.LoadStats();
            manageDocumentsControl1.LoadDropdowns();
            manageDocumentsControl1.LoadDocuments();
            searchRetrieveControl1.LoadDocuments();
        }

        public void ShowDashboard()
        {
            dashboardControl1.LoadStats();
            dashboardControl1.LoadRecentActivities();
            dashboardControl1.Visible = true;
            addDocumentControl1.Visible = false;
            searchRetrieveControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        public void ShowAddDocument()
        {
            addDocumentControl1.Visible = true;
            dashboardControl1.Visible = false;
            searchRetrieveControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        public void ShowSearchRetrieve()
        {
           searchRetrieveControl1.LoadDocuments();
            searchRetrieveControl1.Visible = true;
            dashboardControl1.Visible = false;
            addDocumentControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        public void ShowManageDocuments()
        {
            manageDocumentsControl1.LoadDropdowns();
            manageDocumentsControl1.LoadDocuments();
            manageDocumentsControl1.Visible = true;
            dashboardControl1.Visible = false;
            addDocumentControl1.Visible = false;
            searchRetrieveControl1.Visible = false;
        }

        // Sidebar button event handlers
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            ShowAddDocument();
        }

        private void btnSearchRetrieve_Click_1(object sender, EventArgs e)
        {
            ShowSearchRetrieve();
        }

        private void dashboardControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ShowManageDocuments();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                
            }
        }
    }
}