
namespace AutomationApp
{
    partial class EditProductsInNoteForm
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
            this.labelPanle = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.DeterminationLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.UnitDeterminationTextBox = new JMetroTextBox.JMetroTextBox();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.FurnitureLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.CountBorder = new JMetroTextBox.JMetroTextBox();
            this.CountErrorLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SortTextBox = new JMetroTextBox.JMetroTextBox();
            this.SortErrorLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new JMetroTextBox.JMetroTextBox();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.EndPriceTextBox = new JMetroTextBox.JMetroTextBox();
            this.EndPriceOneLabel = new System.Windows.Forms.Label();
            this.BetNDSTextBox = new JMetroTextBox.JMetroTextBox();
            this.BetErrorLabel = new System.Windows.Forms.Label();
            this.BetNDSlabel = new System.Windows.Forms.Label();
            this.SumNDSTextBox = new JMetroTextBox.JMetroTextBox();
            this.SumNDSLabel = new System.Windows.Forms.Label();
            this.TotalNDSTextBox = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.ТоварныеНакладныеbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.товарные_накладныеTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварныеНакладныеbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPanle
            // 
            this.labelPanle.AutoSize = true;
            this.labelPanle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanle.ForeColor = System.Drawing.Color.Gray;
            this.labelPanle.Location = new System.Drawing.Point(49, 14);
            this.labelPanle.Name = "labelPanle";
            this.labelPanle.Size = new System.Drawing.Size(353, 19);
            this.labelPanle.TabIndex = 60;
            this.labelPanle.Text = "Добавление данных о продукции в накладную";
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
            this.TitlePanel.Controls.Add(this.labelPanle);
            this.TitlePanel.Controls.Add(this.iconPictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(932, 51);
            this.TitlePanel.TabIndex = 66;
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
            this.CloseButton.Location = new System.Drawing.Point(880, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // DeterminationLabel
            // 
            this.DeterminationLabel.AutoSize = true;
            this.DeterminationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DeterminationLabel.ForeColor = System.Drawing.Color.Gray;
            this.DeterminationLabel.Location = new System.Drawing.Point(26, 281);
            this.DeterminationLabel.Name = "DeterminationLabel";
            this.DeterminationLabel.Size = new System.Drawing.Size(137, 19);
            this.DeterminationLabel.TabIndex = 110;
            this.DeterminationLabel.Text = "Единица измерения";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(26, 178);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 111;
            this.ModelLabel.Text = "Модель";
            // 
            // ModelErrorLabel
            // 
            this.ModelErrorLabel.AutoSize = true;
            this.ModelErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelErrorLabel.Location = new System.Drawing.Point(27, 245);
            this.ModelErrorLabel.Name = "ModelErrorLabel";
            this.ModelErrorLabel.Size = new System.Drawing.Size(105, 16);
            this.ModelErrorLabel.TabIndex = 108;
            this.ModelErrorLabel.Text = "Выберите модель";
            this.ModelErrorLabel.Visible = false;
            // 
            // DeterminationErrorLabel
            // 
            this.DeterminationErrorLabel.AutoSize = true;
            this.DeterminationErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminationErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeterminationErrorLabel.Location = new System.Drawing.Point(27, 349);
            this.DeterminationErrorLabel.Name = "DeterminationErrorLabel";
            this.DeterminationErrorLabel.Size = new System.Drawing.Size(164, 16);
            this.DeterminationErrorLabel.TabIndex = 109;
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
            this.ModelTextBox.Location = new System.Drawing.Point(25, 200);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(251, 41);
            this.ModelTextBox.TabIndex = 106;
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
            this.UnitDeterminationTextBox.Location = new System.Drawing.Point(25, 304);
            this.UnitDeterminationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnitDeterminationTextBox.MaxLength = 32767;
            this.UnitDeterminationTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.Name = "UnitDeterminationTextBox";
            this.UnitDeterminationTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitDeterminationTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.ReadOnly = false;
            this.UnitDeterminationTextBox.Size = new System.Drawing.Size(251, 41);
            this.UnitDeterminationTextBox.TabIndex = 107;
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
            this.SelectButton.Location = new System.Drawing.Point(277, 102);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(51, 39);
            this.SelectButton.TabIndex = 105;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FurnitureLabel
            // 
            this.FurnitureLabel.AutoSize = true;
            this.FurnitureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.FurnitureLabel.ForeColor = System.Drawing.Color.Gray;
            this.FurnitureLabel.Location = new System.Drawing.Point(25, 78);
            this.FurnitureLabel.Name = "FurnitureLabel";
            this.FurnitureLabel.Size = new System.Drawing.Size(105, 19);
            this.FurnitureLabel.TabIndex = 104;
            this.FurnitureLabel.Text = "Наименование";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(27, 147);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(129, 16);
            this.NameErrorLabel.TabIndex = 103;
            this.NameErrorLabel.Text = "Выберите продукцию";
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
            this.NameTextBox.Location = new System.Drawing.Point(25, 102);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NameTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(251, 41);
            this.NameTextBox.TabIndex = 102;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(780, 407);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(120, 39);
            this.CancelAddButton.TabIndex = 112;
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
            this.SaveItemButton.Location = new System.Drawing.Point(656, 407);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(122, 39);
            this.SaveItemButton.TabIndex = 113;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // CountBorder
            // 
            this.CountBorder.BackColor = System.Drawing.Color.Transparent;
            this.CountBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CountBorder.BorderRadius = 2;
            this.CountBorder.FillColor = System.Drawing.Color.White;
            this.CountBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountBorder.ForeColors = System.Drawing.Color.Black;
            this.CountBorder.IsPassword = false;
            this.CountBorder.LineThickness = 1;
            this.CountBorder.Location = new System.Drawing.Point(25, 405);
            this.CountBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountBorder.MaxLength = 32767;
            this.CountBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.CountBorder.Name = "CountBorder";
            this.CountBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CountBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.CountBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CountBorder.ReadOnly = true;
            this.CountBorder.Size = new System.Drawing.Size(251, 41);
            this.CountBorder.TabIndex = 106;
            this.CountBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountBorder.TextName = "";
            // 
            // CountErrorLabel
            // 
            this.CountErrorLabel.AutoSize = true;
            this.CountErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorLabel.Location = new System.Drawing.Point(26, 450);
            this.CountErrorLabel.Name = "CountErrorLabel";
            this.CountErrorLabel.Size = new System.Drawing.Size(118, 16);
            this.CountErrorLabel.TabIndex = 108;
            this.CountErrorLabel.Text = "Введите количество";
            this.CountErrorLabel.Visible = false;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CountLabel.ForeColor = System.Drawing.Color.Gray;
            this.CountLabel.Location = new System.Drawing.Point(25, 383);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 19);
            this.CountLabel.TabIndex = 111;
            this.CountLabel.Text = "Количество";
            // 
            // SortTextBox
            // 
            this.SortTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SortTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SortTextBox.BorderRadius = 2;
            this.SortTextBox.FillColor = System.Drawing.Color.White;
            this.SortTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SortTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SortTextBox.ForeColors = System.Drawing.Color.Black;
            this.SortTextBox.IsPassword = false;
            this.SortTextBox.LineThickness = 1;
            this.SortTextBox.Location = new System.Drawing.Point(354, 102);
            this.SortTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortTextBox.MaxLength = 32767;
            this.SortTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SortTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SortTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SortTextBox.ReadOnly = false;
            this.SortTextBox.Size = new System.Drawing.Size(251, 41);
            this.SortTextBox.TabIndex = 106;
            this.SortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SortTextBox.TextName = "";
            // 
            // SortErrorLabel
            // 
            this.SortErrorLabel.AutoSize = true;
            this.SortErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SortErrorLabel.Location = new System.Drawing.Point(355, 147);
            this.SortErrorLabel.Name = "SortErrorLabel";
            this.SortErrorLabel.Size = new System.Drawing.Size(80, 16);
            this.SortErrorLabel.TabIndex = 108;
            this.SortErrorLabel.Text = "Введите сорт";
            this.SortErrorLabel.Visible = false;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SortLabel.ForeColor = System.Drawing.Color.Gray;
            this.SortLabel.Location = new System.Drawing.Point(354, 80);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(40, 19);
            this.SortLabel.TabIndex = 111;
            this.SortLabel.Text = "Сорт";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.PriceTextBox.BorderRadius = 2;
            this.PriceTextBox.FillColor = System.Drawing.Color.White;
            this.PriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTextBox.ForeColors = System.Drawing.Color.Black;
            this.PriceTextBox.IsPassword = false;
            this.PriceTextBox.LineThickness = 1;
            this.PriceTextBox.Location = new System.Drawing.Point(354, 200);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceTextBox.MaxLength = 32767;
            this.PriceTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.PriceTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.PriceTextBox.ReadOnly = false;
            this.PriceTextBox.Size = new System.Drawing.Size(251, 41);
            this.PriceTextBox.TabIndex = 106;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceTextBox.TextName = "";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PriceErrorLabel.Location = new System.Drawing.Point(355, 245);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(81, 16);
            this.PriceErrorLabel.TabIndex = 108;
            this.PriceErrorLabel.Text = "Введите цену";
            this.PriceErrorLabel.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.PriceLabel.ForeColor = System.Drawing.Color.Gray;
            this.PriceLabel.Location = new System.Drawing.Point(354, 178);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(93, 19);
            this.PriceLabel.TabIndex = 111;
            this.PriceLabel.Text = "Цена за 1 ед.";
            // 
            // EndPriceTextBox
            // 
            this.EndPriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EndPriceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.EndPriceTextBox.BorderRadius = 2;
            this.EndPriceTextBox.FillColor = System.Drawing.Color.White;
            this.EndPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EndPriceTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EndPriceTextBox.ForeColors = System.Drawing.Color.Black;
            this.EndPriceTextBox.IsPassword = false;
            this.EndPriceTextBox.LineThickness = 1;
            this.EndPriceTextBox.Location = new System.Drawing.Point(354, 304);
            this.EndPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndPriceTextBox.MaxLength = 32767;
            this.EndPriceTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.EndPriceTextBox.Name = "EndPriceTextBox";
            this.EndPriceTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.EndPriceTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.EndPriceTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.EndPriceTextBox.ReadOnly = false;
            this.EndPriceTextBox.Size = new System.Drawing.Size(251, 41);
            this.EndPriceTextBox.TabIndex = 106;
            this.EndPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EndPriceTextBox.TextName = "";
            // 
            // EndPriceOneLabel
            // 
            this.EndPriceOneLabel.AutoSize = true;
            this.EndPriceOneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.EndPriceOneLabel.ForeColor = System.Drawing.Color.Gray;
            this.EndPriceOneLabel.Location = new System.Drawing.Point(355, 282);
            this.EndPriceOneLabel.Name = "EndPriceOneLabel";
            this.EndPriceOneLabel.Size = new System.Drawing.Size(110, 19);
            this.EndPriceOneLabel.TabIndex = 111;
            this.EndPriceOneLabel.Text = "Сумма без НДС";
            // 
            // BetNDSTextBox
            // 
            this.BetNDSTextBox.BackColor = System.Drawing.Color.Transparent;
            this.BetNDSTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.BetNDSTextBox.BorderRadius = 2;
            this.BetNDSTextBox.FillColor = System.Drawing.Color.White;
            this.BetNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BetNDSTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BetNDSTextBox.ForeColors = System.Drawing.Color.Black;
            this.BetNDSTextBox.IsPassword = false;
            this.BetNDSTextBox.LineThickness = 1;
            this.BetNDSTextBox.Location = new System.Drawing.Point(354, 405);
            this.BetNDSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetNDSTextBox.MaxLength = 32767;
            this.BetNDSTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.BetNDSTextBox.Name = "BetNDSTextBox";
            this.BetNDSTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.BetNDSTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.BetNDSTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.BetNDSTextBox.ReadOnly = false;
            this.BetNDSTextBox.Size = new System.Drawing.Size(251, 41);
            this.BetNDSTextBox.TabIndex = 106;
            this.BetNDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BetNDSTextBox.TextName = "";
            // 
            // BetErrorLabel
            // 
            this.BetErrorLabel.AutoSize = true;
            this.BetErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BetErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BetErrorLabel.Location = new System.Drawing.Point(355, 450);
            this.BetErrorLabel.Name = "BetErrorLabel";
            this.BetErrorLabel.Size = new System.Drawing.Size(90, 16);
            this.BetErrorLabel.TabIndex = 108;
            this.BetErrorLabel.Text = "Введите ставку";
            this.BetErrorLabel.Visible = false;
            // 
            // BetNDSlabel
            // 
            this.BetNDSlabel.AutoSize = true;
            this.BetNDSlabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.BetNDSlabel.ForeColor = System.Drawing.Color.Gray;
            this.BetNDSlabel.Location = new System.Drawing.Point(354, 383);
            this.BetNDSlabel.Name = "BetNDSlabel";
            this.BetNDSlabel.Size = new System.Drawing.Size(105, 19);
            this.BetNDSlabel.TabIndex = 111;
            this.BetNDSlabel.Text = "Ставка НДС, %";
            // 
            // SumNDSTextBox
            // 
            this.SumNDSTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumNDSTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumNDSTextBox.BorderRadius = 2;
            this.SumNDSTextBox.FillColor = System.Drawing.Color.White;
            this.SumNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumNDSTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumNDSTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumNDSTextBox.IsPassword = false;
            this.SumNDSTextBox.LineThickness = 1;
            this.SumNDSTextBox.Location = new System.Drawing.Point(661, 102);
            this.SumNDSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumNDSTextBox.MaxLength = 32767;
            this.SumNDSTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumNDSTextBox.Name = "SumNDSTextBox";
            this.SumNDSTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumNDSTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumNDSTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumNDSTextBox.ReadOnly = false;
            this.SumNDSTextBox.Size = new System.Drawing.Size(251, 41);
            this.SumNDSTextBox.TabIndex = 106;
            this.SumNDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumNDSTextBox.TextName = "";
            // 
            // SumNDSLabel
            // 
            this.SumNDSLabel.AutoSize = true;
            this.SumNDSLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumNDSLabel.ForeColor = System.Drawing.Color.Gray;
            this.SumNDSLabel.Location = new System.Drawing.Point(661, 80);
            this.SumNDSLabel.Name = "SumNDSLabel";
            this.SumNDSLabel.Size = new System.Drawing.Size(85, 19);
            this.SumNDSLabel.TabIndex = 111;
            this.SumNDSLabel.Text = "Сумма НДС";
            // 
            // TotalNDSTextBox
            // 
            this.TotalNDSTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TotalNDSTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.TotalNDSTextBox.BorderRadius = 2;
            this.TotalNDSTextBox.FillColor = System.Drawing.Color.White;
            this.TotalNDSTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalNDSTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalNDSTextBox.ForeColors = System.Drawing.Color.Black;
            this.TotalNDSTextBox.IsPassword = false;
            this.TotalNDSTextBox.LineThickness = 1;
            this.TotalNDSTextBox.Location = new System.Drawing.Point(661, 200);
            this.TotalNDSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalNDSTextBox.MaxLength = 32767;
            this.TotalNDSTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.TotalNDSTextBox.Name = "TotalNDSTextBox";
            this.TotalNDSTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalNDSTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.TotalNDSTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.TotalNDSTextBox.ReadOnly = false;
            this.TotalNDSTextBox.Size = new System.Drawing.Size(251, 41);
            this.TotalNDSTextBox.TabIndex = 106;
            this.TotalNDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TotalNDSTextBox.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(661, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Всего с учетом НДС";
            // 
            // CountTextBox
            // 
            this.CountTextBox.BackColor = System.Drawing.Color.White;
            this.CountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Location = new System.Drawing.Point(40, 419);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(227, 16);
            this.CountTextBox.TabIndex = 139;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // ТоварныеНакладныеbindingSource
            // 
            this.ТоварныеНакладныеbindingSource.DataMember = "Товарные_накладные";
            this.ТоварныеНакладныеbindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарные_накладныеTableAdapter
            // 
            this.товарные_накладныеTableAdapter.ClearBeforeFill = true;
            // 
            // EditProductsInNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.DeterminationLabel);
            this.Controls.Add(this.EndPriceOneLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumNDSLabel);
            this.Controls.Add(this.BetNDSlabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.PriceErrorLabel);
            this.Controls.Add(this.BetErrorLabel);
            this.Controls.Add(this.SortErrorLabel);
            this.Controls.Add(this.CountErrorLabel);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.EndPriceTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.TotalNDSTextBox);
            this.Controls.Add(this.SumNDSTextBox);
            this.Controls.Add(this.BetNDSTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.CountBorder);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.UnitDeterminationTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FurnitureLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Name = "EditProductsInNoteForm";
            this.Text = "EditProductsForm";
            this.Load += new System.EventHandler(this.EditProductsInNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварныеНакладныеbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPanle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label DeterminationLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private JMetroTextBox.JMetroTextBox UnitDeterminationTextBox;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label FurnitureLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private JMetroTextBox.JMetroTextBox CountBorder;
        private System.Windows.Forms.Label CountErrorLabel;
        private System.Windows.Forms.Label CountLabel;
        private JMetroTextBox.JMetroTextBox SortTextBox;
        private System.Windows.Forms.Label SortErrorLabel;
        private System.Windows.Forms.Label SortLabel;
        private JMetroTextBox.JMetroTextBox PriceTextBox;
        private System.Windows.Forms.Label PriceErrorLabel;
        private System.Windows.Forms.Label PriceLabel;
        private JMetroTextBox.JMetroTextBox EndPriceTextBox;
        private System.Windows.Forms.Label EndPriceOneLabel;
        private JMetroTextBox.JMetroTextBox BetNDSTextBox;
        private System.Windows.Forms.Label BetErrorLabel;
        private System.Windows.Forms.Label BetNDSlabel;
        private JMetroTextBox.JMetroTextBox SumNDSTextBox;
        private System.Windows.Forms.Label SumNDSLabel;
        private JMetroTextBox.JMetroTextBox TotalNDSTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.BindingSource ТоварныеНакладныеbindingSource;
        private AutomationAppDBDataSet automationAppDBDataSet;
        private AutomationAppDBDataSetTableAdapters.Товарные_накладныеTableAdapter товарные_накладныеTableAdapter;
    }
}