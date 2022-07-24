
namespace AutomationApp
{
    partial class EditReceivedItemsForm
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new JMetroTextBox.JMetroTextBox();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.NumberErrorLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemErrorLabel = new System.Windows.Forms.Label();
            this.ItemTextBox = new JMetroTextBox.JMetroTextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.DeterminationErrorLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountErrorLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new JMetroTextBox.JMetroTextBox();
            this.SortItemTextBox = new JMetroTextBox.JMetroTextBox();
            this.SortItemErrorLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.FlatAppearance.BorderSize = 0;
            this.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.CancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddButton.Location = new System.Drawing.Point(480, 307);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(120, 39);
            this.CancelAddButton.TabIndex = 43;
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
            this.SaveItemButton.Location = new System.Drawing.Point(357, 307);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(122, 39);
            this.SaveItemButton.TabIndex = 44;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(564, 8);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 32);
            this.iconButton1.TabIndex = 62;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TitlePanel.Controls.Add(this.iconButton1);
            this.TitlePanel.Controls.Add(this.label8);
            this.TitlePanel.Controls.Add(this.iconPictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(629, 51);
            this.TitlePanel.TabIndex = 65;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(49, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Принятие изделия на склад";
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
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.NumberLabel.ForeColor = System.Drawing.Color.Gray;
            this.NumberLabel.Location = new System.Drawing.Point(24, 79);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(182, 19);
            this.NumberLabel.TabIndex = 96;
            this.NumberLabel.Text = "Номер маршрутного листа";
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
            this.NumberTextBox.Location = new System.Drawing.Point(24, 103);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberTextBox.MaxLength = 32767;
            this.NumberTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NumberTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(251, 41);
            this.NumberTextBox.TabIndex = 95;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberTextBox.TextName = "";
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
            this.SelectButton.TabIndex = 98;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // NumberErrorLabel
            // 
            this.NumberErrorLabel.AutoSize = true;
            this.NumberErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NumberErrorLabel.Location = new System.Drawing.Point(26, 148);
            this.NumberErrorLabel.Name = "NumberErrorLabel";
            this.NumberErrorLabel.Size = new System.Drawing.Size(164, 16);
            this.NumberErrorLabel.TabIndex = 97;
            this.NumberErrorLabel.Text = "Выберите маршрутный лист";
            this.NumberErrorLabel.Visible = false;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ItemLabel.ForeColor = System.Drawing.Color.Gray;
            this.ItemLabel.Location = new System.Drawing.Point(25, 179);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(64, 19);
            this.ItemLabel.TabIndex = 104;
            this.ItemLabel.Text = "Изделие";
            // 
            // ItemErrorLabel
            // 
            this.ItemErrorLabel.AutoSize = true;
            this.ItemErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ItemErrorLabel.Location = new System.Drawing.Point(26, 246);
            this.ItemErrorLabel.Name = "ItemErrorLabel";
            this.ItemErrorLabel.Size = new System.Drawing.Size(109, 16);
            this.ItemErrorLabel.TabIndex = 103;
            this.ItemErrorLabel.Text = "Выберите изделие";
            this.ItemErrorLabel.Visible = false;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ItemTextBox.BorderRadius = 2;
            this.ItemTextBox.FillColor = System.Drawing.Color.White;
            this.ItemTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ItemTextBox.ForeColors = System.Drawing.Color.Black;
            this.ItemTextBox.IsPassword = false;
            this.ItemTextBox.LineThickness = 1;
            this.ItemTextBox.Location = new System.Drawing.Point(24, 201);
            this.ItemTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemTextBox.MaxLength = 32767;
            this.ItemTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ItemTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ItemTextBox.ReadOnly = true;
            this.ItemTextBox.Size = new System.Drawing.Size(251, 41);
            this.ItemTextBox.TabIndex = 102;
            this.ItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemTextBox.TextName = "";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(25, 282);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(116, 19);
            this.ModelLabel.TabIndex = 107;
            this.ModelLabel.Text = "Модель изделия";
            // 
            // DeterminationErrorLabel
            // 
            this.DeterminationErrorLabel.AutoSize = true;
            this.DeterminationErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminationErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeterminationErrorLabel.Location = new System.Drawing.Point(26, 350);
            this.DeterminationErrorLabel.Name = "DeterminationErrorLabel";
            this.DeterminationErrorLabel.Size = new System.Drawing.Size(95, 16);
            this.DeterminationErrorLabel.TabIndex = 106;
            this.DeterminationErrorLabel.Text = "Введите модель";
            this.DeterminationErrorLabel.Visible = false;
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
            this.ModelTextBox.Location = new System.Drawing.Point(24, 305);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(251, 41);
            this.ModelTextBox.TabIndex = 105;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CountLabel.ForeColor = System.Drawing.Color.Gray;
            this.CountLabel.Location = new System.Drawing.Point(354, 179);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 19);
            this.CountLabel.TabIndex = 112;
            this.CountLabel.Text = "Количество";
            // 
            // CountErrorLabel
            // 
            this.CountErrorLabel.AutoSize = true;
            this.CountErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CountErrorLabel.Location = new System.Drawing.Point(355, 246);
            this.CountErrorLabel.Name = "CountErrorLabel";
            this.CountErrorLabel.Size = new System.Drawing.Size(118, 16);
            this.CountErrorLabel.TabIndex = 111;
            this.CountErrorLabel.Text = "Введите количество";
            this.CountErrorLabel.Visible = false;
            // 
            // CountTextBox
            // 
            this.CountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CountTextBox.BorderRadius = 2;
            this.CountTextBox.FillColor = System.Drawing.Color.White;
            this.CountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CountTextBox.ForeColors = System.Drawing.Color.Black;
            this.CountTextBox.IsPassword = false;
            this.CountTextBox.LineThickness = 1;
            this.CountTextBox.Location = new System.Drawing.Point(354, 201);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CountTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.CountTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CountTextBox.ReadOnly = false;
            this.CountTextBox.Size = new System.Drawing.Size(251, 41);
            this.CountTextBox.TabIndex = 110;
            this.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountTextBox.TextName = "";
            // 
            // SortItemTextBox
            // 
            this.SortItemTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SortItemTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SortItemTextBox.BorderRadius = 2;
            this.SortItemTextBox.FillColor = System.Drawing.Color.White;
            this.SortItemTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SortItemTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SortItemTextBox.ForeColors = System.Drawing.Color.Black;
            this.SortItemTextBox.IsPassword = false;
            this.SortItemTextBox.LineThickness = 1;
            this.SortItemTextBox.Location = new System.Drawing.Point(354, 103);
            this.SortItemTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortItemTextBox.MaxLength = 32767;
            this.SortItemTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SortItemTextBox.Name = "SortItemTextBox";
            this.SortItemTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SortItemTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SortItemTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SortItemTextBox.ReadOnly = false;
            this.SortItemTextBox.Size = new System.Drawing.Size(251, 41);
            this.SortItemTextBox.TabIndex = 110;
            this.SortItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SortItemTextBox.TextName = "";
            // 
            // SortItemErrorLabel
            // 
            this.SortItemErrorLabel.AutoSize = true;
            this.SortItemErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortItemErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SortItemErrorLabel.Location = new System.Drawing.Point(355, 148);
            this.SortItemErrorLabel.Name = "SortItemErrorLabel";
            this.SortItemErrorLabel.Size = new System.Drawing.Size(80, 16);
            this.SortItemErrorLabel.TabIndex = 111;
            this.SortItemErrorLabel.Text = "Введите сорт";
            this.SortItemErrorLabel.Visible = false;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SortLabel.ForeColor = System.Drawing.Color.Gray;
            this.SortLabel.Location = new System.Drawing.Point(354, 81);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(40, 19);
            this.SortLabel.TabIndex = 112;
            this.SortLabel.Text = "Сорт";
            // 
            // EditReceivedItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 392);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.SortItemErrorLabel);
            this.Controls.Add(this.CountErrorLabel);
            this.Controls.Add(this.SortItemTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.DeterminationErrorLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.ItemErrorLabel);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.NumberErrorLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditReceivedItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReceivedItemsForm";            
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label NumberLabel;
        private JMetroTextBox.JMetroTextBox NumberTextBox;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label NumberErrorLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ItemErrorLabel;
        private JMetroTextBox.JMetroTextBox ItemTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label DeterminationErrorLabel;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountErrorLabel;
        private JMetroTextBox.JMetroTextBox CountTextBox;
        private JMetroTextBox.JMetroTextBox SortItemTextBox;
        private System.Windows.Forms.Label SortItemErrorLabel;
        private System.Windows.Forms.Label SortLabel;
    }
}