
namespace AutomationApp
{
    partial class RouteSheetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteSheetsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RouteSheetsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделиизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМаршрутноголистаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ростDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полнотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодцветаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.маршрутныелистыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddSheetButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.маршрутные_листыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSheetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутныелистыBindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RouteSheetsDataGridView);
            this.panel2.Controls.Add(this.TitleFoodPanel);
            this.panel2.Controls.Add(this.TopPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 539);
            this.panel2.TabIndex = 4;
            // 
            // RouteSheetsDataGridView
            // 
            this.RouteSheetsDataGridView.AllowUserToAddRows = false;
            this.RouteSheetsDataGridView.AllowUserToDeleteRows = false;
            this.RouteSheetsDataGridView.AutoGenerateColumns = false;
            this.RouteSheetsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RouteSheetsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RouteSheetsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RouteSheetsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RouteSheetsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RouteSheetsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteSheetsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RouteSheetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteSheetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИзделияDataGridViewTextBoxColumn,
            this.iDМоделиизделияDataGridViewTextBoxColumn,
            this.iDМаршрутноголистаDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельизделияDataGridViewTextBoxColumn,
            this.ростDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.полнотаDataGridViewTextBoxColumn,
            this.кодцветаDataGridViewTextBoxColumn,
            this.Status,
            this.EditColumn,
            this.DeleteColumn,
            this.PrintColumn});
            this.RouteSheetsDataGridView.DataSource = this.маршрутныелистыBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteSheetsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.RouteSheetsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RouteSheetsDataGridView.EnableHeadersVisualStyles = false;
            this.RouteSheetsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.RouteSheetsDataGridView.Location = new System.Drawing.Point(0, 118);
            this.RouteSheetsDataGridView.MultiSelect = false;
            this.RouteSheetsDataGridView.Name = "RouteSheetsDataGridView";
            this.RouteSheetsDataGridView.ReadOnly = true;
            this.RouteSheetsDataGridView.RowHeadersVisible = false;
            this.RouteSheetsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RouteSheetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RouteSheetsDataGridView.Size = new System.Drawing.Size(1430, 421);
            this.RouteSheetsDataGridView.TabIndex = 19;
            this.RouteSheetsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RouteSheetsDataGridView_CellContentClick);
            this.RouteSheetsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.маршрутные_листыDataGridView_CellMouseDoubleClick);
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
            // iDМаршрутноголистаDataGridViewTextBoxColumn
            // 
            this.iDМаршрутноголистаDataGridViewTextBoxColumn.DataPropertyName = "ID_Маршрутного_листа";
            this.iDМаршрутноголистаDataGridViewTextBoxColumn.HeaderText = "НОМЕР МАРШ. ЛИСТА";
            this.iDМаршрутноголистаDataGridViewTextBoxColumn.Name = "iDМаршрутноголистаDataGridViewTextBoxColumn";
            this.iDМаршрутноголистаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "НОМЕР ЗАКАЗА";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            this.номерзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "ИЗДЕЛИЕ";
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
            // ростDataGridViewTextBoxColumn
            // 
            this.ростDataGridViewTextBoxColumn.DataPropertyName = "Рост";
            this.ростDataGridViewTextBoxColumn.HeaderText = "РОСТ";
            this.ростDataGridViewTextBoxColumn.Name = "ростDataGridViewTextBoxColumn";
            this.ростDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "РАЗМЕР";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            this.размерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полнотаDataGridViewTextBoxColumn
            // 
            this.полнотаDataGridViewTextBoxColumn.DataPropertyName = "Полнота";
            this.полнотаDataGridViewTextBoxColumn.HeaderText = "ПОЛНОТА";
            this.полнотаDataGridViewTextBoxColumn.Name = "полнотаDataGridViewTextBoxColumn";
            this.полнотаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодцветаDataGridViewTextBoxColumn
            // 
            this.кодцветаDataGridViewTextBoxColumn.DataPropertyName = "Код_цвета";
            this.кодцветаDataGridViewTextBoxColumn.HeaderText = "КОД ЦВЕТА";
            this.кодцветаDataGridViewTextBoxColumn.Name = "кодцветаDataGridViewTextBoxColumn";
            this.кодцветаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "СТАТУС";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditColumn.Image")));
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
            this.DeleteColumn.Visible = false;
            // 
            // PrintColumn
            // 
            this.PrintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.PrintColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrintColumn.HeaderText = "";
            this.PrintColumn.Image = ((System.Drawing.Image)(resources.GetObject("PrintColumn.Image")));
            this.PrintColumn.Name = "PrintColumn";
            this.PrintColumn.ReadOnly = true;
            this.PrintColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrintColumn.Width = 34;
            // 
            // маршрутныелистыBindingSource
            // 
            this.маршрутныелистыBindingSource.DataMember = "Маршрутные_листы";
            this.маршрутныелистыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddSheetButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 18;
            // 
            // AddSheetButton
            // 
            this.AddSheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddSheetButton.FlatAppearance.BorderSize = 0;
            this.AddSheetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSheetButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddSheetButton.ForeColor = System.Drawing.Color.White;
            this.AddSheetButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddSheetButton.IconColor = System.Drawing.Color.White;
            this.AddSheetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddSheetButton.IconSize = 16;
            this.AddSheetButton.Location = new System.Drawing.Point(1231, 13);
            this.AddSheetButton.Name = "AddSheetButton";
            this.AddSheetButton.Size = new System.Drawing.Size(182, 39);
            this.AddSheetButton.TabIndex = 9;
            this.AddSheetButton.Text = "Добавить лист";
            this.AddSheetButton.UseVisualStyleBackColor = false;
            this.AddSheetButton.Click += new System.EventHandler(this.AddSheetButton_Click);
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
            this.SearchTextBox.Size = new System.Drawing.Size(1151, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.TopPanel.TabIndex = 17;
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
            this.MaximizedButton.TabIndex = 67;
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
            this.HideButton.TabIndex = 65;
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
            this.ExitButton.TabIndex = 66;
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
            this.label1.Size = new System.Drawing.Size(525, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите маршрутный лист двойным нажатием по строке с данными";
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
            // маршрутные_листыTableAdapter
            // 
            this.маршрутные_листыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::AutomationApp.Properties.Resources.print_solidTWO;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RouteSheetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 539);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RouteSheetsForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RouteSheetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутныелистыBindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.BindingSource маршрутныелистыBindingSource;
        public AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter маршрутные_листыTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.DataGridView RouteSheetsDataGridView;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddSheetButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделиизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМаршрутноголистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ростDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полнотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодцветаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn PrintColumn;
    }
}