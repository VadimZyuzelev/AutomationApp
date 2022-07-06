
namespace AutomationApp
{
    partial class EditCounteragentsForm
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
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.YNPErrorLabel = new System.Windows.Forms.Label();
            this.YNPLabel = new System.Windows.Forms.Label();
            this.YNPTextBox = new JMetroTextBox.JMetroTextBox();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new JMetroTextBox.JMetroTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressErrorLabel = new System.Windows.Forms.Label();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(194, 389);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(164, 39);
            this.CancelAddButton.TabIndex = 33;
            this.CancelAddButton.Text = "ОТМЕНА";
            this.CancelAddButton.UseVisualStyleBackColor = false;
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveItemButton.FlatAppearance.BorderSize = 0;
            this.SaveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveItemButton.ForeColor = System.Drawing.Color.White;
            this.SaveItemButton.Location = new System.Drawing.Point(24, 389);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(171, 39);
            this.SaveItemButton.TabIndex = 34;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
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
            this.TitleBarPanel.Size = new System.Drawing.Size(377, 51);
            this.TitleBarPanel.TabIndex = 48;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
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
            this.ExitButton.Location = new System.Drawing.Point(317, 8);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 32);
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
            this.LabelForm.Size = new System.Drawing.Size(191, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление контрагента";
            // 
            // YNPErrorLabel
            // 
            this.YNPErrorLabel.AutoSize = true;
            this.YNPErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YNPErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.YNPErrorLabel.Location = new System.Drawing.Point(21, 141);
            this.YNPErrorLabel.Name = "YNPErrorLabel";
            this.YNPErrorLabel.Size = new System.Drawing.Size(80, 16);
            this.YNPErrorLabel.TabIndex = 51;
            this.YNPErrorLabel.Text = "Введите УНП";
            this.YNPErrorLabel.Visible = false;
            // 
            // YNPLabel
            // 
            this.YNPLabel.AutoSize = true;
            this.YNPLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.YNPLabel.ForeColor = System.Drawing.Color.Gray;
            this.YNPLabel.Location = new System.Drawing.Point(20, 73);
            this.YNPLabel.Name = "YNPLabel";
            this.YNPLabel.Size = new System.Drawing.Size(37, 19);
            this.YNPLabel.TabIndex = 49;
            this.YNPLabel.Text = "УНП";
            // 
            // YNPTextBox
            // 
            this.YNPTextBox.BackColor = System.Drawing.Color.Transparent;
            this.YNPTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.YNPTextBox.BorderRadius = 2;
            this.YNPTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.YNPTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.YNPTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.YNPTextBox.ForeColors = System.Drawing.Color.Black;
            this.YNPTextBox.IsPassword = false;
            this.YNPTextBox.LineThickness = 1;
            this.YNPTextBox.Location = new System.Drawing.Point(21, 96);
            this.YNPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YNPTextBox.MaxLength = 32767;
            this.YNPTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.YNPTextBox.Name = "YNPTextBox";
            this.YNPTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.YNPTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.YNPTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.YNPTextBox.ReadOnly = false;
            this.YNPTextBox.Size = new System.Drawing.Size(337, 41);
            this.YNPTextBox.TabIndex = 50;
            this.YNPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YNPTextBox.TextName = "";
            this.YNPTextBox.Enter += new System.EventHandler(this.YNPTextBox_Enter);
            this.YNPTextBox.Leave += new System.EventHandler(this.YNPTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NameTextBox.BorderRadius = 2;
            this.NameTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.ForeColors = System.Drawing.Color.Black;
            this.NameTextBox.IsPassword = false;
            this.NameTextBox.LineThickness = 1;
            this.NameTextBox.Location = new System.Drawing.Point(21, 198);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NameTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(337, 41);
            this.NameTextBox.TabIndex = 50;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.NameLabel.ForeColor = System.Drawing.Color.Gray;
            this.NameLabel.Location = new System.Drawing.Point(20, 175);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(105, 19);
            this.NameLabel.TabIndex = 49;
            this.NameLabel.Text = "Наименование";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(21, 243);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(135, 16);
            this.NameErrorLabel.TabIndex = 51;
            this.NameErrorLabel.Text = "Введите наименование";
            this.NameErrorLabel.Visible = false;
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
            this.AddressTextBox.Location = new System.Drawing.Point(21, 303);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.MaxLength = 32767;
            this.AddressTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.AddressTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.AddressTextBox.ReadOnly = false;
            this.AddressTextBox.Size = new System.Drawing.Size(337, 41);
            this.AddressTextBox.TabIndex = 50;
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
            this.AddressLabel.Location = new System.Drawing.Point(20, 280);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 19);
            this.AddressLabel.TabIndex = 49;
            this.AddressLabel.Text = "Адрес";
            // 
            // AddressErrorLabel
            // 
            this.AddressErrorLabel.AutoSize = true;
            this.AddressErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddressErrorLabel.Location = new System.Drawing.Point(21, 348);
            this.AddressErrorLabel.Name = "AddressErrorLabel";
            this.AddressErrorLabel.Size = new System.Drawing.Size(87, 16);
            this.AddressErrorLabel.TabIndex = 51;
            this.AddressErrorLabel.Text = "Введите адрес";
            this.AddressErrorLabel.Visible = false;
            // 
            // EditCounteragentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 449);
            this.Controls.Add(this.AddressErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.YNPErrorLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.YNPLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.YNPTextBox);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCounteragentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCounteragentsForm";
            this.Load += new System.EventHandler(this.EditCounteragentsForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Panel TitleBarPanel;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label LabelForm;
        private System.Windows.Forms.Label YNPErrorLabel;
        private System.Windows.Forms.Label YNPLabel;
        private JMetroTextBox.JMetroTextBox YNPTextBox;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private JMetroTextBox.JMetroTextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label AddressErrorLabel;
    }
}