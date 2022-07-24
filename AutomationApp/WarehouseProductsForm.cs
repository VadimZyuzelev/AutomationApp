using System;
using System.Data;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class WarehouseProductsForm : Form
    {
        private readonly EditProductsInNoteForm editProductsInNote;
        readonly bool FlagSelectProductsInNote;

        public WarehouseProductsForm()
        {
            InitializeComponent();
        }

        public WarehouseProductsForm(EditProductsInNoteForm productsForm, bool FlagSelect)
        {
            InitializeComponent();
            this.editProductsInNote = productsForm;
            this.FlagSelectProductsInNote = FlagSelect;

        }

        private void WarehouseProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия_принятые_на_склад". При необходимости она может быть перемещена или удалена.
            this.изделия_принятые_на_складTableAdapter.Fill(this.automationAppDBDataSet.Изделия_принятые_на_склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_готовой_продукции". При необходимости она может быть перемещена или удалена.
            this.склад_готовой_продукцииTableAdapter.Fill(this.automationAppDBDataSet.Склад_готовой_продукции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_готовой_продукции". При необходимости она может быть перемещена или удалена.
            this.склад_готовой_продукцииTableAdapter.Fill(this.automationAppDBDataSet.Склад_готовой_продукции);

        }

        private void WarehouseProductsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectProductsInNote)
            {
                editProductsInNote.ID_ProductsWarehouse = Convert.ToInt32(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["ID_Готовой_продукции_на_складе"]);
                editProductsInNote.ID_ModelProducts = Convert.ToInt32(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["ID_Модели_изделия"]);
                editProductsInNote.Products = Convert.ToString(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["Наименование"]);
                editProductsInNote.ModelProducts = Convert.ToString(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["Модель_изделия"]);
                editProductsInNote.Sort = Convert.ToString(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["Сорт"]);
                editProductsInNote.UnitDetermination = Convert.ToString(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["Единица_измерения"]);
                editProductsInNote.CountProducts = Convert.ToInt32(((DataRowView)this.складготовойпродукцииBindingSource.Current).Row["Количество"]);
                this.Close();
            }
        }
    }
}
