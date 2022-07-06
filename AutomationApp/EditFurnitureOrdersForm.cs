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
    public partial class EditOrdersForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly OrdersForm OrdersForm;
        //private WarehouseFurnitureForm WarehouseFurnitureForm;

        private readonly bool FlagEdit;

        private int ID_Order;
        private decimal SumTotal;

        private int id_provider;
        private string provider;

        public int ID_Provider
        {
            set
            {
                id_provider = value;
            }
            get
            {
                return id_provider;
            }
        }

        public string Provider
        {
            set
            {
                provider = value;
            }
            get
            {
                return provider;
            }
        }

        public EditOrdersForm()
        {
            InitializeComponent();
        }
        
        public EditOrdersForm(OrdersForm ordersForm)
        {
            InitializeComponent();
            this.OrdersForm = ordersForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        /*public EditOrdersForm(OrdersForm ordersForm, WarehouseFurnitureForm warehouseFurnitureForm)
        {
            InitializeComponent();
            this.OrdersForm = ordersForm;
            this.WarehouseFurnitureForm = warehouseFurnitureForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }*/

        public EditOrdersForm(OrdersForm ordersForm, bool flagEdit)
        {
            InitializeComponent();
            this.OrdersForm = ordersForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditOrdersFurnitureForm_Load(object sender, EventArgs e)
        {           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Приходные_ордера_на_фурнитуру". При необходимости она может быть перемещена или удалена.
            this.приходные_ордера_на_фурнитуруTableAdapter.Fill(this.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру". При необходимости она может быть перемещена или удалена.
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Fill(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Приходные_ордера_на_фурнитуру". При необходимости она может быть перемещена или удалена.


            if (FlagEdit)
            {
                ID_Order = Convert.ToInt32(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["ID_Приходного_ордера"]);
                ID_Provider = Convert.ToInt32(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["ID_Поставщика"]);
                ProviderTextBox.TextName = Convert.ToString(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Поставщик"]);
                DateTimePicker.Value = Convert.ToDateTime(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Дата_составления"]);
                WarehouseTextBox.TextName = Convert.ToString(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Склад"]);
                CorrespondingAccountTextBox.TextName = Convert.ToString(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Корреспондирующий_счет"]);
                FollowDocumentTextBox.TextName = Convert.ToString(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Сопроводительный_документ"]);
                SumOrderTextBox.TextName = Convert.ToString(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["Сумма"]);

                fKМатериальIDПр1F63A897BindingSource.DataSource = OrdersForm.приходные_ордера_на_фурнитуруBindingSource;

                MaterialsOrderFurnitureDataGridView.Enabled = false;
                AddFurnitureButton.BackColor = Color.FromArgb(226, 226, 226);
                AddFurnitureButton.Enabled = false;

                CalculatingSum();
            }
            else
            {
                MaterialsOrderFurnitureDataGridView.DataSource = null;
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (MaterialsOrderFurnitureDataGridView.Rows.Count == 0)
                {
                    FurnitureLabelError.Visible = true;
                }
                else
                {                    
                    UpdateData();

                    ProviderTextBox.TextName = "";
                    WarehouseTextBox.TextName = "";
                    CorrespondingAccountTextBox.TextName = "";
                    FollowDocumentTextBox.TextName = "";
                    SumOrderTextBox.TextName = "";

                    MaterialsOrderFurnitureDataGridView.DataSource = null;
                }
            }
            else
            {
                if (MaterialsOrderFurnitureDataGridView.Rows.Count == 0)
                {
                    FurnitureLabelError.Visible = true;
                }
            }
        }

        private void AddFurnitureButton_Click_1(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (MaterialsOrderFurnitureDataGridView.Rows.Count == 0)
                {
                    DateTime Date = DateTimePicker.Value;
                    string Warehouse = WarehouseTextBox.TextName;
                    string CorrespondingAccount = CorrespondingAccountTextBox.TextName;
                    string FollowDocument = FollowDocumentTextBox.TextName;

                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Insert(ID_Provider, Date, Warehouse, CorrespondingAccount, FollowDocument, 100);
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);

                    MaterialsOrderFurnitureDataGridView.DataSource = OrdersForm.fKМатериальIDПр1F63A897BindingSource;

                    OrdersForm.приходные_ордера_на_фурнитуруBindingSource.MoveLast();
                    ID_Order = Convert.ToInt32(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["ID_Приходного_ордера"]);
                }

                FurnitureLabelError.Visible = false;
                EditFurnitureInOrderForm EditFurniture = new EditFurnitureInOrderForm(this, OrdersForm);
                EditFurniture.ShowDialog();

                if (MaterialsOrderFurnitureDataGridView.Rows.Count == 0)
                {
                    OrdersForm.приходные_ордера_на_фурнитуруBindingSource.RemoveCurrent();
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Update(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                }

                CalculatingSum();
            }
        }

        // При открытии формы для добавления данных о фурнитуре по приходному ордеру добавляем данные о приходном ордере.
        private void AddFurnitureButton_Click(object sender, EventArgs e)
        {           
            EditFurnitureInOrderForm EditFurniture = new EditFurnitureInOrderForm(this, OrdersForm);
            EditFurniture.ShowDialog();
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            if (!FlagEdit)
            {
                int RowCount;
                RowCount = MaterialsOrderFurnitureDataGridView.RowCount;

                if (RowCount == 0)
                {
                    OrdersForm.приходные_ордера_на_фурнитуруBindingSource.RemoveCurrent();
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Update(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                }
                else
                {
                    for (int i = 0; i <= RowCount-1; i++)
                    {
                        OrdersForm.fKМатериальIDПр1F63A897BindingSource.RemoveCurrent();
                        OrdersForm.fKМатериальIDПр1F63A897BindingSource.MoveNext();
                    }

                    OrdersForm.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Update(OrdersForm.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру);
                    OrdersForm.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру);

                    OrdersForm.приходные_ордера_на_фурнитуруBindingSource.RemoveCurrent();
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Update(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                    OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                int CountOrder = OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Count;

                for (int i = 0; i < CountOrder; i++)
                {
                    if (OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].ID_Приходного_ордера == ID_Order)
                    {
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].ID_Поставщика = ID_Provider;
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].Дата_составления = DateTimePicker.Value;
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].Склад = WarehouseTextBox.TextName;
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].Корреспондирующий_счет = CorrespondingAccountTextBox.TextName;
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].Сопроводительный_документ = FollowDocumentTextBox.TextName;
                        OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру[i].Сумма = Convert.ToDecimal(SumOrderTextBox.TextName);

                        OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Update(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                        OrdersForm.приходные_ордера_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Приходные_ордера_на_фурнитуру);
                    }
                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (ProviderTextBox.TextName == "")
            {
                ProviderTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                ProviderErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (WarehouseTextBox.TextName == "")
            {
                WarehouseTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                WarehouseErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (CorrespondingAccountTextBox.TextName == "")
            {
                CorrespondingAccountTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                CorrespondingErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (FollowDocumentTextBox.TextName == "")
            {
                FollowDocumentTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                FollowErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (FlagEmpty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CalculatingSum()
        {
            //Расчёт суммы приходного ордера
            int RowCount = MaterialsOrderFurnitureDataGridView.RowCount;

            if (RowCount != 0)
            {
                for (int i = 0; i < RowCount; i++)
                {
                    SumTotal += Convert.ToDecimal(MaterialsOrderFurnitureDataGridView.Rows[i].Cells[8].Value);
                }

                SumOrderTextBox.TextName = Convert.ToString(SumTotal);
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MaterialsOrderFurnitureDataGridView.Rows.Count != 0)
            {
                string Query = "";
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Материальные_ценности like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Количество, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Цена, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Сумма, System.String) like '%" + SearchTextBox.Text + "%'";
                }
                this.fKМатериальIDПр1F63A897BindingSource.Filter = Query;
            }
            else
            {
                this.fKМатериальIDПр1F63A897BindingSource.Filter = "";
            }
            if (SearchTextBox.Text == "")
            {
                this.fKМатериальIDПр1F63A897BindingSource.Filter = "";
                //SearchTextBox.Text = "Введите ваш запрос";
                //SearchTextBox.ForeColor = Color.FromArgb(164, 167, 180);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectProvidersInOrder = true;

            ProviderTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ProviderErrorLabel.Visible = false;

            ProvidersForm ProvidersForm = new ProvidersForm(this, FlagSelectProvidersInOrder);
            ProvidersForm.ShowDialog();

            ProviderTextBox.TextName = Provider;
        }

        private void WarehouseTextBox_Enter(object sender, EventArgs e)
        {
            WarehouseTextBox.BorderColor = Color.Black;
            WarehouseErrorLabel.Visible = false;
        }

        private void WarehouseTextBox_Leave(object sender, EventArgs e)
        {
            WarehouseTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void CorrespondingAccountTextBox_Enter(object sender, EventArgs e)
        {
            CorrespondingAccountTextBox.BorderColor = Color.Black;
            CorrespondingErrorLabel.Visible = false;
        }

        private void CorrespondingAccountTextBox_Leave(object sender, EventArgs e)
        {
            CorrespondingAccountTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void FollowDocumentTextBox_Enter(object sender, EventArgs e)
        {
            FollowDocumentTextBox.BorderColor = Color.Black;
            FollowErrorLabel.Visible = false;
        }

        private void FollowDocumentTextBox_Leave(object sender, EventArgs e)
        {
            FollowDocumentTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.White;
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.Gray;
        }
    }
}


//SummOrders = ;
/*ID_Furniture = Convert.ToInt32(FurnitureComboBox.SelectedValue);
UnitDetermination = Convert.ToString(UnitDeterminationComboBox.SelectedValue);
Count = Convert.ToInt32(CountTextBox.Text);
Price = Convert.ToInt32(PriceTextBox.Text);*/