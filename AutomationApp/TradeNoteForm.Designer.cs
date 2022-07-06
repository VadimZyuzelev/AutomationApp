
namespace AutomationApp
{
    partial class TradeNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.товарныенакладныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductsTradeNoteDataGridView = new System.Windows.Forms.DataGridView();
            this.iDТоварногоразделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьпродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегосНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKТоварныйIDТо1B29035FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CounteragentsNoteDataGridView = new System.Windows.Forms.DataGridView();
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКонтрагентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKКонтрагенIDТо4CF5691DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TradeNoteDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddTradeNoteButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.контрагентытоварнойнакладнойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарные_накладныеTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter();
            this.товарный_раздел_товарной_накладнойTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Товарный_раздел_товарной_накладнойTableAdapter();
            this.контрагенты_товарной_накладнойTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Контрагенты_товарной_накладнойTableAdapter();
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.товарныенакладныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTradeNoteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварныйIDТо1B29035FBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounteragentsNoteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКонтрагенIDТо4CF5691DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeNoteDataGridView)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентытоварнойнакладнойBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // товарныенакладныеBindingSource
            // 
            this.товарныенакладныеBindingSource.DataMember = "Товарные_накладные";
            this.товарныенакладныеBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.TitleFoodPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1130, 641);
            this.MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductsTradeNoteDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 236);
            this.panel2.TabIndex = 76;
            // 
            // ProductsTradeNoteDataGridView
            // 
            this.ProductsTradeNoteDataGridView.AllowUserToAddRows = false;
            this.ProductsTradeNoteDataGridView.AllowUserToDeleteRows = false;
            this.ProductsTradeNoteDataGridView.AutoGenerateColumns = false;
            this.ProductsTradeNoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsTradeNoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTradeNoteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТоварногоразделаDataGridViewTextBoxColumn,
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1,
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.стоимостьпродукцииDataGridViewTextBoxColumn,
            this.ставкаНДСDataGridViewTextBoxColumn,
            this.суммаНДСDataGridViewTextBoxColumn,
            this.всегосНДСDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn});
            this.ProductsTradeNoteDataGridView.DataSource = this.fKТоварныйIDТо1B29035FBindingSource;
            this.ProductsTradeNoteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTradeNoteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductsTradeNoteDataGridView.Name = "ProductsTradeNoteDataGridView";
            this.ProductsTradeNoteDataGridView.ReadOnly = true;
            this.ProductsTradeNoteDataGridView.RowHeadersVisible = false;
            this.ProductsTradeNoteDataGridView.Size = new System.Drawing.Size(1130, 236);
            this.ProductsTradeNoteDataGridView.TabIndex = 72;
            // 
            // iDТоварногоразделаDataGridViewTextBoxColumn
            // 
            this.iDТоварногоразделаDataGridViewTextBoxColumn.DataPropertyName = "ID_Товарного_раздела";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.HeaderText = "ID_Товарного_раздела";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.Name = "iDТоварногоразделаDataGridViewTextBoxColumn";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDТоварнойнакладнойDataGridViewTextBoxColumn1
            // 
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1.DataPropertyName = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1.HeaderText = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1.Name = "iDТоварнойнакладнойDataGridViewTextBoxColumn1";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDГотовойпродукциинаскладеDataGridViewTextBoxColumn
            // 
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.Name = "iDГотовойпродукциинаскладеDataGridViewTextBoxColumn";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьпродукцииDataGridViewTextBoxColumn
            // 
            this.стоимостьпродукцииDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_продукции";
            this.стоимостьпродукцииDataGridViewTextBoxColumn.HeaderText = "Стоимость_продукции";
            this.стоимостьпродукцииDataGridViewTextBoxColumn.Name = "стоимостьпродукцииDataGridViewTextBoxColumn";
            this.стоимостьпродукцииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ставкаНДСDataGridViewTextBoxColumn
            // 
            this.ставкаНДСDataGridViewTextBoxColumn.DataPropertyName = "Ставка_НДС";
            this.ставкаНДСDataGridViewTextBoxColumn.HeaderText = "Ставка_НДС";
            this.ставкаНДСDataGridViewTextBoxColumn.Name = "ставкаНДСDataGridViewTextBoxColumn";
            this.ставкаНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаНДСDataGridViewTextBoxColumn
            // 
            this.суммаНДСDataGridViewTextBoxColumn.DataPropertyName = "Сумма_НДС";
            this.суммаНДСDataGridViewTextBoxColumn.HeaderText = "Сумма_НДС";
            this.суммаНДСDataGridViewTextBoxColumn.Name = "суммаНДСDataGridViewTextBoxColumn";
            this.суммаНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // всегосНДСDataGridViewTextBoxColumn
            // 
            this.всегосНДСDataGridViewTextBoxColumn.DataPropertyName = "Всего_с_НДС";
            this.всегосНДСDataGridViewTextBoxColumn.HeaderText = "Всего_с_НДС";
            this.всегосНДСDataGridViewTextBoxColumn.Name = "всегосНДСDataGridViewTextBoxColumn";
            this.всегосНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материальныеценностиDataGridViewTextBoxColumn
            // 
            this.материальныеценностиDataGridViewTextBoxColumn.DataPropertyName = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.HeaderText = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.Name = "материальныеценностиDataGridViewTextBoxColumn";
            this.материальныеценностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKТоварныйIDТо1B29035FBindingSource
            // 
            this.fKТоварныйIDТо1B29035FBindingSource.DataMember = "FK__Товарный___ID_То__1B29035F";
            this.fKТоварныйIDТо1B29035FBindingSource.DataSource = this.товарныенакладныеBindingSource;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FooterPanel.Location = new System.Drawing.Point(0, 381);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1130, 24);
            this.FooterPanel.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CounteragentsNoteDataGridView);
            this.panel1.Controls.Add(this.TradeNoteDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 314);
            this.panel1.TabIndex = 74;
            // 
            // CounteragentsNoteDataGridView
            // 
            this.CounteragentsNoteDataGridView.AllowUserToAddRows = false;
            this.CounteragentsNoteDataGridView.AllowUserToDeleteRows = false;
            this.CounteragentsNoteDataGridView.AutoGenerateColumns = false;
            this.CounteragentsNoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CounteragentsNoteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CounteragentsNoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounteragentsNoteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn,
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2,
            this.iDКонтрагентаDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.уНПDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.CounteragentsNoteDataGridView.DataSource = this.fKКонтрагенIDТо4CF5691DBindingSource;
            this.CounteragentsNoteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounteragentsNoteDataGridView.Enabled = false;
            this.CounteragentsNoteDataGridView.Location = new System.Drawing.Point(537, 0);
            this.CounteragentsNoteDataGridView.Name = "CounteragentsNoteDataGridView";
            this.CounteragentsNoteDataGridView.ReadOnly = true;
            this.CounteragentsNoteDataGridView.RowHeadersVisible = false;
            this.CounteragentsNoteDataGridView.Size = new System.Drawing.Size(593, 314);
            this.CounteragentsNoteDataGridView.TabIndex = 74;
            // 
            // iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn
            // 
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn.DataPropertyName = "ID_Контрагента_товарной_накладной";
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn.HeaderText = "ID_Контрагента_товарной_накладной";
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn.Name = "iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn";
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDТоварнойнакладнойDataGridViewTextBoxColumn2
            // 
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2.DataPropertyName = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2.HeaderText = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2.Name = "iDТоварнойнакладнойDataGridViewTextBoxColumn2";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn2.Visible = false;
            // 
            // iDКонтрагентаDataGridViewTextBoxColumn
            // 
            this.iDКонтрагентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Контрагента";
            this.iDКонтрагентаDataGridViewTextBoxColumn.HeaderText = "ID_Контрагента";
            this.iDКонтрагентаDataGridViewTextBoxColumn.Name = "iDКонтрагентаDataGridViewTextBoxColumn";
            this.iDКонтрагентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКонтрагентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Тип_контрагента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип_контрагента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // уНПDataGridViewTextBoxColumn
            // 
            this.уНПDataGridViewTextBoxColumn.DataPropertyName = "УНП";
            this.уНПDataGridViewTextBoxColumn.HeaderText = "УНП";
            this.уНПDataGridViewTextBoxColumn.Name = "уНПDataGridViewTextBoxColumn";
            this.уНПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fKКонтрагенIDТо4CF5691DBindingSource
            // 
            this.fKКонтрагенIDТо4CF5691DBindingSource.DataMember = "FK__Контраген__ID_То__4CF5691D";
            this.fKКонтрагенIDТо4CF5691DBindingSource.DataSource = this.товарныенакладныеBindingSource;
            // 
            // TradeNoteDataGridView
            // 
            this.TradeNoteDataGridView.AllowUserToAddRows = false;
            this.TradeNoteDataGridView.AllowUserToDeleteRows = false;
            this.TradeNoteDataGridView.AutoGenerateColumns = false;
            this.TradeNoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TradeNoteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TradeNoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TradeNoteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn,
            this.датаотпускаDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.TradeNoteDataGridView.DataSource = this.товарныенакладныеBindingSource;
            this.TradeNoteDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TradeNoteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TradeNoteDataGridView.MultiSelect = false;
            this.TradeNoteDataGridView.Name = "TradeNoteDataGridView";
            this.TradeNoteDataGridView.ReadOnly = true;
            this.TradeNoteDataGridView.RowHeadersVisible = false;
            this.TradeNoteDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TradeNoteDataGridView.Size = new System.Drawing.Size(537, 314);
            this.TradeNoteDataGridView.TabIndex = 70;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddTradeNoteButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1130, 67);
            this.TitleFoodPanel.TabIndex = 19;
            // 
            // AddTradeNoteButton
            // 
            this.AddTradeNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTradeNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddTradeNoteButton.FlatAppearance.BorderSize = 0;
            this.AddTradeNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddTradeNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTradeNoteButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddTradeNoteButton.ForeColor = System.Drawing.Color.White;
            this.AddTradeNoteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddTradeNoteButton.IconColor = System.Drawing.Color.White;
            this.AddTradeNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddTradeNoteButton.IconSize = 16;
            this.AddTradeNoteButton.Location = new System.Drawing.Point(931, 13);
            this.AddTradeNoteButton.Name = "AddTradeNoteButton";
            this.AddTradeNoteButton.Size = new System.Drawing.Size(182, 39);
            this.AddTradeNoteButton.TabIndex = 9;
            this.AddTradeNoteButton.Text = "Добавить накладную";
            this.AddTradeNoteButton.UseVisualStyleBackColor = false;
            this.AddTradeNoteButton.Click += new System.EventHandler(this.AddTradeNoteButton_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchIcon.Enabled = false;
            this.SearchIcon.FlatAppearance.BorderSize = 0;
            this.SearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.SearchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchIcon.IconSize = 30;
            this.SearchIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchIcon.Location = new System.Drawing.Point(0, 0);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SearchIcon.Size = new System.Drawing.Size(61, 67);
            this.SearchIcon.TabIndex = 8;
            this.SearchIcon.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.SearchTextBox.Location = new System.Drawing.Point(67, 22);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(851, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            // 
            // контрагентытоварнойнакладнойBindingSource
            // 
            this.контрагентытоварнойнакладнойBindingSource.DataMember = "Контрагенты_товарной_накладной";
            this.контрагентытоварнойнакладнойBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // товарные_накладныеTableAdapter
            // 
            this.товарные_накладныеTableAdapter.ClearBeforeFill = true;
            // 
            // товарный_раздел_товарной_накладнойTableAdapter
            // 
            this.товарный_раздел_товарной_накладнойTableAdapter.ClearBeforeFill = true;
            // 
            // контрагенты_товарной_накладнойTableAdapter
            // 
            this.контрагенты_товарной_накладнойTableAdapter.ClearBeforeFill = true;
            // 
            // iDТоварнойнакладнойDataGridViewTextBoxColumn
            // 
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.DataPropertyName = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.HeaderText = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.Name = "iDТоварнойнакладнойDataGridViewTextBoxColumn";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаотпускаDataGridViewTextBoxColumn
            // 
            this.датаотпускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_отпуска";
            this.датаотпускаDataGridViewTextBoxColumn.HeaderText = "Дата_отпуска";
            this.датаотпускаDataGridViewTextBoxColumn.Name = "датаотпускаDataGridViewTextBoxColumn";
            this.датаотпускаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // TradeNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 641);
            this.Controls.Add(this.MainPanel);
            this.Name = "TradeNoteForm";
            this.Text = "TradeNoteForm";
            this.Load += new System.EventHandler(this.TradeNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарныенакладныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTradeNoteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварныйIDТо1B29035FBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CounteragentsNoteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКонтрагенIDТо4CF5691DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeNoteDataGridView)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентытоварнойнакладнойBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource товарныенакладныеBindingSource;
        public AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter товарные_накладныеTableAdapter;
        public AutomationAppDBDataSetTableAdapters.Товарный_раздел_товарной_накладнойTableAdapter товарный_раздел_товарной_накладнойTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddTradeNoteButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.BindingSource контрагентытоварнойнакладнойBindingSource;
        public AutomationAppDBDataSetTableAdapters.Контрагенты_товарной_накладнойTableAdapter контрагенты_товарной_накладнойTableAdapter;
        public System.Windows.Forms.BindingSource fKТоварныйIDТо1B29035FBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ProductsTradeNoteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварногоразделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварнойнакладнойDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГотовойпродукциинаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьпродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегосНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.DataGridView CounteragentsNoteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКонтрагентатоварнойнакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварнойнакладнойDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКонтрагентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn уНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource fKКонтрагенIDТо4CF5691DBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварнойнакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView TradeNoteDataGridView;
    }
}