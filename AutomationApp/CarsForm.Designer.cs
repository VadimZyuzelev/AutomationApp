
namespace AutomationApp
{
    partial class CarsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.автомобилиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.АвтомобилиTableAdapter();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddIButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CarsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владелецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
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
            this.TopPanel.Size = new System.Drawing.Size(998, 51);
            this.TopPanel.TabIndex = 22;
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
            this.MaximizedButton.Location = new System.Drawing.Point(914, 0);
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
            this.HideButton.Location = new System.Drawing.Point(872, -1);
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
            this.ExitButton.Location = new System.Drawing.Point(956, 0);
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
            this.label1.Size = new System.Drawing.Size(482, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите автомобиль двойным нажатием по строке с данными";
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
            this.TitleFoodPanel.Controls.Add(this.AddIButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 51);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(998, 67);
            this.TitleFoodPanel.TabIndex = 75;
            // 
            // AddIButton
            // 
            this.AddIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddIButton.FlatAppearance.BorderSize = 0;
            this.AddIButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddIButton.ForeColor = System.Drawing.Color.White;
            this.AddIButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddIButton.IconColor = System.Drawing.Color.White;
            this.AddIButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddIButton.IconSize = 16;
            this.AddIButton.Location = new System.Drawing.Point(799, 13);
            this.AddIButton.Name = "AddIButton";
            this.AddIButton.Size = new System.Drawing.Size(182, 39);
            this.AddIButton.TabIndex = 12;
            this.AddIButton.Text = "Добавить автомобиль";
            this.AddIButton.UseVisualStyleBackColor = false;
            this.AddIButton.Click += new System.EventHandler(this.AddIButton_Click);
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
            this.SearchTextBox.Size = new System.Drawing.Size(719, 20);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CarsDataGridView
            // 
            this.CarsDataGridView.AllowUserToAddRows = false;
            this.CarsDataGridView.AllowUserToDeleteRows = false;
            this.CarsDataGridView.AutoGenerateColumns = false;
            this.CarsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CarsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАвтомобиляDataGridViewTextBoxColumn,
            this.владелецDataGridViewTextBoxColumn,
            this.регистрационныйномерDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.CarsDataGridView.DataSource = this.автомобилиBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsDataGridView.EnableHeadersVisualStyles = false;
            this.CarsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.CarsDataGridView.Location = new System.Drawing.Point(0, 118);
            this.CarsDataGridView.Name = "CarsDataGridView";
            this.CarsDataGridView.ReadOnly = true;
            this.CarsDataGridView.RowHeadersVisible = false;
            this.CarsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsDataGridView.Size = new System.Drawing.Size(998, 417);
            this.CarsDataGridView.TabIndex = 76;
            this.CarsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDataGridView_CellContentClick);
            // 
            // iDАвтомобиляDataGridViewTextBoxColumn
            // 
            this.iDАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "ID_Автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.HeaderText = "ID_Автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.Name = "iDАвтомобиляDataGridViewTextBoxColumn";
            this.iDАвтомобиляDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDАвтомобиляDataGridViewTextBoxColumn.Visible = false;
            // 
            // владелецDataGridViewTextBoxColumn
            // 
            this.владелецDataGridViewTextBoxColumn.DataPropertyName = "Владелец";
            this.владелецDataGridViewTextBoxColumn.HeaderText = "ВЛАДЕЛЕЦ";
            this.владелецDataGridViewTextBoxColumn.Name = "владелецDataGridViewTextBoxColumn";
            this.владелецDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // регистрационныйномерDataGridViewTextBoxColumn
            // 
            this.регистрационныйномерDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_номер";
            this.регистрационныйномерDataGridViewTextBoxColumn.HeaderText = "РЕГ. НОМЕР";
            this.регистрационныйномерDataGridViewTextBoxColumn.Name = "регистрационныйномерDataGridViewTextBoxColumn";
            this.регистрационныйномерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "МАРКА";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Width = 34;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 535);
            this.Controls.Add(this.CarsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CarsForm";
            this.ShowIcon = false;
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource автомобилиBindingSource;
        public AutomationAppDBDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddIButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView CarsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn владелецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}