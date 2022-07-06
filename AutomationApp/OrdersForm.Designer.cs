
namespace AutomationApp
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.приходные_ордера_на_фурнитуруBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.приходные_ордера_на_фурнитуруTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_фурнитуруTableAdapter();
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddIOrderButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.OrdersFurnitureDataGridView = new System.Windows.Forms.DataGridView();
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
            this.MaterialOrdersFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.fKМатериальIDПр1F63A897BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDМатериальнойценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПриходногоордераDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделифурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.приходные_ордера_на_фурнитуруBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersFurnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialOrdersFurnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1F63A897BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // приходные_ордера_на_фурнитуруBindingSource
            // 
            this.приходные_ордера_на_фурнитуруBindingSource.DataMember = "Приходные_ордера_на_фурнитуру";
            this.приходные_ордера_на_фурнитуруBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приходные_ордера_на_фурнитуруTableAdapter
            // 
            this.приходные_ордера_на_фурнитуруTableAdapter.ClearBeforeFill = true;
            // 
            // материальные_ценности_по_ордеру_на_фурнитуруTableAdapter
            // 
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.ClearBeforeFill = true;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddIOrderButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 7;
            // 
            // AddIOrderButton
            // 
            this.AddIOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddIOrderButton.FlatAppearance.BorderSize = 0;
            this.AddIOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddIOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIOrderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddIOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddIOrderButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddIOrderButton.IconColor = System.Drawing.Color.White;
            this.AddIOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddIOrderButton.IconSize = 16;
            this.AddIOrderButton.Location = new System.Drawing.Point(1231, 13);
            this.AddIOrderButton.Name = "AddIOrderButton";
            this.AddIOrderButton.Size = new System.Drawing.Size(182, 39);
            this.AddIOrderButton.TabIndex = 12;
            this.AddIOrderButton.Text = "Добавить ордер";
            this.AddIOrderButton.UseVisualStyleBackColor = false;
            this.AddIOrderButton.Click += new System.EventHandler(this.AddIOrderButton_Click);
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
            this.SearchIcon.TabIndex = 11;
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
            this.SearchTextBox.Size = new System.Drawing.Size(1151, 20);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // OrdersFurnitureDataGridView
            // 
            this.OrdersFurnitureDataGridView.AllowUserToAddRows = false;
            this.OrdersFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.OrdersFurnitureDataGridView.AutoGenerateColumns = false;
            this.OrdersFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OrdersFurnitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrdersFurnitureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersFurnitureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersFurnitureDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.OrdersFurnitureDataGridView.DataSource = this.приходные_ордера_на_фурнитуруBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersFurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrdersFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.OrdersFurnitureDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.OrdersFurnitureDataGridView.Location = new System.Drawing.Point(0, 67);
            this.OrdersFurnitureDataGridView.MultiSelect = false;
            this.OrdersFurnitureDataGridView.Name = "OrdersFurnitureDataGridView";
            this.OrdersFurnitureDataGridView.ReadOnly = true;
            this.OrdersFurnitureDataGridView.RowHeadersVisible = false;
            this.OrdersFurnitureDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrdersFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersFurnitureDataGridView.Size = new System.Drawing.Size(1430, 285);
            this.OrdersFurnitureDataGridView.TabIndex = 8;
            this.OrdersFurnitureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersFurnitureDataGridView_CellContentClick);
            this.OrdersFurnitureDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrdersFurnitureDataGridView_DataBindingComplete_1);
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
            this.датасоставленияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.датасоставленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_составления";
            this.датасоставленияDataGridViewTextBoxColumn.FillWeight = 109.6292F;
            this.датасоставленияDataGridViewTextBoxColumn.HeaderText = "ДАТА СОСТАВЛЕНИЯ";
            this.датасоставленияDataGridViewTextBoxColumn.Name = "датасоставленияDataGridViewTextBoxColumn";
            this.датасоставленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датасоставленияDataGridViewTextBoxColumn.Width = 200;
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.FillWeight = 3.282312F;
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "ПОСТАВЩИК";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            this.поставщикDataGridViewTextBoxColumn.ReadOnly = true;
            this.поставщикDataGridViewTextBoxColumn.Width = 210;
            // 
            // складDataGridViewTextBoxColumn
            // 
            this.складDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.складDataGridViewTextBoxColumn.DataPropertyName = "Склад";
            this.складDataGridViewTextBoxColumn.FillWeight = 3.282312F;
            this.складDataGridViewTextBoxColumn.HeaderText = "СКЛАД";
            this.складDataGridViewTextBoxColumn.Name = "складDataGridViewTextBoxColumn";
            this.складDataGridViewTextBoxColumn.ReadOnly = true;
            this.складDataGridViewTextBoxColumn.Width = 230;
            // 
            // корреспондирующийсчетDataGridViewTextBoxColumn
            // 
            this.корреспондирующийсчетDataGridViewTextBoxColumn.DataPropertyName = "Корреспондирующий_счет";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.FillWeight = 3.282312F;
            this.корреспондирующийсчетDataGridViewTextBoxColumn.HeaderText = "КОРРЕСПОН. СЧЕТ";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.Name = "корреспондирующийсчетDataGridViewTextBoxColumn";
            this.корреспондирующийсчетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сопроводительныйдокументDataGridViewTextBoxColumn
            // 
            this.сопроводительныйдокументDataGridViewTextBoxColumn.DataPropertyName = "Сопроводительный_документ";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.FillWeight = 3.282312F;
            this.сопроводительныйдокументDataGridViewTextBoxColumn.HeaderText = "СОПРОВОД. ДОКУМЕНТ";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.Name = "сопроводительныйдокументDataGridViewTextBoxColumn";
            this.сопроводительныйдокументDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.FillWeight = 3.282312F;
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
            this.FooterPanel.Location = new System.Drawing.Point(0, 352);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1430, 24);
            this.FooterPanel.TabIndex = 67;
            // 
            // MaterialOrdersFurnitureDataGridView
            // 
            this.MaterialOrdersFurnitureDataGridView.AllowUserToAddRows = false;
            this.MaterialOrdersFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.MaterialOrdersFurnitureDataGridView.AutoGenerateColumns = false;
            this.MaterialOrdersFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialOrdersFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MaterialOrdersFurnitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MaterialOrdersFurnitureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialOrdersFurnitureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialOrdersFurnitureDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialOrdersFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MaterialOrdersFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialOrdersFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатериальнойценностиDataGridViewTextBoxColumn,
            this.iDПриходногоордераDataGridViewTextBoxColumn1,
            this.iDМоделифурнитурыDataGridViewTextBoxColumn,
            this.iDФурнитурыDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn1});
            this.MaterialOrdersFurnitureDataGridView.DataSource = this.fKМатериальIDПр1F63A897BindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialOrdersFurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaterialOrdersFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialOrdersFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.MaterialOrdersFurnitureDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.MaterialOrdersFurnitureDataGridView.Location = new System.Drawing.Point(0, 376);
            this.MaterialOrdersFurnitureDataGridView.MultiSelect = false;
            this.MaterialOrdersFurnitureDataGridView.Name = "MaterialOrdersFurnitureDataGridView";
            this.MaterialOrdersFurnitureDataGridView.ReadOnly = true;
            this.MaterialOrdersFurnitureDataGridView.RowHeadersVisible = false;
            this.MaterialOrdersFurnitureDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MaterialOrdersFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialOrdersFurnitureDataGridView.Size = new System.Drawing.Size(1430, 279);
            this.MaterialOrdersFurnitureDataGridView.TabIndex = 68;
            this.MaterialOrdersFurnitureDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MaterialOrdersFurnitureDataGridView_DataBindingComplete);
            // 
            // fKМатериальIDПр1F63A897BindingSource
            // 
            this.fKМатериальIDПр1F63A897BindingSource.DataMember = "FK__Материаль__ID_Пр__1F63A897";
            this.fKМатериальIDПр1F63A897BindingSource.DataSource = this.приходные_ордера_на_фурнитуруBindingSource;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
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
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::AutomationApp.Properties.Resources.printTWO;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // iDМоделифурнитурыDataGridViewTextBoxColumn
            // 
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Name = "iDМоделифурнитурыDataGridViewTextBoxColumn";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDФурнитурыDataGridViewTextBoxColumn
            // 
            this.iDФурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_Фурнитуры";
            this.iDФурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_Фурнитуры";
            this.iDФурнитурыDataGridViewTextBoxColumn.Name = "iDФурнитурыDataGridViewTextBoxColumn";
            this.iDФурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDФурнитурыDataGridViewTextBoxColumn.Visible = false;
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
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "ЕД, ИЗМЕРЕНИЯ";
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
            // суммаDataGridViewTextBoxColumn1
            // 
            this.суммаDataGridViewTextBoxColumn1.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn1.HeaderText = "СУММА";
            this.суммаDataGridViewTextBoxColumn1.Name = "суммаDataGridViewTextBoxColumn1";
            this.суммаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 655);
            this.Controls.Add(this.MaterialOrdersFurnitureDataGridView);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.OrdersFurnitureDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Name = "OrdersForm";
            this.Text = "OrdersFurnitureForm";
            this.Load += new System.EventHandler(this.OrdersFurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.приходные_ордера_на_фурнитуруBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersFurnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialOrdersFurnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1F63A897BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource приходные_ордера_на_фурнитуруBindingSource;
        public AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_фурнитуруTableAdapter приходные_ордера_на_фурнитуруTableAdapter;
        public System.Windows.Forms.BindingSource fKМатериальIDПр1F63A897BindingSource;
        public AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter материальные_ценности_по_ордеру_на_фурнитуруTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddIOrderButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.DataGridView OrdersFurnitureDataGridView;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.DataGridView MaterialOrdersFurnitureDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериальнойценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПриходногоордераDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделифурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn1;
    }
}