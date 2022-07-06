
namespace AutomationApp
{
    partial class EditDriversForm
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FIOErrorLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FIOTextBox = new JMetroTextBox.JMetroTextBox();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.NumberErrorLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new JMetroTextBox.JMetroTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
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
            this.CancelAddButton.Location = new System.Drawing.Point(194, 356);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(164, 39);
            this.CancelAddButton.TabIndex = 41;
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
            this.SaveItemButton.Location = new System.Drawing.Point(23, 356);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(171, 39);
            this.SaveItemButton.TabIndex = 42;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.DateTimePicker.Location = new System.Drawing.Point(22, 307);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(336, 24);
            this.DateTimePicker.TabIndex = 43;
            // 
            // FIOErrorLabel
            // 
            this.FIOErrorLabel.AutoSize = true;
            this.FIOErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FIOErrorLabel.Location = new System.Drawing.Point(21, 141);
            this.FIOErrorLabel.Name = "FIOErrorLabel";
            this.FIOErrorLabel.Size = new System.Drawing.Size(82, 16);
            this.FIOErrorLabel.TabIndex = 46;
            this.FIOErrorLabel.Text = "Введите ФИО";
            this.FIOErrorLabel.Visible = false;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.FIOLabel.ForeColor = System.Drawing.Color.Gray;
            this.FIOLabel.Location = new System.Drawing.Point(20, 73);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(41, 19);
            this.FIOLabel.TabIndex = 44;
            this.FIOLabel.Text = "ФИО";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FIOTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.FIOTextBox.BorderRadius = 2;
            this.FIOTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.FIOTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FIOTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FIOTextBox.ForeColors = System.Drawing.Color.Black;
            this.FIOTextBox.IsPassword = false;
            this.FIOTextBox.LineThickness = 1;
            this.FIOTextBox.Location = new System.Drawing.Point(21, 96);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FIOTextBox.MaxLength = 32767;
            this.FIOTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.FIOTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.FIOTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.FIOTextBox.ReadOnly = false;
            this.FIOTextBox.Size = new System.Drawing.Size(337, 41);
            this.FIOTextBox.TabIndex = 45;
            this.FIOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FIOTextBox.TextName = "";
            this.FIOTextBox.Enter += new System.EventHandler(this.FIOTextBox_Enter);
            this.FIOTextBox.Leave += new System.EventHandler(this.FIOTextBox_Leave);
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
            this.TitleBarPanel.TabIndex = 47;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
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
            this.LabelForm.Size = new System.Drawing.Size(171, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление водителя";
            // 
            // NumberErrorLabel
            // 
            this.NumberErrorLabel.AutoSize = true;
            this.NumberErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumberErrorLabel.Location = new System.Drawing.Point(21, 243);
            this.NumberErrorLabel.Name = "NumberErrorLabel";
            this.NumberErrorLabel.Size = new System.Drawing.Size(260, 16);
            this.NumberErrorLabel.TabIndex = 50;
            this.NumberErrorLabel.Text = "Введите номер водительского удостоверения";
            this.NumberErrorLabel.Visible = false;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.NumberLabel.ForeColor = System.Drawing.Color.Gray;
            this.NumberLabel.Location = new System.Drawing.Point(20, 175);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(252, 19);
            this.NumberLabel.TabIndex = 48;
            this.NumberLabel.Text = "Номер водительского удостоверения";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NumberTextBox.BorderRadius = 2;
            this.NumberTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.NumberTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTextBox.ForeColors = System.Drawing.Color.Black;
            this.NumberTextBox.IsPassword = false;
            this.NumberTextBox.LineThickness = 1;
            this.NumberTextBox.Location = new System.Drawing.Point(21, 198);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberTextBox.MaxLength = 32767;
            this.NumberTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NumberTextBox.ReadOnly = false;
            this.NumberTextBox.Size = new System.Drawing.Size(337, 41);
            this.NumberTextBox.TabIndex = 49;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberTextBox.TextName = "";
            this.NumberTextBox.Enter += new System.EventHandler(this.NumberTextBox_Enter);
            this.NumberTextBox.Leave += new System.EventHandler(this.NumberTextBox_Leave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DateLabel.ForeColor = System.Drawing.Color.Gray;
            this.DateLabel.Location = new System.Drawing.Point(19, 280);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(193, 19);
            this.DateLabel.TabIndex = 48;
            this.DateLabel.Text = "Дата выдачи удостоверения";
            // 
            // EditDriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 422);
            this.Controls.Add(this.NumberErrorLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.FIOErrorLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditDriversForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDriversForm";
            this.Load += new System.EventHandler(this.EditDriversForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label FIOErrorLabel;
        private System.Windows.Forms.Label FIOLabel;
        private JMetroTextBox.JMetroTextBox FIOTextBox;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Panel TitleBarPanel;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label LabelForm;
        private System.Windows.Forms.Label NumberErrorLabel;
        private System.Windows.Forms.Label NumberLabel;
        private JMetroTextBox.JMetroTextBox NumberTextBox;
        private System.Windows.Forms.Label DateLabel;
    }
}