using System;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ReportReceivedItemForm : Form
    {
        public ReportReceivedItemForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ReprotReceivedItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AutomationAppDBDataSet.Маршрутные_листы". При необходимости она может быть перемещена или удалена.
            this.Маршрутные_листыTableAdapter.Fill(this.AutomationAppDBDataSet.Маршрутные_листы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AutomationAppDBDataSet.Изделия_принятые_на_склад". При необходимости она может быть перемещена или удалена.
            this.Изделия_принятые_на_складTableAdapter.Fill(this.AutomationAppDBDataSet.Изделия_принятые_на_склад);

            this.reportViewer.RefreshReport();
        }

        private void FoodTitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(Handle, 0x112, 0xf012, 0);
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
            this.Close();
        }
    }
}
