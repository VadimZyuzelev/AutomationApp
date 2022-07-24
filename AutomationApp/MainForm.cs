using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class MainForm : Form 
    {
        private Form CurrentChildForm;
        private readonly AuthenticationForm AuthenticationForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(AuthenticationForm AuthenticationFormTwo)
        {
            InitializeComponent();
            this.AuthenticationForm = AuthenticationFormTwo;      
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void OpenSubMenu(Panel SubMenuPanel)
        {
            if (SubMenuPanel.Visible == false)
            {
                SubMenuPanel.Visible = true;
            }
            else
            {
                SubMenuPanel.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenMenuUser(AuthenticationForm.Login);
        }

        private void OpenMenuUser(string User)
        {
            if (User == "CutPicker")
            {              
                MenuCutPcikerUser.Dock = DockStyle.Fill;
                MenuPanel.Controls.Add(MenuCutPcikerUser);
                MenuPanel.Tag = MenuCutPcikerUser;
                MenuCutPcikerUser.BringToFront();
                MenuCutPcikerUser.Show();

                RouteSheetsButton_Click(null, null);
            }
            if (User == "WarehouseFurniture")
            {
                MenuWarehouseFurnitureUser.Dock = DockStyle.Fill;
                MenuPanel.Controls.Add(MenuWarehouseFurnitureUser);
                MenuPanel.Tag = MenuWarehouseFurnitureUser;
                MenuWarehouseFurnitureUser.BringToFront();
                MenuWarehouseFurnitureUser.Show();

                OrdersFurnitureButton_Click(null, null);
            }
            if (User == "WarehouseCloth")
            {                
                MenuWarehouseClothUser.Dock = DockStyle.Fill;
                MenuPanel.Controls.Add(MenuWarehouseClothUser);
                MenuPanel.Tag = MenuWarehouseClothUser;
                MenuWarehouseClothUser.BringToFront();
                MenuWarehouseClothUser.Show();

                OrdersClothButton_Click(null, null);
            }
            if (User == "WarehouseProducts")
            {
                MenuWarehouseProductsUser.Dock = DockStyle.Fill;
                MenuPanel.Controls.Add(MenuWarehouseProductsUser);
                MenuPanel.Tag = MenuWarehouseProductsUser;
                MenuWarehouseProductsUser.BringToFront();
                MenuWarehouseProductsUser.Show();

                RouteSheetsProductsButton_Click(null, null);
            }
        }

        private void OpenChildFormInPanel(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
   
        private void RouteSheetsButton_Click(object sender, EventArgs e)
        {
            RouteSheetsButton.ForeColor = Color.Gainsboro;
            RouteSheetsButton.IconColor = Color.Gainsboro;

            ItemsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ItemsButton.IconColor = Color.FromArgb(126, 142, 180);

            TitleBarLabel.Text = "Маршрутные листы";
            RouteSheetsForm RouteSheetsForm = new RouteSheetsForm();
            OpenChildFormInPanel(RouteSheetsForm);
            
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            ItemsButton.ForeColor = Color.Gainsboro;
            ItemsButton.IconColor = Color.Gainsboro;

            RouteSheetsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsButton.IconColor = Color.FromArgb(126, 142, 180);

            TitleBarLabel.Text = "Изделия";
            ItemsForm ItemsForm = new ItemsForm();
            OpenChildFormInPanel(ItemsForm);
        }

        // При нажатии и задержании левой кнопки мыши форму можно перетаскивать.
        // Создается объект, в который передаются параметры (handle окна и т.д.),
        // с помощью которого и происходит настройка формы для перетаскивания.
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(0, 120, 215);
            ExitButton.IconColor = Color.White;

            Application.Exit();
        }       
        private void OrdersFurnitureButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Приходные ордера";

            OrdersFurnitureButton.ForeColor = Color.Gainsboro;
            OrdersFurnitureButton.IconColor = Color.Gainsboro;

            LimitCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            LimitCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            FurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            OrdersForm OrdersFurnitureForm = new OrdersForm();
            OpenChildFormInPanel(OrdersFurnitureForm);
        }

        private void DocumentationButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Сопроводительная документация";

            RouteSheetsProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DocumentationButton.ForeColor = Color.Gainsboro;
            DocumentationButton.IconColor = Color.Gainsboro;

            WarehouseProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversButton.ForeColor = Color.FromArgb(126, 142, 180);
            DriversButton.IconColor = Color.FromArgb(126, 142, 180);

            AutoButton.ForeColor = Color.FromArgb(126, 142, 180);
            AutoButton.IconColor = Color.FromArgb(126, 142, 180);

            ContractorsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ContractorsButton.IconColor = Color.FromArgb(126, 142, 180);

            OpenSubMenu(SubMenuDocumentationsPanel);

        }

        private void LimitCardsButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Лимитно-заборные карты";

            OrdersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsButton.ForeColor = Color.Gainsboro;
            LimitCardsButton.IconColor = Color.Gainsboro;

            WarehouseFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            FurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsForm LimitCardsForm = new LimitCardsForm();
            OpenChildFormInPanel(LimitCardsForm);
        }

        private void WarehouseFurnitureButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Склад фурнитуры";

            OrdersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            LimitCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureButton.ForeColor = Color.Gainsboro;
            WarehouseFurnitureButton.IconColor = Color.Gainsboro;

            ProvidersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            FurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureForm WarehouseFurnitureForm = new WarehouseFurnitureForm();
            OpenChildFormInPanel(WarehouseFurnitureForm);
        }

        private void ProvidersFurnitureButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Поставщики";

            OrdersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            LimitCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersFurnitureButton.ForeColor = Color.Gainsboro;
            ProvidersFurnitureButton.IconColor = Color.Gainsboro;

            FurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            FurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersForm ProvidersForm = new ProvidersForm();
            OpenChildFormInPanel(ProvidersForm);
        }

        private void MaximizedButton_Click(object sender, EventArgs e)
        {
            MaximizedButton.ForeColor = Color.FromArgb(0, 120, 215);
            MaximizedButton.IconColor = Color.White;

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void FurnitureButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Данные о фурнитуре";

            OrdersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            LimitCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureButton.ForeColor = Color.Gainsboro;
            FurnitureButton.IconColor = Color.Gainsboro;

            SectionFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureForm FurnitureForm = new FurnitureForm();
            OpenChildFormInPanel(FurnitureForm);
        }

        private void SectionFurnitureButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Цеха";

            OrdersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            LimitCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            LimitCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersFurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersFurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            FurnitureButton.ForeColor = Color.FromArgb(126, 142, 180);
            FurnitureButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionFurnitureButton.ForeColor = Color.Gainsboro;
            SectionFurnitureButton.IconColor = Color.Gainsboro;

            WorkshopForm WorkshopForm = new WorkshopForm();
            OpenChildFormInPanel(WorkshopForm);
        }

        private void ClothsButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Ткани";

            OrdersClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersClothButton.IconColor = Color.FromArgb(126, 142, 180);

            CalcutationCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            CalcutationCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseClothButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsButton.ForeColor = Color.Gainsboro;
            ClothsButton.IconColor = Color.Gainsboro;

            SectionClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsForm ClothsForm = new ClothsForm();
            OpenChildFormInPanel(ClothsForm);
        }

        private void OrdersClothButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Приходные ордера";

            OrdersClothButton.ForeColor = Color.Gainsboro;
            OrdersClothButton.IconColor = Color.Gainsboro;

            CalcutationCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            CalcutationCardsButton.IconColor = Color.FromArgb(126, 142, 180);
            
            WarehouseClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseClothButton.IconColor = Color.FromArgb(126, 142, 180);
            
            ProvidersProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothOrdersForm ClothOrdersForm = new ClothOrdersForm();
            OpenChildFormInPanel(ClothOrdersForm);
        }

        private void CalcutationCardsButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Расчётные карты";

            OrdersClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersClothButton.IconColor = Color.FromArgb(126, 142, 180);

            CalcutationCardsButton.ForeColor = Color.Gainsboro;
            CalcutationCardsButton.IconColor = Color.Gainsboro;

            WarehouseClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseClothButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            CalculationCardsForm CalculationCardsForm = new CalculationCardsForm();
            OpenChildFormInPanel(CalculationCardsForm);
        }

        private void ProvidersProductsButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Поставщики";

            OrdersClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersClothButton.IconColor = Color.FromArgb(126, 142, 180);

            CalcutationCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            CalcutationCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseClothButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersProductsButton.ForeColor = Color.Gainsboro;
            ProvidersProductsButton.IconColor = Color.Gainsboro;

            ClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersForm ProvidersForm = new ProvidersForm();
            OpenChildFormInPanel(ProvidersForm);
        }

        private void SectionClothsButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Цеха";

            OrdersClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersClothButton.IconColor = Color.FromArgb(126, 142, 180);

            CalcutationCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            CalcutationCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseClothButton.IconColor = Color.FromArgb(126, 142, 180);

            ProvidersProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionClothsButton.ForeColor = Color.Gainsboro;
            SectionClothsButton.IconColor = Color.Gainsboro;

            WorkshopForm WorkshopForm = new WorkshopForm();
            OpenChildFormInPanel(WorkshopForm);
        }

        private void WarehouseClothButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Склад ткани";

            OrdersClothButton.ForeColor = Color.FromArgb(126, 142, 180);
            OrdersClothButton.IconColor = Color.FromArgb(126, 142, 180);

            CalcutationCardsButton.ForeColor = Color.FromArgb(126, 142, 180);
            CalcutationCardsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseClothButton.ForeColor = Color.Gainsboro;
            WarehouseClothButton.IconColor = Color.Gainsboro;

            ProvidersProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ProvidersProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            ClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            SectionClothsButton.ForeColor = Color.FromArgb(126, 142, 180);
            SectionClothsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseClothsForm warehouse = new WarehouseClothsForm();
            OpenChildFormInPanel(warehouse);
        }

        private void WarehouseProductsButton_Click(object sender, EventArgs e)
        {
            if (SubMenuDocumentationsPanel.Visible == true)
            {
                SubMenuDocumentationsPanel.Visible = false;
            }

            TitleBarLabel.Text = "Склад продукции";

            RouteSheetsProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DocumentationButton.ForeColor = Color.FromArgb(126, 142, 180);
            DocumentationButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsButton.ForeColor = Color.Gainsboro;
            WarehouseProductsButton.IconColor = Color.Gainsboro;

            DriversButton.ForeColor = Color.FromArgb(126, 142, 180);
            DriversButton.IconColor = Color.FromArgb(126, 142, 180);

            AutoButton.ForeColor = Color.FromArgb(126, 142, 180);
            AutoButton.IconColor = Color.FromArgb(126, 142, 180);

            ContractorsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ContractorsButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsForm warehouse = new WarehouseProductsForm();
            OpenChildFormInPanel(warehouse);
        }

        private void RouteSheetsProductsButton_Click(object sender, EventArgs e)
        {
            if (SubMenuDocumentationsPanel.Visible == true)
            {
                SubMenuDocumentationsPanel.Visible = false;
            }

            TitleBarLabel.Text = "Принятые изделия";

            RouteSheetsProductsButton.ForeColor = Color.Gainsboro;
            RouteSheetsProductsButton.IconColor = Color.Gainsboro;

            DocumentationButton.ForeColor = Color.FromArgb(126, 142, 180);
            DocumentationButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversButton.ForeColor = Color.FromArgb(126, 142, 180);
            DriversButton.IconColor = Color.FromArgb(126, 142, 180);

            AutoButton.ForeColor = Color.FromArgb(126, 142, 180);
            AutoButton.IconColor = Color.FromArgb(126, 142, 180);

            ContractorsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ContractorsButton.IconColor = Color.FromArgb(126, 142, 180);

            ReceivedItemsForm ReceivedItemsForm = new ReceivedItemsForm();
            OpenChildFormInPanel(ReceivedItemsForm);
        }

        private void ProductNotesButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Товарные накладные";

            TradeNoteForm TradeNoteForm = new TradeNoteForm();
            OpenChildFormInPanel(TradeNoteForm);
        }

        private void ProductTransportNotesButton_Click(object sender, EventArgs e)
        {
            TitleBarLabel.Text = "Товарно-транспортные накладные";

            TradeTransportNoteForm tradeTransportNoteForm = new TradeTransportNoteForm();
            OpenChildFormInPanel(tradeTransportNoteForm);
        }

        private void DriversButton_Click(object sender, EventArgs e)
        {
            if (SubMenuDocumentationsPanel.Visible == true)
            {
                SubMenuDocumentationsPanel.Visible = false;
            }

            TitleBarLabel.Text = "Водители";

            RouteSheetsProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DocumentationButton.ForeColor = Color.FromArgb(126, 142, 180);
            DocumentationButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversButton.ForeColor = Color.Gainsboro;
            DriversButton.IconColor = Color.Gainsboro;

            AutoButton.ForeColor = Color.FromArgb(126, 142, 180);
            AutoButton.IconColor = Color.FromArgb(126, 142, 180);

            ContractorsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ContractorsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversForm DriversForm = new DriversForm();
            OpenChildFormInPanel(DriversForm);
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            if (SubMenuDocumentationsPanel.Visible == true)
            {
                SubMenuDocumentationsPanel.Visible = false;
            }

            TitleBarLabel.Text = "Автомобили";

            RouteSheetsProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DocumentationButton.ForeColor = Color.FromArgb(126, 142, 180);
            DocumentationButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversButton.ForeColor = Color.FromArgb(126, 142, 180);
            DriversButton.IconColor = Color.FromArgb(126, 142, 180);

            AutoButton.ForeColor = Color.Gainsboro;
            AutoButton.IconColor = Color.Gainsboro;

            ContractorsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ContractorsButton.IconColor = Color.FromArgb(126, 142, 180);

            CarsForm CarsForm = new CarsForm();
            OpenChildFormInPanel(CarsForm);
        }

        private void ContractorsButton_Click_1(object sender, EventArgs e)
        {
            if (SubMenuDocumentationsPanel.Visible == true)
            {
                SubMenuDocumentationsPanel.Visible = false;
            }

            TitleBarLabel.Text = "Контрагенты";

            RouteSheetsProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DocumentationButton.ForeColor = Color.FromArgb(126, 142, 180);
            DocumentationButton.IconColor = Color.FromArgb(126, 142, 180);

            WarehouseProductsButton.ForeColor = Color.FromArgb(126, 142, 180);
            WarehouseProductsButton.IconColor = Color.FromArgb(126, 142, 180);

            DriversButton.ForeColor = Color.FromArgb(126, 142, 180);
            DriversButton.IconColor = Color.FromArgb(126, 142, 180);

            AutoButton.ForeColor = Color.FromArgb(126, 142, 180);
            AutoButton.IconColor = Color.FromArgb(126, 142, 180);

            ContractorsButton.ForeColor = Color.Gainsboro;
            ContractorsButton.IconColor = Color.Gainsboro;

            CounteragentsForm CounteragentsForm = new CounteragentsForm();
            OpenChildFormInPanel(CounteragentsForm);
        }

        private void ItemsButton_Leave(object sender, EventArgs e)
        {
            ItemsButton.ForeColor = Color.FromArgb(126, 142, 180);
            ItemsButton.IconColor = Color.FromArgb(126, 142, 180);
        }

        private void RouteSheetsButton_Leave(object sender, EventArgs e)
        {
            RouteSheetsButton.ForeColor = Color.FromArgb(126, 142, 180);
            RouteSheetsButton.IconColor = Color.FromArgb(126, 142, 180);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            HideButton.ForeColor = Color.Blue;
            HideButton.IconColor = Color.White;

            WindowState = FormWindowState.Minimized;            
        }

        private void HideButton_MouseDown(object sender, MouseEventArgs e)
        {
            HideButton.IconColor = Color.White;
        }

        private void HideButton_MouseUp(object sender, MouseEventArgs e)
        {
            HideButton.IconColor = Color.Gray;
        }

        private void MaximizedButton_MouseDown(object sender, MouseEventArgs e)
        {
            MaximizedButton.IconColor = Color.White;
        }

        private void MaximizedButton_MouseUp(object sender, MouseEventArgs e)
        {
            MaximizedButton.IconColor = Color.Gray;
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
