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
    public partial class EditClothForm : Form
    {
        private readonly ClothsForm ClothsForm;
        private readonly bool FlagEdit;

        private int ID_Cloth;
        private int ID_Model;

        private string NameCloth;
        private string Model;

        public EditClothForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditClothForm(ClothsForm clothsForm)
        {
            InitializeComponent();
            this.ClothsForm = clothsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditClothForm(ClothsForm clothsForm, bool flaEdit)
        {
            InitializeComponent();
            this.ClothsForm = clothsForm;
            this.FlagEdit = flaEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditClothForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                ID_Cloth = Convert.ToInt32(((DataRowView)ClothsForm.моделитканиBindingSource.Current).Row["ID_Ткани"]);
                ID_Model = Convert.ToInt32(((DataRowView)ClothsForm.моделитканиBindingSource.Current).Row["ID_Модели_ткани"]);

                NameTextBox.TextName = Convert.ToString(((DataRowView)ClothsForm.моделитканиBindingSource.Current).Row["Наименование"]);
                ModelTextBox.TextName = Convert.ToString(((DataRowView)ClothsForm.моделитканиBindingSource.Current).Row["Модель_ткани"]);
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                UpdateData();
            }
            else
            {
                InsertData();
            }
        }

        private void InsertData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countCloths;

                    if (NameCloth == NameTextBox.TextName)
                    {
                        countCloths = ClothsForm.automationAppDBDataSet.Ткани.Count;

                        for (int i = 0; i < countCloths; i++)
                        {
                            if (ClothsForm.automationAppDBDataSet.Ткани[i].Наименование == NameCloth)
                            {
                                ID_Cloth = ClothsForm.automationAppDBDataSet.Ткани[i].ID_Ткани;
                            }
                        }

                        Model = ModelTextBox.TextName;
                        ClothsForm.модели_тканиTableAdapter.Insert(ID_Cloth, Model);
                        ClothsForm.модели_тканиTableAdapter.Fill(ClothsForm.automationAppDBDataSet.Модели_ткани);

                    }
                    else
                    {
                        NameCloth = NameTextBox.TextName;
                        Model = ModelTextBox.TextName;

                        ClothsForm.тканиTableAdapter.Insert(NameCloth);
                        ClothsForm.тканиTableAdapter.Fill(ClothsForm.automationAppDBDataSet.Ткани);

                        ClothsForm.тканиBindingSource.MoveLast();

                        ID_Cloth = Convert.ToInt32(((DataRowView)ClothsForm.тканиBindingSource.Current).Row["ID_Ткани"]);

                        ClothsForm.модели_тканиTableAdapter.Insert(ID_Cloth, Model);
                        ClothsForm.модели_тканиTableAdapter.Fill(ClothsForm.automationAppDBDataSet.Модели_ткани);
                    }
                }
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countModels;
                    int countCloths;

                    countModels = ClothsForm.automationAppDBDataSet.Модели_ткани.Count;
                    countCloths = ClothsForm.automationAppDBDataSet.Ткани.Count;

                    for (int i = 0; i < countModels; i++)
                    {
                        if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].ID_Модели_ткани == ID_Model)
                        {
                            ClothsForm.automationAppDBDataSet.Модели_ткани[i].Модель_ткани = ModelTextBox.TextName;
                            ClothsForm.automationAppDBDataSet.Модели_ткани[i].Наименование = NameTextBox.TextName;
                        }
                    }

                    for (int i = 0; i < countCloths; i++)
                    {
                        if (ClothsForm.automationAppDBDataSet.Ткани[i].ID_Ткани == ID_Cloth)
                        {
                            ClothsForm.automationAppDBDataSet.Ткани[i].Наименование = NameTextBox.TextName;
                        }
                    }

                    ClothsForm.тканиTableAdapter.Update(ClothsForm.automationAppDBDataSet.Ткани);
                    ClothsForm.тканиTableAdapter.Fill(ClothsForm.automationAppDBDataSet.Ткани);

                    ClothsForm.модели_тканиTableAdapter.Update(ClothsForm.automationAppDBDataSet.Модели_ткани);
                    ClothsForm.модели_тканиTableAdapter.Fill(ClothsForm.automationAppDBDataSet.Модели_ткани);

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
            int countModels = ClothsForm.automationAppDBDataSet.Модели_ткани.Count;

            if (countModels != 0)
            {
                for (int i = 0; i < countModels; i++)
                {
                    if (FlagEdit)
                    {
                        if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].ID_Модели_ткани != ID_Model)
                        {
                            if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].Наименование == NameTextBox.TextName)
                            {
                                if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].Модель_ткани == ModelTextBox.TextName)
                                {
                                    ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                    ModelErrorLabel.Text = "Ткань с данной моделью уже есть в списке";
                                    ModelErrorLabel.Visible = true;

                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].Наименование == NameTextBox.TextName)
                        {
                            if (ClothsForm.automationAppDBDataSet.Модели_ткани[i].Модель_ткани == ModelTextBox.TextName)
                            {
                                ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                ModelErrorLabel.Text = "Ткань с данной моделью уже есть в списке";
                                ModelErrorLabel.Visible = true;
                                return true;
                            }
                        }
                    }
                }
            }

            ModelErrorLabel.Text = "Введите модель";
            ModelErrorLabel.Visible = false;
            return false;
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.Black;
            NameErrorLabel.Visible = false;
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void ModelTextBox_Enter(object sender, EventArgs e)
        {
            ModelTextBox.BorderColor = Color.Black;
            ModelErrorLabel.Visible = false;
        }

        private void ModelTextBox_Leave(object sender, EventArgs e)
        {
            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
