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
    public partial class EditClothInOrdersForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly EditClothOrdersForm EditClothOrdersForm;
        private readonly ClothOrdersForm ClothOrdersForm;

        private int id_Cloth;
        private int id_ModelCloth;
        private string cloth;
        private string modelCloth;

        public int ID_Cloth
        {
            set
            {
                id_Cloth = value;
            }
            get
            {
                return id_Cloth;
            }
        }

        public int ID_ModelCloth
        {
            set
            {
                id_ModelCloth = value;
            }
            get
            {
                return id_ModelCloth;
            }
        }

        public string Cloth
        {
            set
            {
                cloth = value;
            }
            get
            {
                return cloth;
            }
        }

        public string ModelCloth
        {
            set
            {
                modelCloth = value;
            }
            get
            {
                return modelCloth;
            }
        }

        public EditClothInOrdersForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditClothInOrdersForm(ClothOrdersForm clothOrdersForm, EditClothOrdersForm editClothOrdersForm)
        {
            InitializeComponent();
            this.ClothOrdersForm = clothOrdersForm;
            this.EditClothOrdersForm = editClothOrdersForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        private void EditClothInOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_ткани". При необходимости она может быть перемещена или удалена.
            this.склад_тканиTableAdapter.Fill(this.automationAppDBDataSet.Склад_ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.automationAppDBDataSet.Ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_ткани". При необходимости она может быть перемещена или удалена.
            this.модели_тканиTableAdapter.Fill(this.automationAppDBDataSet.Модели_ткани);
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void AddClothButton_Click(object sender, EventArgs e)
        {
            /*FurnitureForm furnitureForm = new FurnitureForm(this);
            //ItemsForm itemsForm = new ItemsForm(this);
            EditFurnitureForm editFurnitureForm = new EditFurnitureForm(furnitureForm);
            editFurnitureForm.ShowDialog();*/            
        }

        private void NameCothComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectClothInOrder = true;

            NameTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ClothErrorLabel.Visible = false;

            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ModelErrorLabel.Visible = false;

            ClothsForm ClothsForm = new ClothsForm(this, FlagSelectClothInOrder);
            ClothsForm.ShowDialog();

            NameTextBox.TextName = Cloth;
            ModelTextBox.TextName = ModelCloth;
        }



        private void UnitDeterminationTextBox_Enter(object sender, EventArgs e)
        {
            UnitDeterminationTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            DeterminationErrorLabel.Visible = false;
        }

        private void ModelTextBox_Enter(object sender, EventArgs e)
        {
            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ModelErrorLabel.Visible = false;
        }

        private void CountTextBox_Enter(object sender, EventArgs e)
        {
            //CountTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            CountErrorLabel.Visible = false;
        }

        private void PriceTextBox_Enter(object sender, EventArgs e)
        {
            //PriceTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            PriceErrorLabel.Visible = false;
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (!CheckEmptyData())
            //{
                CalculatingSum();
            //}
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (!CheckEmptyData())
            //{
                CalculatingSum();
            //}
        }

        private void SumNDSTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (!CheckEmptyData())
            //{
                CalculatingSum();
            //}
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.White;
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.IconColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertData()
        {
            int ID_Order;

            string UnitDetermination;
            int Count;
            int Price;
            decimal SumWithoutNDS;
            decimal SumTotalNDS;
            decimal SumWithNDS;

            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    UnitDetermination = Convert.ToString(UnitDeterminationTextBox.TextName);
                    Count = Convert.ToInt32(CountTextBox.Text);
                    Price = Convert.ToInt32(PriceTextBox.Text);
                    SumWithoutNDS = Convert.ToDecimal(SumWithoutNDSTextBox.TextName);
                    SumTotalNDS = Convert.ToDecimal(SumTotalNDSTextBox.TextName);

                    if (SumNDSTextBox.Text == "")
                    {
                        SumWithNDS = 0;
                    }
                    else
                    {
                        SumWithNDS = Convert.ToDecimal(SumNDSTextBox.Text);
                    }

                    ID_Order = Convert.ToInt32(((DataRowView)ClothOrdersForm.приходныеордеранатканьBindingSource.Current).Row["ID_Приходного_ордера"]);

                    ClothOrdersForm.материальные_ценности_по_ордеру_на_тканьTableAdapter.Insert(ID_Order, ID_ModelCloth, UnitDetermination, Count, Price, SumWithNDS, SumWithoutNDS, SumTotalNDS);
                    ClothOrdersForm.материальные_ценности_по_ордеру_на_тканьTableAdapter.Fill(ClothOrdersForm.automationAppDBDataSet.Материальные_ценности_по_ордеру_на_ткань);
                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (NameTextBox.TextName == "")
            {
                NameTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                ClothErrorLabel.Visible = true;
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
                //CountTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                CountErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (PriceTextBox.Text == "")
            {
                //PriceTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                PriceErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (SumNDSTextBox.Text != "")
            {
                if (Convert.ToInt32(SumNDSTextBox.Text) <= 0)
                {
                    //SumNDSTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                    SumNDSErrorLabel.Visible = true;
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
            int RowsCount = EditClothOrdersForm.MaterialsClothsDataGridView.Rows.Count;

            if (RowsCount != 0)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToInt32(EditClothOrdersForm.MaterialsClothsDataGridView.Rows[i].Cells[3].Value) == Convert.ToInt32(ID_ModelCloth))
                    {
                        ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        ModelErrorLabel.Text = "Выбранная модель ткани уже есть в приходном ордере";
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
            int SumWithoutNDS;
            int SumWithNDS;

            if (PriceTextBox.Text != "" && CountTextBox.Text != "")
            {
                if (Convert.ToInt32(CountTextBox.Text) > 0 && Convert.ToInt32(PriceTextBox.Text) > 0)
                {
                    SumWithoutNDS = Convert.ToInt32(CountTextBox.Text) * Convert.ToInt32(PriceTextBox.Text);

                    SumWithoutNDSTextBox.TextName = Convert.ToString(SumWithoutNDS);
                    SumTotalNDSTextBox.TextName = Convert.ToString(SumWithoutNDS);

                    if (SumNDSTextBox.Text != "")
                    {
                        if (Convert.ToInt32(SumNDSTextBox.Text) > 0)
                        {
                            SumWithNDS = SumWithoutNDS + Convert.ToInt32(SumNDSTextBox.Text);
                            SumTotalNDSTextBox.TextName = Convert.ToString(SumWithNDS);
                        }
                    }

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