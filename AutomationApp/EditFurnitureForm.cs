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
    public partial class EditFurnitureForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private FurnitureForm FurnitureForm;
        private bool FlagEdit;

        private int ID_Furniture;
        private int ID_Model;

        private string NameFurniture;
        private string ModelFurniture;
        
        public EditFurnitureForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditFurnitureForm(FurnitureForm furnitureForm)
        {
            InitializeComponent();
            this.FurnitureForm = furnitureForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditFurnitureForm(FurnitureForm furnitureForm, bool flagEdit)
        {
            InitializeComponent();
            this.FurnitureForm = furnitureForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditFurnitureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.automationAppDBDataSet.Фурнитура);

            if (FlagEdit)
            {
                ID_Furniture = Convert.ToInt32(((DataRowView)FurnitureForm.модели_фурнитурыBindingSource.Current).Row["ID_Фурнитуры"]);
                ID_Model = Convert.ToInt32(((DataRowView)FurnitureForm.модели_фурнитурыBindingSource.Current).Row["ID_Модели_фурнитуры"]);
                NameTextBox.TextName = Convert.ToString(((DataRowView)FurnitureForm.модели_фурнитурыBindingSource.Current).Row["Наименование"]);
                ModelTextBox.TextName = Convert.ToString(((DataRowView)FurnitureForm.модели_фурнитурыBindingSource.Current).Row["Модель_фурнитуры"]);
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                if (!CheckEmptyData())
                {
                    if (!CheckRepeatData())
                    {
                        UpdateData();
                    }
                }
            }
            else
            {
                if (!CheckEmptyData())
                {
                    if (!CheckRepeatData())
                    {
                        InsertData();
                    }
                }
            }
        }

        private void InsertData()
        {
            
            int countItems;

            if (NameFurniture == NameTextBox.TextName)
            {
                countItems = FurnitureForm.фурнитураBindingSource.Count;

                for (int i = 0; i < countItems; i++)
                {
                    if (FurnitureForm.automationAppDBDataSet.Фурнитура[i].Наименование == NameFurniture)
                    {
                        ID_Furniture = FurnitureForm.automationAppDBDataSet.Фурнитура[i].ID_Фурнитуры;
                    }
                }

                ModelFurniture = ModelTextBox.TextName;
                FurnitureForm.модели_фурнитурыTableAdapter.Insert(ID_Furniture, ModelFurniture);
                FurnitureForm.модели_фурнитурыTableAdapter.Fill(FurnitureForm.automationAppDBDataSet.Модели_фурнитуры);

            }
            else
            {
                NameFurniture = NameTextBox.TextName;
                ModelFurniture = ModelTextBox.TextName;

                FurnitureForm.фурнитураTableAdapter.Insert(NameFurniture);
                FurnitureForm.фурнитураTableAdapter.Fill(FurnitureForm.automationAppDBDataSet.Фурнитура);

                FurnitureForm.фурнитураBindingSource.MoveLast();

                ID_Furniture = Convert.ToInt32(((DataRowView)FurnitureForm.фурнитураBindingSource.Current).Row["ID_Фурнитуры"]);

                FurnitureForm.модели_фурнитурыTableAdapter.Insert(ID_Furniture, ModelFurniture);
                FurnitureForm.модели_фурнитурыTableAdapter.Fill(FurnitureForm.automationAppDBDataSet.Модели_фурнитуры);

            }
           
        }

        private void UpdateData()
        {           
            int countModels;
            int countFurniture;

            countModels =FurnitureForm.automationAppDBDataSet.Модели_фурнитуры.Count;
            countFurniture = FurnitureForm.automationAppDBDataSet.Фурнитура.Count;

            for (int i = 0; i < countModels; i++)
            {
                if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].ID_Модели_фурнитуры == ID_Model)
                {
                    FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].Модель_фурнитуры = ModelTextBox.TextName;
                    FurnitureForm.automationAppDBDataSet.Модели_изделия[i].Наименование = NameTextBox.TextName;
                }
            }

            for (int i = 0; i < countFurniture; i++)
            {
                if (FurnitureForm.automationAppDBDataSet.Фурнитура[i].ID_Фурнитуры == ID_Furniture)
                {
                    FurnitureForm.automationAppDBDataSet.Фурнитура[i].Наименование = NameTextBox.TextName;
                }
            }

            FurnitureForm.фурнитураTableAdapter.Update(FurnitureForm.automationAppDBDataSet.Фурнитура);
            FurnitureForm.фурнитураTableAdapter.Fill(FurnitureForm.automationAppDBDataSet.Фурнитура);

            FurnitureForm.модели_фурнитурыTableAdapter.Update(FurnitureForm.automationAppDBDataSet.Модели_фурнитуры);
            FurnitureForm.модели_фурнитурыTableAdapter.Fill(FurnitureForm.automationAppDBDataSet.Модели_фурнитуры);           
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
            int countModels = FurnitureForm.automationAppDBDataSet.Модели_фурнитуры.Count;

            if (countModels != 0)
            {
                for (int i = 0; i < countModels; i++)
                {
                    if (FlagEdit)
                    {
                        if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].ID_Модели_фурнитуры != ID_Model)
                        {
                            if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].Наименование == NameTextBox.TextName)
                            {
                                if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].Модель_фурнитуры == ModelTextBox.TextName)
                                {
                                    ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                    ModelErrorLabel.Text = "Фурнитура с данной моделью уже есть в списке";
                                    ModelErrorLabel.Visible = true;
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].Наименование == NameTextBox.TextName)
                        {
                            if (FurnitureForm.automationAppDBDataSet.Модели_фурнитуры[i].Модель_фурнитуры == ModelTextBox.TextName)
                            {
                                ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                ModelErrorLabel.Text = "Фурнитура с данной моделью уже есть в списке";
                                ModelErrorLabel.Visible = true;
                                return true;
                            }
                        }
                    }
                }
            }
            ModelErrorLabel.Text = "Введите модель";
            return false;
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

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.Black;
            NameErrorLabel.Visible = false;
        }

        private void ModelTextBox_Enter(object sender, EventArgs e)
        {
            ModelTextBox.BorderColor = Color.Black;
            ModelErrorLabel.Visible = false;
        }
        
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.White;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.Gray;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
