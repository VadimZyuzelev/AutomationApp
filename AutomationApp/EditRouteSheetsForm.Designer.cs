
namespace AutomationApp
{
    partial class EditRouteSheetsForm
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
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.изделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberBorder = new JMetroTextBox.JMetroTextBox();
            this.ItemBorder = new JMetroTextBox.JMetroTextBox();
            this.ModelBorder = new JMetroTextBox.JMetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrowthBorder = new JMetroTextBox.JMetroTextBox();
            this.SizeBorder = new JMetroTextBox.JMetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FullnessBorder = new JMetroTextBox.JMetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ColorBorder = new JMetroTextBox.JMetroTextBox();
            this.изделияTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter();
            this.моделиизделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.модели_изделияTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_изделияTableAdapter();
            this.NumberTicketTextBox = new System.Windows.Forms.TextBox();
            this.SaveSheetButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.GrowthLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.FullnessLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.GrowthTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.FullnessTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.SelectItemButton = new FontAwesome.Sharp.IconButton();
            this.fKМоделиизМодел38996AB5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.моделиизделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиизМодел38996AB5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TitleBarPanel.Controls.Add(this.ExitButton);
            this.TitleBarPanel.Controls.Add(this.IconPictureBox);
            this.TitleBarPanel.Controls.Add(this.LabelForm);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(833, 51);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 25;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(789, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 32);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.IconPictureBox.ForeColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconPictureBox.IconColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBox.IconSize = 18;
            this.IconPictureBox.Location = new System.Drawing.Point(22, 17);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(18, 18);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconPictureBox.TabIndex = 3;
            this.IconPictureBox.TabStop = false;
            // 
            // LabelForm
            // 
            this.LabelForm.AutoSize = true;
            this.LabelForm.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForm.ForeColor = System.Drawing.Color.Gray;
            this.LabelForm.Location = new System.Drawing.Point(46, 14);
            this.LabelForm.Name = "LabelForm";
            this.LabelForm.Size = new System.Drawing.Size(246, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление маршрутного листа";
            // 
            // изделияBindingSource
            // 
            this.изделияBindingSource.DataMember = "Изделия";
            this.изделияBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Модель изделия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Изделие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер заказа";
            // 
            // NumberBorder
            // 
            this.NumberBorder.BackColor = System.Drawing.Color.Transparent;
            this.NumberBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NumberBorder.BorderRadius = 2;
            this.NumberBorder.Enabled = false;
            this.NumberBorder.FillColor = System.Drawing.SystemColors.Window;
            this.NumberBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberBorder.ForeColors = System.Drawing.Color.Black;
            this.NumberBorder.IsPassword = false;
            this.NumberBorder.LineThickness = 1;
            this.NumberBorder.Location = new System.Drawing.Point(21, 99);
            this.NumberBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberBorder.MaxLength = 32767;
            this.NumberBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.NumberBorder.Name = "NumberBorder";
            this.NumberBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.NumberBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NumberBorder.ReadOnly = false;
            this.NumberBorder.Size = new System.Drawing.Size(223, 41);
            this.NumberBorder.TabIndex = 15;
            this.NumberBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberBorder.TextName = "";
            this.NumberBorder.Enter += new System.EventHandler(this.NumberTicketTextBox_Enter);
            this.NumberBorder.Leave += new System.EventHandler(this.NumberTicketTextBox_Leave);
            // 
            // ItemBorder
            // 
            this.ItemBorder.BackColor = System.Drawing.Color.Transparent;
            this.ItemBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ItemBorder.BorderRadius = 2;
            this.ItemBorder.Enabled = false;
            this.ItemBorder.FillColor = System.Drawing.SystemColors.Window;
            this.ItemBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemBorder.ForeColors = System.Drawing.Color.Black;
            this.ItemBorder.IsPassword = false;
            this.ItemBorder.LineThickness = 1;
            this.ItemBorder.Location = new System.Drawing.Point(21, 192);
            this.ItemBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemBorder.MaxLength = 32767;
            this.ItemBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.ItemBorder.Name = "ItemBorder";
            this.ItemBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.ItemBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ItemBorder.ReadOnly = false;
            this.ItemBorder.Size = new System.Drawing.Size(223, 41);
            this.ItemBorder.TabIndex = 15;
            this.ItemBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemBorder.TextName = "";
            // 
            // ModelBorder
            // 
            this.ModelBorder.BackColor = System.Drawing.Color.Transparent;
            this.ModelBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ModelBorder.BorderRadius = 2;
            this.ModelBorder.Enabled = false;
            this.ModelBorder.FillColor = System.Drawing.SystemColors.Window;
            this.ModelBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelBorder.ForeColors = System.Drawing.Color.Black;
            this.ModelBorder.IsPassword = false;
            this.ModelBorder.LineThickness = 1;
            this.ModelBorder.Location = new System.Drawing.Point(21, 286);
            this.ModelBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelBorder.MaxLength = 32767;
            this.ModelBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelBorder.Name = "ModelBorder";
            this.ModelBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelBorder.ReadOnly = false;
            this.ModelBorder.Size = new System.Drawing.Size(223, 41);
            this.ModelBorder.TabIndex = 16;
            this.ModelBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelBorder.TextName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(317, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Рост (см.)";
            // 
            // GrowthBorder
            // 
            this.GrowthBorder.BackColor = System.Drawing.Color.Transparent;
            this.GrowthBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.GrowthBorder.BorderRadius = 2;
            this.GrowthBorder.Enabled = false;
            this.GrowthBorder.FillColor = System.Drawing.SystemColors.Window;
            this.GrowthBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GrowthBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GrowthBorder.ForeColors = System.Drawing.Color.Black;
            this.GrowthBorder.IsPassword = false;
            this.GrowthBorder.LineThickness = 1;
            this.GrowthBorder.Location = new System.Drawing.Point(317, 99);
            this.GrowthBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrowthBorder.MaxLength = 32767;
            this.GrowthBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.GrowthBorder.Name = "GrowthBorder";
            this.GrowthBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.GrowthBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.GrowthBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.GrowthBorder.ReadOnly = false;
            this.GrowthBorder.Size = new System.Drawing.Size(223, 41);
            this.GrowthBorder.TabIndex = 19;
            this.GrowthBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GrowthBorder.TextName = "";
            // 
            // SizeBorder
            // 
            this.SizeBorder.BackColor = System.Drawing.Color.Transparent;
            this.SizeBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SizeBorder.BorderRadius = 2;
            this.SizeBorder.Enabled = false;
            this.SizeBorder.FillColor = System.Drawing.SystemColors.Window;
            this.SizeBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SizeBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SizeBorder.ForeColors = System.Drawing.Color.Black;
            this.SizeBorder.IsPassword = false;
            this.SizeBorder.LineThickness = 1;
            this.SizeBorder.Location = new System.Drawing.Point(317, 192);
            this.SizeBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeBorder.MaxLength = 32767;
            this.SizeBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.SizeBorder.Name = "SizeBorder";
            this.SizeBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SizeBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.SizeBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SizeBorder.ReadOnly = false;
            this.SizeBorder.Size = new System.Drawing.Size(223, 41);
            this.SizeBorder.TabIndex = 15;
            this.SizeBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SizeBorder.TextName = "";
            this.SizeBorder.Enter += new System.EventHandler(this.SizeComboBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(316, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Размер (см.)";
            // 
            // FullnessBorder
            // 
            this.FullnessBorder.BackColor = System.Drawing.Color.Transparent;
            this.FullnessBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.FullnessBorder.BorderRadius = 2;
            this.FullnessBorder.Enabled = false;
            this.FullnessBorder.FillColor = System.Drawing.SystemColors.Window;
            this.FullnessBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FullnessBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FullnessBorder.ForeColors = System.Drawing.Color.Black;
            this.FullnessBorder.IsPassword = false;
            this.FullnessBorder.LineThickness = 1;
            this.FullnessBorder.Location = new System.Drawing.Point(317, 288);
            this.FullnessBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FullnessBorder.MaxLength = 32767;
            this.FullnessBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.FullnessBorder.Name = "FullnessBorder";
            this.FullnessBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnessBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.FullnessBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.FullnessBorder.ReadOnly = false;
            this.FullnessBorder.Size = new System.Drawing.Size(223, 41);
            this.FullnessBorder.TabIndex = 16;
            this.FullnessBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FullnessBorder.TextName = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(315, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Полнота (см.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(590, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Код цвета";
            // 
            // ColorBorder
            // 
            this.ColorBorder.BackColor = System.Drawing.Color.Transparent;
            this.ColorBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ColorBorder.BorderRadius = 2;
            this.ColorBorder.Enabled = false;
            this.ColorBorder.FillColor = System.Drawing.SystemColors.Window;
            this.ColorBorder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ColorBorder.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ColorBorder.ForeColors = System.Drawing.Color.Black;
            this.ColorBorder.IsPassword = false;
            this.ColorBorder.LineThickness = 1;
            this.ColorBorder.Location = new System.Drawing.Point(590, 99);
            this.ColorBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorBorder.MaxLength = 32767;
            this.ColorBorder.MouseOnHover = System.Drawing.Color.Empty;
            this.ColorBorder.Name = "ColorBorder";
            this.ColorBorder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ColorBorder.OnFocusColor = System.Drawing.Color.Empty;
            this.ColorBorder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ColorBorder.ReadOnly = false;
            this.ColorBorder.Size = new System.Drawing.Size(223, 41);
            this.ColorBorder.TabIndex = 19;
            this.ColorBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ColorBorder.TextName = "";
            // 
            // изделияTableAdapter
            // 
            this.изделияTableAdapter.ClearBeforeFill = true;
            // 
            // моделиизделияBindingSource
            // 
            this.моделиизделияBindingSource.DataMember = "Модели_изделия";
            this.моделиизделияBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // модели_изделияTableAdapter
            // 
            this.модели_изделияTableAdapter.ClearBeforeFill = true;
            // 
            // NumberTicketTextBox
            // 
            this.NumberTicketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberTicketTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.NumberTicketTextBox.Location = new System.Drawing.Point(36, 111);
            this.NumberTicketTextBox.Name = "NumberTicketTextBox";
            this.NumberTicketTextBox.Size = new System.Drawing.Size(200, 17);
            this.NumberTicketTextBox.TabIndex = 23;
            this.NumberTicketTextBox.Enter += new System.EventHandler(this.NumberTicketTextBox_Enter);
            this.NumberTicketTextBox.Leave += new System.EventHandler(this.NumberTicketTextBox_Leave);
            // 
            // SaveSheetButton
            // 
            this.SaveSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveSheetButton.FlatAppearance.BorderSize = 0;
            this.SaveSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSheetButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveSheetButton.ForeColor = System.Drawing.Color.White;
            this.SaveSheetButton.Location = new System.Drawing.Point(693, 290);
            this.SaveSheetButton.Name = "SaveSheetButton";
            this.SaveSheetButton.Size = new System.Drawing.Size(116, 39);
            this.SaveSheetButton.TabIndex = 24;
            this.SaveSheetButton.Text = "СОХРАНИТЬ";
            this.SaveSheetButton.UseVisualStyleBackColor = false;
            this.SaveSheetButton.Click += new System.EventHandler(this.SaveSheetButton_Click);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(575, 290);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(116, 39);
            this.CancelAddButton.TabIndex = 24;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumberLabel.Location = new System.Drawing.Point(21, 144);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(127, 16);
            this.NumberLabel.TabIndex = 25;
            this.NumberLabel.Text = "Введите номер заказа";
            this.NumberLabel.Visible = false;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ItemLabel.Location = new System.Drawing.Point(21, 237);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(109, 16);
            this.ItemLabel.TabIndex = 25;
            this.ItemLabel.Text = "Выберите изделие";
            this.ItemLabel.Visible = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelLabel.Location = new System.Drawing.Point(21, 331);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(105, 16);
            this.ModelLabel.TabIndex = 25;
            this.ModelLabel.Text = "Выберите модель";
            this.ModelLabel.Visible = false;
            // 
            // GrowthLabel
            // 
            this.GrowthLabel.AutoSize = true;
            this.GrowthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrowthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GrowthLabel.Location = new System.Drawing.Point(318, 144);
            this.GrowthLabel.Name = "GrowthLabel";
            this.GrowthLabel.Size = new System.Drawing.Size(140, 16);
            this.GrowthLabel.TabIndex = 25;
            this.GrowthLabel.Text = "Введите значение роста";
            this.GrowthLabel.Visible = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SizeLabel.Location = new System.Drawing.Point(318, 237);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(164, 16);
            this.SizeLabel.TabIndex = 25;
            this.SizeLabel.Text = "Выберите значение размера";
            this.SizeLabel.Visible = false;
            // 
            // FullnessLabel
            // 
            this.FullnessLabel.AutoSize = true;
            this.FullnessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FullnessLabel.Location = new System.Drawing.Point(318, 331);
            this.FullnessLabel.Name = "FullnessLabel";
            this.FullnessLabel.Size = new System.Drawing.Size(167, 16);
            this.FullnessLabel.TabIndex = 25;
            this.FullnessLabel.Text = "Выберите значение полноты";
            this.FullnessLabel.Visible = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ColorLabel.Location = new System.Drawing.Point(591, 144);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(108, 16);
            this.ColorLabel.TabIndex = 25;
            this.ColorLabel.Text = "Введите код цвета";
            this.ColorLabel.Visible = false;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.ItemTextBox.Location = new System.Drawing.Point(36, 204);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(200, 17);
            this.ItemTextBox.TabIndex = 26;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.ModelTextBox.Location = new System.Drawing.Point(36, 297);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(200, 17);
            this.ModelTextBox.TabIndex = 26;
            // 
            // GrowthTextBox
            // 
            this.GrowthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrowthTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.GrowthTextBox.Location = new System.Drawing.Point(331, 111);
            this.GrowthTextBox.Name = "GrowthTextBox";
            this.GrowthTextBox.Size = new System.Drawing.Size(200, 17);
            this.GrowthTextBox.TabIndex = 26;
            this.GrowthTextBox.Enter += new System.EventHandler(this.GrowthTextBox_Enter);
            this.GrowthTextBox.Leave += new System.EventHandler(this.GrowthTextBox_Leave);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.SizeTextBox.Location = new System.Drawing.Point(331, 204);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(200, 17);
            this.SizeTextBox.TabIndex = 26;
            this.SizeTextBox.Enter += new System.EventHandler(this.SizeTextBox_Enter);
            this.SizeTextBox.Leave += new System.EventHandler(this.SizeTextBox_Leave);
            // 
            // FullnessTextBox
            // 
            this.FullnessTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullnessTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.FullnessTextBox.Location = new System.Drawing.Point(331, 299);
            this.FullnessTextBox.Name = "FullnessTextBox";
            this.FullnessTextBox.Size = new System.Drawing.Size(200, 17);
            this.FullnessTextBox.TabIndex = 26;
            this.FullnessTextBox.Enter += new System.EventHandler(this.FullnessTextBox_Enter);
            this.FullnessTextBox.Leave += new System.EventHandler(this.FullnessTextBox_Leave);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColorTextBox.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.ColorTextBox.Location = new System.Drawing.Point(604, 111);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(200, 17);
            this.ColorTextBox.TabIndex = 26;
            this.ColorTextBox.Enter += new System.EventHandler(this.ColorTextBox_Enter);
            this.ColorTextBox.Leave += new System.EventHandler(this.ColorTextBox_Leave);
            // 
            // SelectItemButton
            // 
            this.SelectItemButton.FlatAppearance.BorderSize = 0;
            this.SelectItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(197)))));
            this.SelectItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(215)))));
            this.SelectItemButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectItemButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(215)))));
            this.SelectItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectItemButton.IconSize = 40;
            this.SelectItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectItemButton.Location = new System.Drawing.Point(246, 199);
            this.SelectItemButton.Name = "SelectItemButton";
            this.SelectItemButton.Size = new System.Drawing.Size(52, 34);
            this.SelectItemButton.TabIndex = 17;
            this.SelectItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectItemButton.UseVisualStyleBackColor = true;
            this.SelectItemButton.Click += new System.EventHandler(this.SelectItemButton_Click);
            // 
            // fKМоделиизМодел38996AB5BindingSource
            // 
            this.fKМоделиизМодел38996AB5BindingSource.DataMember = "FK__Модели_из__Модел__38996AB5";
            this.fKМоделиизМодел38996AB5BindingSource.DataSource = this.изделияBindingSource;
            // 
            // EditRouteSheetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CancelAddButton;
            this.ClientSize = new System.Drawing.Size(833, 363);
            this.Controls.Add(this.FullnessTextBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.GrowthTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.FullnessLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.GrowthLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveSheetButton);
            this.Controls.Add(this.NumberTicketTextBox);
            this.Controls.Add(this.ColorBorder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrowthBorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectItemButton);
            this.Controls.Add(this.NumberBorder);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SizeBorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullnessBorder);
            this.Controls.Add(this.ItemBorder);
            this.Controls.Add(this.ModelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditRouteSheetsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRouteSheetsForm";
            this.Load += new System.EventHandler(this.EditRouteSheetsForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.моделиизделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиизМодел38996AB5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label LabelForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private JMetroTextBox.JMetroTextBox NumberBorder;
        private JMetroTextBox.JMetroTextBox ItemBorder;
        private JMetroTextBox.JMetroTextBox ModelBorder;
        private FontAwesome.Sharp.IconButton SelectItemButton;
        private System.Windows.Forms.Label label5;
        private JMetroTextBox.JMetroTextBox GrowthBorder;
        private JMetroTextBox.JMetroTextBox SizeBorder;
        private System.Windows.Forms.Label label6;
        private JMetroTextBox.JMetroTextBox FullnessBorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private JMetroTextBox.JMetroTextBox ColorBorder;
        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource изделияBindingSource;
        private AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter изделияTableAdapter;
        private System.Windows.Forms.BindingSource моделиизделияBindingSource;
        private AutomationAppDBDataSetTableAdapters.Модели_изделияTableAdapter модели_изделияTableAdapter;
        private System.Windows.Forms.BindingSource fKМоделиизМодел38996AB5BindingSource;
        private System.Windows.Forms.TextBox NumberTicketTextBox;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Button SaveSheetButton;
        private System.Windows.Forms.Button CancelAddButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label GrowthLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label FullnessLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox GrowthTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox FullnessTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
    }
}