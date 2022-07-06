
namespace AutomationApp
{
    partial class EditCalculationCardsForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.расчётныекартыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.DateCreateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.расчётные_картыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Расчётные_картыTableAdapter();
            this.ткань_для_расчётной_картыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Ткань_для_расчётной_картыTableAdapter();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ClothsOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataErrorLabel = new System.Windows.Forms.Label();
            this.NumberTicketTextBox = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberErrorLabel = new System.Windows.Forms.Label();
            this.WorkshopTextBox = new JMetroTextBox.JMetroTextBox();
            this.WorkshopLabel = new System.Windows.Forms.Label();
            this.WorkshopErrorLabel = new System.Windows.Forms.Label();
            this.BrigadeLabel = new System.Windows.Forms.Label();
            this.BrigadeErrorLabel = new System.Windows.Forms.Label();
            this.BrigadeTextBox = new JMetroTextBox.JMetroTextBox();
            this.ItemTextBox = new JMetroTextBox.JMetroTextBox();
            this.ItemErrorLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.ClothLabelError = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.SelectItemButton = new FontAwesome.Sharp.IconButton();
            this.SelectWorkshopButton = new FontAwesome.Sharp.IconButton();
            this.iDТканидлякартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDРасчётнойкартыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТканинаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельтканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKТканьдляIDРа0C1BC9F9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddClothButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.TopPictureButton = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.расчётныекартыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothsOrderDataGridView)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТканьдляIDРа0C1BC9F9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).BeginInit();
            this.SuspendLayout();
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
            this.SaveButton.TabIndex = 40;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            // DateCreateTimePicker
            // 
            this.DateCreateTimePicker.Location = new System.Drawing.Point(28, 219);
            this.DateCreateTimePicker.Name = "DateCreateTimePicker";
            this.DateCreateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.DateCreateTimePicker.TabIndex = 44;
            // 
            // расчётные_картыTableAdapter
            // 
            this.расчётные_картыTableAdapter.ClearBeforeFill = true;
            // 
            // ткань_для_расчётной_картыTableAdapter
            // 
            this.ткань_для_расчётной_картыTableAdapter.ClearBeforeFill = true;
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
            this.TopPanel.TabIndex = 62;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.Gray;
            this.TopLabel.Location = new System.Drawing.Point(51, 15);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(226, 19);
            this.TopLabel.TabIndex = 57;
            this.TopLabel.Text = "Добавление расчетной карты";
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FooterPanel.Location = new System.Drawing.Point(0, 315);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1357, 24);
            this.FooterPanel.TabIndex = 63;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ClothsOrderDataGridView);
            this.MainPanel.Controls.Add(this.TitleFoodPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 340);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1357, 393);
            this.MainPanel.TabIndex = 64;
            // 
            // ClothsOrderDataGridView
            // 
            this.ClothsOrderDataGridView.AllowUserToAddRows = false;
            this.ClothsOrderDataGridView.AllowUserToDeleteRows = false;
            this.ClothsOrderDataGridView.AutoGenerateColumns = false;
            this.ClothsOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothsOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClothsOrderDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClothsOrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClothsOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClothsOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClothsOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClothsOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothsOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТканидлякартыDataGridViewTextBoxColumn,
            this.iDРасчётнойкартыDataGridViewTextBoxColumn,
            this.iDТканинаскладеDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельтканиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.ClothsOrderDataGridView.DataSource = this.fKТканьдляIDРа0C1BC9F9BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClothsOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClothsOrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClothsOrderDataGridView.EnableHeadersVisualStyles = false;
            this.ClothsOrderDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClothsOrderDataGridView.Location = new System.Drawing.Point(0, 67);
            this.ClothsOrderDataGridView.Name = "ClothsOrderDataGridView";
            this.ClothsOrderDataGridView.ReadOnly = true;
            this.ClothsOrderDataGridView.RowHeadersVisible = false;
            this.ClothsOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothsOrderDataGridView.Size = new System.Drawing.Size(1357, 326);
            this.ClothsOrderDataGridView.TabIndex = 58;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddClothButton);
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
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DataLabel.ForeColor = System.Drawing.Color.Gray;
            this.DataLabel.Location = new System.Drawing.Point(25, 184);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(133, 19);
            this.DataLabel.TabIndex = 81;
            this.DataLabel.Text = "Дата отпуска ткани";
            // 
            // DataErrorLabel
            // 
            this.DataErrorLabel.AutoSize = true;
            this.DataErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataErrorLabel.Location = new System.Drawing.Point(26, 252);
            this.DataErrorLabel.Name = "DataErrorLabel";
            this.DataErrorLabel.Size = new System.Drawing.Size(89, 16);
            this.DataErrorLabel.TabIndex = 82;
            this.DataErrorLabel.Text = "Выберите дату";
            this.DataErrorLabel.Visible = false;
            // 
            // NumberTicketTextBox
            // 
            this.NumberTicketTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberTicketTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NumberTicketTextBox.BorderRadius = 2;
            this.NumberTicketTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.NumberTicketTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTicketTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTicketTextBox.ForeColors = System.Drawing.Color.Black;
            this.NumberTicketTextBox.IsPassword = false;
            this.NumberTicketTextBox.LineThickness = 1;
            this.NumberTicketTextBox.Location = new System.Drawing.Point(25, 101);
            this.NumberTicketTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberTicketTextBox.MaxLength = 32767;
            this.NumberTicketTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NumberTicketTextBox.Name = "NumberTicketTextBox";
            this.NumberTicketTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTicketTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NumberTicketTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NumberTicketTextBox.ReadOnly = false;
            this.NumberTicketTextBox.Size = new System.Drawing.Size(284, 41);
            this.NumberTicketTextBox.TabIndex = 83;
            this.NumberTicketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberTicketTextBox.TextName = "";
            this.NumberTicketTextBox.Enter += new System.EventHandler(this.NumberTicketTextBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Номер заказ";
            // 
            // NumberErrorLabel
            // 
            this.NumberErrorLabel.AutoSize = true;
            this.NumberErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumberErrorLabel.Location = new System.Drawing.Point(25, 147);
            this.NumberErrorLabel.Name = "NumberErrorLabel";
            this.NumberErrorLabel.Size = new System.Drawing.Size(127, 16);
            this.NumberErrorLabel.TabIndex = 82;
            this.NumberErrorLabel.Text = "Введите номер заказа";
            this.NumberErrorLabel.Visible = false;
            // 
            // WorkshopTextBox
            // 
            this.WorkshopTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WorkshopTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.WorkshopTextBox.BorderRadius = 2;
            this.WorkshopTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.WorkshopTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WorkshopTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WorkshopTextBox.ForeColors = System.Drawing.Color.Black;
            this.WorkshopTextBox.IsPassword = false;
            this.WorkshopTextBox.LineThickness = 1;
            this.WorkshopTextBox.Location = new System.Drawing.Point(382, 101);
            this.WorkshopTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkshopTextBox.MaxLength = 32767;
            this.WorkshopTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.WorkshopTextBox.Name = "WorkshopTextBox";
            this.WorkshopTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.WorkshopTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.WorkshopTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.WorkshopTextBox.ReadOnly = true;
            this.WorkshopTextBox.Size = new System.Drawing.Size(284, 41);
            this.WorkshopTextBox.TabIndex = 83;
            this.WorkshopTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WorkshopTextBox.TextName = "";
            // 
            // WorkshopLabel
            // 
            this.WorkshopLabel.AutoSize = true;
            this.WorkshopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.WorkshopLabel.ForeColor = System.Drawing.Color.Gray;
            this.WorkshopLabel.Location = new System.Drawing.Point(381, 78);
            this.WorkshopLabel.Name = "WorkshopLabel";
            this.WorkshopLabel.Size = new System.Drawing.Size(34, 19);
            this.WorkshopLabel.TabIndex = 81;
            this.WorkshopLabel.Text = "Цех";
            // 
            // WorkshopErrorLabel
            // 
            this.WorkshopErrorLabel.AutoSize = true;
            this.WorkshopErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkshopErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WorkshopErrorLabel.Location = new System.Drawing.Point(382, 146);
            this.WorkshopErrorLabel.Name = "WorkshopErrorLabel";
            this.WorkshopErrorLabel.Size = new System.Drawing.Size(84, 16);
            this.WorkshopErrorLabel.TabIndex = 82;
            this.WorkshopErrorLabel.Text = "Выберите цех";
            this.WorkshopErrorLabel.Visible = false;
            // 
            // BrigadeLabel
            // 
            this.BrigadeLabel.AutoSize = true;
            this.BrigadeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.BrigadeLabel.ForeColor = System.Drawing.Color.Gray;
            this.BrigadeLabel.Location = new System.Drawing.Point(384, 184);
            this.BrigadeLabel.Name = "BrigadeLabel";
            this.BrigadeLabel.Size = new System.Drawing.Size(60, 19);
            this.BrigadeLabel.TabIndex = 81;
            this.BrigadeLabel.Text = "Бригада";
            // 
            // BrigadeErrorLabel
            // 
            this.BrigadeErrorLabel.AutoSize = true;
            this.BrigadeErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrigadeErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BrigadeErrorLabel.Location = new System.Drawing.Point(385, 252);
            this.BrigadeErrorLabel.Name = "BrigadeErrorLabel";
            this.BrigadeErrorLabel.Size = new System.Drawing.Size(110, 16);
            this.BrigadeErrorLabel.TabIndex = 82;
            this.BrigadeErrorLabel.Text = "Выберите бригаду";
            this.BrigadeErrorLabel.Visible = false;
            // 
            // BrigadeTextBox
            // 
            this.BrigadeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.BrigadeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.BrigadeTextBox.BorderRadius = 2;
            this.BrigadeTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.BrigadeTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BrigadeTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BrigadeTextBox.ForeColors = System.Drawing.Color.Black;
            this.BrigadeTextBox.IsPassword = false;
            this.BrigadeTextBox.LineThickness = 1;
            this.BrigadeTextBox.Location = new System.Drawing.Point(385, 207);
            this.BrigadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrigadeTextBox.MaxLength = 32767;
            this.BrigadeTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.BrigadeTextBox.Name = "BrigadeTextBox";
            this.BrigadeTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.BrigadeTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.BrigadeTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.BrigadeTextBox.ReadOnly = true;
            this.BrigadeTextBox.Size = new System.Drawing.Size(284, 41);
            this.BrigadeTextBox.TabIndex = 83;
            this.BrigadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BrigadeTextBox.TextName = "";
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ItemTextBox.BorderRadius = 2;
            this.ItemTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.ItemTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemTextBox.ForeColors = System.Drawing.Color.Black;
            this.ItemTextBox.IsPassword = false;
            this.ItemTextBox.LineThickness = 1;
            this.ItemTextBox.Location = new System.Drawing.Point(763, 101);
            this.ItemTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemTextBox.MaxLength = 32767;
            this.ItemTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ItemTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ItemTextBox.ReadOnly = true;
            this.ItemTextBox.Size = new System.Drawing.Size(284, 41);
            this.ItemTextBox.TabIndex = 83;
            this.ItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemTextBox.TextName = "";
            // 
            // ItemErrorLabel
            // 
            this.ItemErrorLabel.AutoSize = true;
            this.ItemErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ItemErrorLabel.Location = new System.Drawing.Point(764, 147);
            this.ItemErrorLabel.Name = "ItemErrorLabel";
            this.ItemErrorLabel.Size = new System.Drawing.Size(109, 16);
            this.ItemErrorLabel.TabIndex = 82;
            this.ItemErrorLabel.Text = "Выберите изделие";
            this.ItemErrorLabel.Visible = false;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ItemLabel.ForeColor = System.Drawing.Color.Gray;
            this.ItemLabel.Location = new System.Drawing.Point(762, 78);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(64, 19);
            this.ItemLabel.TabIndex = 81;
            this.ItemLabel.Text = "Изделие";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(762, 184);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 81;
            this.ModelLabel.Text = "Модель";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ModelTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ModelTextBox.BorderRadius = 2;
            this.ModelTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.ModelTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.ForeColors = System.Drawing.Color.Black;
            this.ModelTextBox.IsPassword = false;
            this.ModelTextBox.LineThickness = 1;
            this.ModelTextBox.Location = new System.Drawing.Point(763, 207);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(284, 41);
            this.ModelTextBox.TabIndex = 83;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // ClothLabelError
            // 
            this.ClothLabelError.AutoSize = true;
            this.ClothLabelError.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClothLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClothLabelError.Location = new System.Drawing.Point(26, 291);
            this.ClothLabelError.Name = "ClothLabelError";
            this.ClothLabelError.Size = new System.Drawing.Size(260, 16);
            this.ClothLabelError.TabIndex = 82;
            this.ClothLabelError.Text = "Введите данные о ткани для расчётной карты";
            this.ClothLabelError.Visible = false;
            // 
            // ModelErrorLabel
            // 
            this.ModelErrorLabel.AutoSize = true;
            this.ModelErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelErrorLabel.Location = new System.Drawing.Point(763, 252);
            this.ModelErrorLabel.Name = "ModelErrorLabel";
            this.ModelErrorLabel.Size = new System.Drawing.Size(110, 16);
            this.ModelErrorLabel.TabIndex = 82;
            this.ModelErrorLabel.Text = "Выберите бригаду";
            this.ModelErrorLabel.Visible = false;
            // 
            // SelectItemButton
            // 
            this.SelectItemButton.FlatAppearance.BorderSize = 0;
            this.SelectItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectItemButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectItemButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectItemButton.IconSize = 40;
            this.SelectItemButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectItemButton.Location = new System.Drawing.Point(1048, 101);
            this.SelectItemButton.Name = "SelectItemButton";
            this.SelectItemButton.Size = new System.Drawing.Size(53, 39);
            this.SelectItemButton.TabIndex = 91;
            this.SelectItemButton.UseVisualStyleBackColor = true;
            this.SelectItemButton.Click += new System.EventHandler(this.SelectItemButton_Click);
            // 
            // SelectWorkshopButton
            // 
            this.SelectWorkshopButton.FlatAppearance.BorderSize = 0;
            this.SelectWorkshopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectWorkshopButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectWorkshopButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectWorkshopButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectWorkshopButton.IconSize = 40;
            this.SelectWorkshopButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectWorkshopButton.Location = new System.Drawing.Point(666, 101);
            this.SelectWorkshopButton.Name = "SelectWorkshopButton";
            this.SelectWorkshopButton.Size = new System.Drawing.Size(53, 39);
            this.SelectWorkshopButton.TabIndex = 91;
            this.SelectWorkshopButton.UseVisualStyleBackColor = true;
            this.SelectWorkshopButton.Click += new System.EventHandler(this.SelectWorkshopButton_Click);
            // 
            // iDТканидлякартыDataGridViewTextBoxColumn
            // 
            this.iDТканидлякартыDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани_для_карты";
            this.iDТканидлякартыDataGridViewTextBoxColumn.HeaderText = "ID_Ткани_для_карты";
            this.iDТканидлякартыDataGridViewTextBoxColumn.Name = "iDТканидлякартыDataGridViewTextBoxColumn";
            this.iDТканидлякартыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканидлякартыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDРасчётнойкартыDataGridViewTextBoxColumn
            // 
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.DataPropertyName = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.HeaderText = "ID_Расчётной_карты";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.Name = "iDРасчётнойкартыDataGridViewTextBoxColumn";
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDРасчётнойкартыDataGridViewTextBoxColumn.Visible = false;
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
            // fKТканьдляIDРа0C1BC9F9BindingSource
            // 
            this.fKТканьдляIDРа0C1BC9F9BindingSource.DataMember = "FK__Ткань_для__ID_Ра__0C1BC9F9";
            this.fKТканьдляIDРа0C1BC9F9BindingSource.DataSource = this.расчётныекартыBindingSource;
            // 
            // AddClothButton
            // 
            this.AddClothButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddClothButton.FlatAppearance.BorderSize = 0;
            this.AddClothButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddClothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClothButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddClothButton.ForeColor = System.Drawing.Color.White;
            this.AddClothButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddClothButton.IconColor = System.Drawing.Color.White;
            this.AddClothButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClothButton.IconSize = 16;
            this.AddClothButton.Location = new System.Drawing.Point(1148, 13);
            this.AddClothButton.Name = "AddClothButton";
            this.AddClothButton.Size = new System.Drawing.Size(182, 39);
            this.AddClothButton.TabIndex = 9;
            this.AddClothButton.Text = "Добавить ткань";
            this.AddClothButton.UseVisualStyleBackColor = false;
            this.AddClothButton.Click += new System.EventHandler(this.AddClothButton_Click);
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
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
            // EditCalculationCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 745);
            this.Controls.Add(this.SelectItemButton);
            this.Controls.Add(this.SelectWorkshopButton);
            this.Controls.Add(this.BrigadeTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.WorkshopTextBox);
            this.Controls.Add(this.NumberTicketTextBox);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.BrigadeErrorLabel);
            this.Controls.Add(this.DateCreateTimePicker);
            this.Controls.Add(this.ItemErrorLabel);
            this.Controls.Add(this.WorkshopErrorLabel);
            this.Controls.Add(this.NumberErrorLabel);
            this.Controls.Add(this.BrigadeLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ClothLabelError);
            this.Controls.Add(this.DataErrorLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.WorkshopLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCalculationCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCalculationCardsForm";
            this.Load += new System.EventHandler(this.EditCalculationCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.расчётныекартыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClothsOrderDataGridView)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKТканьдляIDРа0C1BC9F9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker DateCreateTimePicker;
        public AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource расчётныекартыBindingSource;
        public AutomationAppDBDataSetTableAdapters.Расчётные_картыTableAdapter расчётные_картыTableAdapter;
        public System.Windows.Forms.BindingSource fKТканьдляIDРа0C1BC9F9BindingSource;
        public AutomationAppDBDataSetTableAdapters.Ткань_для_расчётной_картыTableAdapter ткань_для_расчётной_картыTableAdapter;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label TopLabel;
        private FontAwesome.Sharp.IconPictureBox TopPictureButton;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddClothButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label DataErrorLabel;
        private JMetroTextBox.JMetroTextBox NumberTicketTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberErrorLabel;
        private JMetroTextBox.JMetroTextBox WorkshopTextBox;
        private System.Windows.Forms.Label WorkshopLabel;
        private System.Windows.Forms.Label WorkshopErrorLabel;
        private System.Windows.Forms.Label BrigadeLabel;
        private System.Windows.Forms.Label BrigadeErrorLabel;
        private JMetroTextBox.JMetroTextBox BrigadeTextBox;
        private FontAwesome.Sharp.IconButton SelectWorkshopButton;
        private JMetroTextBox.JMetroTextBox ItemTextBox;
        private FontAwesome.Sharp.IconButton SelectItemButton;
        private System.Windows.Forms.Label ItemErrorLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ModelLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private System.Windows.Forms.Label ClothLabelError;
        public System.Windows.Forms.DataGridView ClothsOrderDataGridView;
        private System.Windows.Forms.Label ModelErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканидлякартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРасчётнойкартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканинаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельтканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}