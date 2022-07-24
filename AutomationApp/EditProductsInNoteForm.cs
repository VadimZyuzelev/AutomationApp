using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class EditProductsInNoteForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly TradeNoteForm TradeNote;
        private readonly EditTradeNoteForm EditTradeNote;

        private int id_ModelProducts;
        private int id_ProductsWarehouse;
        private int countProducts;
        private string products;
        private string modelProducts;
        private string unitDetermination;
        private string sort;

        public int ID_ModelProducts
        {
            set
            {
                id_ModelProducts = value;
            }
            get
            {
                return id_ModelProducts;
            }
        }

        public int ID_ProductsWarehouse
        {
            set
            {
                id_ProductsWarehouse = value;
            }
            get
            {
                return id_ProductsWarehouse;
            }
        }

        public string Products
        {
            set
            {
                products = value;
            }
            get
            {
                return products;
            }
        }

        public string ModelProducts
        {
            set
            {
                modelProducts = value;
            }
            get
            {
                return modelProducts;
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

        public int CountProducts
        {
            get
            {
                return countProducts;
            }
            set
            {
                countProducts = value;
            }
        }

        public string Sort
        {
            set
            {
                sort = value;
            }
            get
            {
                return sort;
            }

        }

        public EditProductsInNoteForm()
        {
            InitializeComponent();
        }

        public EditProductsInNoteForm(TradeNoteForm tradeNote, EditTradeNoteForm editTradeNote)
        {
            InitializeComponent();
            this.TradeNote = tradeNote;
            this.EditTradeNote = editTradeNote;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectProductsInNote = true;

            WarehouseProductsForm productsForm = new WarehouseProductsForm(this, FlagSelectProductsInNote);
            productsForm.ShowDialog();

            NameTextBox.TextName = Products;
            ModelTextBox.TextName = ModelProducts;
            UnitDeterminationTextBox.TextName = UnitDetermination;
            SortTextBox.TextName = Sort;
            CountErrorLabel.Visible = true;
            CountErrorLabel.ForeColor = Color.Black;
            CountErrorLabel.Text = "Доступно на складе: " + countProducts + " " + unitDetermination + ".";   
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            CountTextBox.ForeColor = Color.Black;

            if (countProducts != 0)
            {
                if (CountTextBox.Text != "")
                {
                    if (Convert.ToInt32(CountTextBox.Text) != 0 && Convert.ToInt32(CountTextBox.Text) > 0 && Convert.ToInt32(CountTextBox.Text) <= CountProducts && CountTextBox.Text != "")
                    {
                        int TotalCount;

                        TotalCount = CountProducts - Convert.ToInt32(CountTextBox.Text);
                        CountErrorLabel.Text = "Доступно на складе в количестве " + TotalCount + " " + unitDetermination + ".";
                    }
                    else
                    {
                        CountTextBox.ForeColor = Color.FromArgb(255, 128, 128);
                        CountErrorLabel.Text = "Доступно на складе в количестве " + countProducts + " " + unitDetermination + ".";
                    }
                }
                else
                {
                    CountErrorLabel.Text = "Доступно на складе в количестве " + countProducts + " " + unitDetermination + ".";
                }
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }


        private void InsertData()
        {
            int ID_TransportNote;

            string UnitDetermination;
            int Count;
            decimal Price;
            decimal CostProducts;
            int BetNDS;
            int SumNDS;
            int TotalWithNDS;

            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    UnitDetermination = Convert.ToString(UnitDeterminationTextBox.TextName);
                    Count = Convert.ToInt32(CountTextBox.Text);
                    Price = Convert.ToDecimal(PriceTextBox.TextName);
                    CostProducts = Convert.ToDecimal(EndPriceTextBox.TextName);
                    BetNDS = Convert.ToInt32(BetNDSTextBox.TextName);
                    TotalWithNDS = Convert.ToInt32(TotalNDSTextBox.TextName);

                    if (BetNDSTextBox.Text == "")
                    {
                        SumNDS = 0;
                    }
                    else
                    {
                        SumNDS = Convert.ToInt32(SumNDSTextBox.Text);
                    }

                    ID_TransportNote = Convert.ToInt32(((DataRowView)TradeNote.товарныенакладныеBindingSource.Current).Row["ID_Товарной_накладной"]);

                    TradeNote.товарный_раздел_товарной_накладнойTableAdapter.Insert(ID_TransportNote, ID_ProductsWarehouse, UnitDetermination, Count, Price, CostProducts, BetNDS, SumNDS, TotalWithNDS);
                    TradeNote.товарный_раздел_товарной_накладнойTableAdapter.Fill(TradeNote.automationAppDBDataSet.Товарный_раздел_товарной_накладной);                   
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
                CountErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (PriceTextBox.TextName == "")
            {                
                PriceErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (BetNDSTextBox.Text != "")
            {
                if (Convert.ToInt32(BetNDSTextBox.Text) <= 0)
                {                    
                    BetErrorLabel.Visible = true;
                    FlagEmpty = true;
                }
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
            int RowsCount = EditTradeNote.itemsProductsNoteDataGridView.Rows.Count;

            if (RowsCount != 0)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToInt32(EditTradeNote.itemsProductsNoteDataGridView.Rows[i].Cells[2].Value) == Convert.ToInt32(ID_ProductsWarehouse))
                    {
                        ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        ModelErrorLabel.Text = "Выбранный продукт уже есть в товарной накладной";
                        ModelErrorLabel.Visible = true;
                        return true;
                    }
                }
            }
            ModelTextBox.Text = "Выберите модель";
            ModelErrorLabel.Visible = false;
            return false;
        }

        private void EditProductsInNoteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарные_накладные". При необходимости она может быть перемещена или удалена.
            this.товарные_накладныеTableAdapter.Fill(this.automationAppDBDataSet.Товарные_накладные);

        }
    }
}
