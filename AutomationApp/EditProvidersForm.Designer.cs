
namespace AutomationApp
{
    partial class EditProvidersForm
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
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ProviderTextBox = new JMetroTextBox.JMetroTextBox();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.ProviderErrorLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new JMetroTextBox.JMetroTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(172, 285);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(130, 39);
            this.CancelAddButton.TabIndex = 35;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(24, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(146, 39);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 25;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(277, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 32);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.ExitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseUp);
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
            this.LabelForm.Location = new System.Drawing.Point(46, 15);
            this.LabelForm.Name = "LabelForm";
            this.LabelForm.Size = new System.Drawing.Size(191, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление поставщика";
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
            this.TitleBarPanel.Size = new System.Drawing.Size(330, 51);
            this.TitleBarPanel.TabIndex = 39;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ProviderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ProviderTextBox.BorderRadius = 2;
            this.ProviderTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.ProviderTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProviderTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProviderTextBox.ForeColors = System.Drawing.Color.Black;
            this.ProviderTextBox.IsPassword = false;
            this.ProviderTextBox.LineThickness = 1;
            this.ProviderTextBox.Location = new System.Drawing.Point(21, 96);
            this.ProviderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProviderTextBox.MaxLength = 32767;
            this.ProviderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProviderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.ReadOnly = false;
            this.ProviderTextBox.Size = new System.Drawing.Size(285, 41);
            this.ProviderTextBox.TabIndex = 40;
            this.ProviderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProviderTextBox.TextName = "";
            this.ProviderTextBox.Enter += new System.EventHandler(this.ProviderTextBox_Enter);
            this.ProviderTextBox.Leave += new System.EventHandler(this.ProviderTextBox_Leave);
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ProviderLabel.ForeColor = System.Drawing.Color.Gray;
            this.ProviderLabel.Location = new System.Drawing.Point(20, 73);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(105, 19);
            this.ProviderLabel.TabIndex = 41;
            this.ProviderLabel.Text = "Наименование";
            // 
            // ProviderErrorLabel
            // 
            this.ProviderErrorLabel.AutoSize = true;
            this.ProviderErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProviderErrorLabel.Location = new System.Drawing.Point(21, 141);
            this.ProviderErrorLabel.Name = "ProviderErrorLabel";
            this.ProviderErrorLabel.Size = new System.Drawing.Size(135, 16);
            this.ProviderErrorLabel.TabIndex = 42;
            this.ProviderErrorLabel.Text = "Введите наименование";
            this.ProviderErrorLabel.Visible = false;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.Transparent;
            this.AddressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.AddressTextBox.BorderRadius = 2;
            this.AddressTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.AddressTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddressTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddressTextBox.ForeColors = System.Drawing.Color.Black;
            this.AddressTextBox.IsPassword = false;
            this.AddressTextBox.LineThickness = 1;
            this.AddressTextBox.Location = new System.Drawing.Point(21, 198);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.MaxLength = 32767;
            this.AddressTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.AddressTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.AddressTextBox.ReadOnly = false;
            this.AddressTextBox.Size = new System.Drawing.Size(285, 41);
            this.AddressTextBox.TabIndex = 43;
            this.AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddressTextBox.TextName = "";
            this.AddressTextBox.Enter += new System.EventHandler(this.AddressTextBox_Enter);
            this.AddressTextBox.Leave += new System.EventHandler(this.AddressTextBox_Leave);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.AddressLabel.ForeColor = System.Drawing.Color.Gray;
            this.AddressLabel.Location = new System.Drawing.Point(20, 175);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 19);
            this.AddressLabel.TabIndex = 44;
            this.AddressLabel.Text = "Адрес";
            // 
            // AddressErrorLabel
            // 
            this.AddressErrorLabel.AutoSize = true;
            this.AddressErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddressErrorLabel.Location = new System.Drawing.Point(21, 243);
            this.AddressErrorLabel.Name = "AddressErrorLabel";
            this.AddressErrorLabel.Size = new System.Drawing.Size(87, 16);
            this.AddressErrorLabel.TabIndex = 45;
            this.AddressErrorLabel.Text = "Введите адрес";
            this.AddressErrorLabel.Visible = false;
            // 
            // EditProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(330, 348);
            this.Controls.Add(this.AddressErrorLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ProviderErrorLabel);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditProvidersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label LabelForm;
        private System.Windows.Forms.Panel TitleBarPanel;
        private JMetroTextBox.JMetroTextBox ProviderTextBox;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Label ProviderErrorLabel;
        private JMetroTextBox.JMetroTextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label AddressErrorLabel;
    }
}