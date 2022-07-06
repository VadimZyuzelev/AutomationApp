
namespace AutomationApp
{
    partial class EditWorkshopForm
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
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.WorkshopErrorLabel = new System.Windows.Forms.Label();
            this.WorkshopLabel = new System.Windows.Forms.Label();
            this.WorkshopTextBox = new JMetroTextBox.JMetroTextBox();
            this.BrigadeErrorLabel = new System.Windows.Forms.Label();
            this.BrigadeLabel = new System.Windows.Forms.Label();
            this.BrigadeTextBox = new JMetroTextBox.JMetroTextBox();
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
            this.CancelAddButton.Location = new System.Drawing.Point(156, 285);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(130, 39);
            this.CancelAddButton.TabIndex = 37;
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
            this.SaveItemButton.Location = new System.Drawing.Point(24, 285);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(131, 39);
            this.SaveItemButton.TabIndex = 38;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
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
            this.ExitButton.Location = new System.Drawing.Point(257, 9);
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
            this.LabelForm.Size = new System.Drawing.Size(137, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление цеха";
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
            this.TitleBarPanel.Size = new System.Drawing.Size(310, 51);
            this.TitleBarPanel.TabIndex = 40;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // WorkshopErrorLabel
            // 
            this.WorkshopErrorLabel.AutoSize = true;
            this.WorkshopErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkshopErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WorkshopErrorLabel.Location = new System.Drawing.Point(21, 141);
            this.WorkshopErrorLabel.Name = "WorkshopErrorLabel";
            this.WorkshopErrorLabel.Size = new System.Drawing.Size(135, 16);
            this.WorkshopErrorLabel.TabIndex = 45;
            this.WorkshopErrorLabel.Text = "Введите наименование";
            this.WorkshopErrorLabel.Visible = false;
            // 
            // WorkshopLabel
            // 
            this.WorkshopLabel.AutoSize = true;
            this.WorkshopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.WorkshopLabel.ForeColor = System.Drawing.Color.Gray;
            this.WorkshopLabel.Location = new System.Drawing.Point(20, 73);
            this.WorkshopLabel.Name = "WorkshopLabel";
            this.WorkshopLabel.Size = new System.Drawing.Size(105, 19);
            this.WorkshopLabel.TabIndex = 44;
            this.WorkshopLabel.Text = "Наименование";
            // 
            // WorkshopTextBox
            // 
            this.WorkshopTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WorkshopTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.WorkshopTextBox.BorderRadius = 2;
            this.WorkshopTextBox.FillColor = System.Drawing.Color.White;
            this.WorkshopTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WorkshopTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WorkshopTextBox.ForeColors = System.Drawing.Color.Black;
            this.WorkshopTextBox.IsPassword = false;
            this.WorkshopTextBox.LineThickness = 1;
            this.WorkshopTextBox.Location = new System.Drawing.Point(21, 96);
            this.WorkshopTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkshopTextBox.MaxLength = 32767;
            this.WorkshopTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.WorkshopTextBox.Name = "WorkshopTextBox";
            this.WorkshopTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.WorkshopTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.WorkshopTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.WorkshopTextBox.ReadOnly = false;
            this.WorkshopTextBox.Size = new System.Drawing.Size(268, 41);
            this.WorkshopTextBox.TabIndex = 43;
            this.WorkshopTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WorkshopTextBox.TextName = "";
            this.WorkshopTextBox.Enter += new System.EventHandler(this.WorkshopTextBox_Enter);
            this.WorkshopTextBox.Leave += new System.EventHandler(this.WorkshopTextBox_Leave);
            // 
            // BrigadeErrorLabel
            // 
            this.BrigadeErrorLabel.AutoSize = true;
            this.BrigadeErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrigadeErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BrigadeErrorLabel.Location = new System.Drawing.Point(21, 243);
            this.BrigadeErrorLabel.Name = "BrigadeErrorLabel";
            this.BrigadeErrorLabel.Size = new System.Drawing.Size(186, 16);
            this.BrigadeErrorLabel.TabIndex = 48;
            this.BrigadeErrorLabel.Text = "Введите наименование бригады";
            this.BrigadeErrorLabel.Visible = false;
            // 
            // BrigadeLabel
            // 
            this.BrigadeLabel.AutoSize = true;
            this.BrigadeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.BrigadeLabel.ForeColor = System.Drawing.Color.Gray;
            this.BrigadeLabel.Location = new System.Drawing.Point(20, 175);
            this.BrigadeLabel.Name = "BrigadeLabel";
            this.BrigadeLabel.Size = new System.Drawing.Size(60, 19);
            this.BrigadeLabel.TabIndex = 47;
            this.BrigadeLabel.Text = "Бригада";
            // 
            // BrigadeTextBox
            // 
            this.BrigadeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.BrigadeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.BrigadeTextBox.BorderRadius = 2;
            this.BrigadeTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.BrigadeTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BrigadeTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BrigadeTextBox.ForeColors = System.Drawing.Color.Black;
            this.BrigadeTextBox.IsPassword = false;
            this.BrigadeTextBox.LineThickness = 1;
            this.BrigadeTextBox.Location = new System.Drawing.Point(21, 198);
            this.BrigadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrigadeTextBox.MaxLength = 32767;
            this.BrigadeTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.BrigadeTextBox.Name = "BrigadeTextBox";
            this.BrigadeTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.BrigadeTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.BrigadeTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.BrigadeTextBox.ReadOnly = false;
            this.BrigadeTextBox.Size = new System.Drawing.Size(268, 41);
            this.BrigadeTextBox.TabIndex = 46;
            this.BrigadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BrigadeTextBox.TextName = "";
            this.BrigadeTextBox.Enter += new System.EventHandler(this.BrigadeTextBox_Enter);
            this.BrigadeTextBox.Leave += new System.EventHandler(this.BrigadeTextBox_Leave);
            // 
            // EditWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 348);
            this.Controls.Add(this.BrigadeErrorLabel);
            this.Controls.Add(this.BrigadeLabel);
            this.Controls.Add(this.BrigadeTextBox);
            this.Controls.Add(this.WorkshopErrorLabel);
            this.Controls.Add(this.WorkshopLabel);
            this.Controls.Add(this.WorkshopTextBox);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.SaveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditWorkshopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWorkshopForm";
            this.Load += new System.EventHandler(this.EditWorkshopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label LabelForm;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label WorkshopErrorLabel;
        private System.Windows.Forms.Label WorkshopLabel;
        private JMetroTextBox.JMetroTextBox WorkshopTextBox;
        private System.Windows.Forms.Label BrigadeErrorLabel;
        private System.Windows.Forms.Label BrigadeLabel;
        private JMetroTextBox.JMetroTextBox BrigadeTextBox;
    }
}