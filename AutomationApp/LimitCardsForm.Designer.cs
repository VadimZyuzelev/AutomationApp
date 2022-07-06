
namespace AutomationApp
{
    partial class LimitCardsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimitCardsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.лимитнозаборныекартыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.fKФурнитураIDЛи13BCEBC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лимитно_заборные_картыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Лимитно_заборные_картыTableAdapter();
            this.фурнитура_по_лимитно_заборной_картеTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Фурнитура_по_лимитно_заборной_картеTableAdapter();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddCardsButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LimitCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CardsFurnitureGridView = new System.Windows.Forms.DataGridView();
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.норманаединицуизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиефурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделиизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасоставленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изделиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоизделийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.лимитнозаборныекартыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKФурнитураIDЛи13BCEBC1BindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsFurnitureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // лимитнозаборныекартыBindingSource
            // 
            this.лимитнозаборныекартыBindingSource.DataMember = "Лимитно_заборные_карты";
            this.лимитнозаборныекартыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKФурнитураIDЛи13BCEBC1BindingSource
            // 
            this.fKФурнитураIDЛи13BCEBC1BindingSource.DataMember = "FK__Фурнитура__ID_Ли__13BCEBC1";
            this.fKФурнитураIDЛи13BCEBC1BindingSource.DataSource = this.лимитнозаборныекартыBindingSource;
            // 
            // лимитно_заборные_картыTableAdapter
            // 
            this.лимитно_заборные_картыTableAdapter.ClearBeforeFill = true;
            // 
            // фурнитура_по_лимитно_заборной_картеTableAdapter
            // 
            this.фурнитура_по_лимитно_заборной_картеTableAdapter.ClearBeforeFill = true;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddCardsButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1296, 67);
            this.TitleFoodPanel.TabIndex = 6;
            // 
            // AddCardsButton
            // 
            this.AddCardsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCardsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddCardsButton.FlatAppearance.BorderSize = 0;
            this.AddCardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardsButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddCardsButton.ForeColor = System.Drawing.Color.White;
            this.AddCardsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddCardsButton.IconColor = System.Drawing.Color.White;
            this.AddCardsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddCardsButton.IconSize = 16;
            this.AddCardsButton.Location = new System.Drawing.Point(1097, 13);
            this.AddCardsButton.Name = "AddCardsButton";
            this.AddCardsButton.Size = new System.Drawing.Size(182, 39);
            this.AddCardsButton.TabIndex = 9;
            this.AddCardsButton.Text = "Добавить карту";
            this.AddCardsButton.UseVisualStyleBackColor = false;
            this.AddCardsButton.Click += new System.EventHandler(this.AddCardsButton_Click);
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
            this.SearchTextBox.Size = new System.Drawing.Size(1017, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            // 
            // LimitCardsDataGridView
            // 
            this.LimitCardsDataGridView.AllowUserToAddRows = false;
            this.LimitCardsDataGridView.AllowUserToDeleteRows = false;
            this.LimitCardsDataGridView.AutoGenerateColumns = false;
            this.LimitCardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LimitCardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LimitCardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LimitCardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LimitCardsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LimitCardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LimitCardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LimitCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LimitCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn,
            this.iDБригадыDataGridViewTextBoxColumn,
            this.iDМоделиизделияDataGridViewTextBoxColumn,
            this.датасоставленияDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.изделиеDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.количествоизделийDataGridViewTextBoxColumn,
            this.iDЦехаDataGridViewTextBoxColumn,
            this.iDИзделияDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn,
            this.PrintColumn});
            this.LimitCardsDataGridView.DataSource = this.лимитнозаборныекартыBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LimitCardsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.LimitCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.LimitCardsDataGridView.EnableHeadersVisualStyles = false;
            this.LimitCardsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.LimitCardsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.LimitCardsDataGridView.MultiSelect = false;
            this.LimitCardsDataGridView.Name = "LimitCardsDataGridView";
            this.LimitCardsDataGridView.ReadOnly = true;
            this.LimitCardsDataGridView.RowHeadersVisible = false;
            this.LimitCardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LimitCardsDataGridView.Size = new System.Drawing.Size(1296, 278);
            this.LimitCardsDataGridView.TabIndex = 7;
            this.LimitCardsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LimitCardsDataGridView_CellContentClick);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FooterPanel.Location = new System.Drawing.Point(0, 345);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1296, 24);
            this.FooterPanel.TabIndex = 69;
            // 
            // CardsFurnitureGridView
            // 
            this.CardsFurnitureGridView.AllowUserToAddRows = false;
            this.CardsFurnitureGridView.AllowUserToDeleteRows = false;
            this.CardsFurnitureGridView.AutoGenerateColumns = false;
            this.CardsFurnitureGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardsFurnitureGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CardsFurnitureGridView.BackgroundColor = System.Drawing.Color.White;
            this.CardsFurnitureGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsFurnitureGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CardsFurnitureGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsFurnitureGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CardsFurnitureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardsFurnitureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn,
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1,
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn,
            this.норманаединицуизделияDataGridViewTextBoxColumn,
            this.наименованиефурнитурыDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.CardsFurnitureGridView.DataSource = this.fKФурнитураIDЛи13BCEBC1BindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsFurnitureGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.CardsFurnitureGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardsFurnitureGridView.EnableHeadersVisualStyles = false;
            this.CardsFurnitureGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.CardsFurnitureGridView.Location = new System.Drawing.Point(0, 369);
            this.CardsFurnitureGridView.MultiSelect = false;
            this.CardsFurnitureGridView.Name = "CardsFurnitureGridView";
            this.CardsFurnitureGridView.ReadOnly = true;
            this.CardsFurnitureGridView.RowHeadersVisible = false;
            this.CardsFurnitureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardsFurnitureGridView.Size = new System.Drawing.Size(1296, 331);
            this.CardsFurnitureGridView.TabIndex = 70;
            // 
            // iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn
            // 
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn.DataPropertyName = "ID_Фурнитруы_по_лимитно_заборной_карте";
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn.HeaderText = "ID_Фурнитруы_по_лимитно_заборной_карте";
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn.Name = "iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn";
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1
            // 
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1.DataPropertyName = "ID_Лимитно_заборной_карты";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1.HeaderText = "ID_Лимитно_заборной_карты";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1.Name = "iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDФурнитурынаскладеDataGridViewTextBoxColumn
            // 
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Фурнитуры_на_складе";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Фурнитуры_на_складе";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.Name = "iDФурнитурынаскладеDataGridViewTextBoxColumn";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.Visible = false;
            // 
            // норманаединицуизделияDataGridViewTextBoxColumn
            // 
            this.норманаединицуизделияDataGridViewTextBoxColumn.DataPropertyName = "Норма_на_единицу_изделия";
            this.норманаединицуизделияDataGridViewTextBoxColumn.HeaderText = "Норма_на_единицу_изделия";
            this.норманаединицуизделияDataGridViewTextBoxColumn.Name = "норманаединицуизделияDataGridViewTextBoxColumn";
            this.норманаединицуизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.норманаединицуизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиефурнитурыDataGridViewTextBoxColumn
            // 
            this.наименованиефурнитурыDataGridViewTextBoxColumn.DataPropertyName = "Наименование_фурнитуры";
            this.наименованиефурнитурыDataGridViewTextBoxColumn.HeaderText = "ФУРНИТУРА";
            this.наименованиефурнитурыDataGridViewTextBoxColumn.Name = "наименованиефурнитурыDataGridViewTextBoxColumn";
            this.наименованиефурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "ЕД. ИЗМЕРЕНИЯ";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "КОЛИЧЕСТВО";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "ЦЕНА";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "СУММА";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЛимитнозаборнойкартыDataGridViewTextBoxColumn
            // 
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn.DataPropertyName = "ID_Лимитно_заборной_карты";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn.HeaderText = "ID_Лимитно_заборной_карты";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn.Name = "iDЛимитнозаборнойкартыDataGridViewTextBoxColumn";
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЛимитнозаборнойкартыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            this.iDБригадыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDБригадыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделиизделияDataGridViewTextBoxColumn
            // 
            this.iDМоделиизделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.HeaderText = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.Name = "iDМоделиизделияDataGridViewTextBoxColumn";
            this.iDМоделиизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделиизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // датасоставленияDataGridViewTextBoxColumn
            // 
            this.датасоставленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_составления";
            this.датасоставленияDataGridViewTextBoxColumn.HeaderText = "ДАТА СОСТАВЛЕНИЯ";
            this.датасоставленияDataGridViewTextBoxColumn.Name = "датасоставленияDataGridViewTextBoxColumn";
            this.датасоставленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цех";
            this.dataGridViewTextBoxColumn3.HeaderText = "ЦЕХ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Бригада";
            this.dataGridViewTextBoxColumn1.HeaderText = "БРИГАДА";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // изделиеDataGridViewTextBoxColumn
            // 
            this.изделиеDataGridViewTextBoxColumn.DataPropertyName = "Изделие";
            this.изделиеDataGridViewTextBoxColumn.HeaderText = "ИЗДЕЛИЕ";
            this.изделиеDataGridViewTextBoxColumn.Name = "изделиеDataGridViewTextBoxColumn";
            this.изделиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Модель_изделия";
            this.dataGridViewTextBoxColumn2.HeaderText = "МОДЕЛЬ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // количествоизделийDataGridViewTextBoxColumn
            // 
            this.количествоизделийDataGridViewTextBoxColumn.DataPropertyName = "Количество_изделий";
            this.количествоизделийDataGridViewTextBoxColumn.HeaderText = "КОЛ-ВО ИЗДЕЛИЙ";
            this.количествоизделийDataGridViewTextBoxColumn.Name = "количествоизделийDataGridViewTextBoxColumn";
            this.количествоизделийDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЦехаDataGridViewTextBoxColumn
            // 
            this.iDЦехаDataGridViewTextBoxColumn.DataPropertyName = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.HeaderText = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.Name = "iDЦехаDataGridViewTextBoxColumn";
            this.iDЦехаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЦехаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDИзделияDataGridViewTextBoxColumn
            // 
            this.iDИзделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.Name = "iDИзделияDataGridViewTextBoxColumn";
            this.iDИзделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDИзделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::AutomationApp.Properties.Resources.pen_solid5;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumn.Width = 34;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Width = 34;
            // 
            // PrintColumn
            // 
            this.PrintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.PrintColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrintColumn.HeaderText = "";
            this.PrintColumn.Image = global::AutomationApp.Properties.Resources.printTWO;
            this.PrintColumn.Name = "PrintColumn";
            this.PrintColumn.ReadOnly = true;
            this.PrintColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrintColumn.Width = 34;
            // 
            // LimitCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 700);
            this.Controls.Add(this.CardsFurnitureGridView);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.LimitCardsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Name = "LimitCardsForm";
            this.Text = "LimitCardsForm";
            this.Load += new System.EventHandler(this.LimitCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.лимитнозаборныекартыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKФурнитураIDЛи13BCEBC1BindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsFurnitureGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource лимитнозаборныекартыBindingSource;
        public AutomationAppDBDataSetTableAdapters.Лимитно_заборные_картыTableAdapter лимитно_заборные_картыTableAdapter;
        public System.Windows.Forms.BindingSource fKФурнитураIDЛи13BCEBC1BindingSource;
        public AutomationAppDBDataSetTableAdapters.Фурнитура_по_лимитно_заборной_картеTableAdapter фурнитура_по_лимитно_заборной_картеTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddCardsButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView LimitCardsDataGridView;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.DataGridView CardsFurnitureGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитруыполимитнозаборнойкартеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛимитнозаборнойкартыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурынаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn норманаединицуизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиефурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛимитнозаборнойкартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделиизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасоставленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn изделиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоизделийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn PrintColumn;
    }
}