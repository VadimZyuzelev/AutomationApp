
namespace AutomationApp
{
    partial class EditTradeNoteForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.DateCreateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataLabel = new System.Windows.Forms.Label();
            this.CargoReceiveTextBox = new JMetroTextBox.JMetroTextBox();
            this.SenderTextBox = new JMetroTextBox.JMetroTextBox();
            this.CargoReceiveErrorLabel = new System.Windows.Forms.Label();
            this.SenderErorLabel = new System.Windows.Forms.Label();
            this.CargoReceiveLabel = new System.Windows.Forms.Label();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.ClothLabelError = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.itemsProductsNoteDataGridView = new System.Windows.Forms.DataGridView();
            this.товарныенакладныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.товарные_накладныеTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter();
            this.товарный_раздел_товарной_накладнойTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Товарный_раздел_товарной_накладнойTableAdapter();
            this.fKТоварныйIDТо1B29035FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddItemsButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SelectCargoReceiveButton = new FontAwesome.Sharp.IconButton();
            this.SelectSenderButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.TopPictureButton = new FontAwesome.Sharp.IconPictureBox();
            this.iDТоварногоразделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьпродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегосНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsProductsNoteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарныенакладныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварныйIDТо1B29035FBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.TopPictureButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1356, 51);
            this.TopPanel.TabIndex = 63;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.Gray;
            this.TopLabel.Location = new System.Drawing.Point(51, 15);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(254, 19);
            this.TopLabel.TabIndex = 57;
            this.TopLabel.Text = "Добавление товарной накладной";
            // 
            // DateCreateTimePicker
            // 
            this.DateCreateTimePicker.Location = new System.Drawing.Point(29, 115);
            this.DateCreateTimePicker.Name = "DateCreateTimePicker";
            this.DateCreateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.DateCreateTimePicker.TabIndex = 82;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DataLabel.ForeColor = System.Drawing.Color.Gray;
            this.DataLabel.Location = new System.Drawing.Point(25, 78);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(168, 19);
            this.DataLabel.TabIndex = 83;
            this.DataLabel.Text = "Дата отпуска продукции";
            // 
            // CargoReceiveTextBox
            // 
            this.CargoReceiveTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CargoReceiveTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CargoReceiveTextBox.BorderRadius = 2;
            this.CargoReceiveTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.CargoReceiveTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CargoReceiveTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CargoReceiveTextBox.ForeColors = System.Drawing.Color.Black;
            this.CargoReceiveTextBox.IsPassword = false;
            this.CargoReceiveTextBox.LineThickness = 1;
            this.CargoReceiveTextBox.Location = new System.Drawing.Point(763, 101);
            this.CargoReceiveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargoReceiveTextBox.MaxLength = 32767;
            this.CargoReceiveTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.CargoReceiveTextBox.Name = "CargoReceiveTextBox";
            this.CargoReceiveTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CargoReceiveTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.CargoReceiveTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CargoReceiveTextBox.ReadOnly = true;
            this.CargoReceiveTextBox.Size = new System.Drawing.Size(284, 41);
            this.CargoReceiveTextBox.TabIndex = 97;
            this.CargoReceiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CargoReceiveTextBox.TextName = "";
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SenderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SenderTextBox.BorderRadius = 2;
            this.SenderTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.SenderTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SenderTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SenderTextBox.ForeColors = System.Drawing.Color.Black;
            this.SenderTextBox.IsPassword = false;
            this.SenderTextBox.LineThickness = 1;
            this.SenderTextBox.Location = new System.Drawing.Point(382, 101);
            this.SenderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderTextBox.MaxLength = 32767;
            this.SenderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SenderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SenderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SenderTextBox.ReadOnly = true;
            this.SenderTextBox.Size = new System.Drawing.Size(284, 41);
            this.SenderTextBox.TabIndex = 98;
            this.SenderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SenderTextBox.TextName = "";
            // 
            // CargoReceiveErrorLabel
            // 
            this.CargoReceiveErrorLabel.AutoSize = true;
            this.CargoReceiveErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CargoReceiveErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CargoReceiveErrorLabel.Location = new System.Drawing.Point(764, 147);
            this.CargoReceiveErrorLabel.Name = "CargoReceiveErrorLabel";
            this.CargoReceiveErrorLabel.Size = new System.Drawing.Size(157, 16);
            this.CargoReceiveErrorLabel.TabIndex = 95;
            this.CargoReceiveErrorLabel.Text = "Выберите грузополучателя";
            this.CargoReceiveErrorLabel.Visible = false;
            // 
            // SenderErorLabel
            // 
            this.SenderErorLabel.AutoSize = true;
            this.SenderErorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SenderErorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SenderErorLabel.Location = new System.Drawing.Point(382, 146);
            this.SenderErorLabel.Name = "SenderErorLabel";
            this.SenderErorLabel.Size = new System.Drawing.Size(163, 16);
            this.SenderErorLabel.TabIndex = 96;
            this.SenderErorLabel.Text = "Выберите грузоотправителя";
            this.SenderErorLabel.Visible = false;
            // 
            // CargoReceiveLabel
            // 
            this.CargoReceiveLabel.AutoSize = true;
            this.CargoReceiveLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CargoReceiveLabel.ForeColor = System.Drawing.Color.Gray;
            this.CargoReceiveLabel.Location = new System.Drawing.Point(762, 78);
            this.CargoReceiveLabel.Name = "CargoReceiveLabel";
            this.CargoReceiveLabel.Size = new System.Drawing.Size(119, 19);
            this.CargoReceiveLabel.TabIndex = 93;
            this.CargoReceiveLabel.Text = "Грузополучатель";
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SenderLabel.ForeColor = System.Drawing.Color.Gray;
            this.SenderLabel.Location = new System.Drawing.Point(381, 78);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(126, 19);
            this.SenderLabel.TabIndex = 94;
            this.SenderLabel.Text = "Грузоотправитель";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1148, 101);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(182, 39);
            this.SaveButton.TabIndex = 92;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FooterPanel.Location = new System.Drawing.Point(0, 213);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1357, 24);
            this.FooterPanel.TabIndex = 101;
            // 
            // ClothLabelError
            // 
            this.ClothLabelError.AutoSize = true;
            this.ClothLabelError.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClothLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClothLabelError.Location = new System.Drawing.Point(24, 184);
            this.ClothLabelError.Name = "ClothLabelError";
            this.ClothLabelError.Size = new System.Drawing.Size(310, 16);
            this.ClothLabelError.TabIndex = 83;
            this.ClothLabelError.Text = "Введите данные о продукции для товарной накладной";
            this.ClothLabelError.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.itemsProductsNoteDataGridView);
            this.MainPanel.Controls.Add(this.TitleFoodPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 237);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1357, 393);
            this.MainPanel.TabIndex = 102;
            // 
            // itemsProductsNoteDataGridView
            // 
            this.itemsProductsNoteDataGridView.AllowUserToAddRows = false;
            this.itemsProductsNoteDataGridView.AllowUserToDeleteRows = false;
            this.itemsProductsNoteDataGridView.AutoGenerateColumns = false;
            this.itemsProductsNoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsProductsNoteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.itemsProductsNoteDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsProductsNoteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsProductsNoteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemsProductsNoteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsProductsNoteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsProductsNoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsProductsNoteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТоварногоразделаDataGridViewTextBoxColumn,
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn,
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.стоимостьпродукцииDataGridViewTextBoxColumn,
            this.ставкаНДСDataGridViewTextBoxColumn,
            this.суммаНДСDataGridViewTextBoxColumn,
            this.всегосНДСDataGridViewTextBoxColumn});
            this.itemsProductsNoteDataGridView.DataSource = this.fKТоварныйIDТо1B29035FBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsProductsNoteDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemsProductsNoteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsProductsNoteDataGridView.EnableHeadersVisualStyles = false;
            this.itemsProductsNoteDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.itemsProductsNoteDataGridView.Location = new System.Drawing.Point(0, 67);
            this.itemsProductsNoteDataGridView.Name = "itemsProductsNoteDataGridView";
            this.itemsProductsNoteDataGridView.ReadOnly = true;
            this.itemsProductsNoteDataGridView.RowHeadersVisible = false;
            this.itemsProductsNoteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsProductsNoteDataGridView.Size = new System.Drawing.Size(1357, 326);
            this.itemsProductsNoteDataGridView.TabIndex = 59;
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
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddItemsButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1357, 67);
            this.TitleFoodPanel.TabIndex = 57;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.SearchTextBox.Location = new System.Drawing.Point(67, 22);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(1068, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            // 
            // товарные_накладныеTableAdapter
            // 
            this.товарные_накладныеTableAdapter.ClearBeforeFill = true;
            // 
            // товарный_раздел_товарной_накладнойTableAdapter
            // 
            this.товарный_раздел_товарной_накладнойTableAdapter.ClearBeforeFill = true;
            // 
            // fKТоварныйIDТо1B29035FBindingSource
            // 
            this.fKТоварныйIDТо1B29035FBindingSource.DataMember = "FK__Товарный___ID_То__1B29035F";
            this.fKТоварныйIDТо1B29035FBindingSource.DataSource = this.товарныенакладныеBindingSource;
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddItemsButton.FlatAppearance.BorderSize = 0;
            this.AddItemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemsButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddItemsButton.ForeColor = System.Drawing.Color.White;
            this.AddItemsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddItemsButton.IconColor = System.Drawing.Color.White;
            this.AddItemsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddItemsButton.IconSize = 16;
            this.AddItemsButton.Location = new System.Drawing.Point(1148, 13);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(182, 39);
            this.AddItemsButton.TabIndex = 9;
            this.AddItemsButton.Text = "Добавить продукцию";
            this.AddItemsButton.UseVisualStyleBackColor = false;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
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
            // SelectCargoReceiveButton
            // 
            this.SelectCargoReceiveButton.FlatAppearance.BorderSize = 0;
            this.SelectCargoReceiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCargoReceiveButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectCargoReceiveButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectCargoReceiveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectCargoReceiveButton.IconSize = 40;
            this.SelectCargoReceiveButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectCargoReceiveButton.Location = new System.Drawing.Point(1048, 101);
            this.SelectCargoReceiveButton.Name = "SelectCargoReceiveButton";
            this.SelectCargoReceiveButton.Size = new System.Drawing.Size(53, 39);
            this.SelectCargoReceiveButton.TabIndex = 99;
            this.SelectCargoReceiveButton.UseVisualStyleBackColor = true;
            this.SelectCargoReceiveButton.Click += new System.EventHandler(this.SelectCargoReceiveButton_Click);
            // 
            // SelectSenderButton
            // 
            this.SelectSenderButton.FlatAppearance.BorderSize = 0;
            this.SelectSenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSenderButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectSenderButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectSenderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectSenderButton.IconSize = 40;
            this.SelectSenderButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectSenderButton.Location = new System.Drawing.Point(666, 101);
            this.SelectSenderButton.Name = "SelectSenderButton";
            this.SelectSenderButton.Size = new System.Drawing.Size(53, 39);
            this.SelectSenderButton.TabIndex = 100;
            this.SelectSenderButton.UseVisualStyleBackColor = true;
            this.SelectSenderButton.Click += new System.EventHandler(this.SelectSenderButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.Gray;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 25;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(1289, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 59;
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // TopPictureButton
            // 
            this.TopPictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPictureButton.ForeColor = System.Drawing.Color.Gray;
            this.TopPictureButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.TopPictureButton.IconColor = System.Drawing.Color.Gray;
            this.TopPictureButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TopPictureButton.IconSize = 18;
            this.TopPictureButton.Location = new System.Drawing.Point(27, 18);
            this.TopPictureButton.Name = "TopPictureButton";
            this.TopPictureButton.Size = new System.Drawing.Size(18, 18);
            this.TopPictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopPictureButton.TabIndex = 58;
            this.TopPictureButton.TabStop = false;
            // 
            // iDТоварногоразделаDataGridViewTextBoxColumn
            // 
            this.iDТоварногоразделаDataGridViewTextBoxColumn.DataPropertyName = "ID_Товарного_раздела";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.HeaderText = "ID_Товарного_раздела";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.Name = "iDТоварногоразделаDataGridViewTextBoxColumn";
            this.iDТоварногоразделаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТоварногоразделаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDТоварнойнакладнойDataGridViewTextBoxColumn
            // 
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.DataPropertyName = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.HeaderText = "ID_Товарной_накладной";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.Name = "iDТоварнойнакладнойDataGridViewTextBoxColumn";
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТоварнойнакладнойDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDГотовойпродукциинаскладеDataGridViewTextBoxColumn
            // 
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.Name = "iDГотовойпродукциинаскладеDataGridViewTextBoxColumn";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.Visible = false;
            // 
            // материальныеценностиDataGridViewTextBoxColumn
            // 
            this.материальныеценностиDataGridViewTextBoxColumn.DataPropertyName = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.HeaderText = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.Name = "материальныеценностиDataGridViewTextBoxColumn";
            this.материальныеценностиDataGridViewTextBoxColumn.ReadOnly = true;
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
            // EditTradeNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 656);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ClothLabelError);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.SelectCargoReceiveButton);
            this.Controls.Add(this.SelectSenderButton);
            this.Controls.Add(this.CargoReceiveTextBox);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.CargoReceiveErrorLabel);
            this.Controls.Add(this.SenderErorLabel);
            this.Controls.Add(this.CargoReceiveLabel);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateCreateTimePicker);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TopPanel);
            this.Name = "EditTradeNoteForm";
            this.Text = "EditTradeNoteForm";
            this.Load += new System.EventHandler(this.EditTradeNoteForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsProductsNoteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарныенакладныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТоварныйIDТо1B29035FBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label TopLabel;
        private FontAwesome.Sharp.IconPictureBox TopPictureButton;
        private System.Windows.Forms.DateTimePicker DateCreateTimePicker;
        private System.Windows.Forms.Label DataLabel;
        private FontAwesome.Sharp.IconButton SelectCargoReceiveButton;
        private FontAwesome.Sharp.IconButton SelectSenderButton;
        private JMetroTextBox.JMetroTextBox CargoReceiveTextBox;
        private JMetroTextBox.JMetroTextBox SenderTextBox;
        private System.Windows.Forms.Label CargoReceiveErrorLabel;
        private System.Windows.Forms.Label SenderErorLabel;
        private System.Windows.Forms.Label CargoReceiveLabel;
        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label ClothLabelError;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.DataGridView itemsProductsNoteDataGridView;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddItemsButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource товарныенакладныеBindingSource;
        private AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter товарные_накладныеTableAdapter;
        private System.Windows.Forms.BindingSource fKТоварныйIDТо1B29035FBindingSource;
        private AutomationAppDBDataSetTableAdapters.Товарный_раздел_товарной_накладнойTableAdapter товарный_раздел_товарной_накладнойTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварногоразделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТоварнойнакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГотовойпродукциинаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьпродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегосНДСDataGridViewTextBoxColumn;
    }
}