
namespace AutomationApp
{
    partial class ReceivedItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivedItemsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddRecivedButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RecivedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.изделияпринятыенаскладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.изделия_принятые_на_складTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.маршрутныелистыbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутные_листыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter();
            this.iDПринятогоизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.TitleFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecivedItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияпринятыенаскладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутныелистыbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddRecivedButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1430, 67);
            this.TitleFoodPanel.TabIndex = 10;
            // 
            // AddRecivedButton
            // 
            this.AddRecivedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecivedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddRecivedButton.FlatAppearance.BorderSize = 0;
            this.AddRecivedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddRecivedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecivedButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddRecivedButton.ForeColor = System.Drawing.Color.White;
            this.AddRecivedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddRecivedButton.IconColor = System.Drawing.Color.White;
            this.AddRecivedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddRecivedButton.IconSize = 16;
            this.AddRecivedButton.Location = new System.Drawing.Point(1231, 13);
            this.AddRecivedButton.Name = "AddRecivedButton";
            this.AddRecivedButton.Size = new System.Drawing.Size(182, 39);
            this.AddRecivedButton.TabIndex = 12;
            this.AddRecivedButton.Text = "Принять изделие";
            this.AddRecivedButton.UseVisualStyleBackColor = false;
            this.AddRecivedButton.Click += new System.EventHandler(this.AddRecivedButton_Click);
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
            this.SearchTextBox.Size = new System.Drawing.Size(1027, 20);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.Text = "Введите ваш запрос";
            // 
            // RecivedItemsDataGridView
            // 
            this.RecivedItemsDataGridView.AllowUserToAddRows = false;
            this.RecivedItemsDataGridView.AllowUserToDeleteRows = false;
            this.RecivedItemsDataGridView.AutoGenerateColumns = false;
            this.RecivedItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecivedItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RecivedItemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RecivedItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecivedItemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RecivedItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 20, 8, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecivedItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecivedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecivedItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПринятогоизделияDataGridViewTextBoxColumn,
            this.iDИзделияDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.сортDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.DeleteColumn,
            this.PrintColumn});
            this.RecivedItemsDataGridView.DataSource = this.изделияпринятыенаскладBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecivedItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.RecivedItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecivedItemsDataGridView.EnableHeadersVisualStyles = false;
            this.RecivedItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.RecivedItemsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.RecivedItemsDataGridView.Name = "RecivedItemsDataGridView";
            this.RecivedItemsDataGridView.ReadOnly = true;
            this.RecivedItemsDataGridView.RowHeadersVisible = false;
            this.RecivedItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecivedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecivedItemsDataGridView.Size = new System.Drawing.Size(1430, 588);
            this.RecivedItemsDataGridView.TabIndex = 11;
            this.RecivedItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecivedItemsDataGridView_CellContentClick);
            this.RecivedItemsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.RecivedItemsDataGridView_DataBindingComplete);
            // 
            // изделияпринятыенаскладBindingSource
            // 
            this.изделияпринятыенаскладBindingSource.DataMember = "Изделия_принятые_на_склад";
            this.изделияпринятыенаскладBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изделия_принятые_на_складTableAdapter
            // 
            this.изделия_принятые_на_складTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.FillWeight = 4.595123F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.FillWeight = 5F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AutomationApp.Properties.Resources.printTWO;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // маршрутныелистыbindingSource
            // 
            this.маршрутныелистыbindingSource.DataMember = "Маршрутные_листы";
            this.маршрутныелистыbindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // маршрутные_листыTableAdapter
            // 
            this.маршрутные_листыTableAdapter.ClearBeforeFill = true;
            // 
            // iDПринятогоизделияDataGridViewTextBoxColumn
            // 
            this.iDПринятогоизделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Принятого_изделия";
            this.iDПринятогоизделияDataGridViewTextBoxColumn.HeaderText = "ID_Принятого_изделия";
            this.iDПринятогоизделияDataGridViewTextBoxColumn.Name = "iDПринятогоизделияDataGridViewTextBoxColumn";
            this.iDПринятогоизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПринятогоизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDИзделияDataGridViewTextBoxColumn
            // 
            this.iDИзделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.Name = "iDИзделияDataGridViewTextBoxColumn";
            this.iDИзделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDИзделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Модели_изделия";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Модели_изделия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Маршрутного_листа";
            this.dataGridViewTextBoxColumn1.FillWeight = 55F;
            this.dataGridViewTextBoxColumn1.HeaderText = "НОМЕР МАРШРУТНОГО ЛИСТА";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn3.FillWeight = 4.595123F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ИЗДЕЛИЕ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Модель_изделия";
            this.dataGridViewTextBoxColumn4.FillWeight = 4.595123F;
            this.dataGridViewTextBoxColumn4.HeaderText = "МОДЕЛЬ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // сортDataGridViewTextBoxColumn
            // 
            this.сортDataGridViewTextBoxColumn.DataPropertyName = "Сорт";
            this.сортDataGridViewTextBoxColumn.FillWeight = 4.595123F;
            this.сортDataGridViewTextBoxColumn.HeaderText = "СОРТ";
            this.сортDataGridViewTextBoxColumn.Name = "сортDataGridViewTextBoxColumn";
            this.сортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.FillWeight = 4.595123F;
            this.количествоDataGridViewTextBoxColumn.HeaderText = "КОЛИЧЕСТВО";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteColumn.FillWeight = 4.595123F;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Width = 34;
            // 
            // PrintColumn
            // 
            this.PrintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.PrintColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrintColumn.FillWeight = 5F;
            this.PrintColumn.HeaderText = "";
            this.PrintColumn.Image = global::AutomationApp.Properties.Resources.printTWO;
            this.PrintColumn.Name = "PrintColumn";
            this.PrintColumn.ReadOnly = true;
            this.PrintColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrintColumn.Width = 34;
            // 
            // ReceivedItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 655);
            this.Controls.Add(this.RecivedItemsDataGridView);
            this.Controls.Add(this.TitleFoodPanel);
            this.Name = "ReceivedItemsForm";
            this.Text = "ReceivedItemsForm";
            this.Load += new System.EventHandler(this.ReceivedItemsForm_Load);
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecivedItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияпринятыенаскладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутныелистыbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddRecivedButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.DataGridView RecivedItemsDataGridView;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public System.Windows.Forms.BindingSource изделияпринятыенаскладBindingSource;
        public AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter изделия_принятые_на_складTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter маршрутные_листыTableAdapter;
        public System.Windows.Forms.BindingSource маршрутныелистыbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПринятогоизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn сортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn PrintColumn;
    }
}