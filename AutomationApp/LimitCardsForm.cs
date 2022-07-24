using System;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class LimitCardsForm : Form
    {
        public LimitCardsForm()
        {
            InitializeComponent();
        }

        private void LimitCardsForm_Load(object sender, EventArgs e)
        {           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Лимитно_заборные_карты". При необходимости она может быть перемещена или удалена.
            this.лимитно_заборные_картыTableAdapter.Fill(this.automationAppDBDataSet.Лимитно_заборные_карты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте". При необходимости она может быть перемещена или удалена.
            this.фурнитура_по_лимитно_заборной_картеTableAdapter.Fill(this.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);         
        }

        private void AddCardsButton_Click(object sender, EventArgs e)
        {
            EditLimitCardsForm EditLimitCardsForm = new EditLimitCardsForm(this);
            EditLimitCardsForm.ShowDialog();
        }

        private void LimitCardsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                bool FlagEdit = true;

                EditLimitCardsForm EditLimitCardsForm = new EditLimitCardsForm(this, FlagEdit);
                EditLimitCardsForm.ShowDialog();
            }
        }
    }
}
