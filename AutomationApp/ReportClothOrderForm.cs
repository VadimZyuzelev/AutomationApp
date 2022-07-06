using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ReportClothOrderForm : Form
    {
        public ReportClothOrderForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ReportClothOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AutomationAppDBDataSet.Приходные_ордера_на_ткань". При необходимости она может быть перемещена или удалена.
            this.Приходные_ордера_на_тканьTableAdapter.Fill(this.AutomationAppDBDataSet.Приходные_ордера_на_ткань);
            this.OrderReportViewer.RefreshReport();
        }

        private void TitleBarLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodTitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
