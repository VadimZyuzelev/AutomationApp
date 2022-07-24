
namespace AutomationApp
{
    partial class WarehouseProductsForm
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
            this.WarehouseProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.automationAppDBDataSet = new AutomationApp.AutomationAppDBDataSet();
            this.склад_готовой_продукцииTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Склад_готовой_продукцииTableAdapter();
            this.изделияпринятыенаскладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделия_принятые_на_складTableAdapter = new AutomationApp.AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter();
            this.складготовойпродукцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМоделиизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияпринятыенаскладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складготовойпродукцииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WarehouseProductsDataGridView
            // 
            this.WarehouseProductsDataGridView.AllowUserToAddRows = false;
            this.WarehouseProductsDataGridView.AllowUserToDeleteRows = false;
            this.WarehouseProductsDataGridView.AutoGenerateColumns = false;
            this.WarehouseProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WarehouseProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn,
            this.iDМоделиизделияDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.сортDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn});
            this.WarehouseProductsDataGridView.DataSource = this.складготовойпродукцииBindingSource;
            this.WarehouseProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseProductsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.WarehouseProductsDataGridView.Name = "WarehouseProductsDataGridView";
            this.WarehouseProductsDataGridView.ReadOnly = true;
            this.WarehouseProductsDataGridView.RowHeadersVisible = false;
            this.WarehouseProductsDataGridView.Size = new System.Drawing.Size(1425, 608);
            this.WarehouseProductsDataGridView.TabIndex = 0;
            this.WarehouseProductsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WarehouseProductsDataGridView_CellMouseDoubleClick);
            // 
            // automationAppDBDataSet
            // 
            this.automationAppDBDataSet.DataSetName = "AutomationAppDBDataSet";
            this.automationAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // склад_готовой_продукцииTableAdapter
            // 
            this.склад_готовой_продукцииTableAdapter.ClearBeforeFill = true;
            // 
            // изделияпринятыенаскладBindingSource
            // 
            this.изделияпринятыенаскладBindingSource.DataMember = "Изделия_принятые_на_склад";
            this.изделияпринятыенаскладBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // изделия_принятые_на_складTableAdapter
            // 
            this.изделия_принятые_на_складTableAdapter.ClearBeforeFill = true;
            // 
            // складготовойпродукцииBindingSource
            // 
            this.складготовойпродукцииBindingSource.DataMember = "Склад_готовой_продукции";
            this.складготовойпродукцииBindingSource.DataSource = this.automationAppDBDataSet;
            // 
            // iDГотовойпродукциинаскладеDataGridViewTextBoxColumn
            // 
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.DataPropertyName = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.HeaderText = "ID_Готовой_продукции_на_складе";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.Name = "iDГотовойпродукциинаскладеDataGridViewTextBoxColumn";
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDГотовойпродукциинаскладеDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDМоделиизделияDataGridViewTextBoxColumn
            // 
            this.iDМоделиизделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.HeaderText = "ID_Модели_изделия";
            this.iDМоделиизделияDataGridViewTextBoxColumn.Name = "iDМоделиизделияDataGridViewTextBoxColumn";
            this.iDМоделиизделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМоделиизделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Изделия";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Изделия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Изделие";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Модель_изделия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // сортDataGridViewTextBoxColumn
            // 
            this.сортDataGridViewTextBoxColumn.DataPropertyName = "Сорт";
            this.сортDataGridViewTextBoxColumn.HeaderText = "Сорт";
            this.сортDataGridViewTextBoxColumn.Name = "сортDataGridViewTextBoxColumn";
            this.сортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Ед. измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WarehouseProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 608);
            this.Controls.Add(this.WarehouseProductsDataGridView);
            this.Name = "WarehouseProductsForm";
            this.Text = "WarehouseProductsForm";
            this.Load += new System.EventHandler(this.WarehouseProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automationAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияпринятыенаскладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складготовойпродукцииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WarehouseProductsDataGridView;
        public AutomationAppDBDataSet automationAppDBDataSet;
        public AutomationAppDBDataSetTableAdapters.Склад_готовой_продукцииTableAdapter склад_готовой_продукцииTableAdapter;        
        private System.Windows.Forms.BindingSource изделияпринятыенаскладBindingSource;
        private AutomationAppDBDataSetTableAdapters.Изделия_принятые_на_складTableAdapter изделия_принятые_на_складTableAdapter;
        private System.Windows.Forms.BindingSource складготовойпродукцииBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГотовойпродукциинаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМоделиизделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn сортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
    }
}