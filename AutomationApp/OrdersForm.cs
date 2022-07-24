using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersFurnitureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Приходные_ордера_на_фурнитуру". При необходимости она может быть перемещена или удалена.
            this.приходные_ордера_на_фурнитуруTableAdapter.Fill(this.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру". При необходимости она может быть перемещена или удалена.    
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Fill(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру);
        }

        private void OrdersFurnitureDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            OrdersFurnitureDataGridView.ClearSelection();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (OrdersFurnitureDataGridView.Rows.Count != 0)
            {
                string Query = "";
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Дата_составления, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Поставщик like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Склад like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Корреспондирующий_счет like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Сопроводительный_документ like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Сумма, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.приходные_ордера_на_фурнитуруBindingSource.Filter = Query;
            }
            else
            {
                this.приходные_ордера_на_фурнитуруBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.приходные_ордера_на_фурнитуруBindingSource.Filter = "";
            }
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Введите ваш запрос")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.FromArgb(86, 87, 96);
            }
        }

        private void OrdersFurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                bool FlagEdit = true;

                EditOrdersForm EditOrdersFurnitureForm = new EditOrdersForm(this, FlagEdit);
                EditOrdersFurnitureForm.ShowDialog();
            }
        }

        private void AddIOrderButton_Click(object sender, EventArgs e)
        {
            EditOrdersForm EditOrdersFurnitureForm = new EditOrdersForm(this);
            EditOrdersFurnitureForm.ShowDialog();
        }

        private void OrdersFurnitureDataGridView_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            OrdersFurnitureDataGridView.ClearSelection();
        }

        private void MaterialOrdersFurnitureDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MaterialOrdersFurnitureDataGridView.ClearSelection();
        }
    }
}
