using System;
using System.Windows.Forms;

namespace ArchivingSystemUserDesigned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Show only the dashboard at startup
            ShowDashboard();

            // Optionally, you can load data on startup
            dashboardControl1.LoadStats();
           // manageDocumentsControl1.LoadDropdowns();
           // manageDocumentsControl1.LoadDocuments();
           // searchRetrieveControl1.LoadDocuments();
        }

        private void ShowDashboard()
        {
            dashboardControl1.LoadStats();
            dashboardControl1.Visible = true;
            addDocumentControl1.Visible = false;
            searchRetrieveControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        private void ShowAddDocument()
        {
            addDocumentControl1.Visible = true;
            dashboardControl1.Visible = false;
            searchRetrieveControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        private void ShowSearchRetrieve()
        {
           // searchRetrieveControl1.LoadDocuments();
            searchRetrieveControl1.Visible = true;
            dashboardControl1.Visible = false;
            addDocumentControl1.Visible = false;
            manageDocumentsControl1.Visible = false;
        }

        private void ShowManageDocuments()
        {
          //  manageDocumentsControl1.LoadDropdowns();
           // manageDocumentsControl1.LoadDocuments();
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


        private void btnManageDocuments_Click(object sender, EventArgs e)
        {
            ShowManageDocuments();
        }

        // Quick action buttons inside DashboardControl (if you have them)
        private void dashboardControl1_btnAddNew_Click(object sender, EventArgs e)
        {
            ShowAddDocument();
        }

        private void dashboardControl1_btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearchRetrieve();
        }

        private void dashboardControl1_btnManage_Click(object sender, EventArgs e)
        {
            ShowManageDocuments();
        }

        private void searchRetrieveControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchRetrieve_Click_1(object sender, EventArgs e)
        {
            ShowSearchRetrieve();
        }

        private void dashboardControl1_Load(object sender, EventArgs e)
        {

        }
    }
}