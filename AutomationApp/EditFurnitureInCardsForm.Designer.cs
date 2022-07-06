
namespace AutomationApp
{
    partial class EditFurnitureInCardsForm
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
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.складфурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.склад_фурнитурыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NormTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NormLabel = new System.Windows.Forms.Label();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.NormErrorLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new JMetroTextBox.JMetroTextBox();
            this.DeterminationLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.NormBorder = new JMetroTextBox.JMetroTextBox();
            this.PriceBorder = new JMetroTextBox.JMetroTextBox();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.UnitDeterminationTextBox = new JMetroTextBox.JMetroTextBox();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.FurnitureLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountErrorlabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.CountBorder = new JMetroTextBox.JMetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
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
            this.CancelAddButton.TabIndex = 39;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
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
            this.SaveItemButton.TabIndex = 40;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // складфурнитурыBindingSource
            // 
            this.складфурнитурыBindingSource.DataMember = "Склад_фурнитуры";
            this.складфурнитурыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // склад_фурнитурыTableAdapter
            // 
            this.склад_фурнитурыTableAdapter.ClearBeforeFill = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.Location = new System.Drawing.Point(372, 214);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(227, 16);
            this.PriceTextBox.TabIndex = 133;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // NormTextBox
            // 
            this.NormTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NormTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NormTextBox.Location = new System.Drawing.Point(372, 116);
            this.NormTextBox.Name = "NormTextBox";
            this.NormTextBox.Size = new System.Drawing.Size(227, 16);
            this.NormTextBox.TabIndex = 132;
            this.NormTextBox.TextChanged += new System.EventHandler(this.NormTextBox_TextChanged);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumLabel.ForeColor = System.Drawing.Color.Gray;
            this.SumLabel.Location = new System.Drawing.Point(679, 81);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(52, 19);
            this.SumLabel.TabIndex = 129;
            this.SumLabel.Text = "Сумма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(354, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 130;
            this.label1.Text = "Цена";
            // 
            // NormLabel
            // 
            this.NormLabel.AutoSize = true;
            this.NormLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.NormLabel.ForeColor = System.Drawing.Color.Gray;
            this.NormLabel.Location = new System.Drawing.Point(354, 81);
            this.NormLabel.Name = "NormLabel";
            this.NormLabel.Size = new System.Drawing.Size(186, 19);
            this.NormLabel.TabIndex = 131;
            this.NormLabel.Text = "Норма на единицу изделия";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PriceErrorLabel.Location = new System.Drawing.Point(355, 246);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(81, 16);
            this.PriceErrorLabel.TabIndex = 127;
            this.PriceErrorLabel.Text = "Введите цену";
            this.PriceErrorLabel.Visible = false;
            // 
            // NormErrorLabel
            // 
            this.NormErrorLabel.AutoSize = true;
            this.NormErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NormErrorLabel.Location = new System.Drawing.Point(355, 148);
            this.NormErrorLabel.Name = "NormErrorLabel";
            this.NormErrorLabel.Size = new System.Drawing.Size(203, 16);
            this.NormErrorLabel.TabIndex = 128;
            this.NormErrorLabel.Text = "Введите норму на единицу изделия";
            this.NormErrorLabel.Visible = false;
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
            this.SumTextBox.Location = new System.Drawing.Point(678, 103);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumTextBox.MaxLength = 32767;
            this.SumTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(251, 41);
            this.SumTextBox.TabIndex = 126;
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TextName = "";
            // 
            // DeterminationLabel
            // 
            this.DeterminationLabel.AutoSize = true;
            this.DeterminationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DeterminationLabel.ForeColor = System.Drawing.Color.Gray;
            this.DeterminationLabel.Location = new System.Drawing.Point(25, 282);
            this.DeterminationLabel.Name = "DeterminationLabel";
            this.DeterminationLabel.Size = new System.Drawing.Size(137, 19);
            this.DeterminationLabel.TabIndex = 124;
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
            this.ModelLabel.TabIndex = 125;
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
            this.ModelErrorLabel.TabIndex = 122;
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
            this.DeterminationErrorLabel.TabIndex = 123;
            this.DeterminationErrorLabel.Text = "Введите единицу измерения";
            this.DeterminationErrorLabel.Visible = false;
            // 
            // NormBorder
            // 
            this.NormBorder.BackColor = System.Drawing.Color.Transparent;
            this.NormBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NormBorder.BorderRadius = 2;
            this.NormBorder.Enabled = false;
            this.NormBorder.FillColor = System.Drawing.Color.White;
            this.NormBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NormBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NormBorder.ForeColors = System.Drawing.Color.Black;
            this.NormBorder.IsPassword = false;
            this.NormBorder.LineThickness = 1;
            this.NormBorder.Location = new System.Drawing.Point(354, 103);
            this.NormBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NormBorder.MaxLength = 32767;
            this.NormBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.NormBorder.Name = "NormBorder";
            this.NormBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NormBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.NormBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NormBorder.ReadOnly = true;
            this.NormBorder.Size = new System.Drawing.Size(251, 41);
            this.NormBorder.TabIndex = 120;
            this.NormBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NormBorder.TextName = "";
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
            this.PriceBorder.TabIndex = 119;
            this.PriceBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceBorder.TextName = "";
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
            this.ModelTextBox.TabIndex = 118;
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
            this.UnitDeterminationTextBox.ReadOnly = true;
            this.UnitDeterminationTextBox.Size = new System.Drawing.Size(251, 41);
            this.UnitDeterminationTextBox.TabIndex = 121;
            this.UnitDeterminationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UnitDeterminationTextBox.TextName = "";
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
            this.SelectButton.TabIndex = 117;
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
            this.FurnitureLabel.TabIndex = 116;
            this.FurnitureLabel.Text = "Наименование";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(124, 16);
            this.NameErrorLabel.TabIndex = 115;
            this.NameErrorLabel.Text = "Выберите фурнитуру";
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
            this.NameTextBox.TabIndex = 114;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(49, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Добавление данных о фурнитуре в лимитно-заборную карту";
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
            this.TitlePanel.Size = new System.Drawing.Size(945, 51);
            this.TitlePanel.TabIndex = 134;
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
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CountLabel.ForeColor = System.Drawing.Color.Gray;
            this.CountLabel.Location = new System.Drawing.Point(354, 283);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 19);
            this.CountLabel.TabIndex = 137;
            this.CountLabel.Text = "Количество";
            // 
            // CountErrorlabel
            // 
            this.CountErrorlabel.AutoSize = true;
            this.CountErrorlabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorlabel.Location = new System.Drawing.Point(355, 350);
            this.CountErrorlabel.Name = "CountErrorlabel";
            this.CountErrorlabel.Size = new System.Drawing.Size(118, 16);
            this.CountErrorlabel.TabIndex = 136;
            this.CountErrorlabel.Text = "Введите количество";
            this.CountErrorlabel.Visible = false;
            // 
            // CountTextBox
            // 
            this.CountTextBox.BackColor = System.Drawing.Color.White;
            this.CountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Location = new System.Drawing.Point(372, 319);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.ReadOnly = true;
            this.CountTextBox.Size = new System.Drawing.Size(227, 16);
            this.CountTextBox.TabIndex = 138;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
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
            this.CountBorder.Location = new System.Drawing.Point(354, 305);
            this.CountBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountBorder.MaxLength = 32767;
            this.CountBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.CountBorder.Name = "CountBorder";
            this.CountBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CountBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.CountBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CountBorder.ReadOnly = true;
            this.CountBorder.Size = new System.Drawing.Size(251, 41);
            this.CountBorder.TabIndex = 119;
            this.CountBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountBorder.TextName = "";
            // 
            // EditFurnitureInCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 383);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountErrorlabel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NormTextBox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NormLabel);
            this.Controls.Add(this.PriceErrorLabel);
            this.Controls.Add(this.NormErrorLabel);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.DeterminationLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.NormBorder);
            this.Controls.Add(this.CountBorder);
            this.Controls.Add(this.PriceBorder);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.UnitDeterminationTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FurnitureLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditFurnitureInCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFurnitureInCardsForm";
            this.Load += new System.EventHandler(this.EditFurnitureInCardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource складфурнитурыBindingSource;
        private AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter склад_фурнитурыTableAdapter;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NormTextBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NormLabel;
        private System.Windows.Forms.Label PriceErrorLabel;
        private System.Windows.Forms.Label NormErrorLabel;
        private JMetroTextBox.JMetroTextBox SumTextBox;
        private System.Windows.Forms.Label DeterminationLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private JMetroTextBox.JMetroTextBox NormBorder;
        private JMetroTextBox.JMetroTextBox PriceBorder;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private JMetroTextBox.JMetroTextBox UnitDeterminationTextBox;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label FurnitureLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountErrorlabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private JMetroTextBox.JMetroTextBox CountBorder;
    }
}