
namespace AutomationApp
{
    partial class SettingsUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataSourcePanel = new System.Windows.Forms.Panel();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.InitialCatalogPanel = new System.Windows.Forms.Panel();
            this.InitialCatalogTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSourceErrorLabel = new System.Windows.Forms.Label();
            this.InitialCatalogErrorLabel = new System.Windows.Forms.Label();
            this.DataSourcePanel.SuspendLayout();
            this.InitialCatalogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSourcePanel
            // 
            this.DataSourcePanel.BackColor = System.Drawing.Color.White;
            this.DataSourcePanel.Controls.Add(this.DataSourceTextBox);
            this.DataSourcePanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataSourcePanel.Location = new System.Drawing.Point(31, 60);
            this.DataSourcePanel.Name = "DataSourcePanel";
            this.DataSourcePanel.Size = new System.Drawing.Size(310, 39);
            this.DataSourcePanel.TabIndex = 5;
            this.DataSourcePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DataSourcePanel_Paint);
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataSourceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.DataSourceTextBox.Location = new System.Drawing.Point(11, 9);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(270, 17);
            this.DataSourceTextBox.TabIndex = 0;
            this.DataSourceTextBox.Click += new System.EventHandler(this.DataSourceTextBox_Click);
            this.DataSourceTextBox.Enter += new System.EventHandler(this.DataSourceTextBox_Enter);
            this.DataSourceTextBox.Leave += new System.EventHandler(this.DataSourceTextBox_Leave);
            // 
            // InitialCatalogPanel
            // 
            this.InitialCatalogPanel.BackColor = System.Drawing.Color.White;
            this.InitialCatalogPanel.Controls.Add(this.InitialCatalogTextbox);
            this.InitialCatalogPanel.Location = new System.Drawing.Point(31, 135);
            this.InitialCatalogPanel.Name = "InitialCatalogPanel";
            this.InitialCatalogPanel.Size = new System.Drawing.Size(310, 39);
            this.InitialCatalogPanel.TabIndex = 6;
            this.InitialCatalogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InitialCatalogPanel_Paint);
            // 
            // InitialCatalogTextbox
            // 
            this.InitialCatalogTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InitialCatalogTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.InitialCatalogTextbox.Location = new System.Drawing.Point(11, 9);
            this.InitialCatalogTextbox.Name = "InitialCatalogTextbox";
            this.InitialCatalogTextbox.Size = new System.Drawing.Size(270, 17);
            this.InitialCatalogTextbox.TabIndex = 0;
            this.InitialCatalogTextbox.Click += new System.EventHandler(this.InitialCatalogTextbox_Click);
            this.InitialCatalogTextbox.Enter += new System.EventHandler(this.InitialCatalogTextbox_Enter);
            this.InitialCatalogTextbox.Leave += new System.EventHandler(this.InitialCatalogTextbox_Leave);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(32, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(159, 39);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(191, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 39);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "НАЗАД";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметры подключения";
            // 
            // DataSourceErrorLabel
            // 
            this.DataSourceErrorLabel.AutoSize = true;
            this.DataSourceErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataSourceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataSourceErrorLabel.Location = new System.Drawing.Point(29, 102);
            this.DataSourceErrorLabel.Name = "DataSourceErrorLabel";
            this.DataSourceErrorLabel.Size = new System.Drawing.Size(160, 16);
            this.DataSourceErrorLabel.TabIndex = 95;
            this.DataSourceErrorLabel.Text = "Введите имя/адрес сервера";
            this.DataSourceErrorLabel.Visible = false;
            // 
            // InitialCatalogErrorLabel
            // 
            this.InitialCatalogErrorLabel.AutoSize = true;
            this.InitialCatalogErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialCatalogErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InitialCatalogErrorLabel.Location = new System.Drawing.Point(29, 177);
            this.InitialCatalogErrorLabel.Name = "InitialCatalogErrorLabel";
            this.InitialCatalogErrorLabel.Size = new System.Drawing.Size(151, 16);
            this.InitialCatalogErrorLabel.TabIndex = 95;
            this.InitialCatalogErrorLabel.Text = "Введите имя базы данных";
            this.InitialCatalogErrorLabel.Visible = false;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InitialCatalogErrorLabel);
            this.Controls.Add(this.DataSourceErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataSourcePanel);
            this.Controls.Add(this.InitialCatalogPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(371, 326);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            this.DataSourcePanel.ResumeLayout(false);
            this.DataSourcePanel.PerformLayout();
            this.InitialCatalogPanel.ResumeLayout(false);
            this.InitialCatalogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DataSourcePanel;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Panel InitialCatalogPanel;
        private System.Windows.Forms.TextBox InitialCatalogTextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataSourceErrorLabel;
        private System.Windows.Forms.Label InitialCatalogErrorLabel;
    }
}
