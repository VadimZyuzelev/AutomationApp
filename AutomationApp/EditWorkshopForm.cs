using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditWorkshopForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly WorkshopForm WorkshopForm;
        private readonly bool FlagEdit;

        private int ID_Workshop;
        private int ID_Brigade;

        private string Workshop;
        private string Brigade;

        public EditWorkshopForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditWorkshopForm(WorkshopForm workshopForm)
        {
            InitializeComponent();
            this.WorkshopForm = workshopForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditWorkshopForm(WorkshopForm workshopForm, bool flagEdit)
        {
            InitializeComponent();
            this.WorkshopForm = workshopForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditWorkshopForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                ID_Workshop = Convert.ToInt32(((DataRowView)WorkshopForm.бригадыBindingSource.Current).Row["ID_Цеха"]);
                ID_Brigade = Convert.ToInt32(((DataRowView)WorkshopForm.бригадыBindingSource.Current).Row["ID_Бригады"]);
                WorkshopTextBox.TextName = Convert.ToString(((DataRowView)WorkshopForm.бригадыBindingSource.Current).Row["Цех"]);
                BrigadeTextBox.TextName = Convert.ToString(((DataRowView)WorkshopForm.бригадыBindingSource.Current).Row["Наименование"]);

                LabelForm.Text = "Редактирование цеха";
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

        private void InsertData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countWorkshops;

                    if (Workshop == WorkshopTextBox.TextName)
                    {
                        countWorkshops = WorkshopForm.automationAppDBDataSet.Цеха.Count;

                        for (int i = 0; i < countWorkshops; i++)
                        {
                            if (WorkshopForm.automationAppDBDataSet.Цеха[i].Наименование == Workshop)
                            {
                                ID_Workshop = WorkshopForm.automationAppDBDataSet.Цеха[i].ID_Цеха;
                            }
                        }

                        Brigade = BrigadeTextBox.TextName;
                        WorkshopForm.бригадыTableAdapter.Insert(ID_Workshop, Brigade);
                        WorkshopForm.бригадыTableAdapter.Fill(WorkshopForm.automationAppDBDataSet.Бригады);

                    }
                    else
                    {
                        Workshop = WorkshopTextBox.TextName;
                        Brigade = BrigadeTextBox.TextName;

                        WorkshopForm.цехаTableAdapter.Insert(Workshop);
                        WorkshopForm.цехаTableAdapter.Fill(WorkshopForm.automationAppDBDataSet.Цеха);

                        WorkshopForm.цехаBindingSource.MoveLast();

                        ID_Workshop = Convert.ToInt32(((DataRowView)WorkshopForm.цехаBindingSource.Current).Row["ID_Цеха"]);
                        Brigade = BrigadeTextBox.TextName;

                        WorkshopForm.бригадыTableAdapter.Insert(ID_Workshop, Brigade);
                        WorkshopForm.бригадыTableAdapter.Fill(WorkshopForm.automationAppDBDataSet.Бригады);
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
                    int countBirgades;
                    int countWorkshops;

                    countBirgades = WorkshopForm.automationAppDBDataSet.Бригады.Count;
                    countWorkshops = WorkshopForm.automationAppDBDataSet.Цеха.Count;

                    for (int i = 0; i < countBirgades; i++)
                    {
                        if (WorkshopForm.automationAppDBDataSet.Бригады[i].ID_Бригады == ID_Brigade)
                        {
                            WorkshopForm.automationAppDBDataSet.Бригады[i].Наименование = BrigadeTextBox.TextName;
                            WorkshopForm.automationAppDBDataSet.Бригады[i].Цех = WorkshopTextBox.TextName;
                        }
                    }

                    for (int i = 0; i < countWorkshops; i++)
                    {
                        if (WorkshopForm.automationAppDBDataSet.Цеха[i].ID_Цеха == ID_Workshop)
                        {
                            WorkshopForm.automationAppDBDataSet.Цеха[i].Наименование = WorkshopTextBox.TextName;
                        }
                    }

                    WorkshopForm.цехаTableAdapter.Update(WorkshopForm.automationAppDBDataSet.Цеха);
                    WorkshopForm.цехаTableAdapter.Fill(WorkshopForm.automationAppDBDataSet.Цеха);

                    WorkshopForm.бригадыTableAdapter.Update(WorkshopForm.automationAppDBDataSet.Бригады);
                    WorkshopForm.бригадыTableAdapter.Fill(WorkshopForm.automationAppDBDataSet.Бригады);
                }
            }
            
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (WorkshopTextBox.TextName == "")
            {
                WorkshopTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                WorkshopErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (BrigadeTextBox.TextName == "")
            {
                BrigadeTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                BrigadeErrorLabel.Visible = true;
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
            int countBrigades = WorkshopForm.automationAppDBDataSet.Бригады.Count;

            if (countBrigades != 0)
            {
                for (int i = 0; i < countBrigades; i++)
                {
                    if (FlagEdit)
                    {                       
                        if (WorkshopForm.automationAppDBDataSet.Бригады[i].ID_Бригады != ID_Brigade)
                        {
                            if (WorkshopForm.automationAppDBDataSet.Бригады[i].Цех == WorkshopTextBox.TextName)
                            {
                                if (WorkshopForm.automationAppDBDataSet.Бригады[i].Наименование == BrigadeTextBox.TextName)
                                {
                                    BrigadeTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                    BrigadeErrorLabel.Text = "Цех с данной бригадой уже есть в списке";
                                    BrigadeErrorLabel.Visible = true;
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (WorkshopForm.automationAppDBDataSet.Бригады[i].ID_Бригады != ID_Brigade)
                        {
                            if (WorkshopForm.automationAppDBDataSet.Бригады[i].Цех == WorkshopTextBox.TextName)
                            {
                                if (WorkshopForm.automationAppDBDataSet.Бригады[i].Наименование == BrigadeTextBox.TextName)
                                {
                                    BrigadeTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                                    BrigadeErrorLabel.Text = "Цех с данной бригадой уже есть в списке";
                                    BrigadeErrorLabel.Visible = true;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            BrigadeTextBox.Text = "Введите наименование бригады";
            BrigadeErrorLabel.Visible = false;
            BrigadeTextBox.BorderColor = Color.FromArgb(222, 223, 226);

            return false;
        }

        private void WorkshopTextBox_Enter(object sender, EventArgs e)
        {
            WorkshopTextBox.BorderColor = Color.Black;
            WorkshopErrorLabel.Visible = false;
        }

        private void WorkshopTextBox_Leave(object sender, EventArgs e)
        {
            WorkshopTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void BrigadeTextBox_Enter(object sender, EventArgs e)
        {
            BrigadeTextBox.BorderColor = Color.Black;
            BrigadeErrorLabel.Visible = false;
        }

        private void BrigadeTextBox_Leave(object sender, EventArgs e)
        {
            BrigadeTextBox.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.White;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.Gray;
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
    }
}
