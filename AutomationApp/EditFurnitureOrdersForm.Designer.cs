
namespace AutomationApp
{
    partial class EditOrdersForm
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.поставщикиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ПоставщикиTableAdapter();
            this.приходныеордеранафурнитуруBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приходные_ордера_на_фурнитуруTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_фурнитуруTableAdapter();
            this.fKМатериальIDПр1F63A897BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter();
            this.материальныеценностипоордерунафурнитуруBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.склад_фурнитурыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.CorrespondingLabel = new System.Windows.Forms.Label();
            this.CorrespondingAccountTextBox = new JMetroTextBox.JMetroTextBox();
            this.CorrespondingErrorLabel = new System.Windows.Forms.Label();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FollowLabel = new System.Windows.Forms.Label();
            this.SumOrderTextBox = new JMetroTextBox.JMetroTextBox();
            this.FollowDocumentTextBox = new JMetroTextBox.JMetroTextBox();
            this.WarehouseLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.ProviderTextBox = new JMetroTextBox.JMetroTextBox();
            this.FollowErrorLabel = new System.Windows.Forms.Label();
            this.WarehouseErrorLabel = new System.Windows.Forms.Label();
            this.ProviderErrorLabel = new System.Windows.Forms.Label();
            this.WarehouseTextBox = new JMetroTextBox.JMetroTextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MaterialsOrderFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.iDМатериальнойценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделифурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПриходногоордераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddFurnitureButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FurnitureLabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранафурнитуруBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1F63A897BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материальныеценностипоордерунафурнитуруBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsOrderFurnitureDataGridView)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(27, 108);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(283, 24);
            this.DateTimePicker.TabIndex = 2;
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveItemButton.FlatAppearance.BorderSize = 0;
            this.SaveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveItemButton.ForeColor = System.Drawing.Color.White;
            this.SaveItemButton.Location = new System.Drawing.Point(1082, 102);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(182, 39);
            this.SaveItemButton.TabIndex = 34;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // приходныеордеранафурнитуруBindingSource
            // 
            this.приходныеордеранафурнитуруBindingSource.DataMember = "Приходные_ордера_на_фурнитуру";
            this.приходныеордеранафурнитуруBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // приходные_ордера_на_фурнитуруTableAdapter
            // 
            this.приходные_ордера_на_фурнитуруTableAdapter.ClearBeforeFill = true;
            // 
            // fKМатериальIDПр1F63A897BindingSource
            // 
            this.fKМатериальIDПр1F63A897BindingSource.DataMember = "FK__Материаль__ID_Пр__1F63A897";
            this.fKМатериальIDПр1F63A897BindingSource.DataSource = this.приходныеордеранафурнитуруBindingSource;
            // 
            // материальные_ценности_по_ордеру_на_фурнитуруTableAdapter
            // 
            this.материальные_ценности_по_ордеру_на_фурнитуруTableAdapter.ClearBeforeFill = true;
            // 
            // материальныеценностипоордерунафурнитуруBindingSource
            // 
            this.материальныеценностипоордерунафурнитуруBindingSource.DataMember = "Материальные_ценности_по_ордеру_на_фурнитуру";
            this.материальныеценностипоордерунафурнитуруBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Склад_фурнитуры";
            this.bindingSource1.DataSource = this.automationAppDBDataSet;
            // 
            // склад_фурнитурыTableAdapter
            // 
            this.склад_фурнитурыTableAdapter.ClearBeforeFill = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.iconPictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1291, 51);
            this.TopPanel.TabIndex = 61;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
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
            this.CloseButton.Location = new System.Drawing.Point(1223, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 59;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Добавление приходного ордера";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 18;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(18, 18);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 58;
            this.iconPictureBox1.TabStop = false;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DataLabel.ForeColor = System.Drawing.Color.Gray;
            this.DataLabel.Location = new System.Drawing.Point(25, 78);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(124, 19);
            this.DataLabel.TabIndex = 79;
            this.DataLabel.Text = "Дата составления";
            // 
            // CorrespondingLabel
            // 
            this.CorrespondingLabel.AutoSize = true;
            this.CorrespondingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CorrespondingLabel.ForeColor = System.Drawing.Color.Gray;
            this.CorrespondingLabel.Location = new System.Drawing.Point(25, 184);
            this.CorrespondingLabel.Name = "CorrespondingLabel";
            this.CorrespondingLabel.Size = new System.Drawing.Size(182, 19);
            this.CorrespondingLabel.TabIndex = 90;
            this.CorrespondingLabel.Text = "Корреспондирующий счет";
            // 
            // CorrespondingAccountTextBox
            // 
            this.CorrespondingAccountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CorrespondingAccountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CorrespondingAccountTextBox.BorderRadius = 2;
            this.CorrespondingAccountTextBox.FillColor = System.Drawing.Color.White;
            this.CorrespondingAccountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorrespondingAccountTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorrespondingAccountTextBox.ForeColors = System.Drawing.Color.Black;
            this.CorrespondingAccountTextBox.IsPassword = false;
            this.CorrespondingAccountTextBox.LineThickness = 1;
            this.CorrespondingAccountTextBox.Location = new System.Drawing.Point(26, 207);
            this.CorrespondingAccountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CorrespondingAccountTextBox.MaxLength = 32767;
            this.CorrespondingAccountTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.Name = "CorrespondingAccountTextBox";
            this.CorrespondingAccountTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CorrespondingAccountTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.ReadOnly = false;
            this.CorrespondingAccountTextBox.Size = new System.Drawing.Size(284, 41);
            this.CorrespondingAccountTextBox.TabIndex = 89;
            this.CorrespondingAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CorrespondingAccountTextBox.TextName = "";
            this.CorrespondingAccountTextBox.Enter += new System.EventHandler(this.CorrespondingAccountTextBox_Enter);
            this.CorrespondingAccountTextBox.Leave += new System.EventHandler(this.CorrespondingAccountTextBox_Leave);
            // 
            // CorrespondingErrorLabel
            // 
            this.CorrespondingErrorLabel.AutoSize = true;
            this.CorrespondingErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrespondingErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CorrespondingErrorLabel.Location = new System.Drawing.Point(26, 252);
            this.CorrespondingErrorLabel.Name = "CorrespondingErrorLabel";
            this.CorrespondingErrorLabel.Size = new System.Drawing.Size(140, 16);
            this.CorrespondingErrorLabel.TabIndex = 88;
            this.CorrespondingErrorLabel.Text = "Введите данные о счете";
            this.CorrespondingErrorLabel.Visible = false;
            // 
            // SelectButton
            // 
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectButton.IconSize = 40;
            this.SelectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectButton.Location = new System.Drawing.Point(668, 103);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(53, 39);
            this.SelectButton.TabIndex = 102;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(763, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 100;
            this.label2.Text = "Сумма";
            // 
            // FollowLabel
            // 
            this.FollowLabel.AutoSize = true;
            this.FollowLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.FollowLabel.ForeColor = System.Drawing.Color.Gray;
            this.FollowLabel.Location = new System.Drawing.Point(381, 185);
            this.FollowLabel.Name = "FollowLabel";
            this.FollowLabel.Size = new System.Drawing.Size(201, 19);
            this.FollowLabel.TabIndex = 99;
            this.FollowLabel.Text = "Сопроводительный документ";
            // 
            // SumOrderTextBox
            // 
            this.SumOrderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumOrderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumOrderTextBox.BorderRadius = 2;
            this.SumOrderTextBox.FillColor = System.Drawing.Color.White;
            this.SumOrderTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumOrderTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumOrderTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumOrderTextBox.IsPassword = false;
            this.SumOrderTextBox.LineThickness = 1;
            this.SumOrderTextBox.Location = new System.Drawing.Point(763, 207);
            this.SumOrderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumOrderTextBox.MaxLength = 32767;
            this.SumOrderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumOrderTextBox.Name = "SumOrderTextBox";
            this.SumOrderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumOrderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumOrderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumOrderTextBox.ReadOnly = true;
            this.SumOrderTextBox.Size = new System.Drawing.Size(284, 41);
            this.SumOrderTextBox.TabIndex = 98;
            this.SumOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumOrderTextBox.TextName = "";
            // 
            // FollowDocumentTextBox
            // 
            this.FollowDocumentTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FollowDocumentTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.FollowDocumentTextBox.BorderRadius = 2;
            this.FollowDocumentTextBox.FillColor = System.Drawing.Color.White;
            this.FollowDocumentTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FollowDocumentTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FollowDocumentTextBox.ForeColors = System.Drawing.Color.Black;
            this.FollowDocumentTextBox.IsPassword = false;
            this.FollowDocumentTextBox.LineThickness = 1;
            this.FollowDocumentTextBox.Location = new System.Drawing.Point(382, 207);
            this.FollowDocumentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FollowDocumentTextBox.MaxLength = 32767;
            this.FollowDocumentTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.Name = "FollowDocumentTextBox";
            this.FollowDocumentTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.FollowDocumentTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.ReadOnly = false;
            this.FollowDocumentTextBox.Size = new System.Drawing.Size(284, 41);
            this.FollowDocumentTextBox.TabIndex = 97;
            this.FollowDocumentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FollowDocumentTextBox.TextName = "";
            this.FollowDocumentTextBox.Enter += new System.EventHandler(this.FollowDocumentTextBox_Enter);
            this.FollowDocumentTextBox.Leave += new System.EventHandler(this.FollowDocumentTextBox_Leave);
            // 
            // WarehouseLabel
            // 
            this.WarehouseLabel.AutoSize = true;
            this.WarehouseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.WarehouseLabel.ForeColor = System.Drawing.Color.Gray;
            this.WarehouseLabel.Location = new System.Drawing.Point(763, 78);
            this.WarehouseLabel.Name = "WarehouseLabel";
            this.WarehouseLabel.Size = new System.Drawing.Size(48, 19);
            this.WarehouseLabel.TabIndex = 95;
            this.WarehouseLabel.Text = "Склад";
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ProviderLabel.ForeColor = System.Drawing.Color.Gray;
            this.ProviderLabel.Location = new System.Drawing.Point(381, 78);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(82, 19);
            this.ProviderLabel.TabIndex = 96;
            this.ProviderLabel.Text = "Поставщик";
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ProviderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ProviderTextBox.BorderRadius = 2;
            this.ProviderTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.ProviderTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProviderTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProviderTextBox.ForeColors = System.Drawing.Color.Black;
            this.ProviderTextBox.IsPassword = false;
            this.ProviderTextBox.LineThickness = 1;
            this.ProviderTextBox.Location = new System.Drawing.Point(382, 101);
            this.ProviderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProviderTextBox.MaxLength = 32767;
            this.ProviderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProviderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.ReadOnly = true;
            this.ProviderTextBox.Size = new System.Drawing.Size(284, 41);
            this.ProviderTextBox.TabIndex = 94;
            this.ProviderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProviderTextBox.TextName = "";
            // 
            // FollowErrorLabel
            // 
            this.FollowErrorLabel.AutoSize = true;
            this.FollowErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FollowErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FollowErrorLabel.Location = new System.Drawing.Point(382, 252);
            this.FollowErrorLabel.Name = "FollowErrorLabel";
            this.FollowErrorLabel.Size = new System.Drawing.Size(168, 16);
            this.FollowErrorLabel.TabIndex = 93;
            this.FollowErrorLabel.Text = "Введите данные о документе";
            this.FollowErrorLabel.Visible = false;
            // 
            // WarehouseErrorLabel
            // 
            this.WarehouseErrorLabel.AutoSize = true;
            this.WarehouseErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WarehouseErrorLabel.Location = new System.Drawing.Point(765, 147);
            this.WarehouseErrorLabel.Name = "WarehouseErrorLabel";
            this.WarehouseErrorLabel.Size = new System.Drawing.Size(147, 16);
            this.WarehouseErrorLabel.TabIndex = 92;
            this.WarehouseErrorLabel.Text = "Введите данные о складе";
            this.WarehouseErrorLabel.Visible = false;
            // 
            // ProviderErrorLabel
            // 
            this.ProviderErrorLabel.AutoSize = true;
            this.ProviderErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProviderErrorLabel.Location = new System.Drawing.Point(382, 146);
            this.ProviderErrorLabel.Name = "ProviderErrorLabel";
            this.ProviderErrorLabel.Size = new System.Drawing.Size(131, 16);
            this.ProviderErrorLabel.TabIndex = 91;
            this.ProviderErrorLabel.Text = "Выберите поставщика";
            this.ProviderErrorLabel.Visible = false;
            // 
            // WarehouseTextBox
            // 
            this.WarehouseTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WarehouseTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.WarehouseTextBox.BorderRadius = 2;
            this.WarehouseTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.WarehouseTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WarehouseTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WarehouseTextBox.ForeColors = System.Drawing.Color.Black;
            this.WarehouseTextBox.IsPassword = false;
            this.WarehouseTextBox.LineThickness = 1;
            this.WarehouseTextBox.Location = new System.Drawing.Point(763, 101);
            this.WarehouseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WarehouseTextBox.MaxLength = 32767;
            this.WarehouseTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.WarehouseTextBox.Name = "WarehouseTextBox";
            this.WarehouseTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.WarehouseTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.WarehouseTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.WarehouseTextBox.ReadOnly = false;
            this.WarehouseTextBox.Size = new System.Drawing.Size(284, 41);
            this.WarehouseTextBox.TabIndex = 101;
            this.WarehouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WarehouseTextBox.TextName = "";
            this.WarehouseTextBox.Enter += new System.EventHandler(this.WarehouseTextBox_Enter);
            this.WarehouseTextBox.Leave += new System.EventHandler(this.WarehouseTextBox_Leave);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FooterPanel.Location = new System.Drawing.Point(0, 315);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1291, 24);
            this.FooterPanel.TabIndex = 103;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MaterialsOrderFurnitureDataGridView);
            this.MainPanel.Controls.Add(this.TitleFoodPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 340);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1291, 393);
            this.MainPanel.TabIndex = 105;
            // 
            // MaterialsOrderFurnitureDataGridView
            // 
            this.MaterialsOrderFurnitureDataGridView.AllowUserToAddRows = false;
            this.MaterialsOrderFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.MaterialsOrderFurnitureDataGridView.AutoGenerateColumns = false;
            this.MaterialsOrderFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialsOrderFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MaterialsOrderFurnitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MaterialsOrderFurnitureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialsOrderFurnitureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialsOrderFurnitureDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialsOrderFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialsOrderFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialsOrderFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатериальнойценностиDataGridViewTextBoxColumn,
            this.iDМоделифурнитурыDataGridViewTextBoxColumn,
            this.iDПриходногоордераDataGridViewTextBoxColumn,
            this.iDФурнитурыDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.MaterialsOrderFurnitureDataGridView.DataSource = this.fKМатериальIDПр1F63A897BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialsOrderFurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaterialsOrderFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsOrderFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.MaterialsOrderFurnitureDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.MaterialsOrderFurnitureDataGridView.Location = new System.Drawing.Point(0, 67);
            this.MaterialsOrderFurnitureDataGridView.Name = "MaterialsOrderFurnitureDataGridView";
            this.MaterialsOrderFurnitureDataGridView.ReadOnly = true;
            this.MaterialsOrderFurnitureDataGridView.RowHeadersVisible = false;
            this.MaterialsOrderFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialsOrderFurnitureDataGridView.Size = new System.Drawing.Size(1291, 326);
            this.MaterialsOrderFurnitureDataGridView.TabIndex = 106;
            // 
            // iDМатериальнойценностиDataGridViewTextBoxColumn
            // 
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.DataPropertyName = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.HeaderText = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Name = "iDМатериальнойценностиDataGridViewTextBoxColumn";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделифурнитурыDataGridViewTextBoxColumn
            // 
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Name = "iDМоделифурнитурыDataGridViewTextBoxColumn";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDПриходногоордераDataGridViewTextBoxColumn
            // 
            this.iDПриходногоордераDataGridViewTextBoxColumn.DataPropertyName = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.HeaderText = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.Name = "iDПриходногоордераDataGridViewTextBoxColumn";
            this.iDПриходногоордераDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПриходногоордераDataGridViewTextBoxColumn.Visible = false;
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
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddFurnitureButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1291, 67);
            this.TitleFoodPanel.TabIndex = 105;
            // 
            // AddFurnitureButton
            // 
            this.AddFurnitureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFurnitureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddFurnitureButton.FlatAppearance.BorderSize = 0;
            this.AddFurnitureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddFurnitureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFurnitureButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddFurnitureButton.ForeColor = System.Drawing.Color.White;
            this.AddFurnitureButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddFurnitureButton.IconColor = System.Drawing.Color.White;
            this.AddFurnitureButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddFurnitureButton.IconSize = 16;
            this.AddFurnitureButton.Location = new System.Drawing.Point(1082, 13);
            this.AddFurnitureButton.Name = "AddFurnitureButton";
            this.AddFurnitureButton.Size = new System.Drawing.Size(182, 39);
            this.AddFurnitureButton.TabIndex = 9;
            this.AddFurnitureButton.Text = "Добавить фурнитуру";
            this.AddFurnitureButton.UseVisualStyleBackColor = false;
            this.AddFurnitureButton.Click += new System.EventHandler(this.AddFurnitureButton_Click_1);
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
            this.SearchTextBox.Size = new System.Drawing.Size(1002, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FurnitureLabelError
            // 
            this.FurnitureLabelError.AutoSize = true;
            this.FurnitureLabelError.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FurnitureLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FurnitureLabelError.Location = new System.Drawing.Point(26, 289);
            this.FurnitureLabelError.Name = "FurnitureLabelError";
            this.FurnitureLabelError.Size = new System.Drawing.Size(276, 16);
            this.FurnitureLabelError.TabIndex = 107;
            this.FurnitureLabelError.Text = "Введите данные о ткани для приходного ордера";
            this.FurnitureLabelError.Visible = false;
            // 
            // EditOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 745);
            this.Controls.Add(this.FurnitureLabelError);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FollowLabel);
            this.Controls.Add(this.SumOrderTextBox);
            this.Controls.Add(this.FollowDocumentTextBox);
            this.Controls.Add(this.WarehouseLabel);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.FollowErrorLabel);
            this.Controls.Add(this.WarehouseErrorLabel);
            this.Controls.Add(this.ProviderErrorLabel);
            this.Controls.Add(this.WarehouseTextBox);
            this.Controls.Add(this.CorrespondingLabel);
            this.Controls.Add(this.CorrespondingAccountTextBox);
            this.Controls.Add(this.CorrespondingErrorLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.DateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditOrdersFurnitureForm";
            this.Load += new System.EventHandler(this.EditOrdersFurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранафурнитуруBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1F63A897BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материальныеценностипоордерунафурнитуруBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsOrderFurnitureDataGridView)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button SaveItemButton;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource поставщикиBindingSource;
        public AutomationAppDBDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        public System.Windows.Forms.BindingSource приходныеордеранафурнитуруBindingSource;
        public AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_фурнитуруTableAdapter приходные_ордера_на_фурнитуруTableAdapter;
        public System.Windows.Forms.BindingSource fKМатериальIDПр1F63A897BindingSource;
        public AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter материальные_ценности_по_ордеру_на_фурнитуруTableAdapter;
        private System.Windows.Forms.BindingSource материальныеценностипоордерунафурнитуруBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter склад_фурнитурыTableAdapter;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label CorrespondingLabel;
        private JMetroTextBox.JMetroTextBox CorrespondingAccountTextBox;
        private System.Windows.Forms.Label CorrespondingErrorLabel;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FollowLabel;
        private JMetroTextBox.JMetroTextBox SumOrderTextBox;
        private JMetroTextBox.JMetroTextBox FollowDocumentTextBox;
        private System.Windows.Forms.Label WarehouseLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private JMetroTextBox.JMetroTextBox ProviderTextBox;
        private System.Windows.Forms.Label FollowErrorLabel;
        private System.Windows.Forms.Label WarehouseErrorLabel;
        private System.Windows.Forms.Label ProviderErrorLabel;
        private JMetroTextBox.JMetroTextBox WarehouseTextBox;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddFurnitureButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label FurnitureLabelError;
        public System.Windows.Forms.DataGridView MaterialsOrderFurnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериальнойценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделифурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПриходногоордераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}