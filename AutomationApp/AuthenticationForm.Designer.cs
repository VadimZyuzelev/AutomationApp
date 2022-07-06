
namespace AutomationApp
{
    partial class AuthenticationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PasswordErrorLabel = new System.Windows.Forms.Label();
            this.LoginErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeUserPanel = new System.Windows.Forms.Panel();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ForgotButton = new System.Windows.Forms.Button();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.TitleBarPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TypeUserPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.White;
            this.TitleBarPanel.Controls.Add(this.ExitButton);
            this.TitleBarPanel.Controls.Add(this.panel1);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(371, 45);
            this.TitleBarPanel.TabIndex = 1;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 18;
            this.ExitButton.Location = new System.Drawing.Point(329, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 95;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 199);
            this.panel1.TabIndex = 5;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.PasswordErrorLabel);
            this.MainPanel.Controls.Add(this.LoginErrorLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.TypeUserPanel);
            this.MainPanel.Controls.Add(this.ForgotButton);
            this.MainPanel.Controls.Add(this.PasswordPanel);
            this.MainPanel.Controls.Add(this.EnterButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(371, 326);
            this.MainPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.SettingsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 54);
            this.panel2.TabIndex = 95;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Location = new System.Drawing.Point(84, 11);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(209, 31);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Параметры подключения";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PasswordErrorLabel
            // 
            this.PasswordErrorLabel.AutoSize = true;
            this.PasswordErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PasswordErrorLabel.Location = new System.Drawing.Point(28, 177);
            this.PasswordErrorLabel.Name = "PasswordErrorLabel";
            this.PasswordErrorLabel.Size = new System.Drawing.Size(94, 16);
            this.PasswordErrorLabel.TabIndex = 94;
            this.PasswordErrorLabel.Text = "Введите пароль";
            this.PasswordErrorLabel.Visible = false;
            // 
            // LoginErrorLabel
            // 
            this.LoginErrorLabel.AutoSize = true;
            this.LoginErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginErrorLabel.Location = new System.Drawing.Point(28, 102);
            this.LoginErrorLabel.Name = "LoginErrorLabel";
            this.LoginErrorLabel.Size = new System.Drawing.Size(87, 16);
            this.LoginErrorLabel.TabIndex = 94;
            this.LoginErrorLabel.Text = "Введите логин";
            this.LoginErrorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход в учетную запись";
            // 
            // TypeUserPanel
            // 
            this.TypeUserPanel.BackColor = System.Drawing.Color.White;
            this.TypeUserPanel.Controls.Add(this.LoginTextBox);
            this.TypeUserPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeUserPanel.Location = new System.Drawing.Point(31, 60);
            this.TypeUserPanel.Name = "TypeUserPanel";
            this.TypeUserPanel.Size = new System.Drawing.Size(310, 39);
            this.TypeUserPanel.TabIndex = 2;
            this.TypeUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TypeUserPanel_Paint);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LoginTextBox.Location = new System.Drawing.Point(11, 9);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(264, 17);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "Логин";
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.Enter += new System.EventHandler(this.LoginTextBox_Enter);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // ForgotButton
            // 
            this.ForgotButton.FlatAppearance.BorderSize = 0;
            this.ForgotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotButton.ForeColor = System.Drawing.Color.Black;
            this.ForgotButton.Location = new System.Drawing.Point(191, 210);
            this.ForgotButton.Name = "ForgotButton";
            this.ForgotButton.Size = new System.Drawing.Size(150, 39);
            this.ForgotButton.TabIndex = 3;
            this.ForgotButton.Text = "ЗАБЫЛИ ПАРОЛЬ?";
            this.ForgotButton.UseVisualStyleBackColor = true;
            this.ForgotButton.Click += new System.EventHandler(this.ForgotButton_Click);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.Color.White;
            this.PasswordPanel.Controls.Add(this.PasswordTextbox);
            this.PasswordPanel.Location = new System.Drawing.Point(31, 135);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(310, 39);
            this.PasswordPanel.TabIndex = 2;
            this.PasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPanel_Paint);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.PasswordTextbox.Location = new System.Drawing.Point(11, 9);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.ShortcutsEnabled = false;
            this.PasswordTextbox.Size = new System.Drawing.Size(264, 17);
            this.PasswordTextbox.TabIndex = 0;
            this.PasswordTextbox.Text = "Пароль";
            this.PasswordTextbox.Click += new System.EventHandler(this.PasswordTextbox_Click);
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(32, 210);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(159, 39);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "ВОЙТИ";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 371);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthenticationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.TypeUserPanel.ResumeLayout(false);
            this.TypeUserPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TypeUserPanel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button ForgotButton;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label LoginErrorLabel;
        private System.Windows.Forms.Label PasswordErrorLabel;
        private System.Windows.Forms.Button SettingsButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Panel panel2;
    }
}

