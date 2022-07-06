
namespace AutomationApp
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.ИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ИзделияTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter();
            this.tableAdapterManager = new AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager();
            this.МоделиИзделияTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_изделияTableAdapter();
            this.МоделиИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            this.ForeignKey_МоделиИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddItemButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ModelDataGridView = new System.Windows.Forms.DataGridView();
            this.iDМоделиизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИзделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.МоделиИзделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignKey_МоделиИзделияBindingSource)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ИзделияBindingSource
            // 
            this.ИзделияBindingSource.DataMember = "Изделия";
            this.ИзделияBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // ИзделияTableAdapter
            // 
            this.ИзделияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.БригадыTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Изделия_принятые_на_складTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = this.ИзделияTableAdapter;
            this.tableAdapterManager.Контрагенты_товарно_транспортной_накладнойTableAdapter = null;
            this.tableAdapterManager.Контрагенты_товарной_накладнойTableAdapter = null;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.Лимитно_заборные_картыTableAdapter = null;
            this.tableAdapterManager.Маршрутные_листыTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_тканьTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter = null;
            this.tableAdapterManager.Модели_изделияTableAdapter = this.МоделиИзделияTableAdapter;
            this.tableAdapterManager.Модели_тканиTableAdapter = null;
            this.tableAdapterManager.Модели_фурнитурыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.Приходные_ордера_на_тканьTableAdapter = null;
            this.tableAdapterManager.Приходные_ордера_на_фурнитуруTableAdapter = null;
            this.tableAdapterManager.Расчётные_картыTableAdapter = null;
            this.tableAdapterManager.Склад_готовой_продукцииTableAdapter = null;
            this.tableAdapterManager.Склад_тканиTableAdapter = null;
            this.tableAdapterManager.Склад_фурнитурыTableAdapter = null;
            this.tableAdapterManager.ТканиTableAdapter = null;
            this.tableAdapterManager.Ткань_для_расчётной_картыTableAdapter = null;
            this.tableAdapterManager.Товарно_транспортные_накладныеTableAdapter = null;
            this.tableAdapterManager.Товарные_накладныеTableAdapter = null;
            this.tableAdapterManager.Товарный_раздел_товарно_транспортной_накладнойTableAdapter = null;
            this.tableAdapterManager.Товарный_раздел_товарной_накладнойTableAdapter = null;
            this.tableAdapterManager.Фурнитура_по_лимитно_заборной_картеTableAdapter = null;
            this.tableAdapterManager.ФурнитураTableAdapter = null;
            this.tableAdapterManager.ЦехаTableAdapter = null;
            // 
            // МоделиИзделияTableAdapter
            // 
            this.МоделиИзделияTableAdapter.ClearBeforeFill = true;
            // 
            // МоделиИзделияBindingSource
            // 
            this.МоделиИзделияBindingSource.DataMember = "Модели_изделия";
            this.МоделиИзделияBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // DataGridViewGrouper
            // 
            this.DataGridViewGrouper.Options = ((Subro.Controls.GroupingOptions)(resources.GetObject("DataGridViewGrouper.Options")));
            // 
            // ForeignKey_МоделиИзделияBindingSource
            // 
            this.ForeignKey_МоделиИзделияBindingSource.DataMember = "FK__Модели_из__Модел__38996AB5";
            this.ForeignKey_МоделиИзделияBindingSource.DataSource = this.ИзделияBindingSource;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.MaximizedButton);
            this.TopPanel.Controls.Add(this.HideButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.iconPictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1430, 51);
            this.TopPanel.TabIndex = 16;
            this.TopPanel.Visible = false;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // MaximizedButton
            // 
            this.MaximizedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizedButton.FlatAppearance.BorderSize = 0;
            this.MaximizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.MaximizedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.MaximizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizedButton.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.MaximizedButton.IconColor = System.Drawing.Color.Gray;
            this.MaximizedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizedButton.IconSize = 18;
            this.MaximizedButton.Location = new System.Drawing.Point(1346, 0);
            this.MaximizedButton.Name = "MaximizedButton";
            this.MaximizedButton.Size = new System.Drawing.Size(42, 34);
            this.MaximizedButton.TabIndex = 73;
            this.MaximizedButton.UseVisualStyleBackColor = false;
            this.MaximizedButton.Click += new System.EventHandler(this.MaximizedButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.HideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.HideButton.IconColor = System.Drawing.Color.Gray;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.IconSize = 18;
            this.HideButton.Location = new System.Drawing.Point(1304, -1);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(42, 35);
            this.HideButton.TabIndex = 71;
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 18;
            this.ExitButton.Location = new System.Drawing.Point(1388, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 72;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите изделие двойным нажатием по строке с данными";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(28, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 61;
            this.iconPictureBox1.TabStop = false;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddItemButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 18;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddItemButton.FlatAppearance.BorderSize = 0;
            this.AddItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddItemButton.IconColor = System.Drawing.Color.White;
            this.AddItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddItemButton.IconSize = 16;
            this.AddItemButton.Location = new System.Drawing.Point(1231, 13);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(182, 39);
            this.AddItemButton.TabIndex = 12;
            this.AddItemButton.Text = "Добавить изделие";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
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
            // ModelDataGridView
            // 
            this.ModelDataGridView.AllowUserToAddRows = false;
            this.ModelDataGridView.AllowUserToDeleteRows = false;
            this.ModelDataGridView.AutoGenerateColumns = false;
            this.ModelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ModelDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ModelDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ModelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ModelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМоделиизделияDataGridViewTextBoxColumn,
            this.iDИзделияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельизделияDataGridViewTextBoxColumn,
            this.EditColumn});
            this.ModelDataGridView.DataSource = this.МоделиИзделияBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModelDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelDataGridView.EnableHeadersVisualStyles = false;
            this.ModelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ModelDataGridView.Location = new System.Drawing.Point(0, 118);
            this.ModelDataGridView.Name = "ModelDataGridView";
            this.ModelDataGridView.ReadOnly = true;
            this.ModelDataGridView.RowHeadersVisible = false;
            this.ModelDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelDataGridView.Size = new System.Drawing.Size(1430, 421);
            this.ModelDataGridView.TabIndex = 19;
            this.ModelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelDataGridView_CellContentClick);
            this.ModelDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ModelDataGridView_CellMouseDoubleClick);
            // 
            // iDМоделиизделияDataGridViewTextBoxColumn
            // 
            this.iDМоделиизделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.HeaderText = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.Name = "iDМоделиизделияDataGridViewTextBoxColumn";
            this.iDМоделиизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделиизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDИзделияDataGridViewTextBoxColumn
            // 
            this.iDИзделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.Name = "iDИзделияDataGridViewTextBoxColumn";
            this.iDИзделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDИзделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "НАИМЕНОВАНИЕ";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельизделияDataGridViewTextBoxColumn
            // 
            this.модельизделияDataGridViewTextBoxColumn.DataPropertyName = "Модель_изделия";
            this.модельизделияDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельизделияDataGridViewTextBoxColumn.Name = "модельизделияDataGridViewTextBoxColumn";
            this.модельизделияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::AutomationApp.Properties.Resources.pen_solid5;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumn.Width = 34;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 539);
            this.Controls.Add(this.ModelDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИзделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.МоделиИзделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignKey_МоделиИзделияBindingSource)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AutomationAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource ИзделияBindingSource;
        public AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter ИзделияTableAdapter;
        public AutomationAppDBDataSetTableAdapters.Модели_изделияTableAdapter МоделиИзделияTableAdapter;
        public System.Windows.Forms.BindingSource МоделиИзделияBindingSource;
        public System.Windows.Forms.BindingSource ForeignKey_МоделиИзделияBindingSource;
        private Subro.Controls.DataGridViewGrouper DataGridViewGrouper;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddItemButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.DataGridView ModelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделиизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}