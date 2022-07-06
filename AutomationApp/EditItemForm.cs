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
    public partial class EditItemForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private ItemsForm ItemsForm;
        private bool FlagEdit;

        private int ID_Item;
        private int ID_Model;

        private string NameItem;
        private string Model;

        public EditItemForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditItemForm(ItemsForm ItemsFormTwo)
        {
            InitializeComponent();
            this.ItemsForm = ItemsFormTwo;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditItemForm(ItemsForm ItemsFormTwo, bool FlagEditTwo)
        {
            InitializeComponent();
            this.ItemsForm = ItemsFormTwo;
            this.FlagEdit = FlagEditTwo;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.automationAppDBDataSet.Изделия);          

            if (FlagEdit)
            {
                SetData();
                LabelForm.Text = "Редактирование изделия";
                IconPictureBox.IconChar = IconChar.Pen;
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

        private void NameItemTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.Black;
            NameErrorLabel.Visible = false;
        }

        private void NameItemTextBox_Leave(object sender, EventArgs e)
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

        private void SetData()
        {
            ID_Model = Convert.ToInt32(((DataRowView)ItemsForm.МоделиИзделияBindingSource.Current).Row["ID_Модели_изделия"]);
            ID_Item = Convert.ToInt32(((DataRowView)ItemsForm.МоделиИзделияBindingSource.Current).Row["ID_Изделия"]);
            NameTextBox.TextName = Convert.ToString(((DataRowView)ItemsForm.МоделиИзделияBindingSource.Current).Row["Наименование"]);
            ModelTextBox.TextName = Convert.ToString(((DataRowView)ItemsForm.МоделиИзделияBindingSource.Current).Row["Модель_изделия"]);
        }

        private void InsertData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countItems;

                    if (NameItem == NameTextBox.TextName)
                    {
                        countItems = ItemsForm.automationAppDBDataSet.Изделия.Count;

                        for (int i = 0; i < countItems; i++)
                        {
                            if (ItemsForm.automationAppDBDataSet.Изделия[i].Наименование == NameItem)
                            {
                                ID_Item = ItemsForm.automationAppDBDataSet.Изделия[i].ID_Изделия;
                            }
                        }

                        Model = ModelTextBox.TextName;
                        ItemsForm.МоделиИзделияTableAdapter.Insert(ID_Item, Model);
                        ItemsForm.МоделиИзделияTableAdapter.Fill(ItemsForm.automationAppDBDataSet.Модели_изделия);

                    }
                    else
                    {
                        NameItem = NameTextBox.TextName;
                        Model = ModelTextBox.TextName;

                        ItemsForm.ИзделияTableAdapter.Insert(NameItem);
                        ItemsForm.ИзделияTableAdapter.Fill(ItemsForm.automationAppDBDataSet.Изделия);

                        ItemsForm.ИзделияBindingSource.MoveLast();

                        ID_Item = Convert.ToInt32(((DataRowView)ItemsForm.ИзделияBindingSource.Current).Row["ID_Изделия"]);

                        ItemsForm.МоделиИзделияTableAdapter.Insert(ID_Item, Model);
                        ItemsForm.МоделиИзделияTableAdapter.Fill(ItemsForm.automationAppDBDataSet.Модели_изделия);

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
                    int countItems;
           
                    countModels = ItemsForm.automationAppDBDataSet.Модели_изделия.Count;
                    countItems = ItemsForm.automationAppDBDataSet.Изделия.Count;

                    for (int i = 0; i < countModels; i++)
                    {
                        if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].ID_Модели_изделия == ID_Model)
                        {
                            ItemsForm.automationAppDBDataSet.Модели_изделия[i].Модель_изделия = ModelTextBox.TextName;
                            ItemsForm.automationAppDBDataSet.Модели_изделия[i].Наименование = NameTextBox.TextName;
                        }
                    }

                    for (int i = 0; i < countItems; i++)
                    {
                        if (ItemsForm.automationAppDBDataSet.Изделия[i].ID_Изделия == ID_Item)
                        {
                            ItemsForm.automationAppDBDataSet.Изделия[i].Наименование = NameTextBox.TextName;
                        }
                    }

                    ItemsForm.ИзделияTableAdapter.Update(ItemsForm.automationAppDBDataSet.Изделия);
                    ItemsForm.ИзделияTableAdapter.Fill(ItemsForm.automationAppDBDataSet.Изделия);

                    ItemsForm.МоделиИзделияTableAdapter.Update(ItemsForm.automationAppDBDataSet.Модели_изделия);
                    ItemsForm.МоделиИзделияTableAdapter.Fill(ItemsForm.automationAppDBDataSet.Модели_изделия);

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
            int countModels = ItemsForm.automationAppDBDataSet.Модели_изделия.Count;

            if (countModels != 0)
            {
                for (int i = 0; i < countModels; i++)
                {
                    if (FlagEdit)
                    {
                        if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].ID_Модели_изделия != ID_Model)
                        {
                            if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].Наименование == NameTextBox.TextName)
                            {
                                if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].Модель_изделия == ModelTextBox.TextName)
                                {
                                    ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                    ModelErrorLabel.Text = "Изделие с данной моделью уже есть в списке";
                                    ModelErrorLabel.Visible = true;
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].Наименование == NameTextBox.TextName)
                        {
                            if (ItemsForm.automationAppDBDataSet.Модели_изделия[i].Модель_изделия == ModelTextBox.TextName)
                            {
                                ModelTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                ModelErrorLabel.Text = "Изделие с данной моделью уже есть в списке";
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

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.White;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.IconColor = Color.Gray;
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.Black;
            NameErrorLabel.Visible = false;
        }

        private void ModelBorder_Leave(object sender, EventArgs e)
        {
            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(0, 120, 215);
            ExitButton.IconColor = Color.White;

            this.Close();
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
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
