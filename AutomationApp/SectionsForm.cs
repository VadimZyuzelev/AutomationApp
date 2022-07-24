using System;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class SectionsForm : Form
    {
        public SectionsForm()
        {
            InitializeComponent();
        }

        private void SectionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.automationAppDBDataSet.Бригады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Цеха". При необходимости она может быть перемещена или удалена.
            this.цехаTableAdapter.Fill(this.automationAppDBDataSet.Цеха);
        }
    }
}
