
namespace AutomationApp
{
    partial class CounteragentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounteragentsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.контрагентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.контрагентыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.КонтрагентыTableAdapter();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddIButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.CounteragentsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDКонтрагентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounteragentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // контрагентыBindingSource
            // 
            this.контрагентыBindingSource.DataMember = "Контрагенты";
            this.контрагентыBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контрагентыTableAdapter
            // 
            this.контрагентыTableAdapter.ClearBeforeFill = true;
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
            this.TitleFoodPanel.Size = new System.Drawing.Size(1204, 67);
            this.TitleFoodPanel.TabIndex = 22;
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
            this.AddIButton.Location = new System.Drawing.Point(1005, 13);
            this.AddIButton.Name = "AddIButton";
            this.AddIButton.Size = new System.Drawing.Size(182, 39);
            this.AddIButton.TabIndex = 12;
            this.AddIButton.Text = "Добавить контрагента";
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
            this.SearchTextBox.Size = new System.Drawing.Size(925, 20);
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
            this.TopPanel.Size = new System.Drawing.Size(1204, 51);
            this.TopPanel.TabIndex = 21;
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
            this.MaximizedButton.Location = new System.Drawing.Point(1120, 0);
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
            this.HideButton.Location = new System.Drawing.Point(1078, -1);
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
            this.ExitButton.Location = new System.Drawing.Point(1162, 0);
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
            this.label1.Size = new System.Drawing.Size(481, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Выберите контрагента двойным нажатием по строке с данными";
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
            // CounteragentsDataGridView
            // 
            this.CounteragentsDataGridView.AllowUserToAddRows = false;
            this.CounteragentsDataGridView.AllowUserToDeleteRows = false;
            this.CounteragentsDataGridView.AutoGenerateColumns = false;
            this.CounteragentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CounteragentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CounteragentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CounteragentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CounteragentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CounteragentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CounteragentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CounteragentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounteragentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКонтрагентаDataGridViewTextBoxColumn,
            this.уНПDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.CounteragentsDataGridView.DataSource = this.контрагентыBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CounteragentsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.CounteragentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounteragentsDataGridView.EnableHeadersVisualStyles = false;
            this.CounteragentsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.CounteragentsDataGridView.Location = new System.Drawing.Point(0, 118);
            this.CounteragentsDataGridView.Name = "CounteragentsDataGridView";
            this.CounteragentsDataGridView.ReadOnly = true;
            this.CounteragentsDataGridView.RowHeadersVisible = false;
            this.CounteragentsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CounteragentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CounteragentsDataGridView.Size = new System.Drawing.Size(1204, 442);
            this.CounteragentsDataGridView.TabIndex = 23;
            this.CounteragentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CounteragentsDataGridView_CellContentClick);
            this.CounteragentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CounteragentsDataGridView_CellMouseDoubleClick);
            // 
            // iDКонтрагентаDataGridViewTextBoxColumn
            // 
            this.iDКонтрагентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Контрагента";
            this.iDКонтрагентаDataGridViewTextBoxColumn.HeaderText = "ID_Контрагента";
            this.iDКонтрагентаDataGridViewTextBoxColumn.Name = "iDКонтрагентаDataGridViewTextBoxColumn";
            this.iDКонтрагентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКонтрагентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // уНПDataGridViewTextBoxColumn
            // 
            this.уНПDataGridViewTextBoxColumn.DataPropertyName = "УНП";
            this.уНПDataGridViewTextBoxColumn.HeaderText = "УНП";
            this.уНПDataGridViewTextBoxColumn.Name = "уНПDataGridViewTextBoxColumn";
            this.уНПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "НАИМЕНОВАНИЕ";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "АДРЕС";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.EditColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 34;
            // 
            // CounteragentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 560);
            this.Controls.Add(this.CounteragentsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CounteragentsForm";
            this.Text = "ConteragentsForm";
            this.Load += new System.EventHandler(this.ConteragentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.контрагентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounteragentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource контрагентыBindingSource;
        public AutomationAppDBDataSetTableAdapters.КонтрагентыTableAdapter контрагентыTableAdapter;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddIButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView CounteragentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКонтрагентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}