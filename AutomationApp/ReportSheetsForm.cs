using System;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ReportSheetsForm : Form
    {
        public ReportSheetsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ReportSheetsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AutomationAppDBDataSet.Маршрутные_листы". При необходимости она может быть перемещена или удалена.
            this.Маршрутные_листыTableAdapter.Fill(this.AutomationAppDBDataSet.Маршрутные_листы);

            this.SheetsReportViewer.RefreshReport();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizedButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FoodTitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(Handle, 0x112, 0xf012, 0);
        }
    }
}
