using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Subro.Controls;

namespace AutomationApp
{
    public partial class ItemsForm : Form
    {
        private readonly EditRouteSheetsForm EditRouteSheetsForm;
        private readonly EditCalculationCardsForm EditCalculationCardsForm;
        private readonly EditLimitCardsForm EditLimitCardsForm;

        private readonly bool FlagSelectItemsInRouteSheet;
        private readonly bool FlagSelectItemsInCard;
        private readonly bool FlagSelectItemsInLimitCard;
        public ItemsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public ItemsForm(EditRouteSheetsForm editRouteSheetsForm, bool flagSelectItemsInRouteSheet)
        {
            InitializeComponent();
            this.EditRouteSheetsForm = editRouteSheetsForm;
            this.FlagSelectItemsInRouteSheet = flagSelectItemsInRouteSheet;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public ItemsForm(EditCalculationCardsForm editCalculationCardsForm, bool flagSelectItemsInCard)
        {
            InitializeComponent();
            this.EditCalculationCardsForm = editCalculationCardsForm;
            this.FlagSelectItemsInCard = flagSelectItemsInCard;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public ItemsForm(EditLimitCardsForm editLimitCardsForm, bool flagSelectItemsInLimitCard)
        {
            InitializeComponent();
            this.EditLimitCardsForm = editLimitCardsForm;
            this.FlagSelectItemsInLimitCard = flagSelectItemsInLimitCard;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            this.ИзделияTableAdapter.Fill(this.automationAppDBDataSet.Изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_изделия". При необходимости она может быть перемещена или удалена.
            this.МоделиИзделияTableAdapter.Fill(this.automationAppDBDataSet.Модели_изделия);

            if (FlagSelectItemsInRouteSheet || FlagSelectItemsInCard || FlagSelectItemsInLimitCard)
            {
                TopPanel.Visible = true;
            }

            SetGroupingDataGrid();
        }

        private void SetGroupingDataGrid()
        {
            DataGridViewGrouper.DataGridView = ModelDataGridView;
            DataGridViewGrouper.SetGroupOn(ModelDataGridView.Columns["наименованиеDataGridViewTextBoxColumn"]);
            DataGridViewGrouper.DisplayGroup += Grouper_DisplayGroup;
        }

        void Grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void ModelDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectItemsInRouteSheet)
            {
                EditRouteSheetsForm.ID_Model = Convert.ToInt32(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["ID_Модели_изделия"]);
                EditRouteSheetsForm.NameItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Наименование"]);
                EditRouteSheetsForm.ModelItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Модель_изделия"]);
                this.Close();
            }

            if (FlagSelectItemsInCard)
            {
                EditCalculationCardsForm.ID_Model = Convert.ToInt32(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["ID_Модели_изделия"]);
                EditCalculationCardsForm.NameItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Наименование"]);
                EditCalculationCardsForm.ModelItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Модель_изделия"]);
                this.Close();
            }
            
            if (FlagSelectItemsInLimitCard)
            {
                EditLimitCardsForm.ID_Model = Convert.ToInt32(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["ID_Модели_изделия"]);
                EditLimitCardsForm.NameItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Наименование"]);
                EditLimitCardsForm.ModelItem = Convert.ToString(((DataRowView)this.МоделиИзделияBindingSource.Current).Row["Модель_изделия"]);
                this.Close();
            }

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            EditItemForm EditItemForm = new EditItemForm(this);
            EditItemForm.ShowDialog();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = "Введите ваш запрос";
            SearchTextBox.ForeColor = Color.FromArgb(164, 167, 180);
            this.МоделиИзделияBindingSource.Filter = "";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModelDataGridView.Rows.Count != 0)
            {
                string Query = "";
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_изделия like '%" + SearchTextBox.Text + "%'";
                }

                this.МоделиИзделияBindingSource.Filter = Query;
            }
            if (SearchTextBox.Text == "")
            {
                this.МоделиИзделияBindingSource.Filter = "";
            }
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Введите ваш запрос")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.FromArgb(86, 87, 96);
            }
        }

        private void ModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditItemForm ItemForm = new EditItemForm(this, FlagEdit);
                ItemForm.ShowDialog();
            }
        }

        private void ModelDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ModelDataGridView.ClearSelection();           
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizedButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
