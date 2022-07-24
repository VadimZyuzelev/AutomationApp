
namespace AutomationApp
{
    partial class ReportClothOrderForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FoodTitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.OrderReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AutomationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.Приходные_ордера_на_тканьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Приходные_ордера_на_тканьTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter();
            this.FoodTitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutomationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Приходные_ордера_на_тканьBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.FoodTitleBarPanel.Size = new System.Drawing.Size(1176, 89);
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
            this.TitleBarLabel.Size = new System.Drawing.Size(440, 36);
            this.TitleBarLabel.TabIndex = 8;
            this.TitleBarLabel.Text = "Отчет по приходному ордеру";            
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
            this.MaximizedButton.Location = new System.Drawing.Point(1092, 0);
            this.MaximizedButton.Name = "MaximizedButton";
            this.MaximizedButton.Size = new System.Drawing.Size(42, 34);
            this.MaximizedButton.TabIndex = 7;
            this.MaximizedButton.UseVisualStyleBackColor = false;
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
            this.HideButton.Location = new System.Drawing.Point(1050, -1);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(42, 35);
            this.HideButton.TabIndex = 5;
            this.HideButton.UseVisualStyleBackColor = false;
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
            this.ExitButton.Location = new System.Drawing.Point(1134, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OrderReportViewer
            // 
            this.OrderReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Приходные_ордера_на_тканьBindingSource;
            this.OrderReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.OrderReportViewer.LocalReport.ReportEmbeddedResource = "AutomationApp.ReportClothOrder.rdlc";
            this.OrderReportViewer.Location = new System.Drawing.Point(0, 89);
            this.OrderReportViewer.Name = "OrderReportViewer";
            this.OrderReportViewer.ServerReport.BearerToken = null;
            this.OrderReportViewer.Size = new System.Drawing.Size(1176, 530);
            this.OrderReportViewer.TabIndex = 6;
            // 
            // AutomationAppDBDataSet
            // 
            this.AutomationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.AutomationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Приходные_ордера_на_тканьBindingSource
            // 
            this.Приходные_ордера_на_тканьBindingSource.DataMember = "Приходные_ордера_на_ткань";
            this.Приходные_ордера_на_тканьBindingSource.DataSource = this.AutomationAppDBDataSet;
            // 
            // Приходные_ордера_на_тканьTableAdapter
            // 
            this.Приходные_ордера_на_тканьTableAdapter.ClearBeforeFill = true;
            // 
            // ReportClothOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 619);
            this.Controls.Add(this.OrderReportViewer);
            this.Controls.Add(this.FoodTitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReportClothOrderForm";
            this.Text = "ReportClothOrderForm";
            this.Load += new System.EventHandler(this.ReportClothOrderForm_Load);
            this.FoodTitleBarPanel.ResumeLayout(false);
            this.FoodTitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutomationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Приходные_ордера_на_тканьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FoodTitleBarPanel;
        private System.Windows.Forms.Label TitleBarLabel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Microsoft.Reporting.WinForms.ReportViewer OrderReportViewer;
        private System.Windows.Forms.BindingSource Приходные_ордера_на_тканьBindingSource;
        private AutomationAppDBDataSet AutomationAppDBDataSet;
        private AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter Приходные_ордера_на_тканьTableAdapter;
    }
}