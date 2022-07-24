using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditDriversForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly DriversForm DriversForm;
        private readonly bool FlagEdit;

        private int ID_Driver;
        
        public EditDriversForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditDriversForm(DriversForm driversForm)
        {
            InitializeComponent();
            this.DriversForm = driversForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditDriversForm(DriversForm driversForm, bool flagEdit)
        {
            InitializeComponent();
            this.DriversForm = driversForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditDriversForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                ID_Driver = Convert.ToInt32(((DataRowView)DriversForm.водителиBindingSource.Current).Row["ID_Водителя"]);
                FIOTextBox.TextName = Convert.ToString(((DataRowView)DriversForm.водителиBindingSource.Current).Row["ФИО"]);
                NumberTextBox.TextName = Convert.ToString(((DataRowView)DriversForm.водителиBindingSource.Current).Row["Номер_водительского_удостоверения"]);
                DateTimePicker.Value = Convert.ToDateTime(((DataRowView)DriversForm.водителиBindingSource.Current).Row["Дата_выдачи_удостоверения"]);

                LabelForm.Text = "Редактирование водителя";
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
                    string FIO = FIOTextBox.TextName;
                    string NumberLicense = NumberTextBox.TextName;
                    DateTime Date = DateTimePicker.Value;

                    DriversForm.водителиTableAdapter.Insert(FIO, NumberLicense, Date);
                    DriversForm.водителиTableAdapter.Fill(DriversForm.automationAppDBDataSet.Водители);
                }
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countDrivers = DriversForm.automationAppDBDataSet.Водители.Count;

                    for (int i = 0; i < countDrivers; i++)
                    {
                        if (DriversForm.automationAppDBDataSet.Водители[i].ID_Водителя == ID_Driver)
                        {
                            DriversForm.automationAppDBDataSet.Водители[i].ФИО = FIOTextBox.TextName;
                            DriversForm.automationAppDBDataSet.Водители[i].Номер_водительского_удостоверения = NumberTextBox.TextName;
                            DriversForm.automationAppDBDataSet.Водители[i].Дата_выдачи_удостоверения = DateTimePicker.Value;
                        }
                    }

                    DriversForm.водителиTableAdapter.Update(DriversForm.automationAppDBDataSet.Водители);
                    DriversForm.водителиTableAdapter.Fill(DriversForm.automationAppDBDataSet.Водители);

                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (FIOTextBox.TextName == "")
            {
                FIOTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                FIOErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (NumberTextBox.TextName == "")
            {
                NumberTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                NumberErrorLabel.Visible = true;
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
            int countDrivers = DriversForm.automationAppDBDataSet.Водители.Count;

            if (countDrivers != 0)
            {
                for (int i = 0; i < countDrivers; i++)
                {
                    if (FlagEdit)
                    {
                        if (DriversForm.automationAppDBDataSet.Водители[i].ID_Водителя != ID_Driver)
                        {
                            if (DriversForm.automationAppDBDataSet.Водители[i].ФИО == FIOTextBox.TextName)
                            {
                                FIOTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                FIOErrorLabel.Text = "Данный водитель уже есть в списке";
                                FIOErrorLabel.Visible = true;
                                return true;
                            }

                            if (DriversForm.automationAppDBDataSet.Водители[i].Номер_водительского_удостоверения == NumberTextBox.TextName)
                            {
                                NumberTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                NumberErrorLabel.Text = "Данное удостоверение уже есть в списке";
                                NumberErrorLabel.Visible = true;
                                return true;                              
                            }

                        }
                    }
                    else
                    {
                        if (DriversForm.automationAppDBDataSet.Водители[i].ФИО == FIOTextBox.TextName)
                        {
                            {
                                FIOTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                FIOErrorLabel.Text = "Данный водитель уже есть в списке";
                                FIOErrorLabel.Visible = true;
                                return true;
                            }
                        }

                        if (DriversForm.automationAppDBDataSet.Водители[i].Номер_водительского_удостоверения == NumberTextBox.TextName)
                        {
                            NumberTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                            NumberErrorLabel.Text = "Данное удостоверение уже есть в списке";
                            NumberErrorLabel.Visible = true;
                            return true;
                        }
                    }
                }
            }
                FIOErrorLabel.Text = "Введите ФИО";
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

        private void FIOTextBox_Enter(object sender, EventArgs e)
        {
            FIOTextBox.BorderColor = Color.Black;
            FIOErrorLabel.Visible = false;
        }

        private void NumberTextBox_Enter(object sender, EventArgs e)
        {
            NumberTextBox.BorderColor = Color.Black;
            NumberErrorLabel.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIOTextBox_Leave(object sender, EventArgs e)
        {
            FIOTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void NumberTextBox_Leave(object sender, EventArgs e)
        {
            NumberTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }
    }
}
