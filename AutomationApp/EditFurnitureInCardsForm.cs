using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class EditFurnitureInCardsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly LimitCardsForm LimitCardsForm;
        private readonly EditLimitCardsForm EditLimitCardsForm;

        private int id_ModelFurniture;
        private int id_FurnitureWarehouse;
        private int countFurniture;
        private string furniture;
        private string modelFurniture;
        private string unitDetermination;

        public int ID_FurnitureWarehouse
        {
            set
            {
                id_FurnitureWarehouse = value;
            }
            get
            {
                return id_FurnitureWarehouse;
            }
        }

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

        public string UnitDetermination
        {
            get
            {
                return unitDetermination;
            }
            set
            {
                unitDetermination = value;
            }
        }

        public int CountFurniture
        {
            get
            {
                return countFurniture;
            }
            set
            {
                countFurniture = value;
            }
        }

 
        public EditFurnitureInCardsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditFurnitureInCardsForm(EditLimitCardsForm editLimitCardsForm, LimitCardsForm limitCardsForm)
        {
            InitializeComponent();
            this.EditLimitCardsForm = editLimitCardsForm;
            this.LimitCardsForm = limitCardsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditFurnitureInCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_фурнитуры". При необходимости она может быть перемещена или удалена.
            this.склад_фурнитурыTableAdapter.Fill(this.automationAppDBDataSet.Склад_фурнитуры);
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    if (!CheckCalculatingCount())
                    {
                        InsertData();
                    }
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectFurnitureInCards = true;

            ModelErrorLabel.Visible = false;
            ModelTextBox.ForeColor = Color.Black;

            WarehouseFurnitureForm WarehouseForm = new WarehouseFurnitureForm(this, FlagSelectFurnitureInCards);
            WarehouseForm.ShowDialog();

            NameTextBox.TextName = Furniture;
            ModelTextBox.TextName = ModelFurniture;
            UnitDeterminationTextBox.TextName = UnitDetermination;

            CountErrorlabel.Visible = true;
            CountErrorlabel.ForeColor = Color.Black;
            CountErrorlabel.Text = "Доступно на складе в количестве " + countFurniture + " " + unitDetermination;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NormTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatingCount();
            CalculatingSum();

            if (NormTextBox.Text == "")
            {
                CountTextBox.Text = "";
                SumTextBox.TextName = "";
            }         
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatingSum();

            if (PriceTextBox.Text == "")
            {
                SumTextBox.TextName = "";
            }
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {            
            if (CountFurniture != 0)
            {
                if (CountTextBox.Text != "")
                {
                    if (Convert.ToInt32(CountTextBox.Text) != 0 && Convert.ToInt32(CountTextBox.Text) > 0 && Convert.ToInt32(CountTextBox.Text) <= CountFurniture && CountTextBox.Text != "")
                    {
                        int TotalCount;

                        TotalCount = CountFurniture - Convert.ToInt32(CountTextBox.Text);
                        CountTextBox.ForeColor = Color.Black;
                        CountErrorlabel.Text = "Доступно на складе в количестве " + TotalCount + " " + unitDetermination + ".";
                    }
                    else
                    {
                        CountTextBox.ForeColor = Color.FromArgb(255, 128, 128);
                        CountErrorlabel.Text = "Доступно на складе в количестве " + CountFurniture + " " + unitDetermination + ".";
                    }
                }
                else
                {
                    CountTextBox.ForeColor = Color.Black;
                    CountErrorlabel.Text = "Доступно на складе в количестве " + CountFurniture + " " + unitDetermination + ".";
                }
            }
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.Gray;
        }

        private void InsertData()
        {
            int ID_LimitCards;

            string UnitDetermination;
            int Count;
            int NormUnit;
            int Price;
            int SumFurniture;

            NormUnit = Convert.ToInt32(NormTextBox.Text);
            UnitDetermination = Convert.ToString(UnitDeterminationTextBox.TextName);
            Count = Convert.ToInt32(CountTextBox.Text);
            Price = Convert.ToInt32(PriceTextBox.Text);
            SumFurniture = Convert.ToInt32(SumTextBox.TextName);         
            ID_LimitCards = Convert.ToInt32(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["ID_Лимитно_заборной_карты"]);

            EditLimitCardsForm.фурнитура_по_лимитно_заборной_картеTableAdapter.Insert(ID_LimitCards, ID_FurnitureWarehouse, NormUnit, UnitDetermination, Count, Price, SumFurniture);
            EditLimitCardsForm.фурнитура_по_лимитно_заборной_картеTableAdapter.Fill(EditLimitCardsForm.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);
            LimitCardsForm.фурнитура_по_лимитно_заборной_картеTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
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

            if (NormTextBox.Text == "")
            {
                NormBorder.BorderColor = Color.FromArgb(255, 128, 128);
                NormErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (PriceTextBox.Text == "")
            {
                PriceBorder.BorderColor = Color.FromArgb(255, 128, 128);
                PriceErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (CountTextBox.Text == "")
            {
                CountBorder.BorderColor = Color.FromArgb(255, 128, 128);
                CountErrorlabel.Visible = true;
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
            int RowsCount = EditLimitCardsForm.FurnitureDataGridView.Rows.Count;

            if (RowsCount != 0)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToInt32(EditLimitCardsForm.FurnitureDataGridView.Rows[i].Cells[2].Value) == ID_FurnitureWarehouse)
                    {
                        ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        ModelErrorLabel.Text = "Выбранная модель фурнитуры уже есть в лимитно-заборной карте";
                        ModelErrorLabel.Visible = true;
                        return true;
                    }
                }
            }
            ModelTextBox.Text = "Выберите модель";
            ModelErrorLabel.Visible = false;
            return false;
        }

        private bool CheckCalculatingCount()
        {
            if (Convert.ToInt32(CountTextBox.Text) > CountFurniture)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CalculatingCount()
        {
            int TotalCount;

            if (NormTextBox.Text != "")
            {
                if (Convert.ToInt32(NormTextBox.Text) > 0)
                {
                    TotalCount = Convert.ToInt32(NormTextBox.Text) * Convert.ToInt32(EditLimitCardsForm.CountItemsTextBox.TextName);
                    CountTextBox.Text = Convert.ToString(TotalCount);
                }
            }
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
