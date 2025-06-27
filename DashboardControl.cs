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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
    }
}
