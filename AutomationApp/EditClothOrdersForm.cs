using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditClothOrdersForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly ClothOrdersForm ClothOrdersForm;
        //private WarehouseClothsForm WarehouseClothsForm;
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

        public EditClothOrdersForm()
        {
            InitializeComponent();
        }
        
        public EditClothOrdersForm(ClothOrdersForm clothOrdersForm/*, WarehouseClothsForm warehouseClothsForm*/)
        {
            InitializeComponent();
            this.ClothOrdersForm = clothOrdersForm;
            //this.WarehouseClothsForm = warehouseClothsForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        } 
        
        public EditClothOrdersForm(ClothOrdersForm clothOrdersForm, bool flagEdit)
        {
            InitializeComponent();
            this.ClothOrdersForm = clothOrdersForm;
            this.FlagEdit = flagEdit;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        

        private void EditClothOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Приходные_ордера_на_ткань". При необходимости она может быть перемещена или удалена.
            this.приходные_ордера_на_тканьTableAdapter.Fill(this.automationAppDBDataSet.Приходные_ордера_на_ткань);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань". При необходимости она может быть перемещена или удалена.
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter.Fill(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань);         

            if (FlagEdit)
            {
                ID_Order = Convert.ToInt32(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["ID_Приходного_ордера"]);
                ID_Provider = Convert.ToInt32(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["ID_Поставщика"]);
                ProviderTextBox.TextName = Convert.ToString(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Поставщик"]);
                DateTimePicker.Value = Convert.ToDateTime(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Дата_составления"]);
                WarehouseTextBox.TextName = Convert.ToString(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Склад"]);
                CorrespondingAccountTextBox.TextName = Convert.ToString(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Корреспондирующий_счет"]);
                FollowDocumentTextBox.TextName = Convert.ToString(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Сопроводительный_документ"]);
                SumOrderTextBox.TextName = Convert.ToString(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["Сумма"]);
               
                fKМатериальIDПр1209AD79BindingSource.DataSource = ClothOrdersForm.приходныеордеранатканьBindingSource;
                
                MaterialsClothsDataGridView.Enabled = false;
                AddClothButton.BackColor = Color.FromArgb(226, 226, 226);
                AddClothButton.Enabled = false;

                TopLabel.Text = "Редактирование приходного ордера";
                TopPictureButton.IconChar = IconChar.Pen;
            }
            else
            {
                MaterialsClothsDataGridView.DataSource = null;
            }

        }
      
        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (MaterialsClothsDataGridView.Rows.Count == 0)
                {
                    ClothLabelError.Visible = true;
                }
                else
                {
                    UpdateData();

                    ProviderTextBox.TextName = "";
                    WarehouseTextBox.TextName = "";
                    CorrespondingAccountTextBox.TextName = "";
                    FollowDocumentTextBox.TextName = "";
                    SumOrderTextBox.TextName = "";
                    MaterialsClothsDataGridView.DataSource = null;
            
                }
            }
            else
            {
                if (MaterialsClothsDataGridView.Rows.Count == 0)
                {
                    ClothLabelError.Visible = true;
                }
            }
        }

        //
        // Открытие окна для выбора ткани и
        // добавление данных о приходном ордере
        private void AddClothButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (MaterialsClothsDataGridView.Rows.Count == 0)
                {
                    DateTime Date = DateTimePicker.Value;
                    string Warehouse = WarehouseTextBox.TextName;
                    string CorrespondingAccount = CorrespondingAccountTextBox.TextName;
                    string FollowDocument = FollowDocumentTextBox.TextName;
                    int SumOrders = 100;

                    ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Insert(ID_Provider, Date, Warehouse, CorrespondingAccount, FollowDocument, SumOrders);
                    ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Fill(ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань);

                    MaterialsClothsDataGridView.DataSource = ClothOrdersForm.fKМатериальIDПр0CDAE408BindingSource;

                    ClothOrdersForm.приходныеордеранатканьBindingSource.MoveLast();
                    ID_Order = Convert.ToInt32(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["ID_Приходного_ордера"]);
                }

                ClothLabelError.Visible = false;
                EditClothInOrdersForm EditCloth = new EditClothInOrdersForm(ClothOrdersForm, this);
                EditCloth.ShowDialog();

                if (MaterialsClothsDataGridView.Rows.Count == 0)
                {
                    ClothOrdersForm.приходныеордеранатканьBindingSource.RemoveCurrent();
                    ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Update(ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань);
                    ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Fill(ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань);
                }

                CalculatingSum();
            }
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {

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

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                int CountOrder = ClothOrdersForm.приходныеордеранатканьBindingSource.Count;

                for (int i = 0; i < CountOrder; i++)
                {
                    if (ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].ID_Приходного_ордера == ID_Order)
                    {
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].ID_Поставщика = ID_Provider;
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].Дата_составления = DateTimePicker.Value;
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].Склад = WarehouseTextBox.TextName;
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].Корреспондирующий_счет = CorrespondingAccountTextBox.TextName;
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].Сопроводительный_документ = FollowDocumentTextBox.TextName;
                        ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань[i].Сумма = Convert.ToDecimal(SumOrderTextBox.TextName);

                        ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Update(ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань);
                        ClothOrdersForm.приходные_ордера_на_тканьTableAdapter.Fill(ClothOrdersForm.automationAppDBDataSet.Приходные_ордера_на_ткань);
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

            if (MaterialsClothsDataGridView.Rows.Count == 0)
            {
                ClothLabelError.Visible = true;
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
            int RowCount = MaterialsClothsDataGridView.RowCount;

            if (RowCount != 0)
            {
                for (int i = 0; i < RowCount; i++)
                {
                    SumTotal += Convert.ToDecimal(MaterialsClothsDataGridView.Rows[i].Cells[10].Value);
                }

                SumOrderTextBox.TextName = Convert.ToString(SumTotal);
            }
        }

        private void ProviderTextBox_Enter(object sender, EventArgs e)
        {
            ProviderTextBox.BorderColor = Color.Black;
            ProviderErrorLabel.Visible = false;
        }

        private void WarehouseTextBox_Enter(object sender, EventArgs e)
        {
            WarehouseTextBox.BorderColor = Color.Black;
            WarehouseErrorLabel.Visible = false;
        }

        private void CorrespondingAccountTextBox_Enter(object sender, EventArgs e)
        {
            CorrespondingAccountTextBox.BorderColor = Color.Black;
            CorrespondingErrorLabel.Visible = false;
        }

        private void FollowDocumentTextBox_Enter(object sender, EventArgs e)
        {
            FollowDocumentTextBox.BorderColor = Color.Black;
            FollowErrorLabel.Visible = false;
        }

        private void ProviderTextBox_Leave(object sender, EventArgs e)
        {
            ProviderTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void WarehouseTextBox_Leave(object sender, EventArgs e)
        {
            WarehouseTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void CorrespondingAccountTextBox_Leave(object sender, EventArgs e)
        {
            CorrespondingAccountTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void FollowDocumentTextBox_Leave(object sender, EventArgs e)
        {
            FollowDocumentTextBox.BorderColor = Color.FromArgb(222, 223, 226);
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
            this.fKМатериальIDПр1209AD79BindingSource.Filter = "";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MaterialsClothsDataGridView.Rows.Count != 0)
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
                    Query += "CONVERT(Сумма_без_НДС, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Всего_с_НДС, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.fKМатериальIDПр1209AD79BindingSource.Filter = Query;
            }
            else
            {
                this.fKМатериальIDПр1209AD79BindingSource.Filter = "";
            }
            if (SearchTextBox.Text == "")
            {
                this.fKМатериальIDПр1209AD79BindingSource.Filter = "";
            }
        }

        private void MaterialsClothsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                this.fKМатериальIDПр1209AD79BindingSource.RemoveCurrent();
                this.материальные_ценности_по_ордеру_на_тканьTableAdapter.Update(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань);
                this.материальные_ценности_по_ордеру_на_тканьTableAdapter.Fill(this.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.White;
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.Gray;
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

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
