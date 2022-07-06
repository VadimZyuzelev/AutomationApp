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
    public partial class EditProvidersForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private ProvidersForm ProvidersForm;
        private bool FlagEdit;

        private int ID_Provider;
        private string Provider;
        private string Address;

        public EditProvidersForm()
        {
            InitializeComponent();
        }       
        
        public EditProvidersForm(ProvidersForm providersForm)
        {
            InitializeComponent();
            this.ProvidersForm = providersForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }        
        
        public EditProvidersForm(ProvidersForm providersForm, bool flagEdit)
        {
            InitializeComponent();
            this.ProvidersForm = providersForm;
            this.FlagEdit = flagEdit;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditProvidersForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                ID_Provider = Convert.ToInt32(((DataRowView)ProvidersForm.поставщикиBindingSource.Current).Row["ID_Поставщика"]);
                ProviderTextBox.TextName = Convert.ToString(((DataRowView)ProvidersForm.поставщикиBindingSource.Current).Row["Наименование"]);
                AddressTextBox.TextName = Convert.ToString(((DataRowView)ProvidersForm.поставщикиBindingSource.Current).Row["Адрес"]);

                LabelForm.Text = "Редактирование поставщика";
                IconPictureBox.IconChar = IconChar.Pen;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
                    Provider = ProviderTextBox.TextName;
                    Address = AddressTextBox.TextName;

                    ProvidersForm.поставщикиTableAdapter.Insert(Provider, Address);
                    ProvidersForm.поставщикиTableAdapter.Fill(ProvidersForm.automationAppDBDataSet.Поставщики);
                }
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countProviders = ProvidersForm.automationAppDBDataSet.Поставщики.Count;

                    if (countProviders != 0)
                    {
                        for (int i = 0; i < countProviders; i++)
                        {
                            if (ProvidersForm.automationAppDBDataSet.Поставщики[i].ID_Поставщика == ID_Provider)
                            {
                                ProvidersForm.automationAppDBDataSet.Поставщики[i].Наименование = ProviderTextBox.TextName;
                                ProvidersForm.automationAppDBDataSet.Поставщики[i].Адрес = AddressTextBox.TextName;

                                ProvidersForm.поставщикиTableAdapter.Update(ProvidersForm.automationAppDBDataSet.Поставщики);
                                ProvidersForm.поставщикиTableAdapter.Fill(ProvidersForm.automationAppDBDataSet.Поставщики);
                            }
                        }
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
            int countProviders = ProvidersForm.automationAppDBDataSet.Поставщики.Count;

            if (countProviders != 0)
            {
                for (int i = 0; i < countProviders; i++)
                {
                    if (FlagEdit)
                    {                    
                        if (ProvidersForm.automationAppDBDataSet.Поставщики[i].ID_Поставщика != ID_Provider)
                        {
                            if (ProvidersForm.automationAppDBDataSet.Поставщики[i].Наименование == ProviderTextBox.TextName && ProvidersForm.automationAppDBDataSet.Поставщики[i].Адрес == AddressTextBox.TextName)
                            {
                                ProviderTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                ProviderErrorLabel.Text = "Данный поставщик уже есть в списке";
                                ProviderErrorLabel.Visible = true;
                                return true;
                            }
                        }
                    }
                    else
                    {
                        if (ProvidersForm.automationAppDBDataSet.Поставщики[i].Наименование == ProviderTextBox.TextName)
                        {
                            if (ProvidersForm.automationAppDBDataSet.Поставщики[i].Адрес == AddressTextBox.TextName)
                            {
                                ProviderTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                ProviderErrorLabel.Text = "Данный поставщик уже есть в списке";
                                ProviderErrorLabel.Visible = true;
                                return true;
                            }
                        }
                    }
                }
            }
            ProviderErrorLabel.Text = "Введите наименование";
            return false;
        }

        private void ProviderTextBox_Enter(object sender, EventArgs e)
        {
            ProviderTextBox.BorderColor = Color.Black;
            ProviderErrorLabel.Visible = false;
        }

        private void ProviderTextBox_Leave(object sender, EventArgs e)
        {
            ProviderTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            AddressTextBox.BorderColor = Color.Black;
            AddressErrorLabel.Visible = false;
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            AddressTextBox.BorderColor = Color.FromArgb(222, 223, 226);
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

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.White;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.Gray;
        }
    }
}
