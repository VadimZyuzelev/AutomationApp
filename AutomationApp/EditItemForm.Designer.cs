
namespace AutomationApp
{
    partial class EditItemForm
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
            this.components = new System.ComponentModel.Container();
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.изделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделияTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter();
            this.tableAdapterManager = new AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LabelForm = new System.Windows.Forms.Label();
            this.NameTextBox = new JMetroTextBox.JMetroTextBox();
            this.ModelTextBox = new JMetroTextBox.JMetroTextBox();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.ModelErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изделияBindingSource
            // 
            this.изделияBindingSource.DataMember = "Изделия";
            this.изделияBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // изделияTableAdapter
            // 
            this.изделияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.БригадыTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Изделия_принятые_на_складTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = this.изделияTableAdapter;
            this.tableAdapterManager.Контрагенты_товарно_транспортной_накладнойTableAdapter = null;
            this.tableAdapterManager.Контрагенты_товарной_накладнойTableAdapter = null;
            this.tableAdapterManager.КонтрагентыTableAdapter = null;
            this.tableAdapterManager.Лимитно_заборные_картыTableAdapter = null;
            this.tableAdapterManager.Маршрутные_листыTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_тканьTableAdapter = null;
            this.tableAdapterManager.Материальные_ценности_по_ордеру_на_фурнитуруTableAdapter = null;
            this.tableAdapterManager.Модели_изделияTableAdapter = null;
            this.tableAdapterManager.Модели_тканиTableAdapter = null;
            this.tableAdapterManager.Модели_фурнитурыTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.Приходные_ордера_на_тканьTableAdapter = null;
            this.tableAdapterManager.Приходные_ордера_на_фурнитуруTableAdapter = null;
            this.tableAdapterManager.Расчётные_картыTableAdapter = null;
            this.tableAdapterManager.Склад_готовой_продукцииTableAdapter = null;
            this.tableAdapterManager.Склад_тканиTableAdapter = null;
            this.tableAdapterManager.Склад_фурнитурыTableAdapter = null;
            this.tableAdapterManager.ТканиTableAdapter = null;
            this.tableAdapterManager.Ткань_для_расчётной_картыTableAdapter = null;
            this.tableAdapterManager.Товарно_транспортные_накладныеTableAdapter = null;
            this.tableAdapterManager.Товарные_накладныеTableAdapter = null;
            this.tableAdapterManager.Товарный_раздел_товарно_транспортной_накладнойTableAdapter = null;
            this.tableAdapterManager.Товарный_раздел_товарной_накладнойTableAdapter = null;
            this.tableAdapterManager.Фурнитура_по_лимитно_заборной_картеTableAdapter = null;
            this.tableAdapterManager.ФурнитураTableAdapter = null;
            this.tableAdapterManager.ЦехаTableAdapter = null;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ItemLabel.ForeColor = System.Drawing.Color.Gray;
            this.ItemLabel.Location = new System.Drawing.Point(20, 73);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(105, 19);
            this.ItemLabel.TabIndex = 1;
            this.ItemLabel.Text = "Наименование";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ModelLabel.ForeColor = System.Drawing.Color.Gray;
            this.ModelLabel.Location = new System.Drawing.Point(20, 175);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(60, 19);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Модель";
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
            this.CancelAddButton.TabIndex = 4;
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
            this.SaveItemButton.TabIndex = 3;
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
            this.TitleBarPanel.Size = new System.Drawing.Size(310, 51);
            this.TitleBarPanel.TabIndex = 27;
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
            this.ExitButton.Location = new System.Drawing.Point(256, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 32);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
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
            this.LabelForm.Size = new System.Drawing.Size(162, 19);
            this.LabelForm.TabIndex = 2;
            this.LabelForm.Text = "Добавление изделия";
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
            this.NameTextBox.Location = new System.Drawing.Point(21, 96);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.NameTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(268, 41);
            this.NameTextBox.TabIndex = 28;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTextBox.TextName = "";
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
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
            this.ModelTextBox.Location = new System.Drawing.Point(21, 198);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTextBox.MaxLength = 32767;
            this.ModelTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ModelTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ModelTextBox.ReadOnly = false;
            this.ModelTextBox.Size = new System.Drawing.Size(268, 41);
            this.ModelTextBox.TabIndex = 29;
            this.ModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModelTextBox.TextName = "";
            this.ModelTextBox.Enter += new System.EventHandler(this.ModelTextBox_Enter);
            this.ModelTextBox.Leave += new System.EventHandler(this.ModelTextBox_Leave);
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameErrorLabel.Location = new System.Drawing.Point(21, 141);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(135, 16);
            this.NameErrorLabel.TabIndex = 30;
            this.NameErrorLabel.Text = "Введите наименование";
            this.NameErrorLabel.Visible = false;
            // 
            // ModelErrorLabel
            // 
            this.ModelErrorLabel.AutoSize = true;
            this.ModelErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelErrorLabel.Location = new System.Drawing.Point(21, 243);
            this.ModelErrorLabel.Name = "ModelErrorLabel";
            this.ModelErrorLabel.Size = new System.Drawing.Size(95, 16);
            this.ModelErrorLabel.TabIndex = 30;
            this.ModelErrorLabel.Text = "Введите модель";
            this.ModelErrorLabel.Visible = false;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 348);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.ModelErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItemForm";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource изделияBindingSource;
        private AutomationAppDBDataSetTableAdapters.ИзделияTableAdapter изделияTableAdapter;
        private AutomationAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Panel TitleBarPanel;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Label LabelForm;
        private JMetroTextBox.JMetroTextBox NameTextBox;
        private JMetroTextBox.JMetroTextBox ModelTextBox;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label ModelErrorLabel;
    }
}