using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class CalculationCardsForm : Form
    {
        public CalculationCardsForm()
        {
            InitializeComponent();
        }

        private void CalculationCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Ткань_для_расчётной_карты". При необходимости она может быть перемещена или удалена.
            this.ткань_для_расчётной_картыTableAdapter.Fill(this.automationAppDBDataSet.Ткань_для_расчётной_карты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Ткань_для_расчётной_карты". При необходимости она может быть перемещена или удалена.
            this.ткань_для_расчётной_картыTableAdapter.Fill(this.automationAppDBDataSet.Ткань_для_расчётной_карты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Расчётные_карты". При необходимости она может быть перемещена или удалена.
            this.расчётные_картыTableAdapter.Fill(this.automationAppDBDataSet.Расчётные_карты);

        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            EditCalculationCardsForm EditCardsForm = new EditCalculationCardsForm(this);
            EditCardsForm.ShowDialog();
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Введите ваш запрос")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.FromArgb(86, 87, 96);
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Введите ваш запрос";
            SearchTextBox.ForeColor = Color.FromArgb(164, 167, 180);
            this.расчётныекартыBindingSource.Filter = "";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CardsDataGridView.Rows.Count != 0)
            {
                string Query = "";
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Номер_заказа like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Дата_отпуска_ткани, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Цех like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Бригада like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Изделие like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_изделия like '%" + SearchTextBox.Text + "%'";
                }

                this.расчётныекартыBindingSource.Filter = Query;
            }
            else
            {
                this.расчётныекартыBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.расчётныекартыBindingSource.Filter = "";
            }
        }

        private void CardsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                bool FlagEdit = true;

                EditCalculationCardsForm EditCardsForm = new EditCalculationCardsForm(this, FlagEdit);
                EditCardsForm.ShowDialog();
            }
        }

        private void CardsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CardsDataGridView.ClearSelection();
        }

        private void CuttingClothDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CuttingClothDataGridView.ClearSelection();
        }
    }
}
