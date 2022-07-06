
namespace AutomationApp
{
    partial class EditClothOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.приходныеордеранатканьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ПоставщикиTableAdapter();
            this.приходные_ордера_на_тканьTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter();
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_тканьTableAdapter();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.TopLabel = new System.Windows.Forms.Label();
            this.TopPictureButton = new FontAwesome.Sharp.IconPictureBox();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.LabelForm = new System.Windows.Forms.Label();
            this.IconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MaterialsClothsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDМатериальнойценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПриходногоордераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделитканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныеценностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммабезНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегосНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fKМатериальIDПр1209AD79BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleFoodPanel = new System.Windows.Forms.Panel();
            this.AddClothButton = new FontAwesome.Sharp.IconButton();
            this.SearchIcon = new FontAwesome.Sharp.IconButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new FontAwesome.Sharp.IconButton();
            this.ClothLabelError = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.FollowLabel = new System.Windows.Forms.Label();
            this.CorrespondingLabel = new System.Windows.Forms.Label();
            this.SumOrderTextBox = new JMetroTextBox.JMetroTextBox();
            this.FollowDocumentTextBox = new JMetroTextBox.JMetroTextBox();
            this.CorrespondingAccountTextBox = new JMetroTextBox.JMetroTextBox();
            this.WarehouseLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.ProviderTextBox = new JMetroTextBox.JMetroTextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataLabel = new System.Windows.Forms.Label();
            this.FollowErrorLabel = new System.Windows.Forms.Label();
            this.CorrespondingErrorLabel = new System.Windows.Forms.Label();
            this.WarehouseErrorLabel = new System.Windows.Forms.Label();
            this.ProviderErrorLabel = new System.Windows.Forms.Label();
            this.DataErrorLabel = new System.Windows.Forms.Label();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.WarehouseTextBox = new JMetroTextBox.JMetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранатканьBindingSource)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsClothsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1209AD79BindingSource)).BeginInit();
            this.TitleFoodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приходныеордеранатканьBindingSource
            // 
            this.приходныеордеранатканьBindingSource.DataMember = "Приходные_ордера_на_ткань";
            this.приходныеордеранатканьBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // приходные_ордера_на_тканьTableAdapter
            // 
            this.приходные_ордера_на_тканьTableAdapter.ClearBeforeFill = true;
            // 
            // материальные_ценности_по_ордеру_на_тканьTableAdapter
            // 
            this.материальные_ценности_по_ордеру_на_тканьTableAdapter.ClearBeforeFill = true;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TopPanel);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Controls.Add(this.LabelForm);
            this.TitlePanel.Controls.Add(this.IconPictureBox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1291, 51);
            this.TitlePanel.TabIndex = 57;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.TopPictureButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1291, 51);
            this.TopPanel.TabIndex = 60;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
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
            this.CloseButton.Location = new System.Drawing.Point(1223, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 59;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.Gray;
            this.TopLabel.Location = new System.Drawing.Point(51, 15);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(245, 19);
            this.TopLabel.TabIndex = 57;
            this.TopLabel.Text = "Добавление приходного ордера";
            // 
            // TopPictureButton
            // 
            this.TopPictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TopPictureButton.ForeColor = System.Drawing.Color.Gray;
            this.TopPictureButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.TopPictureButton.IconColor = System.Drawing.Color.Gray;
            this.TopPictureButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TopPictureButton.IconSize = 18;
            this.TopPictureButton.Location = new System.Drawing.Point(27, 18);
            this.TopPictureButton.Name = "TopPictureButton";
            this.TopPictureButton.Size = new System.Drawing.Size(18, 18);
            this.TopPictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopPictureButton.TabIndex = 58;
            this.TopPictureButton.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.Gray;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 25;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(1161, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 32);
            this.ExitButton.TabIndex = 59;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // LabelForm
            // 
            this.LabelForm.AutoSize = true;
            this.LabelForm.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForm.ForeColor = System.Drawing.Color.Gray;
            this.LabelForm.Location = new System.Drawing.Point(55, 15);
            this.LabelForm.Name = "LabelForm";
            this.LabelForm.Size = new System.Drawing.Size(245, 19);
            this.LabelForm.TabIndex = 57;
            this.LabelForm.Text = "Добавление приходного ордера";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.IconPictureBox.ForeColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconPictureBox.IconColor = System.Drawing.Color.Gray;
            this.IconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPictureBox.IconSize = 18;
            this.IconPictureBox.Location = new System.Drawing.Point(31, 18);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(18, 18);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconPictureBox.TabIndex = 58;
            this.IconPictureBox.TabStop = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FooterPanel.Location = new System.Drawing.Point(0, 315);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1291, 24);
            this.FooterPanel.TabIndex = 62;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MaterialsClothsDataGridView);
            this.MainPanel.Controls.Add(this.TitleFoodPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 340);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1291, 393);
            this.MainPanel.TabIndex = 63;
            // 
            // MaterialsClothsDataGridView
            // 
            this.MaterialsClothsDataGridView.AllowUserToAddRows = false;
            this.MaterialsClothsDataGridView.AllowUserToDeleteRows = false;
            this.MaterialsClothsDataGridView.AutoGenerateColumns = false;
            this.MaterialsClothsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialsClothsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MaterialsClothsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MaterialsClothsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialsClothsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialsClothsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialsClothsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialsClothsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialsClothsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатериальнойценностиDataGridViewTextBoxColumn,
            this.iDПриходногоордераDataGridViewTextBoxColumn,
            this.iDТканиDataGridViewTextBoxColumn,
            this.iDМоделитканиDataGridViewTextBoxColumn,
            this.материальныеценностиDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.суммабезНДСDataGridViewTextBoxColumn,
            this.суммаНДСDataGridViewTextBoxColumn,
            this.всегосНДСDataGridViewTextBoxColumn,
            this.DeleteColumn});
            this.MaterialsClothsDataGridView.DataSource = this.fKМатериальIDПр1209AD79BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.3F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 13, 8, 13);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialsClothsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaterialsClothsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialsClothsDataGridView.EnableHeadersVisualStyles = false;
            this.MaterialsClothsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.MaterialsClothsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.MaterialsClothsDataGridView.Name = "MaterialsClothsDataGridView";
            this.MaterialsClothsDataGridView.ReadOnly = true;
            this.MaterialsClothsDataGridView.RowHeadersVisible = false;
            this.MaterialsClothsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialsClothsDataGridView.Size = new System.Drawing.Size(1291, 326);
            this.MaterialsClothsDataGridView.TabIndex = 56;
            this.MaterialsClothsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialsClothsDataGridView_CellContentClick);
            // 
            // iDМатериальнойценностиDataGridViewTextBoxColumn
            // 
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.DataPropertyName = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.HeaderText = "ID_Материальной_ценности";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Name = "iDМатериальнойценностиDataGridViewTextBoxColumn";
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМатериальнойценностиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDПриходногоордераDataGridViewTextBoxColumn
            // 
            this.iDПриходногоордераDataGridViewTextBoxColumn.DataPropertyName = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.HeaderText = "ID_Приходного_ордера";
            this.iDПриходногоордераDataGridViewTextBoxColumn.Name = "iDПриходногоордераDataGridViewTextBoxColumn";
            this.iDПриходногоордераDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПриходногоордераDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDТканиDataGridViewTextBoxColumn
            // 
            this.iDТканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.HeaderText = "ID_Ткани";
            this.iDТканиDataGridViewTextBoxColumn.Name = "iDТканиDataGridViewTextBoxColumn";
            this.iDТканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделитканиDataGridViewTextBoxColumn
            // 
            this.iDМоделитканиDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.HeaderText = "ID_Модели_ткани";
            this.iDМоделитканиDataGridViewTextBoxColumn.Name = "iDМоделитканиDataGridViewTextBoxColumn";
            this.iDМоделитканиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделитканиDataGridViewTextBoxColumn.Visible = false;
            // 
            // материальныеценностиDataGridViewTextBoxColumn
            // 
            this.материальныеценностиDataGridViewTextBoxColumn.DataPropertyName = "Материальные_ценности";
            this.материальныеценностиDataGridViewTextBoxColumn.HeaderText = "МАТ. ЦЕННОСТИ";
            this.материальныеценностиDataGridViewTextBoxColumn.Name = "материальныеценностиDataGridViewTextBoxColumn";
            this.материальныеценностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "ЕД. ИЗМЕРЕНИЯ";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "КОЛИЧЕСТВО";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "ЦЕНА";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммабезНДСDataGridViewTextBoxColumn
            // 
            this.суммабезНДСDataGridViewTextBoxColumn.DataPropertyName = "Сумма_без_НДС";
            this.суммабезНДСDataGridViewTextBoxColumn.HeaderText = "СУММА БЕЗ НДС";
            this.суммабезНДСDataGridViewTextBoxColumn.Name = "суммабезНДСDataGridViewTextBoxColumn";
            this.суммабезНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаНДСDataGridViewTextBoxColumn
            // 
            this.суммаНДСDataGridViewTextBoxColumn.DataPropertyName = "Сумма_НДС";
            this.суммаНДСDataGridViewTextBoxColumn.HeaderText = "СУММА НДС";
            this.суммаНДСDataGridViewTextBoxColumn.Name = "суммаНДСDataGridViewTextBoxColumn";
            this.суммаНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // всегосНДСDataGridViewTextBoxColumn
            // 
            this.всегосНДСDataGridViewTextBoxColumn.DataPropertyName = "Всего_с_НДС";
            this.всегосНДСDataGridViewTextBoxColumn.HeaderText = "ВСЕГО С НДС";
            this.всегосНДСDataGridViewTextBoxColumn.Name = "всегосНДСDataGridViewTextBoxColumn";
            this.всегосНДСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::AutomationApp.Properties.Resources.trash_alt_solidFOUR;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.Width = 34;
            // 
            // fKМатериальIDПр1209AD79BindingSource
            // 
            this.fKМатериальIDПр1209AD79BindingSource.DataMember = "FK__Материаль__ID_Пр__0CDAE408";
            this.fKМатериальIDПр1209AD79BindingSource.DataSource = this.приходныеордеранатканьBindingSource;
            // 
            // TitleFoodPanel
            // 
            this.TitleFoodPanel.BackColor = System.Drawing.Color.White;
            this.TitleFoodPanel.Controls.Add(this.AddClothButton);
            this.TitleFoodPanel.Controls.Add(this.SearchIcon);
            this.TitleFoodPanel.Controls.Add(this.SearchTextBox);
            this.TitleFoodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleFoodPanel.Name = "TitleFoodPanel";
            this.TitleFoodPanel.Size = new System.Drawing.Size(1291, 67);
            this.TitleFoodPanel.TabIndex = 55;
            // 
            // AddClothButton
            // 
            this.AddClothButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(187)))));
            this.AddClothButton.FlatAppearance.BorderSize = 0;
            this.AddClothButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.AddClothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClothButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.1F);
            this.AddClothButton.ForeColor = System.Drawing.Color.White;
            this.AddClothButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddClothButton.IconColor = System.Drawing.Color.White;
            this.AddClothButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClothButton.IconSize = 16;
            this.AddClothButton.Location = new System.Drawing.Point(1082, 13);
            this.AddClothButton.Name = "AddClothButton";
            this.AddClothButton.Size = new System.Drawing.Size(182, 39);
            this.AddClothButton.TabIndex = 9;
            this.AddClothButton.Text = "Добавить ткань";
            this.AddClothButton.UseVisualStyleBackColor = false;
            this.AddClothButton.Click += new System.EventHandler(this.AddClothButton_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchIcon.Enabled = false;
            this.SearchIcon.FlatAppearance.BorderSize = 0;
            this.SearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.SearchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchIcon.IconSize = 30;
            this.SearchIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchIcon.Location = new System.Drawing.Point(0, 0);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SearchIcon.Size = new System.Drawing.Size(61, 67);
            this.SearchIcon.TabIndex = 8;
            this.SearchIcon.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.SearchTextBox.Location = new System.Drawing.Point(67, 22);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(980, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Введите ваш запрос";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.SelectButton.Location = new System.Drawing.Point(668, 103);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(53, 39);
            this.SelectButton.TabIndex = 90;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ClothLabelError
            // 
            this.ClothLabelError.AutoSize = true;
            this.ClothLabelError.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClothLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClothLabelError.Location = new System.Drawing.Point(26, 289);
            this.ClothLabelError.Name = "ClothLabelError";
            this.ClothLabelError.Size = new System.Drawing.Size(276, 16);
            this.ClothLabelError.TabIndex = 88;
            this.ClothLabelError.Text = "Введите данные о ткани для приходного ордера";
            this.ClothLabelError.Visible = false;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.SumLabel.ForeColor = System.Drawing.Color.Gray;
            this.SumLabel.Location = new System.Drawing.Point(763, 185);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(52, 19);
            this.SumLabel.TabIndex = 86;
            this.SumLabel.Text = "Сумма";
            // 
            // FollowLabel
            // 
            this.FollowLabel.AutoSize = true;
            this.FollowLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.FollowLabel.ForeColor = System.Drawing.Color.Gray;
            this.FollowLabel.Location = new System.Drawing.Point(381, 185);
            this.FollowLabel.Name = "FollowLabel";
            this.FollowLabel.Size = new System.Drawing.Size(201, 19);
            this.FollowLabel.TabIndex = 85;
            this.FollowLabel.Text = "Сопроводительный документ";
            // 
            // CorrespondingLabel
            // 
            this.CorrespondingLabel.AutoSize = true;
            this.CorrespondingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.CorrespondingLabel.ForeColor = System.Drawing.Color.Gray;
            this.CorrespondingLabel.Location = new System.Drawing.Point(25, 184);
            this.CorrespondingLabel.Name = "CorrespondingLabel";
            this.CorrespondingLabel.Size = new System.Drawing.Size(182, 19);
            this.CorrespondingLabel.TabIndex = 87;
            this.CorrespondingLabel.Text = "Корреспондирующий счет";
            // 
            // SumOrderTextBox
            // 
            this.SumOrderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SumOrderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.SumOrderTextBox.BorderRadius = 2;
            this.SumOrderTextBox.FillColor = System.Drawing.Color.White;
            this.SumOrderTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumOrderTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SumOrderTextBox.ForeColors = System.Drawing.Color.Black;
            this.SumOrderTextBox.IsPassword = false;
            this.SumOrderTextBox.LineThickness = 1;
            this.SumOrderTextBox.Location = new System.Drawing.Point(763, 207);
            this.SumOrderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumOrderTextBox.MaxLength = 32767;
            this.SumOrderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.SumOrderTextBox.Name = "SumOrderTextBox";
            this.SumOrderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SumOrderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.SumOrderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SumOrderTextBox.ReadOnly = true;
            this.SumOrderTextBox.Size = new System.Drawing.Size(284, 41);
            this.SumOrderTextBox.TabIndex = 84;
            this.SumOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumOrderTextBox.TextName = "";
            // 
            // FollowDocumentTextBox
            // 
            this.FollowDocumentTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FollowDocumentTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.FollowDocumentTextBox.BorderRadius = 2;
            this.FollowDocumentTextBox.FillColor = System.Drawing.Color.White;
            this.FollowDocumentTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FollowDocumentTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FollowDocumentTextBox.ForeColors = System.Drawing.Color.Black;
            this.FollowDocumentTextBox.IsPassword = false;
            this.FollowDocumentTextBox.LineThickness = 1;
            this.FollowDocumentTextBox.Location = new System.Drawing.Point(382, 207);
            this.FollowDocumentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FollowDocumentTextBox.MaxLength = 32767;
            this.FollowDocumentTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.Name = "FollowDocumentTextBox";
            this.FollowDocumentTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.FollowDocumentTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.FollowDocumentTextBox.ReadOnly = false;
            this.FollowDocumentTextBox.Size = new System.Drawing.Size(284, 41);
            this.FollowDocumentTextBox.TabIndex = 83;
            this.FollowDocumentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FollowDocumentTextBox.TextName = "";
            this.FollowDocumentTextBox.Enter += new System.EventHandler(this.FollowDocumentTextBox_Enter);
            this.FollowDocumentTextBox.Leave += new System.EventHandler(this.FollowDocumentTextBox_Leave);
            // 
            // CorrespondingAccountTextBox
            // 
            this.CorrespondingAccountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CorrespondingAccountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.CorrespondingAccountTextBox.BorderRadius = 2;
            this.CorrespondingAccountTextBox.FillColor = System.Drawing.Color.White;
            this.CorrespondingAccountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorrespondingAccountTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorrespondingAccountTextBox.ForeColors = System.Drawing.Color.Black;
            this.CorrespondingAccountTextBox.IsPassword = false;
            this.CorrespondingAccountTextBox.LineThickness = 1;
            this.CorrespondingAccountTextBox.Location = new System.Drawing.Point(26, 207);
            this.CorrespondingAccountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CorrespondingAccountTextBox.MaxLength = 32767;
            this.CorrespondingAccountTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.Name = "CorrespondingAccountTextBox";
            this.CorrespondingAccountTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.CorrespondingAccountTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.CorrespondingAccountTextBox.ReadOnly = false;
            this.CorrespondingAccountTextBox.Size = new System.Drawing.Size(284, 41);
            this.CorrespondingAccountTextBox.TabIndex = 82;
            this.CorrespondingAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CorrespondingAccountTextBox.TextName = "";
            this.CorrespondingAccountTextBox.Enter += new System.EventHandler(this.CorrespondingAccountTextBox_Enter);
            this.CorrespondingAccountTextBox.Leave += new System.EventHandler(this.CorrespondingAccountTextBox_Leave);
            // 
            // WarehouseLabel
            // 
            this.WarehouseLabel.AutoSize = true;
            this.WarehouseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.WarehouseLabel.ForeColor = System.Drawing.Color.Gray;
            this.WarehouseLabel.Location = new System.Drawing.Point(763, 78);
            this.WarehouseLabel.Name = "WarehouseLabel";
            this.WarehouseLabel.Size = new System.Drawing.Size(48, 19);
            this.WarehouseLabel.TabIndex = 80;
            this.WarehouseLabel.Text = "Склад";
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.ProviderLabel.ForeColor = System.Drawing.Color.Gray;
            this.ProviderLabel.Location = new System.Drawing.Point(381, 78);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(82, 19);
            this.ProviderLabel.TabIndex = 81;
            this.ProviderLabel.Text = "Поставщик";
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
            this.ProviderTextBox.Location = new System.Drawing.Point(382, 101);
            this.ProviderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProviderTextBox.MaxLength = 32767;
            this.ProviderTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProviderTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.ProviderTextBox.ReadOnly = true;
            this.ProviderTextBox.Size = new System.Drawing.Size(284, 41);
            this.ProviderTextBox.TabIndex = 79;
            this.ProviderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProviderTextBox.TextName = "";
            this.ProviderTextBox.Enter += new System.EventHandler(this.ProviderTextBox_Enter);
            this.ProviderTextBox.Leave += new System.EventHandler(this.ProviderTextBox_Leave);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.1F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(27, 108);
            this.DateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(283, 24);
            this.DateTimePicker.TabIndex = 64;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.2F);
            this.DataLabel.ForeColor = System.Drawing.Color.Gray;
            this.DataLabel.Location = new System.Drawing.Point(25, 78);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(124, 19);
            this.DataLabel.TabIndex = 78;
            this.DataLabel.Text = "Дата составления";
            // 
            // FollowErrorLabel
            // 
            this.FollowErrorLabel.AutoSize = true;
            this.FollowErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FollowErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FollowErrorLabel.Location = new System.Drawing.Point(382, 252);
            this.FollowErrorLabel.Name = "FollowErrorLabel";
            this.FollowErrorLabel.Size = new System.Drawing.Size(168, 16);
            this.FollowErrorLabel.TabIndex = 77;
            this.FollowErrorLabel.Text = "Введите данные о документе";
            this.FollowErrorLabel.Visible = false;
            // 
            // CorrespondingErrorLabel
            // 
            this.CorrespondingErrorLabel.AutoSize = true;
            this.CorrespondingErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrespondingErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CorrespondingErrorLabel.Location = new System.Drawing.Point(26, 252);
            this.CorrespondingErrorLabel.Name = "CorrespondingErrorLabel";
            this.CorrespondingErrorLabel.Size = new System.Drawing.Size(140, 16);
            this.CorrespondingErrorLabel.TabIndex = 76;
            this.CorrespondingErrorLabel.Text = "Введите данные о счете";
            this.CorrespondingErrorLabel.Visible = false;
            // 
            // WarehouseErrorLabel
            // 
            this.WarehouseErrorLabel.AutoSize = true;
            this.WarehouseErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WarehouseErrorLabel.Location = new System.Drawing.Point(765, 147);
            this.WarehouseErrorLabel.Name = "WarehouseErrorLabel";
            this.WarehouseErrorLabel.Size = new System.Drawing.Size(147, 16);
            this.WarehouseErrorLabel.TabIndex = 75;
            this.WarehouseErrorLabel.Text = "Введите данные о складе";
            this.WarehouseErrorLabel.Visible = false;
            // 
            // ProviderErrorLabel
            // 
            this.ProviderErrorLabel.AutoSize = true;
            this.ProviderErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProviderErrorLabel.Location = new System.Drawing.Point(382, 146);
            this.ProviderErrorLabel.Name = "ProviderErrorLabel";
            this.ProviderErrorLabel.Size = new System.Drawing.Size(131, 16);
            this.ProviderErrorLabel.TabIndex = 74;
            this.ProviderErrorLabel.Text = "Выберите поставщика";
            this.ProviderErrorLabel.Visible = false;
            // 
            // DataErrorLabel
            // 
            this.DataErrorLabel.AutoSize = true;
            this.DataErrorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataErrorLabel.Location = new System.Drawing.Point(25, 147);
            this.DataErrorLabel.Name = "DataErrorLabel";
            this.DataErrorLabel.Size = new System.Drawing.Size(89, 16);
            this.DataErrorLabel.TabIndex = 73;
            this.DataErrorLabel.Text = "Выберите дату";
            this.DataErrorLabel.Visible = false;
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveItemButton.FlatAppearance.BorderSize = 0;
            this.SaveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.SaveItemButton.ForeColor = System.Drawing.Color.White;
            this.SaveItemButton.Location = new System.Drawing.Point(1082, 102);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(182, 39);
            this.SaveItemButton.TabIndex = 71;
            this.SaveItemButton.Text = "СОХРАНИТЬ";
            this.SaveItemButton.UseVisualStyleBackColor = false;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // WarehouseTextBox
            // 
            this.WarehouseTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WarehouseTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.WarehouseTextBox.BorderRadius = 2;
            this.WarehouseTextBox.FillColor = System.Drawing.SystemColors.Window;
            this.WarehouseTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WarehouseTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WarehouseTextBox.ForeColors = System.Drawing.Color.Black;
            this.WarehouseTextBox.IsPassword = false;
            this.WarehouseTextBox.LineThickness = 1;
            this.WarehouseTextBox.Location = new System.Drawing.Point(763, 101);
            this.WarehouseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WarehouseTextBox.MaxLength = 32767;
            this.WarehouseTextBox.MouseOnHover = System.Drawing.Color.Empty;
            this.WarehouseTextBox.Name = "WarehouseTextBox";
            this.WarehouseTextBox.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.WarehouseTextBox.OnFocusColor = System.Drawing.Color.Empty;
            this.WarehouseTextBox.OnFocusFontColor = System.Drawing.Color.Empty;
            this.WarehouseTextBox.ReadOnly = false;
            this.WarehouseTextBox.Size = new System.Drawing.Size(284, 41);
            this.WarehouseTextBox.TabIndex = 89;
            this.WarehouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WarehouseTextBox.TextName = "";
            this.WarehouseTextBox.Enter += new System.EventHandler(this.WarehouseTextBox_Enter);
            this.WarehouseTextBox.Leave += new System.EventHandler(this.WarehouseTextBox_Leave);
            // 
            // EditClothOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 745);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ClothLabelError);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.FollowLabel);
            this.Controls.Add(this.CorrespondingLabel);
            this.Controls.Add(this.SumOrderTextBox);
            this.Controls.Add(this.FollowDocumentTextBox);
            this.Controls.Add(this.CorrespondingAccountTextBox);
            this.Controls.Add(this.WarehouseLabel);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.FollowErrorLabel);
            this.Controls.Add(this.CorrespondingErrorLabel);
            this.Controls.Add(this.WarehouseErrorLabel);
            this.Controls.Add(this.ProviderErrorLabel);
            this.Controls.Add(this.DataErrorLabel);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.WarehouseTextBox);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditClothOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClothOrdersForm";
            this.Load += new System.EventHandler(this.EditClothOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходныеордеранатканьBindingSource)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsClothsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKМатериальIDПр1209AD79BindingSource)).EndInit();
            this.TitleFoodPanel.ResumeLayout(false);
            this.TitleFoodPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private AutomationAppDBDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource приходныеордеранатканьBindingSource;
        private AutomationAppDBDataSetTableAdapters.Приходные_ордера_на_тканьTableAdapter приходные_ордера_на_тканьTableAdapter;
        private AutomationAppDBDataSetTableAdapters.Материальные_ценности_по_ордеру_на_тканьTableAdapter материальные_ценности_по_ордеру_на_тканьTableAdapter;
        private System.Windows.Forms.Panel TitlePanel;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label LabelForm;
        private FontAwesome.Sharp.IconPictureBox IconPictureBox;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Label TopLabel;
        private FontAwesome.Sharp.IconPictureBox TopPictureButton;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TitleFoodPanel;
        private FontAwesome.Sharp.IconButton AddClothButton;
        private FontAwesome.Sharp.IconButton SearchIcon;
        private System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.DataGridView MaterialsClothsDataGridView;
        public AutomationAppDBDataSet automationAppDBDataSet;
        private FontAwesome.Sharp.IconButton SelectButton;
        private System.Windows.Forms.Label ClothLabelError;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label FollowLabel;
        private System.Windows.Forms.Label CorrespondingLabel;
        private JMetroTextBox.JMetroTextBox SumOrderTextBox;
        private JMetroTextBox.JMetroTextBox FollowDocumentTextBox;
        private JMetroTextBox.JMetroTextBox CorrespondingAccountTextBox;
        private System.Windows.Forms.Label WarehouseLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private JMetroTextBox.JMetroTextBox ProviderTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label FollowErrorLabel;
        private System.Windows.Forms.Label CorrespondingErrorLabel;
        private System.Windows.Forms.Label WarehouseErrorLabel;
        private System.Windows.Forms.Label ProviderErrorLabel;
        private System.Windows.Forms.Label DataErrorLabel;
        private System.Windows.Forms.Button SaveItemButton;
        private JMetroTextBox.JMetroTextBox WarehouseTextBox;
        public System.Windows.Forms.BindingSource fKМатериальIDПр1209AD79BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериальнойценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПриходногоордераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделитканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныеценностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммабезНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегосНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}