
namespace AutomationApp
{
    partial class FurnitureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurnitureForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ФурнитураTableAdapter();
            this.tableAdapterManager = new AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager();
            this.модели_фурнитурыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_фурнитурыTableAdapter();
            this.модели_фурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ForeignKey_МоделиФурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddIFurnitureButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ModelFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.iDМоделифурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельфурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модели_фурнитурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignKey_МоделиФурнитурыBindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelFurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фурнитураBindingSource
            // 
            this.фурнитураBindingSource.DataMember = "Фурнитура";
            this.фурнитураBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // фурнитураTableAdapter
            // 
            this.фурнитураTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.БригадыTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Изделия_принятые_на_складTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = null;
            this.tableAdapterManager.Контрагенты_товарно_транспортной_накладнойTableAdapter = null;
            this.tableAdapterManager.Контрагенты_товарной_накладнойTableAdapter = null;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.Лимитно_заборные_картыTableAdapter = null;
            this.tableAdapterManager.Маршрутные_листыTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_тканьTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter = null;
            this.tableAdapterManager.Модели_изделияTableAdapter = null;
            this.tableAdapterManager.Модели_тканиTableAdapter = null;
            this.tableAdapterManager.Модели_фурнитурыTableAdapter = this.модели_фурнитурыTableAdapter;
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
            this.tableAdapterManager.ФурнитураTableAdapter = this.фурнитураTableAdapter;
            this.tableAdapterManager.ЦехаTableAdapter = null;
            // 
            // модели_фурнитурыTableAdapter
            // 
            this.модели_фурнитурыTableAdapter.ClearBeforeFill = true;
            // 
            // модели_фурнитурыBindingSource
            // 
            this.модели_фурнитурыBindingSource.DataMember = "Модели_фурнитуры";
            this.модели_фурнитурыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // ForeignKey_МоделиФурнитурыBindingSource
            // 
            this.ForeignKey_МоделиФурнитурыBindingSource.DataMember = "FK__Модели_фу__ID_Фу__756D6ECB";
            this.ForeignKey_МоделиФурнитурыBindingSource.DataSource = this.фурнитураBindingSource;
            // 
            // DataGridViewGrouper
            // 
            this.DataGridViewGrouper.Options = ((Subro.Controls.GroupingOptions)(resources.GetObject("DataGridViewGrouper.Options")));
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddIFurnitureButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 14;
            // 
            // AddIFurnitureButton
            // 
            this.AddIFurnitureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIFurnitureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddIFurnitureButton.FlatAppearance.BorderSize = 0;
            this.AddIFurnitureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddIFurnitureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIFurnitureButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddIFurnitureButton.ForeColor = System.Drawing.Color.White;
            this.AddIFurnitureButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddIFurnitureButton.IconColor = System.Drawing.Color.White;
            this.AddIFurnitureButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddIFurnitureButton.IconSize = 16;
            this.AddIFurnitureButton.Location = new System.Drawing.Point(1231, 13);
            this.AddIFurnitureButton.Name = "AddIFurnitureButton";
            this.AddIFurnitureButton.Size = new System.Drawing.Size(182, 39);
            this.AddIFurnitureButton.TabIndex = 12;
            this.AddIFurnitureButton.Text = "Добавить фурнитуру";
            this.AddIFurnitureButton.UseVisualStyleBackColor = false;
            this.AddIFurnitureButton.Click += new System.EventHandler(this.AddIFurnitureButton_Click);
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
            this.TopPanel.TabIndex = 15;
            this.TopPanel.Visible = false;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите фурнитуру двойным нажатием по строке с данными";
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
            // ModelFurnitureDataGridView
            // 
            this.ModelFurnitureDataGridView.AllowUserToAddRows = false;
            this.ModelFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.ModelFurnitureDataGridView.AutoGenerateColumns = false;
            this.ModelFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ModelFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ModelFurnitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ModelFurnitureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelFurnitureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ModelFurnitureDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModelFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ModelFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМоделифурнитурыDataGridViewTextBoxColumn,
            this.iDФурнитурыDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельфурнитурыDataGridViewTextBoxColumn,
            this.EditColumn});
            this.ModelFurnitureDataGridView.DataSource = this.модели_фурнитурыBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModelFurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.ModelFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.ModelFurnitureDataGridView.Location = new System.Drawing.Point(0, 118);
            this.ModelFurnitureDataGridView.Name = "ModelFurnitureDataGridView";
            this.ModelFurnitureDataGridView.ReadOnly = true;
            this.ModelFurnitureDataGridView.RowHeadersVisible = false;
            this.ModelFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelFurnitureDataGridView.Size = new System.Drawing.Size(1430, 421);
            this.ModelFurnitureDataGridView.TabIndex = 16;
            this.ModelFurnitureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelFurnitureDataGridView_CellContentClick);
            this.ModelFurnitureDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ModelFurnitureDataGridView_CellMouseDoubleClick);
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
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "НАИМЕНОВАНИЕ";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельфурнитурыDataGridViewTextBoxColumn
            // 
            this.модельфурнитурыDataGridViewTextBoxColumn.DataPropertyName = "Модель_фурнитуры";
            this.модельфурнитурыDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельфурнитурыDataGridViewTextBoxColumn.Name = "модельфурнитурыDataGridViewTextBoxColumn";
            this.модельфурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::AutomationApp.Properties.Resources.pen_solid5;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumn.Width = 34;
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
            // FurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 539);
            this.Controls.Add(this.ModelFurnitureDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FurnitureForm";
            this.Text = "FurnitureForm";
            this.Load += new System.EventHandler(this.FurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модели_фурнитурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignKey_МоделиФурнитурыBindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelFurnitureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AutomationAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource фурнитураBindingSource;
        public AutomationAppDBDataSetTableAdapters.ФурнитураTableAdapter фурнитураTableAdapter;
        public AutomationAppDBDataSetTableAdapters.Модели_фурнитурыTableAdapter модели_фурнитурыTableAdapter;
        public System.Windows.Forms.BindingSource модели_фурнитурыBindingSource;
        public System.Windows.Forms.BindingSource ForeignKey_МоделиФурнитурыBindingSource;
        private Subro.Controls.DataGridViewGrouper DataGridViewGrouper;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddIFurnitureButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView ModelFurnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделифурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельфурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}