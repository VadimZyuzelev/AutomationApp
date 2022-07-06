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
    public partial class EditCounteragentsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private CounteragentsForm CounteragentsForm;
        private bool FlagEdit;

        private int ID_Counteragent;

        public EditCounteragentsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditCounteragentsForm(CounteragentsForm counteragentsForm)
        {
            InitializeComponent();
            this.CounteragentsForm = counteragentsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditCounteragentsForm(CounteragentsForm counteragentsForm, bool flagEdit)
        {
            InitializeComponent();
            this.CounteragentsForm = counteragentsForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditCounteragentsForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                ID_Counteragent = Convert.ToInt32(((DataRowView)CounteragentsForm.контрагентыBindingSource.Current).Row["ID_Контрагента"]);
                YNPTextBox.Text = Convert.ToString(((DataRowView)CounteragentsForm.контрагентыBindingSource.Current).Row["УНП"]);
                NameTextBox.Text = Convert.ToString(((DataRowView)CounteragentsForm.контрагентыBindingSource.Current).Row["Наименование"]);
                AddressTextBox.Text = Convert.ToString(((DataRowView)CounteragentsForm.контрагентыBindingSource.Current).Row["Адрес"]);

                LabelForm.Text = "Редактирование контрагента";
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void InsertData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    string YNP = YNPTextBox.TextName;
                    string Name = NameTextBox.TextName;
                    string Address = AddressTextBox.TextName;

                    CounteragentsForm.контрагентыTableAdapter.Insert(YNP, Name, Address);
                    CounteragentsForm.контрагентыTableAdapter.Fill(CounteragentsForm.automationAppDBDataSet.Контрагенты);                   
                }
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countCounterAgengts = CounteragentsForm.automationAppDBDataSet.Контрагенты.Count;

                    for (int i = 0; i < countCounterAgengts; i++)
                    {
                        if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].ID_Контрагента == ID_Counteragent)
                        {
                            CounteragentsForm.automationAppDBDataSet.Контрагенты[i].УНП = YNPTextBox.TextName;
                            CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Наименование = NameTextBox.TextName;
                            CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Адрес = AddressTextBox.TextName;
                        }
                    }
                    CounteragentsForm.контрагентыTableAdapter.Update(CounteragentsForm.automationAppDBDataSet.Контрагенты);
                    CounteragentsForm.контрагентыTableAdapter.Fill(CounteragentsForm.automationAppDBDataSet.Контрагенты);
                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (YNPTextBox.TextName == "")
            {
                YNPTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                YNPErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (NameTextBox.TextName == "")
            {
                NameTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                NameErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (AddressTextBox.TextName == "")
            {
                AddressTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                AddressErrorLabel.Visible = true;
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
            int countCounterAgengts =  CounteragentsForm.automationAppDBDataSet.Контрагенты.Count;

            if (countCounterAgengts != 0)
            {
                for (int i = 0; i < countCounterAgengts; i++)
                {
                    if (FlagEdit)
                    {
                        if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].ID_Контрагента != ID_Counteragent)
                        {
                            if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].УНП == YNPTextBox.TextName)
                            {                                
                                YNPTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                YNPErrorLabel.Text = "Контрагент с данным УНП есть в списке";
                                YNPErrorLabel.Visible = true;
                                return true;
                            }
                            else
                            {
                                if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Наименование == NameTextBox.TextName)
                                {
                                    if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Адрес == AddressTextBox.TextName)
                                    {
                                        NameTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                        NameErrorLabel.Text = "Данный контрагент уже есть в списке";
                                        NameErrorLabel.Visible = true;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].УНП == YNPTextBox.TextName)
                        {
                            if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].УНП == YNPTextBox.TextName)
                            {
                                YNPTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                YNPErrorLabel.Text = "Контрагент с данным УНП есть в списке";
                                YNPErrorLabel.Visible = true;
                                return true;
                            }
                            else
                            {
                                if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Наименование == NameTextBox.TextName)
                                {
                                    if (CounteragentsForm.automationAppDBDataSet.Контрагенты[i].Адрес == AddressTextBox.TextName)
                                    {
                                        NameTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                        NameErrorLabel.Text = "Данный контрагент уже есть в списке";
                                        NameErrorLabel.Visible = true;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            YNPErrorLabel.Text = "Введите УНП";
            NameErrorLabel.Text = "Введите наименование";

            return false;
        }

        private void YNPTextBox_Enter(object sender, EventArgs e)
        {
            YNPTextBox.BorderColor = Color.Black;
            YNPErrorLabel.Visible = false;
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.Black;
            NameErrorLabel.Visible = false;
        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            AddressTextBox.BorderColor = Color.Black;
            AddressErrorLabel.Visible = false;
        }

        private void YNPTextBox_Leave(object sender, EventArgs e)
        {
            YNPTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            AddressTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }
    }
}
