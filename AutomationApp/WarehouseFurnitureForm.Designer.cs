
namespace AutomationApp
{
    partial class WarehouseFurnitureForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.складфурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.склад_фурнитурыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.CreateReprotButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделифурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельфурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseFurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.TopPanel.TabIndex = 18;
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
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.CreateReprotButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 19;
            // 
            // CreateReprotButton
            // 
            this.CreateReprotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateReprotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.CreateReprotButton.FlatAppearance.BorderSize = 0;
            this.CreateReprotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.CreateReprotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateReprotButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.CreateReprotButton.ForeColor = System.Drawing.Color.White;
            this.CreateReprotButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CreateReprotButton.IconColor = System.Drawing.Color.White;
            this.CreateReprotButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateReprotButton.IconSize = 16;
            this.CreateReprotButton.Location = new System.Drawing.Point(1231, 13);
            this.CreateReprotButton.Name = "CreateReprotButton";
            this.CreateReprotButton.Size = new System.Drawing.Size(182, 39);
            this.CreateReprotButton.TabIndex = 10;
            this.CreateReprotButton.Text = "Составить отчет";
            this.CreateReprotButton.UseVisualStyleBackColor = false;
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
            this.SearchTextBox.Size = new System.Drawing.Size(913, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            // 
            // WarehouseFurnitureDataGridView
            // 
            this.WarehouseFurnitureDataGridView.AllowUserToAddRows = false;
            this.WarehouseFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.WarehouseFurnitureDataGridView.AutoGenerateColumns = false;
            this.WarehouseFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WarehouseFurnitureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.WarehouseFurnitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.WarehouseFurnitureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseFurnitureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WarehouseFurnitureDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.WarehouseFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn,
            this.iDФурнитурыDataGridViewTextBoxColumn,
            this.iDМоделифурнитурыDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.модельфурнитурыDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.WarehouseFurnitureDataGridView.DataSource = this.складфурнитурыBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarehouseFurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.WarehouseFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.WarehouseFurnitureDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.WarehouseFurnitureDataGridView.Location = new System.Drawing.Point(0, 118);
            this.WarehouseFurnitureDataGridView.Name = "WarehouseFurnitureDataGridView";
            this.WarehouseFurnitureDataGridView.ReadOnly = true;
            this.WarehouseFurnitureDataGridView.RowHeadersVisible = false;
            this.WarehouseFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WarehouseFurnitureDataGridView.Size = new System.Drawing.Size(1430, 421);
            this.WarehouseFurnitureDataGridView.TabIndex = 20;
            this.WarehouseFurnitureDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WarehouseFurnitureDataGridView_CellMouseDoubleClick);
            // 
            // iDФурнитурынаскладеDataGridViewTextBoxColumn
            // 
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Фурнитуры_на_складе";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Фурнитуры_на_складе";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.Name = "iDФурнитурынаскладеDataGridViewTextBoxColumn";
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDФурнитурынаскладеDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDФурнитурыDataGridViewTextBoxColumn
            // 
            this.iDФурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_Фурнитуры";
            this.iDФурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_Фурнитуры";
            this.iDФурнитурыDataGridViewTextBoxColumn.Name = "iDФурнитурыDataGridViewTextBoxColumn";
            this.iDФурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDФурнитурыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделифурнитурыDataGridViewTextBoxColumn
            // 
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_Модели_фурнитуры";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Name = "iDМоделифурнитурыDataGridViewTextBoxColumn";
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделифурнитурыDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "ФУРНИТУРА";
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
            // WarehouseFurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 539);
            this.Controls.Add(this.WarehouseFurnitureDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WarehouseFurnitureForm";
            this.Text = "WarehouseFurnitureForm";
            this.Load += new System.EventHandler(this.WarehouseFurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseFurnitureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource складфурнитурыBindingSource;
        public AutomationAppDBDataSetTableAdapters.Склад_фурнитурыTableAdapter склад_фурнитурыTableAdapter;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton CreateReprotButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.DataGridView WarehouseFurnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурынаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделифурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельфурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}