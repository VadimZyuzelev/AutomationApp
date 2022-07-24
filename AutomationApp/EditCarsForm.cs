using System;
using System.Data;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditCarsForm : Form
    {
        private readonly CarsForm CarsForm;
        private readonly bool FlagEdit;

        private int ID_Car;

        public EditCarsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditCarsForm(CarsForm carsForm)
        {
            InitializeComponent();
            this.CarsForm = carsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditCarsForm(CarsForm carsForm, bool flagEdit)
        {
            InitializeComponent();
            this.CarsForm = carsForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditCarsForm_Load(object sender, EventArgs e)
        {
            if (FlagEdit)
            {
                LabelForm.Text = "Редактирование автомобиля";
                IconPictureBox.IconChar = IconChar.Pen;

                ID_Car = Convert.ToInt32(((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["ID_Автомобиля"]);
                MarkTextBox.TextName = Convert.ToString(((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Марка"]);
                ModelTextBox.TextName = Convert.ToString(((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Модель"]);
                NumberTextBox.TextName = Convert.ToString(((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Регистрационный_номер"]);
                OwnerTextBox.TextName = Convert.ToString(((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Владелец"]);
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            string Mark = MarkTextBox.Text;
            string Model = ModelTextBox.Text;
            string Number = NumberTextBox.Text;
            string Owner = OwnerTextBox.Text;

            if (FlagEdit)
            {
                ((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Марка"] = Mark;
                ((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Модель"] = Model;
                ((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Регистрационный_номер"] = Number;
                ((DataRowView)CarsForm.автомобилиBindingSource.Current).Row["Владелец"] = Owner;

                CarsForm.автомобилиTableAdapter.Update(CarsForm.automationAppDBDataSet.Автомобили);
                CarsForm.автомобилиTableAdapter.Fill(CarsForm.automationAppDBDataSet.Автомобили);
            }
            else
            {
                CarsForm.автомобилиTableAdapter.Insert(Mark, Model, Owner, Number);
                CarsForm.автомобилиTableAdapter.Fill(CarsForm.automationAppDBDataSet.Автомобили);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
