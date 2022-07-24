using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AutomationApp
{
    public partial class EditRouteSheetsForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly RouteSheetsForm RouteSheetsForm;
        private readonly bool FlagEdit;

        private int NumberTicket;
        private int ID_RouteSheet;

        private string nameItem;
        private string modelItem;
        private int id_Item;
        private int id_Model;
        private int Growth;
        private int ModelSize;
        private int Fullness;
        private int ModelColor;

        public int ID_Item
        {
            get
            {
                return id_Item;
            }

            set
            {
                id_Item = value;
            }
        }

        public int ID_Model
        {
            get
            {
                return id_Model;
            }

            set
            {
                id_Model = value;
            }
        }

        public string NameItem
        {
            get
            {
                return nameItem;
            }

            set
            {
                nameItem = value;
            }

        }

        public string ModelItem
        {
            get
            {
                return modelItem;
            }

            set
            {
                modelItem = value;
            }

        }

        public EditRouteSheetsForm()
        {
            InitializeComponent();            
        }

        public EditRouteSheetsForm(RouteSheetsForm routesheetsFormTwo)
        {
            InitializeComponent();
            this.RouteSheetsForm = routesheetsFormTwo;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public EditRouteSheetsForm(RouteSheetsForm routesheetsFormTwo, bool FlagEditTwo)
        {
            InitializeComponent();           
            this.RouteSheetsForm = routesheetsFormTwo;
            FlagEdit = FlagEditTwo;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
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

        private void EditRouteSheetsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.automationAppDBDataSet.Изделия);
            this.модели_изделияTableAdapter.Fill(this.automationAppDBDataSet.Модели_изделия);

            if (FlagEdit)
            {
                SetData();
                LabelForm.Text = "Редактирование маршрутного листа";
                IconPictureBox.IconChar = IconChar.Pen;
            }
        }

        private void SaveSheetButton_Click(object sender, EventArgs e)
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

        private void SetData()
        {
            ID_RouteSheet = Convert.ToInt32(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["ID_Маршрутного_листа"]);
            ID_Model = Convert.ToInt32(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["ID_Модели_изделия"]);
            NumberTicket = Convert.ToInt32(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Номер_заказа"]);

            NumberTicketTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Номер_заказа"]);
            ItemTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Наименование"]);
            ModelTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Модель_изделия"]);
            GrowthTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Рост"]);
            SizeTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Размер"]);
            FullnessTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Полнота"]);
            ColorTextBox.Text = Convert.ToString(((DataRowView)RouteSheetsForm.маршрутныелистыBindingSource.Current).Row["Код_цвета"]);
        }

        private void InsertData()
        {
            if (!CheckEmptyData())
            {
                NumberTicket = Convert.ToInt32(NumberTicketTextBox.Text);
                Growth = Convert.ToInt32(GrowthTextBox.Text);
                ModelSize = Convert.ToInt32(SizeTextBox.Text);
                Fullness = Convert.ToInt32(FullnessTextBox.Text);
                ModelColor = Convert.ToInt32(ColorTextBox.Text);

                if (!CheckRepeatData())
                {
                    RouteSheetsForm.маршрутные_листыTableAdapter.Insert(ID_Model, NumberTicket, Growth, ModelSize, Fullness, ModelColor);
                    RouteSheetsForm.маршрутные_листыTableAdapter.Fill(RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы);
                }
            }
        }

        private void UpdateData()
        {
            if (!CheckEmptyData())
            {
                if (!CheckRepeatData())
                {
                    int countSheets = RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы.Count;
                    for (int i = 0; i < countSheets; i++)
                    {
                        if (RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].ID_Маршрутного_листа == ID_RouteSheet)
                        {
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Номер_заказа = Convert.ToInt32(NumberTicketTextBox.Text);
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].ID_Модели_изделия = ID_Model;
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Рост = Convert.ToInt32(GrowthTextBox.Text);
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Размер = Convert.ToInt32(SizeTextBox.Text);
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Полнота = Convert.ToInt32(FullnessTextBox.Text);
                            RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Код_цвета = Convert.ToInt32(ColorTextBox.Text);
                        }
                    }
                    RouteSheetsForm.маршрутные_листыTableAdapter.Update(RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы);
                    RouteSheetsForm.маршрутные_листыTableAdapter.Fill(RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы);
                }
            }
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (NumberTicketTextBox.Text == "" || Convert.ToInt32(NumberTicketTextBox.Text) == 0 || Convert.ToInt32(NumberTicketTextBox.Text) < 0)
            {
                NumberBorder.BorderColor = Color.FromArgb(255, 128, 128);
                NumberLabel.Visible = true;
                FlagEmpty = true;
            }

            if (ItemTextBox.Text == "")
            {
                ItemBorder.BorderColor = Color.FromArgb(255, 128, 128);
                ItemLabel.Visible = true;
                FlagEmpty = true;
            }

            if (ModelTextBox.Text == "")
            {
                ModelBorder.BorderColor = Color.FromArgb(255, 128, 128);
                ModelLabel.Visible = true;
                FlagEmpty = true;
            }

            if (GrowthTextBox.Text == "" || Convert.ToInt32(GrowthTextBox.Text) == 0 || Convert.ToInt32(GrowthTextBox.Text) < 0 || Convert.ToInt32(GrowthTextBox.Text) > 250)
            {
                GrowthBorder.BorderColor = Color.FromArgb(255, 128, 128);
                GrowthLabel.Visible = true;
                FlagEmpty = true;
            }

            if (SizeTextBox.Text == "" || Convert.ToInt32(SizeTextBox.Text) == 0 || Convert.ToInt32(SizeTextBox.Text) < 0 || Convert.ToInt32(SizeTextBox.Text) > 200)
            {
                SizeBorder.BorderColor = Color.FromArgb(255, 128, 128);
                SizeLabel.Visible = true;
                FlagEmpty = true;
            }

            if (FullnessTextBox.Text == "" || Convert.ToInt32(FullnessTextBox.Text) == 0 || Convert.ToInt32(FullnessTextBox.Text) < 0 || Convert.ToInt32(FullnessTextBox.Text) > 200)
            {
                FullnessBorder.BorderColor = Color.FromArgb(255, 128, 128);
                FullnessLabel.Visible = true;
                FlagEmpty = true;
            }

            if (ColorTextBox.Text == "" || Convert.ToInt32(ColorTextBox.Text) == 0 || Convert.ToInt32(ColorTextBox.Text) < 0)
            {
                ColorBorder.BorderColor = Color.FromArgb(255, 128, 128);
                ColorLabel.Visible = true;
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
            int countSheets = RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы.Count;

            if (countSheets != 0)
            {
                for (int i = 0; i < countSheets; i++)
                {
                    if (FlagEdit)
                    {
                        NumberTicket = Convert.ToInt32(NumberTicketTextBox.Text);
                       
                        if (RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].ID_Маршрутного_листа != ID_RouteSheet)
                        {
                            if (RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Номер_заказа == NumberTicket)
                            {
                                NumberBorder.BorderColor = Color.FromArgb(255, 128, 128);
                                NumberLabel.Text = "Данный номер заказа уже есть в списке";
                                NumberLabel.Visible = true;
                                return true;
                            }
                        }
                    }
                    else
                    { 
                        if(RouteSheetsForm.automationAppDBDataSet.Маршрутные_листы[i].Номер_заказа == NumberTicket)
                        {
                            NumberBorder.BorderColor = Color.FromArgb(255, 128, 128);
                            NumberLabel.Text = "Данный номер заказа уже есть в списке";
                            NumberLabel.Visible = true;
                            return true;
                        }
                    }
                }
            }
            NumberLabel.Text = "Введите номер заказа";
            return false;
        }

        private void NumberTicketTextBox_Enter(object sender, EventArgs e)
        {
            NumberBorder.BorderColor = Color.Black;
            NumberLabel.Visible = false;
        }

        private void NumberTicketTextBox_Leave(object sender, EventArgs e)
        {
            NumberBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void GrowthComboBox_Enter(object sender, EventArgs e)
        {
            GrowthBorder.BorderColor = Color.Black;
            GrowthLabel.Visible = false;
        }

        private void GrowthComboBox_Leave(object sender, EventArgs e)
        {
            GrowthBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void SizeComboBox_Enter(object sender, EventArgs e)
        {
            SizeBorder.BorderColor = Color.Black;
            SizeLabel.Visible = false;
        }

        private void SizeComboBox_Leave(object sender, EventArgs e)
        {
            SizeBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void FullnessComboBox_Enter(object sender, EventArgs e)
        {
            FullnessBorder.BorderColor = Color.Black;
            FullnessLabel.Visible = false;
        }

        private void FullnessComboBox_Leave(object sender, EventArgs e)
        {
            FullnessBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void ColorComboBox_Enter(object sender, EventArgs e)
        {
            ColorBorder.BorderColor = Color.Black;
            ColorLabel.Visible = false;
        }

        private void ColorComboBox_Leave(object sender, EventArgs e)
        {
            ColorBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void SelectItemButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectItemsInRouteSheet = true;

            ItemBorder.BorderColor = Color.FromArgb(222, 223, 226);
            ModelBorder.BorderColor = Color.FromArgb(222, 223, 226);

            ItemLabel.Visible = false;
            ModelLabel.Visible = false;

            ItemsForm ItemsForm = new ItemsForm(this, FlagSelectItemsInRouteSheet);
            ItemsForm.ShowDialog();

            ItemTextBox.Text = NameItem;
            ModelTextBox.Text = ModelItem;
        }

        private void GrowthTextBox_Enter(object sender, EventArgs e)
        {
            GrowthBorder.BorderColor = Color.Black;
            GrowthLabel.Visible = false;
        }

        private void GrowthTextBox_Leave(object sender, EventArgs e)
        {
            GrowthBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void SizeTextBox_Enter(object sender, EventArgs e)
        {
            SizeBorder.BorderColor = Color.Black;
            SizeLabel.Visible = false;
        }

        private void SizeTextBox_Leave(object sender, EventArgs e)
        {
            SizeBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void FullnessTextBox_Enter(object sender, EventArgs e)
        {
            FullnessBorder.BorderColor = Color.Black;
            FullnessLabel.Visible = false;
        }

        private void FullnessTextBox_Leave(object sender, EventArgs e)
        {
            FullnessBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }

        private void ColorTextBox_Enter(object sender, EventArgs e)
        {
            ColorBorder.BorderColor = Color.Black;
            ColorLabel.Visible = false;
        }

        private void ColorTextBox_Leave(object sender, EventArgs e)
        {
            ColorBorder.BorderColor = Color.FromArgb(222, 223, 226);
        }
    }
}
