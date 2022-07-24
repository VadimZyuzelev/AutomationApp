
namespace AutomationApp
{
    partial class EditClothsInCardsForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.ClothLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.UnitDeterminationTextBox = new JMetroTextBox.JMetroTextBox();
            this.DeterminationLabel = new System.Windows.Forms.Label();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountErrorLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new JMetroTextBox.JMetroTextBox();
            this.CountTextBoxTwo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(153, 288);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(120, 39);
            this.CancelAddButton.TabIndex = 64;
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
            this.SaveItemButton.Location = new System.Drawing.Point(28, 288);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(122, 39);
            this.SaveItemButton.TabIndex = 65;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.MessageLabel.Location = new System.Drawing.Point(364, 246);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(140, 16);
            this.MessageLabel.TabIndex = 71;
            this.MessageLabel.Text = "На складе в количестве ";
            this.MessageLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(49, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Добавление данных о ткани в расчётную карту";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 18;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(18, 18);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 61;
            this.iconPictureBox1.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.label8);
            this.TitlePanel.Controls.Add(this.iconPictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(638, 51);
            this.TitlePanel.TabIndex = 81;
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
            this.CloseButton.Location = new System.Drawing.Point(573, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 63;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.NameTextBox.BorderRadius = 2;
            this.NameTextBox.FillColor = System.Drawing.Color.White;
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTextBox.ForeColors = System.Drawing.Color.Black;
            this.NameTextBox.IsPassword = false;
            this.NameTextBox.LineThickness = 1;
            this.NameTextBox.Location = new System.Drawing.Point(24, 103);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NameTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(251, 41);
            this.NameTextBox.TabIndex = 82;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            // 
            // ClothLabel
            // 
            this.ClothLabel.AutoSize = true;
            this.ClothLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ClothLabel.ForeColor = System.Drawing.Color.Gray;
            this.ClothLabel.Location = new System.Drawing.Point(24, 79);
            this.ClothLabel.Name = "ClothLabel";
            this.ClothLabel.Size = new System.Drawing.Size(105, 19);
            this.ClothLabel.TabIndex = 83;
            this.ClothLabel.Text = "Наименование";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(95, 16);
            this.NameErrorLabel.TabIndex = 84;
            this.NameErrorLabel.Text = "Выберите ткань";
            this.NameErrorLabel.Visible = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(25, 179);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 87;
            this.ModelLabel.Text = "Модель";
            // 
            // ModelErrorLabel
            // 
            this.ModelErrorLabel.AutoSize = true;
            this.ModelErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelErrorLabel.Location = new System.Drawing.Point(26, 246);
            this.ModelErrorLabel.Name = "ModelErrorLabel";
            this.ModelErrorLabel.Size = new System.Drawing.Size(105, 16);
            this.ModelErrorLabel.TabIndex = 86;
            this.ModelErrorLabel.Text = "Выберите модель";
            this.ModelErrorLabel.Visible = false;
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
            this.ModelTextBox.Location = new System.Drawing.Point(24, 201);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(251, 41);
            this.ModelTextBox.TabIndex = 85;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // SelectButton
            // 
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.SelectButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SelectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectButton.IconSize = 40;
            this.SelectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SelectButton.Location = new System.Drawing.Point(276, 103);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(51, 39);
            this.SelectButton.TabIndex = 92;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // UnitDeterminationTextBox
            // 
            this.UnitDeterminationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UnitDeterminationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.UnitDeterminationTextBox.BorderRadius = 2;
            this.UnitDeterminationTextBox.FillColor = System.Drawing.Color.White;
            this.UnitDeterminationTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnitDeterminationTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnitDeterminationTextBox.ForeColors = System.Drawing.Color.Black;
            this.UnitDeterminationTextBox.IsPassword = false;
            this.UnitDeterminationTextBox.LineThickness = 1;
            this.UnitDeterminationTextBox.Location = new System.Drawing.Point(363, 104);
            this.UnitDeterminationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnitDeterminationTextBox.MaxLength = 32767;
            this.UnitDeterminationTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.Name = "UnitDeterminationTextBox";
            this.UnitDeterminationTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitDeterminationTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.UnitDeterminationTextBox.ReadOnly = true;
            this.UnitDeterminationTextBox.Size = new System.Drawing.Size(251, 41);
            this.UnitDeterminationTextBox.TabIndex = 93;
            this.UnitDeterminationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UnitDeterminationTextBox.TextName = "";
            // 
            // DeterminationLabel
            // 
            this.DeterminationLabel.AutoSize = true;
            this.DeterminationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DeterminationLabel.ForeColor = System.Drawing.Color.Gray;
            this.DeterminationLabel.Location = new System.Drawing.Point(363, 81);
            this.DeterminationLabel.Name = "DeterminationLabel";
            this.DeterminationLabel.Size = new System.Drawing.Size(137, 19);
            this.DeterminationLabel.TabIndex = 94;
            this.DeterminationLabel.Text = "Единица измерения";
            // 
            // DeterminationErrorLabel
            // 
            this.DeterminationErrorLabel.AutoSize = true;
            this.DeterminationErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminationErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeterminationErrorLabel.Location = new System.Drawing.Point(364, 149);
            this.DeterminationErrorLabel.Name = "DeterminationErrorLabel";
            this.DeterminationErrorLabel.Size = new System.Drawing.Size(164, 16);
            this.DeterminationErrorLabel.TabIndex = 84;
            this.DeterminationErrorLabel.Text = "Введите единицу измерения";
            this.DeterminationErrorLabel.Visible = false;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CountLabel.ForeColor = System.Drawing.Color.Gray;
            this.CountLabel.Location = new System.Drawing.Point(363, 179);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 19);
            this.CountLabel.TabIndex = 97;
            this.CountLabel.Text = "Количество";
            // 
            // CountErrorLabel
            // 
            this.CountErrorLabel.AutoSize = true;
            this.CountErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorLabel.Location = new System.Drawing.Point(364, 246);
            this.CountErrorLabel.Name = "CountErrorLabel";
            this.CountErrorLabel.Size = new System.Drawing.Size(152, 16);
            this.CountErrorLabel.TabIndex = 96;
            this.CountErrorLabel.Text = "Введите количество ткани";
            this.CountErrorLabel.Visible = false;
            // 
            // CountTextBox
            // 
            this.CountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CountTextBox.BorderRadius = 2;
            this.CountTextBox.Enabled = false;
            this.CountTextBox.FillColor = System.Drawing.Color.White;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.ForeColors = System.Drawing.Color.Black;
            this.CountTextBox.IsPassword = false;
            this.CountTextBox.LineThickness = 1;
            this.CountTextBox.Location = new System.Drawing.Point(363, 201);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CountTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.CountTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CountTextBox.ReadOnly = false;
            this.CountTextBox.Size = new System.Drawing.Size(251, 41);
            this.CountTextBox.TabIndex = 95;
            this.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountTextBox.TextName = "";
            // 
            // CountTextBoxTwo
            // 
            this.CountTextBoxTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountTextBoxTwo.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.CountTextBoxTwo.Location = new System.Drawing.Point(377, 215);
            this.CountTextBoxTwo.Name = "CountTextBoxTwo";
            this.CountTextBoxTwo.Size = new System.Drawing.Size(230, 17);
            this.CountTextBoxTwo.TabIndex = 98;
            this.CountTextBoxTwo.TextChanged += new System.EventHandler(this.CountTextBoxTwo_TextChanged);
            this.CountTextBoxTwo.Enter += new System.EventHandler(this.CountTextBoxTwo_Enter);
            // 
            // EditClothsInCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 341);
            this.Controls.Add(this.CountTextBoxTwo);
            this.Controls.Add(this.CountErrorLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.DeterminationLabel);
            this.Controls.Add(this.UnitDeterminationTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.ClothLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditClothsInCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClothsInCardsForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private System.Windows.Forms.Label ClothLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private FontAwesome.Sharp.IconButton SelectButton;
        private JMetroTextBox.JMetroTextBox UnitDeterminationTextBox;
        private System.Windows.Forms.Label DeterminationLabel;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountErrorLabel;
        private JMetroTextBox.JMetroTextBox CountTextBox;
        private System.Windows.Forms.TextBox CountTextBoxTwo;
    }
}