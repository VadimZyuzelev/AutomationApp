
namespace AutomationApp
{
    partial class CalculationCardsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationCardsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.расчётныекартыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.fKТканьдляIDРа0C1BC9F9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расчётные_картыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Расчётные_картыTableAdapter();
            this.ткань_для_расчётной_картыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Ткань_для_расчётной_картыTableAdapter();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddCardButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CuttingClothDataGridView = new System.Windows.Forms.DataGridView();
            this.iDТканидлякартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТканинаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельтканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDРасчётнойкартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделиизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотпускатканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цехDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бригадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изделиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumnt = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintColumnt = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.расчётныекартыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТканьдляIDРа0C1BC9F9BindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuttingClothDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // расчётныекартыBindingSource
            // 
            this.расчётныекартыBindingSource.DataMember = "Расчётные_карты";
            this.расчётныекартыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKТканьдляIDРа0C1BC9F9BindingSource
            // 
            this.fKТканьдляIDРа0C1BC9F9BindingSource.DataMember = "FK__Ткань_для__ID_Ра__0C1BC9F9";
            this.fKТканьдляIDРа0C1BC9F9BindingSource.DataSource = this.расчётныекартыBindingSource;
            // 
            // расчётные_картыTableAdapter
            // 
            this.расчётные_картыTableAdapter.ClearBeforeFill = true;
            // 
            // ткань_для_расчётной_картыTableAdapter
            // 
            this.ткань_для_расчётной_картыTableAdapter.ClearBeforeFill = true;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddCardButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1296, 67);
            this.TitleFoodPanel.TabIndex = 6;
            // 
            // AddCardButton
            // 
            this.AddCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddCardButton.FlatAppearance.BorderSize = 0;
            this.AddCardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddCardButton.ForeColor = System.Drawing.Color.White;
            this.AddCardButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddCardButton.IconColor = System.Drawing.Color.White;
            this.AddCardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddCardButton.IconSize = 16;
            this.AddCardButton.Location = new System.Drawing.Point(1097, 13);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(182, 39);
            this.AddCardButton.TabIndex = 9;
            this.AddCardButton.Text = "Добавить карту";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
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
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FooterPanel.Location = new System.Drawing.Point(0, 312);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1296, 24);
            this.FooterPanel.TabIndex = 65;
            // 
            // CuttingClothDataGridView
            // 
            this.CuttingClothDataGridView.AllowUserToAddRows = false;
            this.CuttingClothDataGridView.AllowUserToDeleteRows = false;
            this.CuttingClothDataGridView.AutoGenerateColumns = false;
            this.CuttingClothDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CuttingClothDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CuttingClothDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CuttingClothDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CuttingClothDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CuttingClothDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CuttingClothDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CuttingClothDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuttingClothDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТканидлякартыDataGridViewTextBoxColumn,
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1,
            this.iDТканинаскладеDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельтканиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.CuttingClothDataGridView.DataSource = this.fKТканьдляIDРа0C1BC9F9BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CuttingClothDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CuttingClothDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuttingClothDataGridView.EnableHeadersVisualStyles = false;
            this.CuttingClothDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.CuttingClothDataGridView.Location = new System.Drawing.Point(0, 336);
            this.CuttingClothDataGridView.Name = "CuttingClothDataGridView";
            this.CuttingClothDataGridView.ReadOnly = true;
            this.CuttingClothDataGridView.RowHeadersVisible = false;
            this.CuttingClothDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CuttingClothDataGridView.Size = new System.Drawing.Size(1296, 364);
            this.CuttingClothDataGridView.TabIndex = 66;
            this.CuttingClothDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CuttingClothDataGridView_DataBindingComplete);
            // 
            // iDТканидлякартыDataGridViewTextBoxColumn
            // 
            this.iDТканидлякартыDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани_для_карты";
            this.iDТканидлякартыDataGridViewTextBoxColumn.HeaderText = "ID_Ткани_для_карты";
            this.iDТканидлякартыDataGridViewTextBoxColumn.Name = "iDТканидлякартыDataGridViewTextBoxColumn";
            this.iDТканидлякартыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканидлякартыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDРасчётнойкартыDataGridViewTextBoxColumn1
            // 
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1.DataPropertyName = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1.HeaderText = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1.Name = "iDРасчётнойкартыDataGridViewTextBoxColumn1";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDРасчётнойкартыDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDТканинаскладеDataGridViewTextBoxColumn
            // 
            this.iDТканинаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани_на_складе";
            this.iDТканинаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Ткани_на_складе";
            this.iDТканинаскладеDataGridViewTextBoxColumn.Name = "iDТканинаскладеDataGridViewTextBoxColumn";
            this.iDТканинаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканинаскладеDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "ТКАНЬ";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельтканиDataGridViewTextBoxColumn
            // 
            this.модельтканиDataGridViewTextBoxColumn.DataPropertyName = "Модель_ткани";
            this.модельтканиDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельтканиDataGridViewTextBoxColumn.Name = "модельтканиDataGridViewTextBoxColumn";
            this.модельтканиDataGridViewTextBoxColumn.ReadOnly = true;
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
            // CardsDataGridView
            // 
            this.CardsDataGridView.AllowUserToAddRows = false;
            this.CardsDataGridView.AllowUserToDeleteRows = false;
            this.CardsDataGridView.AutoGenerateColumns = false;
            this.CardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРасчётнойкартыDataGridViewTextBoxColumn,
            this.iDЦехаDataGridViewTextBoxColumn,
            this.iDБригадыDataGridViewTextBoxColumn,
            this.iDИзделияDataGridViewTextBoxColumn,
            this.iDМоделиизделияDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn,
            this.датаотпускатканиDataGridViewTextBoxColumn,
            this.цехDataGridViewTextBoxColumn,
            this.бригадаDataGridViewTextBoxColumn,
            this.изделиеDataGridViewTextBoxColumn,
            this.модельизделияDataGridViewTextBoxColumn,
            this.EditColumnt,
            this.DeleteColumn,
            this.PrintColumnt});
            this.CardsDataGridView.DataSource = this.расчётныекартыBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.CardsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardsDataGridView.EnableHeadersVisualStyles = false;
            this.CardsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.CardsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.CardsDataGridView.Name = "CardsDataGridView";
            this.CardsDataGridView.ReadOnly = true;
            this.CardsDataGridView.RowHeadersVisible = false;
            this.CardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardsDataGridView.Size = new System.Drawing.Size(1296, 245);
            this.CardsDataGridView.TabIndex = 7;
            this.CardsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardsDataGridView_CellContentClick);
            this.CardsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CardsDataGridView_DataBindingComplete);
            // 
            // iDРасчётнойкартыDataGridViewTextBoxColumn
            // 
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.DataPropertyName = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.HeaderText = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.Name = "iDРасчётнойкартыDataGridViewTextBoxColumn";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDЦехаDataGridViewTextBoxColumn
            // 
            this.iDЦехаDataGridViewTextBoxColumn.DataPropertyName = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.HeaderText = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.Name = "iDЦехаDataGridViewTextBoxColumn";
            this.iDЦехаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЦехаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            this.iDБригадыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDБригадыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDИзделияDataGridViewTextBoxColumn
            // 
            this.iDИзделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.Name = "iDИзделияDataGridViewTextBoxColumn";
            this.iDИзделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDИзделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделиизделияDataGridViewTextBoxColumn
            // 
            this.iDМоделиизделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.HeaderText = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.Name = "iDМоделиизделияDataGridViewTextBoxColumn";
            this.iDМоделиизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделиизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "НОМЕР ЗАКАЗА";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            this.номерзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаотпускатканиDataGridViewTextBoxColumn
            // 
            this.датаотпускатканиDataGridViewTextBoxColumn.DataPropertyName = "Дата_отпуска_ткани";
            this.датаотпускатканиDataGridViewTextBoxColumn.HeaderText = "ДАТА ОТПУСКА ТКАНИ";
            this.датаотпускатканиDataGridViewTextBoxColumn.Name = "датаотпускатканиDataGridViewTextBoxColumn";
            this.датаотпускатканиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цехDataGridViewTextBoxColumn
            // 
            this.цехDataGridViewTextBoxColumn.DataPropertyName = "Цех";
            this.цехDataGridViewTextBoxColumn.HeaderText = "ЦЕХ";
            this.цехDataGridViewTextBoxColumn.Name = "цехDataGridViewTextBoxColumn";
            this.цехDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // бригадаDataGridViewTextBoxColumn
            // 
            this.бригадаDataGridViewTextBoxColumn.DataPropertyName = "Бригада";
            this.бригадаDataGridViewTextBoxColumn.HeaderText = "БРИГАДА";
            this.бригадаDataGridViewTextBoxColumn.Name = "бригадаDataGridViewTextBoxColumn";
            this.бригадаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // изделиеDataGridViewTextBoxColumn
            // 
            this.изделиеDataGridViewTextBoxColumn.DataPropertyName = "Изделие";
            this.изделиеDataGridViewTextBoxColumn.HeaderText = "ИЗДЕЛИЕ";
            this.изделиеDataGridViewTextBoxColumn.Name = "изделиеDataGridViewTextBoxColumn";
            this.изделиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельизделияDataGridViewTextBoxColumn
            // 
            this.модельизделияDataGridViewTextBoxColumn.DataPropertyName = "Модель_изделия";
            this.модельизделияDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельизделияDataGridViewTextBoxColumn.Name = "модельизделияDataGridViewTextBoxColumn";
            this.модельизделияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumnt
            // 
            this.EditColumnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumnt.DefaultCellStyle = dataGridViewCellStyle4;
            this.EditColumnt.HeaderText = "";
            this.EditColumnt.Image = global::AutomationApp.Properties.Resources.pen_solid5;
            this.EditColumnt.Name = "EditColumnt";
            this.EditColumnt.ReadOnly = true;
            this.EditColumnt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumnt.Width = 34;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 34;
            // 
            // PrintColumnt
            // 
            this.PrintColumnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.PrintColumnt.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrintColumnt.HeaderText = "";
            this.PrintColumnt.Image = global::AutomationApp.Properties.Resources.printTWO;
            this.PrintColumnt.Name = "PrintColumnt";
            this.PrintColumnt.ReadOnly = true;
            this.PrintColumnt.Width = 34;
            // 
            // CalculationCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 700);
            this.Controls.Add(this.CuttingClothDataGridView);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.CardsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Name = "CalculationCardsForm";
            this.Text = "CalculationCardsForm";
            this.Load += new System.EventHandler(this.CalculationCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.расчётныекартыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKТканьдляIDРа0C1BC9F9BindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuttingClothDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource расчётныекартыBindingSource;
        public AutomationAppDBDataSetTableAdapters.Расчётные_картыTableAdapter расчётные_картыTableAdapter;
        public System.Windows.Forms.BindingSource fKТканьдляIDРа0C1BC9F9BindingSource;
        public AutomationAppDBDataSetTableAdapters.Ткань_для_расчётной_картыTableAdapter ткань_для_расчётной_картыTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddCardButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel FooterPanel;
        public System.Windows.Forms.DataGridView CuttingClothDataGridView;
        private System.Windows.Forms.DataGridView CardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканидлякартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРасчётнойкартыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканинаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельтканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРасчётнойкартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделиизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотпускатканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цехDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бригадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изделиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumnt;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn PrintColumnt;
    }
}