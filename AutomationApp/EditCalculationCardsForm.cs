using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditCalculationCardsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly CalculationCardsForm CardsForm;

        private readonly bool FlagEdit;
        private int ID_Card;
        private string NumberTicket;
        private DateTime Date;

        private int id_Brigade;
        private int id_Model;
        private string workshop;
        private string brigade;
        private string nameItem;
        private string modelItem;

        public int ID_Brigade
        {
            set
            {
                id_Brigade = value;
            }
            get
            {
                return id_Brigade;
            }
        }

        public int ID_Model
        {
            set
            {
                id_Model = value;
            }
            get
            {
                return id_Model;
            }
        }

        public string Workshop
        {
            set
            {
                workshop = value;
            }
            get
            {
                return workshop;
            }
        }

        public string Brigade
        {
            set
            {
                brigade = value;
            }
            get
            {
                return brigade;
            }
        }

        public string NameItem
        {
            set
            {
                nameItem = value;
            }
            get
            {
                return nameItem;
            }
        }

        public string ModelItem
        {
            set
            {
                modelItem = value;
            }
            get
            {
                return modelItem;
            }
        }

        public EditCalculationCardsForm()
        {
            InitializeComponent();
        }
        
        public EditCalculationCardsForm(CalculationCardsForm cardsForm)
        {
            InitializeComponent();
            this.CardsForm = cardsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }        
        
        public EditCalculationCardsForm(CalculationCardsForm cardsForm, bool flagEdit)
        {
            InitializeComponent();
            this.CardsForm = cardsForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditCalculationCardsForm_Load(object sender, EventArgs e)
        {          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Расчётные_карты". При необходимости она может быть перемещена или удалена.
            this.расчётные_картыTableAdapter.Fill(this.automationAppDBDataSet.Расчётные_карты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Ткань_для_расчётной_карты". При необходимости она может быть перемещена или удалена.
            this.ткань_для_расчётной_картыTableAdapter.Fill(this.automationAppDBDataSet.Ткань_для_расчётной_карты);
           
            if (FlagEdit)
            {
                ID_Card = Convert.ToInt32(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["ID_Расчётной_карты"]);
                ID_Brigade = Convert.ToInt32(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["ID_Бригады"]);
                ID_Model = Convert.ToInt32(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["ID_Модели_изделия"]);
                NumberTicketTextBox.TextName = Convert.ToString(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Номер_заказа"]);
                WorkshopTextBox.TextName = Convert.ToString(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Цех"]);
                BrigadeTextBox.TextName = Convert.ToString(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Бригада"]);
                ItemTextBox.TextName = Convert.ToString(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Изделие"]);
                ModelTextBox.TextName = Convert.ToString(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Модель_изделия"]);
                DateCreateTimePicker.Value = Convert.ToDateTime(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["Дата_отпуска_ткани"]);

                fKТканьдляIDРа0C1BC9F9BindingSource.DataSource = CardsForm.расчётныекартыBindingSource;

                ClothsOrderDataGridView.Enabled = false;
                AddClothButton.BackColor = Color.FromArgb(226, 226, 226);
                AddClothButton.Enabled = false;

                TopLabel.Text = "Редактирование расчётной карты";
                TopPictureButton.IconChar = IconChar.Pen;

            }
            else
            {
                ClothsOrderDataGridView.DataSource = null; 
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (ClothsOrderDataGridView.Rows.Count == 0)
                {
                    ClothLabelError.Visible = true;
                }
                else
                {
                    UpdateData();

                    NumberTicketTextBox.TextName = "";
                    WorkshopTextBox.TextName = "";
                    ItemTextBox.TextName = "";
                    BrigadeTextBox.TextName = "";
                    ModelTextBox.TextName = "";

                    ClothsOrderDataGridView.DataSource = null;
                }
            }
            else
            {
                if (ClothsOrderDataGridView.Rows.Count == 0)
                {
                    ClothLabelError.Visible = true;
                }
            }
        }

        private void AddClothButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (ClothsOrderDataGridView.Rows.Count == 0)
                {
                    Date = DateCreateTimePicker.Value;
                    NumberTicket = NumberTicketTextBox.TextName;

                    CardsForm.расчётные_картыTableAdapter.Insert(ID_Brigade, ID_Model, NumberTicket, Date);
                    CardsForm.расчётные_картыTableAdapter.Fill(CardsForm.automationAppDBDataSet.Расчётные_карты);

                    fKТканьдляIDРа0C1BC9F9BindingSource.DataSource = CardsForm.расчётныекартыBindingSource;
                    ClothsOrderDataGridView.DataSource = CardsForm.fKТканьдляIDРа0C1BC9F9BindingSource;

                    CardsForm.расчётныекартыBindingSource.MoveLast();
                    ID_Card = Convert.ToInt32(((DataRowView)CardsForm.расчётныекартыBindingSource.Current).Row["ID_Расчётной_карты"]);
                }

                ClothLabelError.Visible = false;
                EditClothsInCardsForm EditForm = new EditClothsInCardsForm(this, CardsForm);
                EditForm.ShowDialog();

                if (ClothsOrderDataGridView.Rows.Count == 0)
                {
                    CardsForm.расчётныекартыBindingSource.RemoveCurrent();
                    CardsForm.расчётные_картыTableAdapter.Update(CardsForm.automationAppDBDataSet.Расчётные_карты);
                    CardsForm.расчётные_картыTableAdapter.Fill(CardsForm.automationAppDBDataSet.Расчётные_карты);
                }

            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int CountCards = CardsForm.расчётныекартыBindingSource.Count;

                    for (int i = 0; i < CountCards; i++)
                    {
                        if (CardsForm.automationAppDBDataSet.Расчётные_карты[i].ID_Расчётной_карты == ID_Card)
                        {
                            CardsForm.automationAppDBDataSet.Расчётные_карты[i].Номер_заказа = NumberTicketTextBox.TextName;
                            CardsForm.automationAppDBDataSet.Расчётные_карты[i].ID_Бригады = ID_Brigade;
                            CardsForm.automationAppDBDataSet.Расчётные_карты[i].ID_Модели_изделия = ID_Model;

                            CardsForm.расчётные_картыTableAdapter.Update(CardsForm.automationAppDBDataSet.Расчётные_карты);
                            CardsForm.расчётные_картыTableAdapter.Fill(CardsForm.automationAppDBDataSet.Расчётные_карты);
                        }
                    }
                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (NumberTicketTextBox.TextName == "")
            {
                NumberTicketTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                NumberErrorLabel.Visible = true;
                FlagEmpty = true;
            }

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

            if (ItemTextBox.TextName == "")
            {
                ItemTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                ItemErrorLabel.Visible = true;
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
            int CountCards = CardsForm.automationAppDBDataSet.Расчётные_карты.Count;
            NumberTicket = NumberTicketTextBox.TextName;

            for (int i = 0; i < CountCards; i++)
            {
                if (CardsForm.automationAppDBDataSet.Расчётные_карты[i].ID_Расчётной_карты != ID_Card)
                {
                    if (CardsForm.automationAppDBDataSet.Расчётные_карты[i].Номер_заказа == NumberTicket)
                    {
                        NumberTicketTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                        NumberErrorLabel.Text = "Карта с данным номером заказа уже есть в списке";
                        NumberErrorLabel.Visible = true;
                        return true;
                    }
                }
            }
            NumberErrorLabel.Text = "Введите номер заказа";
            NumberErrorLabel.Visible = false;
            return false;
        }

        private void NumberTicketTextBox_Enter(object sender, EventArgs e)
        {
            NumberTicketTextBox.BorderColor = Color.Black;
            NumberErrorLabel.Visible = false;
        }

        private void WorkshopTextBox_Enter(object sender, EventArgs e)
        {
            WorkshopTextBox.BorderColor = Color.Black;
            WorkshopErrorLabel.Visible = false;
        }

        private void ItemTextBox_Enter(object sender, EventArgs e)
        {
            ItemTextBox.BorderColor = Color.Black;
            ItemErrorLabel.Visible = false;
        }

        private void SelectWorkshopButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectWorkshopInCard = true;

            WorkshopTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            WorkshopErrorLabel.Visible = false;
            
            BrigadeTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            BrigadeErrorLabel.Visible = false;

            WorkshopForm WorkshopForm = new WorkshopForm(this, FlagSelectWorkshopInCard);
            WorkshopForm.ShowDialog();

            WorkshopTextBox.TextName = Workshop;
            BrigadeTextBox.TextName = Brigade;
        }

        private void SelectItemButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectItemInCard = true;

            ItemTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ItemErrorLabel.Visible = false;

            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ModelErrorLabel.Visible = false;

            ItemsForm ItemsForm = new ItemsForm(this, FlagSelectItemInCard);
            ItemsForm.ShowDialog();

            ItemTextBox.TextName = NameItem;
            ModelTextBox.TextName = ModelItem;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
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

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Введите ваш запрос")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.FromArgb(86, 87, 96);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ClothsOrderDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_ткани like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Единица_измерения like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Количество, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.fKТканьдляIDРа0C1BC9F9BindingSource.Filter = Query;
            }
            else
            {
                this.fKТканьдляIDРа0C1BC9F9BindingSource.Filter = "";
            }
            if (SearchTextBox.Text == "")
            {
                this.fKТканьдляIDРа0C1BC9F9BindingSource.Filter = "";
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
