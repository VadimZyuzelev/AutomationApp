
namespace AutomationApp
{
    partial class EditCarsForm
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.LabelForm = new System.Windows.Forms.Label();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.OwnerErrorLabel = new System.Windows.Forms.Label();
            this.OwnerTextBox = new JMetroTextBox.JMetroTextBox();
            this.NumberTextBox = new JMetroTextBox.JMetroTextBox();
            this.NumberErrorLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.MarkTextBox = new JMetroTextBox.JMetroTextBox();
            this.MarkErrorLabel = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TitlePanel.SuspendLayout();
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
            this.CancelAddButton.Location = new System.Drawing.Point(153, 289);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(122, 39);
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
            this.SaveItemButton.Location = new System.Drawing.Point(25, 289);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(128, 39);
            this.SaveItemButton.TabIndex = 42;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.LabelForm);
            this.TitlePanel.Controls.Add(this.IconPictureBox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(629, 51);
            this.TitlePanel.TabIndex = 66;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.Gray;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 25;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(564, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LabelForm
            // 
            this.LabelForm.AutoSize = true;
            this.LabelForm.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForm.ForeColor = System.Drawing.Color.Gray;
            this.LabelForm.Location = new System.Drawing.Point(49, 14);
            this.LabelForm.Name = "LabelForm";
            this.LabelForm.Size = new System.Drawing.Size(192, 19);
            this.LabelForm.TabIndex = 60;
            this.LabelForm.Text = "Добавление автомобиля";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.IconPictureBox.ForeColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconPictureBox.IconColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBox.IconSize = 18;
            this.IconPictureBox.Location = new System.Drawing.Point(25, 16);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(18, 18);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconPictureBox.TabIndex = 61;
            this.IconPictureBox.TabStop = false;
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.OwnerLabel.ForeColor = System.Drawing.Color.Gray;
            this.OwnerLabel.Location = new System.Drawing.Point(24, 79);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(71, 19);
            this.OwnerLabel.TabIndex = 107;
            this.OwnerLabel.Text = "Владелец";
            // 
            // OwnerErrorLabel
            // 
            this.OwnerErrorLabel.AutoSize = true;
            this.OwnerErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OwnerErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.OwnerErrorLabel.Name = "OwnerErrorLabel";
            this.OwnerErrorLabel.Size = new System.Drawing.Size(111, 16);
            this.OwnerErrorLabel.TabIndex = 106;
            this.OwnerErrorLabel.Text = "Введите владельца";
            this.OwnerErrorLabel.Visible = false;
            // 
            // OwnerTextBox
            // 
            this.OwnerTextBox.BackColor = System.Drawing.Color.Transparent;
            this.OwnerTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.OwnerTextBox.BorderRadius = 2;
            this.OwnerTextBox.FillColor = System.Drawing.Color.White;
            this.OwnerTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OwnerTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OwnerTextBox.ForeColors = System.Drawing.Color.Black;
            this.OwnerTextBox.IsPassword = false;
            this.OwnerTextBox.LineThickness = 1;
            this.OwnerTextBox.Location = new System.Drawing.Point(24, 103);
            this.OwnerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OwnerTextBox.MaxLength = 32767;
            this.OwnerTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.OwnerTextBox.Name = "OwnerTextBox";
            this.OwnerTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.OwnerTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.OwnerTextBox.ReadOnly = false;
            this.OwnerTextBox.Size = new System.Drawing.Size(251, 41);
            this.OwnerTextBox.TabIndex = 105;
            this.OwnerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OwnerTextBox.TextName = "";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NumberTextBox.BorderRadius = 2;
            this.NumberTextBox.FillColor = System.Drawing.Color.White;
            this.NumberTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberTextBox.ForeColors = System.Drawing.Color.Black;
            this.NumberTextBox.IsPassword = false;
            this.NumberTextBox.LineThickness = 1;
            this.NumberTextBox.Location = new System.Drawing.Point(24, 201);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberTextBox.MaxLength = 32767;
            this.NumberTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(251, 41);
            this.NumberTextBox.TabIndex = 105;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberTextBox.TextName = "";
            // 
            // NumberErrorLabel
            // 
            this.NumberErrorLabel.AutoSize = true;
            this.NumberErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumberErrorLabel.Location = new System.Drawing.Point(26, 246);
            this.NumberErrorLabel.Name = "NumberErrorLabel";
            this.NumberErrorLabel.Size = new System.Drawing.Size(193, 16);
            this.NumberErrorLabel.TabIndex = 106;
            this.NumberErrorLabel.Text = "Введите регистрационный номер";
            this.NumberErrorLabel.Visible = false;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.NumberLabel.ForeColor = System.Drawing.Color.Gray;
            this.NumberLabel.Location = new System.Drawing.Point(25, 179);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(169, 19);
            this.NumberLabel.TabIndex = 107;
            this.NumberLabel.Text = "Регистрационный номер";
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.MarkTextBox.BorderRadius = 2;
            this.MarkTextBox.FillColor = System.Drawing.Color.White;
            this.MarkTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MarkTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MarkTextBox.ForeColors = System.Drawing.Color.Black;
            this.MarkTextBox.IsPassword = false;
            this.MarkTextBox.LineThickness = 1;
            this.MarkTextBox.Location = new System.Drawing.Point(354, 103);
            this.MarkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarkTextBox.MaxLength = 32767;
            this.MarkTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.MarkTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.MarkTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.MarkTextBox.ReadOnly = false;
            this.MarkTextBox.Size = new System.Drawing.Size(251, 41);
            this.MarkTextBox.TabIndex = 105;
            this.MarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MarkTextBox.TextName = "";
            // 
            // MarkErrorLabel
            // 
            this.MarkErrorLabel.AutoSize = true;
            this.MarkErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MarkErrorLabel.Location = new System.Drawing.Point(355, 148);
            this.MarkErrorLabel.Name = "MarkErrorLabel";
            this.MarkErrorLabel.Size = new System.Drawing.Size(88, 16);
            this.MarkErrorLabel.TabIndex = 106;
            this.MarkErrorLabel.Text = "Введите марку";
            this.MarkErrorLabel.Visible = false;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.MarkLabel.ForeColor = System.Drawing.Color.Gray;
            this.MarkLabel.Location = new System.Drawing.Point(354, 81);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(51, 19);
            this.MarkLabel.TabIndex = 107;
            this.MarkLabel.Text = "Марка";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ModelTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ModelTextBox.BorderRadius = 2;
            this.ModelTextBox.FillColor = System.Drawing.Color.White;
            this.ModelTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModelTextBox.ForeColors = System.Drawing.Color.Black;
            this.ModelTextBox.IsPassword = false;
            this.ModelTextBox.LineThickness = 1;
            this.ModelTextBox.Location = new System.Drawing.Point(354, 201);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = false;
            this.ModelTextBox.Size = new System.Drawing.Size(251, 41);
            this.ModelTextBox.TabIndex = 105;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(355, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Введите марку";
            this.label1.Visible = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(354, 179);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(51, 19);
            this.ModelLabel.TabIndex = 107;
            this.ModelLabel.Text = "Марка";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(37, 212);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(226, 23);
            this.maskedTextBox1.TabIndex = 108;
            // 
            // EditCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 349);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.NumberErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarkErrorLabel);
            this.Controls.Add(this.OwnerErrorLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.OwnerTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCarsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCarsForm";
            this.Load += new System.EventHandler(this.EditCarsForm_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label LabelForm;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label OwnerErrorLabel;
        private JMetroTextBox.JMetroTextBox OwnerTextBox;
        private JMetroTextBox.JMetroTextBox NumberTextBox;
        private System.Windows.Forms.Label NumberErrorLabel;
        private System.Windows.Forms.Label NumberLabel;
        private JMetroTextBox.JMetroTextBox MarkTextBox;
        private System.Windows.Forms.Label MarkErrorLabel;
        private System.Windows.Forms.Label MarkLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}