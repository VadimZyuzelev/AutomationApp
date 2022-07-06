
namespace AutomationApp
{
    partial class ClothsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.тканиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ТканиTableAdapter();
            this.fKМоделиткIDТк6C190EBBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.модели_тканиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Модели_тканиTableAdapter();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddClothButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ModelClothsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDТканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделитканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельтканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.моделитканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиткIDТк6C190EBBBindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelClothsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.моделитканиBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // fKМоделиткIDТк6C190EBBBindingSource
            // 
            this.fKМоделиткIDТк6C190EBBBindingSource.DataMember = "FK__Модели_тк__ID_Тк__6C190EBB";
            this.fKМоделиткIDТк6C190EBBBindingSource.DataSource = this.тканиBindingSource;
            // 
            // модели_тканиTableAdapter
            // 
            this.модели_тканиTableAdapter.ClearBeforeFill = true;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddClothButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1042, 67);
            this.TitleFoodPanel.TabIndex = 5;
            // 
            // AddClothButton
            // 
            this.AddClothButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddClothButton.FlatAppearance.BorderSize = 0;
            this.AddClothButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddClothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClothButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddClothButton.ForeColor = System.Drawing.Color.White;
            this.AddClothButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddClothButton.IconColor = System.Drawing.Color.White;
            this.AddClothButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClothButton.IconSize = 16;
            this.AddClothButton.Location = new System.Drawing.Point(843, 14);
            this.AddClothButton.Name = "AddClothButton";
            this.AddClothButton.Size = new System.Drawing.Size(182, 39);
            this.AddClothButton.TabIndex = 9;
            this.AddClothButton.Text = "Добавить ткань";
            this.AddClothButton.UseVisualStyleBackColor = false;
            this.AddClothButton.Click += new System.EventHandler(this.AddClothButton_Click);
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
            this.SearchTextBox.Size = new System.Drawing.Size(763, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.MaximizedButton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.HideButton);
            this.TopPanel.Controls.Add(this.iconPictureBox1);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1042, 51);
            this.TopPanel.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(433, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите ткань двойным нажатием по строке с данными";
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
            // ModelClothsDataGridView
            // 
            this.ModelClothsDataGridView.AllowUserToAddRows = false;
            this.ModelClothsDataGridView.AllowUserToDeleteRows = false;
            this.ModelClothsDataGridView.AutoGenerateColumns = false;
            this.ModelClothsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ModelClothsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ModelClothsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ModelClothsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelClothsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ModelClothsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModelClothsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ModelClothsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelClothsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТканиDataGridViewTextBoxColumn,
            this.iDМоделитканиDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельтканиDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.ModelClothsDataGridView.DataSource = this.моделитканиBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModelClothsDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.ModelClothsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelClothsDataGridView.EnableHeadersVisualStyles = false;
            this.ModelClothsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ModelClothsDataGridView.Location = new System.Drawing.Point(0, 118);
            this.ModelClothsDataGridView.MultiSelect = false;
            this.ModelClothsDataGridView.Name = "ModelClothsDataGridView";
            this.ModelClothsDataGridView.ReadOnly = true;
            this.ModelClothsDataGridView.RowHeadersVisible = false;
            this.ModelClothsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelClothsDataGridView.Size = new System.Drawing.Size(1042, 393);
            this.ModelClothsDataGridView.TabIndex = 6;
            this.ModelClothsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelClothsDataGridView_CellContentClick);
            this.ModelClothsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ModelClothsDataGridView_CellMouseDoubleClick);
            this.ModelClothsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModelClothsDataGridView_DataBindingComplete);
            // 
            // iDТканиDataGridViewTextBoxColumn
            // 
            this.iDТканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.HeaderText = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.Name = "iDТканиDataGridViewTextBoxColumn";
            this.iDТканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделитканиDataGridViewTextBoxColumn
            // 
            this.iDМоделитканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.HeaderText = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.Name = "iDМоделитканиDataGridViewTextBoxColumn";
            this.iDМоделитканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделитканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "НАИМЕНОВАНИЕ";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельтканиDataGridViewTextBoxColumn
            // 
            this.модельтканиDataGridViewTextBoxColumn.DataPropertyName = "Модель_ткани";
            this.модельтканиDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельтканиDataGridViewTextBoxColumn.Name = "модельтканиDataGridViewTextBoxColumn";
            this.модельтканиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Width = 34;
            // 
            // моделитканиBindingSource
            // 
            this.моделитканиBindingSource.DataMember = "Модели_ткани";
            this.моделитканиBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // DataGridViewGrouper
            // 
            this.DataGridViewGrouper.Options = ((Subro.Controls.GroupingOptions)(resources.GetObject("DataGridViewGrouper.Options")));
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
            this.MaximizedButton.Location = new System.Drawing.Point(958, 0);
            this.MaximizedButton.Name = "MaximizedButton";
            this.MaximizedButton.Size = new System.Drawing.Size(42, 34);
            this.MaximizedButton.TabIndex = 76;
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
            this.HideButton.Location = new System.Drawing.Point(916, -1);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(42, 35);
            this.HideButton.TabIndex = 74;
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
            this.ExitButton.Location = new System.Drawing.Point(1000, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 75;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClothsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 511);
            this.Controls.Add(this.ModelClothsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ClothsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClothsForm";
            this.Load += new System.EventHandler(this.ClothsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМоделиткIDТк6C190EBBBindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelClothsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.моделитканиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource тканиBindingSource;
        public AutomationAppDBDataSetTableAdapters.ТканиTableAdapter тканиTableAdapter;
        public System.Windows.Forms.BindingSource fKМоделиткIDТк6C190EBBBindingSource;
        public AutomationAppDBDataSetTableAdapters.Модели_тканиTableAdapter модели_тканиTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddClothButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView ModelClothsDataGridView;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.BindingSource моделитканиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделитканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельтканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private Subro.Controls.DataGridViewGrouper DataGridViewGrouper;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}