
namespace AutomationApp
{
    partial class EditClothInOrdersForm
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
            this.fKМоделиткIDТк6C190EBBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.тканиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ТканиTableAdapter();
            this.модели_тканиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_тканиTableAdapter();
            this.fKСкладткаIDМо084B3915BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.склад_тканиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Склад_тканиTableAdapter();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.UnitDeterminationTextBox = new JMetroTextBox.JMetroTextBox();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.ClothLabel = new System.Windows.Forms.Label();
            this.ClothErrorLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.DeterminationLabel = new System.Windows.Forms.Label();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.CounLabel = new System.Windows.Forms.Label();
            this.CountErrorLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.SumWithoutNDSTextBox = new JMetroTextBox.JMetroTextBox();
            this.SumWithoutNDS = new System.Windows.Forms.Label();
            this.SumTotalNDSTextBox = new JMetroTextBox.JMetroTextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SumNDSLabel = new System.Windows.Forms.Label();
            this.SumNDSErrorLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SumNDSTextBox = new System.Windows.Forms.TextBox();
            this.jMetroTextBox1 = new JMetroTextBox.JMetroTextBox();
            this.jMetroTextBox2 = new JMetroTextBox.JMetroTextBox();
            this.jMetroTextBox3 = new JMetroTextBox.JMetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиткIDТк6C190EBBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСкладткаIDМо084B3915BindingSource)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fKМоделиткIDТк6C190EBBBindingSource
            // 
            this.fKМоделиткIDТк6C190EBBBindingSource.DataMember = "FK__Модели_тк__ID_Тк__6C190EBB";
            this.fKМоделиткIDТк6C190EBBBindingSource.DataSource = this.тканиBindingSource;
            // 
            // тканиBindingSource
            // 
            this.тканиBindingSource.DataMember = "Ткани";
            this.тканиBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиTableAdapter
            // 
            this.тканиTableAdapter.ClearBeforeFill = true;
            // 
            // модели_тканиTableAdapter
            // 
            this.модели_тканиTableAdapter.ClearBeforeFill = true;
            // 
            // fKСкладткаIDМо084B3915BindingSource
            // 
            this.fKСкладткаIDМо084B3915BindingSource.DataMember = "FK__Склад_тка__ID_Мо__084B3915";
            this.fKСкладткаIDМо084B3915BindingSource.DataSource = this.fKМоделиткIDТк6C190EBBBindingSource;
            // 
            // склад_тканиTableAdapter
            // 
            this.склад_тканиTableAdapter.ClearBeforeFill = true;
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
            this.TitlePanel.Size = new System.Drawing.Size(945, 51);
            this.TitlePanel.TabIndex = 64;
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
            this.CloseButton.Location = new System.Drawing.Point(888, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(49, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Добавление данных о ткани в приходный ордер";
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
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveItemButton.FlatAppearance.BorderSize = 0;
            this.SaveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveItemButton.ForeColor = System.Drawing.Color.White;
            this.SaveItemButton.Location = new System.Drawing.Point(685, 307);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(122, 39);
            this.SaveItemButton.TabIndex = 50;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(809, 307);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(120, 39);
            this.CancelAddButton.TabIndex = 49;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
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
            this.UnitDeterminationTextBox.TabIndex = 80;
            this.UnitDeterminationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UnitDeterminationTextBox.TextName = "";
            this.UnitDeterminationTextBox.Enter += new System.EventHandler(this.UnitDeterminationTextBox_Enter);
            // 
            // DeterminationErrorLabel
            // 
            this.DeterminationErrorLabel.AutoSize = true;
            this.DeterminationErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminationErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeterminationErrorLabel.Location = new System.Drawing.Point(26, 350);
            this.DeterminationErrorLabel.Name = "DeterminationErrorLabel";
            this.DeterminationErrorLabel.Size = new System.Drawing.Size(164, 16);
            this.DeterminationErrorLabel.TabIndex = 81;
            this.DeterminationErrorLabel.Text = "Введите единицу измерения";
            this.DeterminationErrorLabel.Visible = false;
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
            this.NameTextBox.TabIndex = 80;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            // 
            // ClothLabel
            // 
            this.ClothLabel.AutoSize = true;
            this.ClothLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ClothLabel.ForeColor = System.Drawing.Color.Gray;
            this.ClothLabel.Location = new System.Drawing.Point(24, 79);
            this.ClothLabel.Name = "ClothLabel";
            this.ClothLabel.Size = new System.Drawing.Size(105, 19);
            this.ClothLabel.TabIndex = 82;
            this.ClothLabel.Text = "Наименование";
            // 
            // ClothErrorLabel
            // 
            this.ClothErrorLabel.AutoSize = true;
            this.ClothErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClothErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClothErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.ClothErrorLabel.Name = "ClothErrorLabel";
            this.ClothErrorLabel.Size = new System.Drawing.Size(95, 16);
            this.ClothErrorLabel.TabIndex = 81;
            this.ClothErrorLabel.Text = "Выберите ткань";
            this.ClothErrorLabel.Visible = false;
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
            this.ModelTextBox.TabIndex = 80;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(25, 179);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 82;
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
            this.ModelErrorLabel.TabIndex = 81;
            this.ModelErrorLabel.Text = "Выберите модель";
            this.ModelErrorLabel.Visible = false;
            // 
            // DeterminationLabel
            // 
            this.DeterminationLabel.AutoSize = true;
            this.DeterminationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DeterminationLabel.ForeColor = System.Drawing.Color.Gray;
            this.DeterminationLabel.Location = new System.Drawing.Point(25, 282);
            this.DeterminationLabel.Name = "DeterminationLabel";
            this.DeterminationLabel.Size = new System.Drawing.Size(137, 19);
            this.DeterminationLabel.TabIndex = 82;
            this.DeterminationLabel.Text = "Единица измерения";
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
            this.SelectButton.TabIndex = 91;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // CounLabel
            // 
            this.CounLabel.AutoSize = true;
            this.CounLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CounLabel.ForeColor = System.Drawing.Color.Gray;
            this.CounLabel.Location = new System.Drawing.Point(354, 81);
            this.CounLabel.Name = "CounLabel";
            this.CounLabel.Size = new System.Drawing.Size(85, 19);
            this.CounLabel.TabIndex = 82;
            this.CounLabel.Text = "Количество";
            // 
            // CountErrorLabel
            // 
            this.CountErrorLabel.AutoSize = true;
            this.CountErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorLabel.Location = new System.Drawing.Point(355, 148);
            this.CountErrorLabel.Name = "CountErrorLabel";
            this.CountErrorLabel.Size = new System.Drawing.Size(118, 16);
            this.CountErrorLabel.TabIndex = 81;
            this.CountErrorLabel.Text = "Введите количество";
            this.CountErrorLabel.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.PriceLabel.ForeColor = System.Drawing.Color.Gray;
            this.PriceLabel.Location = new System.Drawing.Point(354, 179);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(42, 19);
            this.PriceLabel.TabIndex = 82;
            this.PriceLabel.Text = "Цена";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PriceErrorLabel.Location = new System.Drawing.Point(355, 246);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(81, 16);
            this.PriceErrorLabel.TabIndex = 81;
            this.PriceErrorLabel.Text = "Введите цену";
            this.PriceErrorLabel.Visible = false;
            // 
            // SumWithoutNDSTextBox
            // 
            this.SumWithoutNDSTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumWithoutNDSTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumWithoutNDSTextBox.BorderRadius = 2;
            this.SumWithoutNDSTextBox.FillColor = System.Drawing.Color.White;
            this.SumWithoutNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumWithoutNDSTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumWithoutNDSTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumWithoutNDSTextBox.IsPassword = false;
            this.SumWithoutNDSTextBox.LineThickness = 1;
            this.SumWithoutNDSTextBox.Location = new System.Drawing.Point(354, 305);
            this.SumWithoutNDSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumWithoutNDSTextBox.MaxLength = 32767;
            this.SumWithoutNDSTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumWithoutNDSTextBox.Name = "SumWithoutNDSTextBox";
            this.SumWithoutNDSTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumWithoutNDSTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumWithoutNDSTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumWithoutNDSTextBox.ReadOnly = true;
            this.SumWithoutNDSTextBox.Size = new System.Drawing.Size(251, 41);
            this.SumWithoutNDSTextBox.TabIndex = 80;
            this.SumWithoutNDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumWithoutNDSTextBox.TextName = "";
            // 
            // SumWithoutNDS
            // 
            this.SumWithoutNDS.AutoSize = true;
            this.SumWithoutNDS.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumWithoutNDS.ForeColor = System.Drawing.Color.Gray;
            this.SumWithoutNDS.Location = new System.Drawing.Point(354, 282);
            this.SumWithoutNDS.Name = "SumWithoutNDS";
            this.SumWithoutNDS.Size = new System.Drawing.Size(110, 19);
            this.SumWithoutNDS.TabIndex = 82;
            this.SumWithoutNDS.Text = "Сумма без НДС";
            // 
            // SumTotalNDSTextBox
            // 
            this.SumTotalNDSTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumTotalNDSTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumTotalNDSTextBox.BorderRadius = 2;
            this.SumTotalNDSTextBox.FillColor = System.Drawing.Color.White;
            this.SumTotalNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumTotalNDSTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumTotalNDSTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumTotalNDSTextBox.IsPassword = false;
            this.SumTotalNDSTextBox.LineThickness = 1;
            this.SumTotalNDSTextBox.Location = new System.Drawing.Point(678, 201);
            this.SumTotalNDSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumTotalNDSTextBox.MaxLength = 32767;
            this.SumTotalNDSTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumTotalNDSTextBox.Name = "SumTotalNDSTextBox";
            this.SumTotalNDSTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumTotalNDSTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumTotalNDSTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumTotalNDSTextBox.ReadOnly = true;
            this.SumTotalNDSTextBox.Size = new System.Drawing.Size(251, 41);
            this.SumTotalNDSTextBox.TabIndex = 80;
            this.SumTotalNDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTotalNDSTextBox.TextName = "";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.TotalLabel.ForeColor = System.Drawing.Color.Gray;
            this.TotalLabel.Location = new System.Drawing.Point(679, 178);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(88, 19);
            this.TotalLabel.TabIndex = 82;
            this.TotalLabel.Text = "Всего с НДС";
            // 
            // SumNDSLabel
            // 
            this.SumNDSLabel.AutoSize = true;
            this.SumNDSLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumNDSLabel.ForeColor = System.Drawing.Color.Gray;
            this.SumNDSLabel.Location = new System.Drawing.Point(679, 81);
            this.SumNDSLabel.Name = "SumNDSLabel";
            this.SumNDSLabel.Size = new System.Drawing.Size(85, 19);
            this.SumNDSLabel.TabIndex = 82;
            this.SumNDSLabel.Text = "Сумма НДС";
            // 
            // SumNDSErrorLabel
            // 
            this.SumNDSErrorLabel.AutoSize = true;
            this.SumNDSErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumNDSErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SumNDSErrorLabel.Location = new System.Drawing.Point(680, 148);
            this.SumNDSErrorLabel.Name = "SumNDSErrorLabel";
            this.SumNDSErrorLabel.Size = new System.Drawing.Size(118, 16);
            this.SumNDSErrorLabel.TabIndex = 81;
            this.SumNDSErrorLabel.Text = "Укажите сумму НДС";
            this.SumNDSErrorLabel.Visible = false;
            // 
            // CountTextBox
            // 
            this.CountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Location = new System.Drawing.Point(372, 115);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(227, 16);
            this.CountTextBox.TabIndex = 92;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.Location = new System.Drawing.Point(372, 215);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(227, 16);
            this.PriceTextBox.TabIndex = 92;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // SumNDSTextBox
            // 
            this.SumNDSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumNDSTextBox.Location = new System.Drawing.Point(696, 117);
            this.SumNDSTextBox.Name = "SumNDSTextBox";
            this.SumNDSTextBox.Size = new System.Drawing.Size(227, 16);
            this.SumNDSTextBox.TabIndex = 92;
            this.SumNDSTextBox.TextChanged += new System.EventHandler(this.SumNDSTextBox_TextChanged);
            // 
            // jMetroTextBox1
            // 
            this.jMetroTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.jMetroTextBox1.BorderRadius = 2;
            this.jMetroTextBox1.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox1.ForeColors = System.Drawing.Color.Black;
            this.jMetroTextBox1.IsPassword = false;
            this.jMetroTextBox1.LineThickness = 1;
            this.jMetroTextBox1.Location = new System.Drawing.Point(354, 103);
            this.jMetroTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox1.MaxLength = 32767;
            this.jMetroTextBox1.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox1.Name = "jMetroTextBox1";
            this.jMetroTextBox1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox1.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.ReadOnly = true;
            this.jMetroTextBox1.Size = new System.Drawing.Size(251, 41);
            this.jMetroTextBox1.TabIndex = 80;
            this.jMetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox1.TextName = "";
            // 
            // jMetroTextBox2
            // 
            this.jMetroTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.jMetroTextBox2.BorderRadius = 2;
            this.jMetroTextBox2.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox2.ForeColors = System.Drawing.Color.Black;
            this.jMetroTextBox2.IsPassword = false;
            this.jMetroTextBox2.LineThickness = 1;
            this.jMetroTextBox2.Location = new System.Drawing.Point(354, 201);
            this.jMetroTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox2.MaxLength = 32767;
            this.jMetroTextBox2.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox2.Name = "jMetroTextBox2";
            this.jMetroTextBox2.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox2.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox2.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox2.ReadOnly = true;
            this.jMetroTextBox2.Size = new System.Drawing.Size(251, 41);
            this.jMetroTextBox2.TabIndex = 80;
            this.jMetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox2.TextName = "";
            // 
            // jMetroTextBox3
            // 
            this.jMetroTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.jMetroTextBox3.BorderRadius = 2;
            this.jMetroTextBox3.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox3.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMetroTextBox3.ForeColors = System.Drawing.Color.Black;
            this.jMetroTextBox3.IsPassword = false;
            this.jMetroTextBox3.LineThickness = 1;
            this.jMetroTextBox3.Location = new System.Drawing.Point(678, 103);
            this.jMetroTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox3.MaxLength = 32767;
            this.jMetroTextBox3.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox3.Name = "jMetroTextBox3";
            this.jMetroTextBox3.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox3.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox3.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox3.ReadOnly = true;
            this.jMetroTextBox3.Size = new System.Drawing.Size(251, 41);
            this.jMetroTextBox3.TabIndex = 80;
            this.jMetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox3.TextName = "";
            // 
            // EditClothInOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 383);
            this.Controls.Add(this.SumNDSTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.DeterminationLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.SumNDSLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SumWithoutNDS);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CounLabel);
            this.Controls.Add(this.ClothLabel);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.ClothErrorLabel);
            this.Controls.Add(this.PriceErrorLabel);
            this.Controls.Add(this.SumNDSErrorLabel);
            this.Controls.Add(this.CountErrorLabel);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.jMetroTextBox1);
            this.Controls.Add(this.jMetroTextBox2);
            this.Controls.Add(this.jMetroTextBox3);
            this.Controls.Add(this.SumTotalNDSTextBox);
            this.Controls.Add(this.SumWithoutNDSTextBox);
            this.Controls.Add(this.UnitDeterminationTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditClothInOrdersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditClothInOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиткIDТк6C190EBBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСкладткаIDМо084B3915BindingSource)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource тканиBindingSource;
        private AutomationAppDBDataSetTableAdapters.ТканиTableAdapter тканиTableAdapter;
        private System.Windows.Forms.BindingSource fKМоделиткIDТк6C190EBBBindingSource;
        private AutomationAppDBDataSetTableAdapters.Модели_тканиTableAdapter модели_тканиTableAdapter;
        private System.Windows.Forms.BindingSource fKСкладткаIDМо084B3915BindingSource;
        private AutomationAppDBDataSetTableAdapters.Склад_тканиTableAdapter склад_тканиTableAdapter;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Button CancelAddButton;
        private JMetroTextBox.JMetroTextBox UnitDeterminationTextBox;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Label ClothLabel;
        private System.Windows.Forms.Label ClothErrorLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
        private System.Windows.Forms.Label DeterminationLabel;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label CounLabel;
        private System.Windows.Forms.Label CountErrorLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label PriceErrorLabel;
        private JMetroTextBox.JMetroTextBox SumWithoutNDSTextBox;
        private System.Windows.Forms.Label SumWithoutNDS;
        private JMetroTextBox.JMetroTextBox SumTotalNDSTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SumNDSLabel;
        private System.Windows.Forms.Label SumNDSErrorLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox SumNDSTextBox;
        private JMetroTextBox.JMetroTextBox jMetroTextBox1;
        private JMetroTextBox.JMetroTextBox jMetroTextBox2;
        private JMetroTextBox.JMetroTextBox jMetroTextBox3;
    }
}