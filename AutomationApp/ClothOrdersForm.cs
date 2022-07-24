using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ClothOrdersForm : Form
    {
        public ClothOrdersForm()
        {
            InitializeComponent();
        }

        private void ClothOrdersForm_Load(object sender, EventArgs e)
        {           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Приходные_ордера_на_ткань". При необходимости она может быть перемещена или удалена.
            this.приходные_ордера_на_тканьTableAdapter.Fill(this.automationAppDBDataSet.Приходные_ордера_на_ткань);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань". При необходимости она может быть перемещена или удалена.
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter.Fill(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            //WarehouseClothsForm WarehouseClothsForm = new WarehouseClothsForm();
            EditClothOrdersForm EditClothOrdersForm = new EditClothOrdersForm(this/*, WarehouseClothsForm*/);
            EditClothOrdersForm.ShowDialog();
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
            this.приходныеордеранатканьBindingSource.Filter = "";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ClothOrdersDataGridView.Rows.Count != 0)
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

                this.приходныеордеранатканьBindingSource.Filter = Query;
            }
            else
            {
                this.приходныеордеранатканьBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.приходныеордеранатканьBindingSource.Filter = "";
            }
        }

        private void ClothOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                bool FlagEdit = true;

                EditClothOrdersForm EditClothOrdersForm = new EditClothOrdersForm(this, FlagEdit);
                EditClothOrdersForm.ShowDialog();
            }

            if (e.ColumnIndex == 10)
            {
                ReportClothOrderForm reportFormTwo = new ReportClothOrderForm();            
                reportFormTwo.Show();
            }
        }

        private void ClothOrdersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClothOrdersDataGridView.ClearSelection();
        }

        private void MaterialsOrderDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MaterialsOrderDataGridView.ClearSelection();
        }
    }
}
