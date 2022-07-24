using System;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ReportWarhouseClothForm : Form
    {
        public ReportWarhouseClothForm()
        {
            InitializeComponent();
        }

        private void ReportWarhouseClothForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
