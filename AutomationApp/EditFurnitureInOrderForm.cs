using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class EditFurnitureInOrderForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly EditOrdersForm EditOrdersForm;
        private readonly OrdersForm OrdersForm;

        private int ID_Order;        
        
        private int id_ModelFurniture;
        private string furniture;
        private string modelFurniture;

        public int ID_ModelFurniture
        {
            set
            {
                id_ModelFurniture = value;
            }
            get
            {
                return id_ModelFurniture;
            }
        }

        public string Furniture
        {
            set
            {
                furniture = value;
            }
            get
            {
                return furniture;
            }
        }

        public string ModelFurniture
        {
            set
            {
                modelFurniture = value;
            }
            get
            {
                return modelFurniture;
            }
        }

        public EditFurnitureInOrderForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditFurnitureInOrderForm(EditOrdersForm editForm, OrdersForm ordersForm)
        {
            InitializeComponent();
            this.EditOrdersForm = editForm;
            this.OrdersForm = ordersForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
       /* public EditFurnitureInOrderForm(EditOrdersForm editForm, OrdersForm ordersForm)
        {
            InitializeComponent();
            this.EditOrdersForm = editForm;
            this.OrdersForm = ordersForm;         

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }*/

        private void EditFurnitureInOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.automationAppDBDataSet.Фурнитура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_фурнитуры". При необходимости она может быть перемещена или удалена.
            this.модели_фурнитурыTableAdapter.Fill(this.automationAppDBDataSet.Модели_фурнитуры);        
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ЫАФЫЫ" + NameFurnitureComboBox.SelectedValue);
        }

        private void AddFurnitureButton_Click(object sender, EventArgs e)
        {
            FurnitureForm furnitureForm = new FurnitureForm();            
            EditFurnitureForm editFurnitureForm = new EditFurnitureForm(furnitureForm);
            editFurnitureForm.ShowDialog();

            фурнитураTableAdapter.Update(automationAppDBDataSet.Фурнитура);
            фурнитураTableAdapter.Fill(automationAppDBDataSet.Фурнитура);

            модели_фурнитурыTableAdapter.Update(automationAppDBDataSet.Модели_фурнитуры);
            модели_фурнитурыTableAdapter.Fill(automationAppDBDataSet.Модели_фурнитуры);
            
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectFurnitureInOrder = true;

            FurnitureForm furnitureForm = new FurnitureForm(this, FlagSelectFurnitureInOrder);
            furnitureForm.ShowDialog();

            NameTextBox.TextName = Furniture;
            ModelTextBox.TextName = ModelFurniture;

            фурнитураTableAdapter.Update(automationAppDBDataSet.Фурнитура);
            фурнитураTableAdapter.Fill(automationAppDBDataSet.Фурнитура);

            модели_фурнитурыTableAdapter.Update(automationAppDBDataSet.Модели_фурнитуры);
            модели_фурнитурыTableAdapter.Fill(automationAppDBDataSet.Модели_фурнитуры);
        }

        private void InsertData()
        {
            string UnitDetermination;
            int Count;
            int Price;
            int SumFurniture;
        
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    UnitDetermination = Convert.ToString(UnitDeterminationTextBox.TextName);
                    Count = Convert.ToInt32(CountTextBox.Text);
                    Price = Convert.ToInt32(PriceTextBox.Text);
                    SumFurniture = Convert.ToInt32(SumTextBox.TextName);

                    ID_Order = Convert.ToInt32(((DataRowView)OrdersForm.приходные_ордера_на_фурнитуруBindingSource.Current).Row["ID_Приходного_ордера"]);

                    OrdersForm.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Insert(ID_ModelFurniture, ID_Order, Count, UnitDetermination, Price, SumFurniture);
                    OrdersForm.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.Fill(OrdersForm.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_фурнитуру);
                }
            }            
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (NameTextBox.TextName == "")
            {
                NameTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                NameErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (ModelTextBox.TextName == "")
            {
                ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                ModelErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (UnitDeterminationTextBox.TextName == "")
            {
                UnitDeterminationTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                DeterminationErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (CountTextBox.Text == "")
            {
                CountBorder.BorderColor = Color.FromArgb(255, 128, 128);
                CountErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (PriceTextBox.Text == "")
            {
                PriceBorder.BorderColor = Color.FromArgb(255, 128, 128);
                PriceErrorLabel.Visible = true;
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

        private bool CheckRepeatData()
        {
            int RowsCount = EditOrdersForm.MaterialsOrderFurnitureDataGridView.Rows.Count;

            if (RowsCount != 0)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToInt32(EditOrdersForm.MaterialsOrderFurnitureDataGridView.Rows[i].Cells[1].Value) == ID_ModelFurniture)
                    {
                        ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        ModelErrorLabel.Text = "Выбранная модель фурнитуры уже есть в приходном ордере";
                        ModelErrorLabel.Visible = true;
                        return true;
                    }
                }
            }
            ModelTextBox.Text = "Выберите модель";
            ModelErrorLabel.Visible = false;
            return false;
        }

        private void CalculatingSum()
        {
            int TotalSum;            

            if (PriceTextBox.Text != "" && CountTextBox.Text != "")
            {
                if (Convert.ToInt32(CountTextBox.Text) > 0 && Convert.ToInt32(PriceTextBox.Text) > 0)
                {
                    TotalSum = Convert.ToInt32(CountTextBox.Text) * Convert.ToInt32(PriceTextBox.Text);
                    SumTextBox.TextName = Convert.ToString(TotalSum);                    
                }
            }

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatingSum();
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatingSum();
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

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
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
    }
}
