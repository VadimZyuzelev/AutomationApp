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
    public partial class EditClothsInCardsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly CalculationCardsForm CalculationCardsForm;
        private readonly EditCalculationCardsForm EditCalculationCardsForm;

        private int id_ClothInWarehouse;
        private int id_Cloth;
        private int id_ModelCloth;
        private int countCloths;
        private string nameCloth;
        private string modelCloth;
        private string unitDetermination;

        public int ID_ClothInWarehouse
        {
            get
            {
                return id_ClothInWarehouse;
            }
            set
            {
                id_ClothInWarehouse = value;
            }
        }

        public int ID_Cloth
        {
            get
            {
                return id_Cloth;
            }
            set
            {
                id_Cloth = value;
            }
        }

        public int ID_ModelCloth
        {
            get
            {
                return id_ModelCloth;
            }
            set
            {
                id_ModelCloth = value;
            }
        }

        public string NameCloth
        {
            get
            {
                return nameCloth;
            }
            set
            {
                nameCloth = value;
            }
        }

        public string ModelCloth
        {
            get
            {
                return modelCloth;
            }
            set
            {
                modelCloth = value;
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

        public int CountCloths
        {
            get
            {
                return countCloths;
            }
            set
            {
                countCloths = value;
            }
        }

        public EditClothsInCardsForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditClothsInCardsForm(EditCalculationCardsForm editCalculationCardsForm, CalculationCardsForm calculationCardsForm)
        {
            InitializeComponent();
            this.EditCalculationCardsForm = editCalculationCardsForm;
            this.CalculationCardsForm = calculationCardsForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditClothsInCardsForm_Load(object sender, EventArgs e)
        {
 
        }

        private void NameCothComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectClothsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    if (!CheckCalculatingCount())
                    {
                        int ID_Calculation_cards = Convert.ToInt32(((DataRowView)CalculationCardsForm.расчётныекартыBindingSource.Current).Row["ID_Расчётной_карты"]);

                        CountCloths = Convert.ToInt32(CountTextBoxTwo.Text);

                        CalculationCardsForm.ткань_для_расчётной_картыTableAdapter.Insert(ID_Calculation_cards, ID_ClothInWarehouse, CountCloths, UnitDetermination);
                        CalculationCardsForm.ткань_для_расчётной_картыTableAdapter.Fill(CalculationCardsForm.automationAppDBDataSet.Ткань_для_расчётной_карты);
                    }
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectClothsInOrder = true;

            WarehouseClothsForm WarehouseForm = new WarehouseClothsForm(this, FlagSelectClothsInOrder);
            WarehouseForm.ShowDialog();

            NameTextBox.TextName = nameCloth;
            ModelTextBox.TextName = modelCloth;
            UnitDeterminationTextBox.TextName = unitDetermination;

            NameErrorLabel.Visible = false;
            ModelErrorLabel.Visible = false;
            CountErrorLabel.Visible = false;
            MessageLabel.Visible = true;

            NameTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            CountTextBox.BorderColor = Color.FromArgb(222, 223, 226);

            MessageLabel.Text = "Доступно на складе в количестве " + countCloths + " " + unitDetermination + ".";
            CountTextBoxTwo_TextChanged(null, null);
            //CountTextBox.Text = Convert.ToString(countCloths);
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

            if (CountTextBoxTwo.Text == "")
            {
                CountTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                CountErrorLabel.Visible = true;
                MessageLabel.Visible = false;
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
            int RowsCount = EditCalculationCardsForm.ClothsOrderDataGridView.Rows.Count;

            if (RowsCount != 0)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToInt32(EditCalculationCardsForm.ClothsOrderDataGridView.Rows[i].Cells[2].Value) == Convert.ToInt32(ID_ClothInWarehouse))
                    {
                        ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        ModelErrorLabel.Text = "Выбранная модель ткани уже есть в расчётной карте";
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
            if (Convert.ToInt32(CountTextBoxTwo.Text) > countCloths)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CountTextBoxTwo_TextChanged(object sender, EventArgs e)
        {
            CountTextBoxTwo.ForeColor = Color.Black;

            if (countCloths != 0)
            {
                if (CountTextBoxTwo.Text != "")
                {
                    if (Convert.ToInt32(CountTextBoxTwo.Text) != 0 && Convert.ToInt32(CountTextBoxTwo.Text) > 0 && Convert.ToInt32(CountTextBoxTwo.Text) <= CountCloths && CountTextBoxTwo.Text != "")
                    {
                        int TotalCount;

                        TotalCount = CountCloths - Convert.ToInt32(CountTextBoxTwo.Text);
                        MessageLabel.Text = "Доступно на складе в количестве " + TotalCount + " " + unitDetermination + ".";
                    }
                    else
                    {
                        CountTextBoxTwo.ForeColor = Color.FromArgb(255, 128, 128);
                        MessageLabel.Text = "Доступно на складе в количестве " + countCloths + " " + unitDetermination + ".";
                    }
                }
                else
                {
                    MessageLabel.Text = "Доступно на складе в количестве " + countCloths + " " + unitDetermination + ".";
                }
            }
        }

        private void CountTextBoxTwo_Enter(object sender, EventArgs e)
        {
            CountTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            CountErrorLabel.Visible = false;

            if (countCloths != 0)
            {
                MessageLabel.Visible = true;
            }
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
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
    }
}
