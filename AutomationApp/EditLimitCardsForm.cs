using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditLimitCardsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly LimitCardsForm LimitCardsForm;
        private readonly bool FlagEdit;

        private int ID_LimitCard;

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


        public EditLimitCardsForm()
        {
            InitializeComponent();
        }       
        
        public EditLimitCardsForm(LimitCardsForm limitCardsForm)
        {
            InitializeComponent();
            this.LimitCardsForm = limitCardsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditLimitCardsForm(LimitCardsForm limitCardsForm, bool flagEdit)
        {
            InitializeComponent();
            this.LimitCardsForm = limitCardsForm;
            this.FlagEdit = flagEdit;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditLimitCardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Лимитно_заборные_карты". При необходимости она может быть перемещена или удалена.
            this.лимитно_заборные_картыTableAdapter.Fill(this.automationAppDBDataSet.Лимитно_заборные_карты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте". При необходимости она может быть перемещена или удалена.
            this.фурнитура_по_лимитно_заборной_картеTableAdapter.Fill(this.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);     
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_изделия". При необходимости она может быть перемещена или удалена.
            this.модели_изделияTableAdapter.Fill(this.automationAppDBDataSet.Модели_изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.automationAppDBDataSet.Изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.automationAppDBDataSet.Бригады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Цеха". При необходимости она может быть перемещена или удалена.
            this.цехаTableAdapter.Fill(this.automationAppDBDataSet.Цеха);                

            if (FlagEdit)
            {
                ID_LimitCard = Convert.ToInt32(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["ID_Лимитно_заборной_карты"]);

                DateTimePicker.Value = Convert.ToDateTime(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Дата_составления"]);
                CountItemsTextBox.TextName = Convert.ToString(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Количество_изделий"]);
                ID_Brigade = Convert.ToInt32(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["ID_Бригады"]);
                ID_Model = Convert.ToInt32(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["ID_Модели_изделия"]);
                WorkshopTextBox.TextName = Convert.ToString(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Цех"]);
                BrigadeTextBox.TextName = Convert.ToString(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Бригада"]);
                ItemTextBox.TextName = Convert.ToString(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Изделие"]);
                ModelTextBox.TextName = Convert.ToString(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["Модель_изделия"]);

                fKФурнитураIDЛи13BCEBC1BindingSource.DataSource = LimitCardsForm.лимитнозаборныекартыBindingSource;

                FurnitureDataGridView.Enabled = false;
                AddFurnitureButton.BackColor = Color.FromArgb(226, 226, 226);
                AddFurnitureButton.Enabled = false;

                TopLabel.Text = "Редактирование лимитно-заборной карты";
                TopIcon.IconChar = IconChar.Pen;              
            }
            else
            { 
                FurnitureDataGridView.DataSource = null;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditFurnitureInCardsForm editFurniture = new EditFurnitureInCardsForm(this, LimitCardsForm);
            editFurniture.ShowDialog();
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            if (!FlagEdit)
            {
                int RowCount;
                RowCount = FurnitureDataGridView.RowCount;

                if (RowCount == 0)
                {
                    LimitCardsForm.лимитнозаборныекартыBindingSource.RemoveCurrent();
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Update(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                }
                else
                {
                    for (int i = 0; i <= RowCount - 1; i++)
                    {
                        LimitCardsForm.fKФурнитураIDЛи13BCEBC1BindingSource.RemoveCurrent();
                        LimitCardsForm.fKФурнитураIDЛи13BCEBC1BindingSource.MoveNext();
                        //RowCount = MaterialsOrderFurnitureDataGridView.RowCount;
                    }

                    LimitCardsForm.фурнитура_по_лимитно_заборной_картеTableAdapter.Update(LimitCardsForm.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);
                    LimitCardsForm.фурнитура_по_лимитно_заборной_картеTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Фурнитура_по_лимитно_заборной_карте);

                    LimitCardsForm.лимитнозаборныекартыBindingSource.RemoveCurrent();
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Update(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (FurnitureDataGridView.Rows.Count == 0)
                {
                    FurnitureLabelError.Visible = true;
                }
                else
                {
                    UpdateData();

                    WorkshopTextBox.TextName = "";
                    ItemTextBox.TextName = "";
                    CountItemsTextBox.TextName = "";
                    BrigadeTextBox.TextName = "";
                    ModelTextBox.TextName = "";

                    FurnitureDataGridView.DataSource = null;
                }
            }
            else
            {
                if (FurnitureDataGridView.Rows.Count == 0)
                {
                    FurnitureLabelError.Visible = true;
                }
            }
        }

        private void AddFurnitureButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                if (FurnitureDataGridView.Rows.Count == 0)
                {
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Insert(ID_Brigade, ID_Model, DateTimePicker.Value, Convert.ToInt32(CountItemsTextBox.TextName));
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);

                    FurnitureDataGridView.DataSource = LimitCardsForm.fKФурнитураIDЛи13BCEBC1BindingSource;

                    LimitCardsForm.лимитнозаборныекартыBindingSource.MoveLast();
                    ID_LimitCard = Convert.ToInt32(((DataRowView)LimitCardsForm.лимитнозаборныекартыBindingSource.Current).Row["ID_Лимитно_заборной_карты"]);
                }

                FurnitureLabelError.Visible = false;
                EditFurnitureInCardsForm editFurniture = new EditFurnitureInCardsForm(this, LimitCardsForm);
                editFurniture.ShowDialog();

                if (FurnitureDataGridView.Rows.Count == 0)
                {
                    LimitCardsForm.лимитнозаборныекартыBindingSource.RemoveCurrent();
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Update(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                }

            }
        }

        private void UpdateData()
        {          
            int CountCards = LimitCardsForm.лимитнозаборныекартыBindingSource.Count;

            for (int i = 0; i < CountCards; i++)
            {
                if (LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты[i].ID_Лимитно_заборной_карты == ID_LimitCard)
                {
                    LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты[i].Количество_изделий = Convert.ToInt32(CountItemsTextBox.TextName);
                    LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты[i].ID_Бригады = ID_Brigade;
                    LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты[i].ID_Модели_изделия = ID_Model;

                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Update(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                    LimitCardsForm.лимитно_заборные_картыTableAdapter.Fill(LimitCardsForm.automationAppDBDataSet.Лимитно_заборные_карты);
                }
            }
           
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (CountItemsTextBox.TextName == "")
            {
                CountItemsTextBox.BorderColor = Color.FromArgb(255, 128, 128);
                CountErrorLabel.Visible = true;
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

        private void SelectWorkshopButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectWorkshopInLimitCard = true;

            WorkshopTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            WorkshopErrorLabel.Visible = false;

            BrigadeTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            BrigadeErrorLabel.Visible = false;

            WorkshopForm WorkshopForm = new WorkshopForm(this, FlagSelectWorkshopInLimitCard);
            WorkshopForm.ShowDialog();

            WorkshopTextBox.TextName = Workshop;
            BrigadeTextBox.TextName = Brigade;
        }

        private void SelectItemButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectItemInLimitCard = true;

            ItemTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ItemErrorLabel.Visible = false;

            ModelTextBox.BorderColor = Color.FromArgb(222, 223, 226);
            ModelErrorLabel.Visible = false;

            ItemsForm ItemsForm = new ItemsForm(this, FlagSelectItemInLimitCard);
            ItemsForm.ShowDialog();

            ItemTextBox.TextName = NameItem;
            ModelTextBox.TextName = ModelItem;
        }

        private void CountItemsTextBox_Enter(object sender, EventArgs e)
        {
            CountItemsTextBox.BorderColor = Color.Black;
            CountErrorLabel.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование_фурнитуры like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Единица_измерения like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Норма_на_единицу_изделия, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Количество, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Цена, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.fKФурнитураIDЛи13BCEBC1BindingSource.Filter = Query;
            }
            else
            {
                this.fKФурнитураIDЛи13BCEBC1BindingSource.Filter = "";
            }
            if (SearchTextBox.Text == "")
            {
                this.fKФурнитураIDЛи13BCEBC1BindingSource.Filter = "";
            }
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Введите ваш запрос")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.FromArgb(86, 87, 96);
            }
        }
    }
}
