
namespace AutomationApp
{
    partial class ReportWarhouseClothForm
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
            this.FoodTitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.MaximizedButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FoodTitleBarPanel.SuspendLayout();
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
            this.FoodTitleBarPanel.Size = new System.Drawing.Size(1082, 89);
            this.FoodTitleBarPanel.TabIndex = 6;
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.TitleBarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.TitleBarLabel.Location = new System.Drawing.Point(24, 25);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(423, 36);
            this.TitleBarLabel.TabIndex = 8;
            this.TitleBarLabel.Text = "Отчет по остаткам на складе";
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
            this.MaximizedButton.Location = new System.Drawing.Point(998, 0);
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
            this.HideButton.Location = new System.Drawing.Point(956, -1);
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
            this.ExitButton.Location = new System.Drawing.Point(1040, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomationApp.ReportWarehouseCloth.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1082, 361);
            this.reportViewer1.TabIndex = 7;
            // 
            // ReportWarhouseClothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.FoodTitleBarPanel);
            this.Name = "ReportWarhouseClothForm";
            this.Text = "ReprotWarhouseClothForm";
            this.Load += new System.EventHandler(this.ReportWarhouseClothForm_Load);
            this.FoodTitleBarPanel.ResumeLayout(false);
            this.FoodTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FoodTitleBarPanel;
        private System.Windows.Forms.Label TitleBarLabel;
        private FontAwesome.Sharp.IconButton MaximizedButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}