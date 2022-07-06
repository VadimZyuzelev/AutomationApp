
namespace AutomationApp
{
    partial class EditFurnitureInOrderForm
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
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.fKМоделифуIDФу756D6ECBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ФурнитураTableAdapter();
            this.модели_фурнитурыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_фурнитурыTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.FurnitureLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.DeterminationLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.UnitDeterminationTextBox = new JMetroTextBox.JMetroTextBox();
            this.SumWithoutNDS = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CounLabel = new System.Windows.Forms.Label();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.CountErrorLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new JMetroTextBox.JMetroTextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CountBorder = new JMetroTextBox.JMetroTextBox();
            this.PriceBorder = new JMetroTextBox.JMetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделифуIDФу756D6ECBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // фурнитураBindingSource
            // 
            this.фурнитураBindingSource.DataMember = "Фурнитура";
            this.фурнитураBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(152, 401);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(120, 39);
            this.CancelAddButton.TabIndex = 35;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveItemButton.FlatAppearance.BorderSize = 0;
            this.SaveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveItemButton.ForeColor = System.Drawing.Color.White;
            this.SaveItemButton.Location = new System.Drawing.Point(28, 401);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(122, 39);
            this.SaveItemButton.TabIndex = 36;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // fKМоделифуIDФу756D6ECBBindingSource
            // 
            this.fKМоделифуIDФу756D6ECBBindingSource.DataMember = "FK__Модели_фу__ID_Фу__756D6ECB";
            this.fKМоделифуIDФу756D6ECBBindingSource.DataSource = this.фурнитураBindingSource;
            // 
            // фурнитураTableAdapter
            // 
            this.фурнитураTableAdapter.ClearBeforeFill = true;
            // 
            // модели_фурнитурыTableAdapter
            // 
            this.модели_фурнитурыTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(49, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(402, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Добавление данных о фурнитуре в приходный ордер";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 18;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(18, 18);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 61;
            this.iconPictureBox1.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.label8);
            this.TitlePanel.Controls.Add(this.iconPictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(629, 51);
            this.TitlePanel.TabIndex = 65;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
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
            this.CloseButton.Location = new System.Drawing.Point(564, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
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
            this.SelectButton.Location = new System.Drawing.Point(276, 103);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(51, 39);
            this.SelectButton.TabIndex = 95;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FurnitureLabel
            // 
            this.FurnitureLabel.AutoSize = true;
            this.FurnitureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.FurnitureLabel.ForeColor = System.Drawing.Color.Gray;
            this.FurnitureLabel.Location = new System.Drawing.Point(24, 79);
            this.FurnitureLabel.Name = "FurnitureLabel";
            this.FurnitureLabel.Size = new System.Drawing.Size(105, 19);
            this.FurnitureLabel.TabIndex = 94;
            this.FurnitureLabel.Text = "Наименование";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(95, 16);
            this.NameErrorLabel.TabIndex = 93;
            this.NameErrorLabel.Text = "Выберите ткань";
            this.NameErrorLabel.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NameTextBox.BorderRadius = 2;
            this.NameTextBox.FillColor = System.Drawing.Color.White;
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.ForeColors = System.Drawing.Color.Black;
            this.NameTextBox.IsPassword = false;
            this.NameTextBox.LineThickness = 1;
            this.NameTextBox.Location = new System.Drawing.Point(24, 103);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NameTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(251, 41);
            this.NameTextBox.TabIndex = 92;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            // 
            // DeterminationLabel
            // 
            this.DeterminationLabel.AutoSize = true;
            this.DeterminationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DeterminationLabel.ForeColor = System.Drawing.Color.Gray;
            this.DeterminationLabel.Location = new System.Drawing.Point(25, 282);
            this.DeterminationLabel.Name = "DeterminationLabel";
            this.DeterminationLabel.Size = new System.Drawing.Size(137, 19);
            this.DeterminationLabel.TabIndex = 100;
            this.DeterminationLabel.Text = "Единица измерения";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(25, 179);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 101;
            this.ModelLabel.Text = "Модель";
            // 
            // ModelErrorLabel
            // 
            this.ModelErrorLabel.AutoSize = true;
            this.ModelErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelErrorLabel.Location = new System.Drawing.Point(26, 246);
            this.ModelErrorLabel.Name = "ModelErrorLabel";
            this.ModelErrorLabel.Size = new System.Drawing.Size(105, 16);
            this.ModelErrorLabel.TabIndex = 98;
            this.ModelErrorLabel.Text = "Выберите модель";
            this.ModelErrorLabel.Visible = false;
            // 
            // DeterminationErrorLabel
            // 
            this.DeterminationErrorLabel.AutoSize = true;
            this.DeterminationErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminationErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeterminationErrorLabel.Location = new System.Drawing.Point(26, 350);
            this.DeterminationErrorLabel.Name = "DeterminationErrorLabel";
            this.DeterminationErrorLabel.Size = new System.Drawing.Size(164, 16);
            this.DeterminationErrorLabel.TabIndex = 99;
            this.DeterminationErrorLabel.Text = "Введите единицу измерения";
            this.DeterminationErrorLabel.Visible = false;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ModelTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ModelTextBox.BorderRadius = 2;
            this.ModelTextBox.FillColor = System.Drawing.Color.White;
            this.ModelTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.ForeColors = System.Drawing.Color.Black;
            this.ModelTextBox.IsPassword = false;
            this.ModelTextBox.LineThickness = 1;
            this.ModelTextBox.Location = new System.Drawing.Point(24, 201);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(251, 41);
            this.ModelTextBox.TabIndex = 96;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // UnitDeterminationTextBox
            // 
            this.UnitDeterminationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UnitDeterminationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.UnitDeterminationTextBox.BorderRadius = 2;
            this.UnitDeterminationTextBox.FillColor = System.Drawing.Color.White;
            this.UnitDeterminationTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnitDeterminationTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnitDeterminationTextBox.ForeColors = System.Drawing.Color.Black;
            this.UnitDeterminationTextBox.IsPassword = false;
            this.UnitDeterminationTextBox.LineThickness = 1;
            this.UnitDeterminationTextBox.Location = new System.Drawing.Point(24, 305);
            this.UnitDeterminationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnitDeterminationTextBox.MaxLength = 32767;
            this.UnitDeterminationTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.Name = "UnitDeterminationTextBox";
            this.UnitDeterminationTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitDeterminationTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.ReadOnly = false;
            this.UnitDeterminationTextBox.Size = new System.Drawing.Size(251, 41);
            this.UnitDeterminationTextBox.TabIndex = 97;
            this.UnitDeterminationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UnitDeterminationTextBox.TextName = "";
            // 
            // SumWithoutNDS
            // 
            this.SumWithoutNDS.AutoSize = true;
            this.SumWithoutNDS.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumWithoutNDS.ForeColor = System.Drawing.Color.Gray;
            this.SumWithoutNDS.Location = new System.Drawing.Point(354, 282);
            this.SumWithoutNDS.Name = "SumWithoutNDS";
            this.SumWithoutNDS.Size = new System.Drawing.Size(52, 19);
            this.SumWithoutNDS.TabIndex = 107;
            this.SumWithoutNDS.Text = "Сумма";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.PriceLabel.ForeColor = System.Drawing.Color.Gray;
            this.PriceLabel.Location = new System.Drawing.Point(354, 179);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(42, 19);
            this.PriceLabel.TabIndex = 108;
            this.PriceLabel.Text = "Цена";
            // 
            // CounLabel
            // 
            this.CounLabel.AutoSize = true;
            this.CounLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CounLabel.ForeColor = System.Drawing.Color.Gray;
            this.CounLabel.Location = new System.Drawing.Point(354, 81);
            this.CounLabel.Name = "CounLabel";
            this.CounLabel.Size = new System.Drawing.Size(85, 19);
            this.CounLabel.TabIndex = 109;
            this.CounLabel.Text = "Количество";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PriceErrorLabel.Location = new System.Drawing.Point(355, 246);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(81, 16);
            this.PriceErrorLabel.TabIndex = 105;
            this.PriceErrorLabel.Text = "Введите цену";
            this.PriceErrorLabel.Visible = false;
            // 
            // CountErrorLabel
            // 
            this.CountErrorLabel.AutoSize = true;
            this.CountErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorLabel.Location = new System.Drawing.Point(355, 148);
            this.CountErrorLabel.Name = "CountErrorLabel";
            this.CountErrorLabel.Size = new System.Drawing.Size(118, 16);
            this.CountErrorLabel.TabIndex = 106;
            this.CountErrorLabel.Text = "Введите количество";
            this.CountErrorLabel.Visible = false;
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumTextBox.BorderRadius = 2;
            this.SumTextBox.FillColor = System.Drawing.Color.White;
            this.SumTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumTextBox.IsPassword = false;
            this.SumTextBox.LineThickness = 1;
            this.SumTextBox.Location = new System.Drawing.Point(354, 305);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumTextBox.MaxLength = 32767;
            this.SumTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumTextBox.ReadOnly = false;
            this.SumTextBox.Size = new System.Drawing.Size(251, 41);
            this.SumTextBox.TabIndex = 102;
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TextName = "";
            // 
            // CountTextBox
            // 
            this.CountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Location = new System.Drawing.Point(372, 116);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(227, 16);
            this.CountTextBox.TabIndex = 110;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.Location = new System.Drawing.Point(372, 215);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(227, 16);
            this.PriceTextBox.TabIndex = 111;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // CountBorder
            // 
            this.CountBorder.BackColor = System.Drawing.Color.Transparent;
            this.CountBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CountBorder.BorderRadius = 2;
            this.CountBorder.Enabled = false;
            this.CountBorder.FillColor = System.Drawing.Color.White;
            this.CountBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountBorder.ForeColors = System.Drawing.Color.Black;
            this.CountBorder.IsPassword = false;
            this.CountBorder.LineThickness = 1;
            this.CountBorder.Location = new System.Drawing.Point(354, 103);
            this.CountBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountBorder.MaxLength = 32767;
            this.CountBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.CountBorder.Name = "CountBorder";
            this.CountBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CountBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.CountBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CountBorder.ReadOnly = true;
            this.CountBorder.Size = new System.Drawing.Size(251, 41);
            this.CountBorder.TabIndex = 96;
            this.CountBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountBorder.TextName = "";
            // 
            // PriceBorder
            // 
            this.PriceBorder.BackColor = System.Drawing.Color.Transparent;
            this.PriceBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.PriceBorder.BorderRadius = 2;
            this.PriceBorder.Enabled = false;
            this.PriceBorder.FillColor = System.Drawing.Color.White;
            this.PriceBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceBorder.ForeColors = System.Drawing.Color.Black;
            this.PriceBorder.IsPassword = false;
            this.PriceBorder.LineThickness = 1;
            this.PriceBorder.Location = new System.Drawing.Point(354, 201);
            this.PriceBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceBorder.MaxLength = 32767;
            this.PriceBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.PriceBorder.Name = "PriceBorder";
            this.PriceBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.PriceBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.PriceBorder.ReadOnly = true;
            this.PriceBorder.Size = new System.Drawing.Size(251, 41);
            this.PriceBorder.TabIndex = 96;
            this.PriceBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceBorder.TextName = "";
            // 
            // EditFurnitureInOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 463);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.SumWithoutNDS);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CounLabel);
            this.Controls.Add(this.PriceErrorLabel);
            this.Controls.Add(this.CountErrorLabel);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.DeterminationLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.CountBorder);
            this.Controls.Add(this.PriceBorder);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.UnitDeterminationTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FurnitureLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditFurnitureInOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFurnitureInOrderForm";
            this.Load += new System.EventHandler(this.EditFurnitureInOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделифуIDФу756D6ECBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource фурнитураBindingSource;
        public AutomationAppDBDataSetTableAdapters.ФурнитураTableAdapter фурнитураTableAdapter;
        public System.Windows.Forms.BindingSource fKМоделифуIDФу756D6ECBBindingSource;
        public AutomationAppDBDataSetTableAdapters.Модели_фурнитурыTableAdapter модели_фурнитурыTableAdapter;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label FurnitureLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Label DeterminationLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private JMetroTextBox.JMetroTextBox UnitDeterminationTextBox;
        private System.Windows.Forms.Label SumWithoutNDS;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CounLabel;
        private System.Windows.Forms.Label PriceErrorLabel;
        private System.Windows.Forms.Label CountErrorLabel;
        private JMetroTextBox.JMetroTextBox SumTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private JMetroTextBox.JMetroTextBox CountBorder;
        private JMetroTextBox.JMetroTextBox PriceBorder;
    }
}