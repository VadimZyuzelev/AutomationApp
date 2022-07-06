
namespace AutomationApp
{
    partial class ClothOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothOrdersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.приходныеордеранатканьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.приходные_ордера_на_тканьTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddOrderButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.ClothOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.iDПриходногоордераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасоставленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корреспондирующийсчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сопроводительныйдокументDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MaterialsOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.iDМатериальнойценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПриходногоордераDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделитканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммабезНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегосНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKМатериальIDПр0CDAE408BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.материальныеценностипоордерунатканьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_тканьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранатканьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothOrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр0CDAE408BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материальныеценностипоордерунатканьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // приходныеордеранатканьBindingSource
            // 
            this.приходныеордеранатканьBindingSource.DataMember = "Приходные_ордера_на_ткань";
            this.приходныеордеранатканьBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приходные_ордера_на_тканьTableAdapter
            // 
            this.приходные_ордера_на_тканьTableAdapter.ClearBeforeFill = true;
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
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddOrderButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1296, 67);
            this.TitleFoodPanel.TabIndex = 4;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddOrderButton.FlatAppearance.BorderSize = 0;
            this.AddOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddOrderButton.IconColor = System.Drawing.Color.White;
            this.AddOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddOrderButton.IconSize = 16;
            this.AddOrderButton.Location = new System.Drawing.Point(1097, 13);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(182, 39);
            this.AddOrderButton.TabIndex = 9;
            this.AddOrderButton.Text = "Добавить ордер";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
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
            // ClothOrdersDataGridView
            // 
            this.ClothOrdersDataGridView.AllowUserToAddRows = false;
            this.ClothOrdersDataGridView.AllowUserToDeleteRows = false;
            this.ClothOrdersDataGridView.AutoGenerateColumns = false;
            this.ClothOrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothOrdersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClothOrdersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClothOrdersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClothOrdersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClothOrdersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClothOrdersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClothOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПриходногоордераDataGridViewTextBoxColumn,
            this.iDПоставщикаDataGridViewTextBoxColumn,
            this.датасоставленияDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.складDataGridViewTextBoxColumn,
            this.корреспондирующийсчетDataGridViewTextBoxColumn,
            this.сопроводительныйдокументDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn,
            this.PrintColumn});
            this.ClothOrdersDataGridView.DataSource = this.приходныеордеранатканьBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClothOrdersDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClothOrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClothOrdersDataGridView.EnableHeadersVisualStyles = false;
            this.ClothOrdersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClothOrdersDataGridView.Location = new System.Drawing.Point(0, 67);
            this.ClothOrdersDataGridView.Name = "ClothOrdersDataGridView";
            this.ClothOrdersDataGridView.ReadOnly = true;
            this.ClothOrdersDataGridView.RowHeadersVisible = false;
            this.ClothOrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothOrdersDataGridView.Size = new System.Drawing.Size(1296, 278);
            this.ClothOrdersDataGridView.TabIndex = 5;
            this.ClothOrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClothOrdersDataGridView_CellContentClick);
            this.ClothOrdersDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ClothOrdersDataGridView_DataBindingComplete);
            // 
            // iDПриходногоордераDataGridViewTextBoxColumn
            // 
            this.iDПриходногоордераDataGridViewTextBoxColumn.DataPropertyName = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.HeaderText = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.Name = "iDПриходногоордераDataGridViewTextBoxColumn";
            this.iDПриходногоордераDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПриходногоордераDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDПоставщикаDataGridViewTextBoxColumn
            // 
            this.iDПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.HeaderText = "ID_Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.Name = "iDПоставщикаDataGridViewTextBoxColumn";
            this.iDПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПоставщикаDataGridViewTextBoxColumn.Visible = false;
            // 
            // датасоставленияDataGridViewTextBoxColumn
            // 
            this.датасоставленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_составления";
            this.датасоставленияDataGridViewTextBoxColumn.HeaderText = "ДАТА СОСТАВЛЕНИЯ";
            this.датасоставленияDataGridViewTextBoxColumn.Name = "датасоставленияDataGridViewTextBoxColumn";
            this.датасоставленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "ПОСТАВЩИК";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            this.поставщикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // складDataGridViewTextBoxColumn
            // 
            this.складDataGridViewTextBoxColumn.DataPropertyName = "Склад";
            this.складDataGridViewTextBoxColumn.HeaderText = "СКЛАД";
            this.складDataGridViewTextBoxColumn.Name = "складDataGridViewTextBoxColumn";
            this.складDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // корреспондирующийсчетDataGridViewTextBoxColumn
            // 
            this.корреспондирующийсчетDataGridViewTextBoxColumn.DataPropertyName = "Корреспондирующий_счет";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.HeaderText = "КОРРЕСПОН. СЧЕТ";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.Name = "корреспондирующийсчетDataGridViewTextBoxColumn";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сопроводительныйдокументDataGridViewTextBoxColumn
            // 
            this.сопроводительныйдокументDataGridViewTextBoxColumn.DataPropertyName = "Сопроводительный_документ";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.HeaderText = "СОПРОВОД. ДОКУМЕНТ";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.Name = "сопроводительныйдокументDataGridViewTextBoxColumn";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "СУММА";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FooterPanel.Location = new System.Drawing.Point(0, 345);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1296, 24);
            this.FooterPanel.TabIndex = 68;
            // 
            // MaterialsOrderDataGridView
            // 
            this.MaterialsOrderDataGridView.AllowUserToAddRows = false;
            this.MaterialsOrderDataGridView.AllowUserToDeleteRows = false;
            this.MaterialsOrderDataGridView.AutoGenerateColumns = false;
            this.MaterialsOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialsOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MaterialsOrderDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MaterialsOrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialsOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialsOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialsOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MaterialsOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialsOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатериальнойценностиDataGridViewTextBoxColumn,
            this.iDПриходногоордераDataGridViewTextBoxColumn1,
            this.iDТканиDataGridViewTextBoxColumn,
            this.iDМоделитканиDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммабезНДСDataGridViewTextBoxColumn,
            this.суммаНДСDataGridViewTextBoxColumn,
            this.всегосНДСDataGridViewTextBoxColumn});
            this.MaterialsOrderDataGridView.DataSource = this.fKМатериальIDПр0CDAE408BindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialsOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaterialsOrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsOrderDataGridView.EnableHeadersVisualStyles = false;
            this.MaterialsOrderDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.MaterialsOrderDataGridView.Location = new System.Drawing.Point(0, 369);
            this.MaterialsOrderDataGridView.Name = "MaterialsOrderDataGridView";
            this.MaterialsOrderDataGridView.ReadOnly = true;
            this.MaterialsOrderDataGridView.RowHeadersVisible = false;
            this.MaterialsOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialsOrderDataGridView.Size = new System.Drawing.Size(1296, 331);
            this.MaterialsOrderDataGridView.TabIndex = 69;
            this.MaterialsOrderDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MaterialsOrderDataGridView_DataBindingComplete);
            // 
            // iDМатериальнойценностиDataGridViewTextBoxColumn
            // 
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.DataPropertyName = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.HeaderText = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Name = "iDМатериальнойценностиDataGridViewTextBoxColumn";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDПриходногоордераDataGridViewTextBoxColumn1
            // 
            this.iDПриходногоордераDataGridViewTextBoxColumn1.DataPropertyName = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn1.HeaderText = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn1.Name = "iDПриходногоордераDataGridViewTextBoxColumn1";
            this.iDПриходногоордераDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDПриходногоордераDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDТканиDataGridViewTextBoxColumn
            // 
            this.iDТканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.HeaderText = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.Name = "iDТканиDataGridViewTextBoxColumn";
            this.iDТканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделитканиDataGridViewTextBoxColumn
            // 
            this.iDМоделитканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.HeaderText = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.Name = "iDМоделитканиDataGridViewTextBoxColumn";
            this.iDМоделитканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделитканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // материальныеценностиDataGridViewTextBoxColumn
            // 
            this.материальныеценностиDataGridViewTextBoxColumn.DataPropertyName = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.HeaderText = "МАТ. ЦЕННОСТИ";
            this.материальныеценностиDataGridViewTextBoxColumn.Name = "материальныеценностиDataGridViewTextBoxColumn";
            this.материальныеценностиDataGridViewTextBoxColumn.ReadOnly = true;
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
            // суммабезНДСDataGridViewTextBoxColumn
            // 
            this.суммабезНДСDataGridViewTextBoxColumn.DataPropertyName = "Сумма_без_НДС";
            this.суммабезНДСDataGridViewTextBoxColumn.HeaderText = "СУММА БЕЗ НДС";
            this.суммабезНДСDataGridViewTextBoxColumn.Name = "суммабезНДСDataGridViewTextBoxColumn";
            this.суммабезНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаНДСDataGridViewTextBoxColumn
            // 
            this.суммаНДСDataGridViewTextBoxColumn.DataPropertyName = "Сумма_НДС";
            this.суммаНДСDataGridViewTextBoxColumn.HeaderText = "СУММА НДС";
            this.суммаНДСDataGridViewTextBoxColumn.Name = "суммаНДСDataGridViewTextBoxColumn";
            this.суммаНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // всегосНДСDataGridViewTextBoxColumn
            // 
            this.всегосНДСDataGridViewTextBoxColumn.DataPropertyName = "Всего_с_НДС";
            this.всегосНДСDataGridViewTextBoxColumn.HeaderText = "ВСЕГО С НДС";
            this.всегосНДСDataGridViewTextBoxColumn.Name = "всегосНДСDataGridViewTextBoxColumn";
            this.всегосНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKМатериальIDПр0CDAE408BindingSource
            // 
            this.fKМатериальIDПр0CDAE408BindingSource.DataMember = "FK__Материаль__ID_Пр__0CDAE408";
            this.fKМатериальIDПр0CDAE408BindingSource.DataSource = this.приходныеордеранатканьBindingSource;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AutomationApp.Properties.Resources.pen_solid5;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // материальныеценностипоордерунатканьBindingSource
            // 
            this.материальныеценностипоордерунатканьBindingSource.DataMember = "Материальные_ценности_по_ордеру_на_ткань";
            this.материальныеценностипоордерунатканьBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // материальные_ценности_по_ордеру_на_тканьTableAdapter
            // 
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter.ClearBeforeFill = true;
            // 
            // ClothOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 700);
            this.Controls.Add(this.MaterialsOrderDataGridView);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.ClothOrdersDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Name = "ClothOrdersForm";
            this.Text = "ClothOrdersForm";
            this.Load += new System.EventHandler(this.ClothOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранатканьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothOrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр0CDAE408BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материальныеценностипоордерунатканьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource приходныеордеранатканьBindingSource;
        public AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter приходные_ордера_на_тканьTableAdapter;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddOrderButton;
        private System.Windows.Forms.DataGridView ClothOrdersDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.DataGridView MaterialsOrderDataGridView;
        public System.Windows.Forms.BindingSource материальныеценностипоордерунатканьBindingSource;
        public AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_тканьTableAdapter материальные_ценности_по_ордеру_на_тканьTableAdapter;
        public System.Windows.Forms.BindingSource fKМатериальIDПр0CDAE408BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериальнойценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПриходногоордераDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделитканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммабезНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегосНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПриходногоордераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасоставленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn складDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корреспондирующийсчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сопроводительныйдокументDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn PrintColumn;
    }
}