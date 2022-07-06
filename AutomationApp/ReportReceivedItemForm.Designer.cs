
namespace AutomationApp
{
    partial class ReportReceivedItemForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AutomationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.Маршрутные_листыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Маршрутные_листыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter();
            this.Изделия_принятые_на_складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Изделия_принятые_на_складTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter();
            this.FoodTitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AutomationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Маршрутные_листыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Изделия_принятые_на_складBindingSource)).BeginInit();
            this.FoodTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutomationAppDBDataSet
            // 
            this.AutomationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.AutomationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Маршрутные_листыBindingSource
            // 
            this.Маршрутные_листыBindingSource.DataMember = "Маршрутные_листы";
            this.Маршрутные_листыBindingSource.DataSource = this.AutomationAppDBDataSet;
            // 
            // Маршрутные_листыTableAdapter
            // 
            this.Маршрутные_листыTableAdapter.ClearBeforeFill = true;
            // 
            // Изделия_принятые_на_складBindingSource
            // 
            this.Изделия_принятые_на_складBindingSource.DataMember = "Изделия_принятые_на_склад";
            this.Изделия_принятые_на_складBindingSource.DataSource = this.AutomationAppDBDataSet;
            // 
            // Изделия_принятые_на_складTableAdapter
            // 
            this.Изделия_принятые_на_складTableAdapter.ClearBeforeFill = true;
            // 
            // FoodTitleBarPanel
            // 
            this.FoodTitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FoodTitleBarPanel.Controls.Add(this.TitleBarLabel);
            this.FoodTitleBarPanel.Controls.Add(this.MaximizedButton);
            this.FoodTitleBarPanel.Controls.Add(this.HideButton);
            this.FoodTitleBarPanel.Controls.Add(this.ExitButton);
            this.FoodTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.FoodTitleBarPanel.Name = "FoodTitleBarPanel";
            this.FoodTitleBarPanel.Size = new System.Drawing.Size(1264, 89);
            this.FoodTitleBarPanel.TabIndex = 5;
            this.FoodTitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FoodTitleBarPanel_MouseDown);
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.TitleBarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.TitleBarLabel.Location = new System.Drawing.Point(24, 25);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(441, 36);
            this.TitleBarLabel.TabIndex = 8;
            this.TitleBarLabel.Text = "Отчет по принятым изделиям";
            // 
            // MaximizedButton
            // 
            this.MaximizedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizedButton.FlatAppearance.BorderSize = 0;
            this.MaximizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizedButton.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.MaximizedButton.IconColor = System.Drawing.Color.Gray;
            this.MaximizedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizedButton.IconSize = 18;
            this.MaximizedButton.Location = new System.Drawing.Point(1180, 0);
            this.MaximizedButton.Name = "MaximizedButton";
            this.MaximizedButton.Size = new System.Drawing.Size(42, 34);
            this.MaximizedButton.TabIndex = 7;
            this.MaximizedButton.UseVisualStyleBackColor = false;
            this.MaximizedButton.Click += new System.EventHandler(this.MaximizedButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.HideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.HideButton.IconColor = System.Drawing.Color.Gray;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.IconSize = 18;
            this.HideButton.Location = new System.Drawing.Point(1138, -1);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(42, 35);
            this.HideButton.TabIndex = 5;
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 18;
            this.ExitButton.Location = new System.Drawing.Point(1222, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.Маршрутные_листыBindingSource;
            reportDataSource12.Name = "DataSet2";
            reportDataSource12.Value = this.Изделия_принятые_на_складBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AutomationApp.ReportRecieved.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 89);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1264, 544);
            this.reportViewer.TabIndex = 6;
            // 
            // ReportReceivedItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 633);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.FoodTitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReportReceivedItemForm";
            this.Text = "ReprotReceivedItemForm";
            this.Load += new System.EventHandler(this.ReprotReceivedItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutomationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Маршрутные_листыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Изделия_принятые_на_складBindingSource)).EndInit();
            this.FoodTitleBarPanel.ResumeLayout(false);
            this.FoodTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Маршрутные_листыBindingSource;
        private AutomationAppDBDataSet AutomationAppDBDataSet;
        private System.Windows.Forms.BindingSource Изделия_принятые_на_складBindingSource;
        private AutomationAppDBDataSetTableAdapters.Маршрутные_листыTableAdapter Маршрутные_листыTableAdapter;
        private AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter Изделия_принятые_на_складTableAdapter;
        private System.Windows.Forms.Panel FoodTitleBarPanel;
        private System.Windows.Forms.Label TitleBarLabel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}