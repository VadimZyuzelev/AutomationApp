
namespace AutomationApp
{
    partial class SectionsForm
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
            this.цехаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цехаTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.ЦехаTableAdapter();
            this.tableAdapterManager = new AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager();
            this.бригадыTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.БригадыTableAdapter();
            this.fKБригадыIDЦеха5FB337D6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeamsGridView = new System.Windows.Forms.DataGridView();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цехDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бригадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKБригадыIDЦеха5FB337D6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цехаBindingSource
            // 
            this.цехаBindingSource.DataMember = "Цеха";
            this.цехаBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // цехаTableAdapter
            // 
            this.цехаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AutomationApp.AutomationAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.БригадыTableAdapter = this.бригадыTableAdapter;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Изделия_принятые_на_складTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = null;
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
            this.tableAdapterManager.ЦехаTableAdapter = this.цехаTableAdapter;
            // 
            // бригадыTableAdapter
            // 
            this.бригадыTableAdapter.ClearBeforeFill = true;
            // 
            // fKБригадыIDЦеха5FB337D6BindingSource
            // 
            this.fKБригадыIDЦеха5FB337D6BindingSource.DataMember = "FK__Бригады__ID_Цеха__5FB337D6";
            this.fKБригадыIDЦеха5FB337D6BindingSource.DataSource = this.цехаBindingSource;
            // 
            // TeamsGridView
            // 
            this.TeamsGridView.AllowUserToAddRows = false;
            this.TeamsGridView.AllowUserToDeleteRows = false;
            this.TeamsGridView.AutoGenerateColumns = false;
            this.TeamsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeamsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDБригадыDataGridViewTextBoxColumn,
            this.iDЦехаDataGridViewTextBoxColumn,
            this.цехDataGridViewTextBoxColumn,
            this.бригадаDataGridViewTextBoxColumn});
            this.TeamsGridView.DataSource = this.fKБригадыIDЦеха5FB337D6BindingSource;
            this.TeamsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsGridView.Location = new System.Drawing.Point(0, 0);
            this.TeamsGridView.Name = "TeamsGridView";
            this.TeamsGridView.ReadOnly = true;
            this.TeamsGridView.RowHeadersVisible = false;
            this.TeamsGridView.Size = new System.Drawing.Size(1296, 574);
            this.TeamsGridView.TabIndex = 3;
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            this.iDБригадыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDБригадыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDЦехаDataGridViewTextBoxColumn
            // 
            this.iDЦехаDataGridViewTextBoxColumn.DataPropertyName = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.HeaderText = "ID_Цеха";
            this.iDЦехаDataGridViewTextBoxColumn.Name = "iDЦехаDataGridViewTextBoxColumn";
            this.iDЦехаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЦехаDataGridViewTextBoxColumn.Visible = false;
            // 
            // цехDataGridViewTextBoxColumn
            // 
            this.цехDataGridViewTextBoxColumn.DataPropertyName = "Цех";
            this.цехDataGridViewTextBoxColumn.HeaderText = "Цех";
            this.цехDataGridViewTextBoxColumn.Name = "цехDataGridViewTextBoxColumn";
            this.цехDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // бригадаDataGridViewTextBoxColumn
            // 
            this.бригадаDataGridViewTextBoxColumn.DataPropertyName = "Бригада";
            this.бригадаDataGridViewTextBoxColumn.HeaderText = "Бригада";
            this.бригадаDataGridViewTextBoxColumn.Name = "бригадаDataGridViewTextBoxColumn";
            this.бригадаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 574);
            this.Controls.Add(this.TeamsGridView);
            this.Name = "SectionsForm";
            this.Text = "SectionsForm";
            this.Load += new System.EventHandler(this.SectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKБригадыIDЦеха5FB337D6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutomationAppDBDataSet automationAppDBDataSet;
        private System.Windows.Forms.BindingSource цехаBindingSource;
        private AutomationAppDBDataSetTableAdapters.ЦехаTableAdapter цехаTableAdapter;
        private AutomationAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutomationAppDBDataSetTableAdapters.БригадыTableAdapter бригадыTableAdapter;
        private System.Windows.Forms.BindingSource fKБригадыIDЦеха5FB337D6BindingSource;
        private System.Windows.Forms.DataGridView TeamsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цехDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бригадаDataGridViewTextBoxColumn;
    }
}