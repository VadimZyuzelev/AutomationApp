using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Subro.Controls;

namespace AutomationApp
{
    public partial class ClothsForm : Form
    {
        private readonly EditClothInOrdersForm EditClothInOrdersForm;
        private readonly bool FlagSelectClothInOrder;

        public ClothsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public ClothsForm(EditClothInOrdersForm editClothInOrdersForm, bool flagSelectClothInOrder)
        {
            InitializeComponent();
            this.EditClothInOrdersForm = editClothInOrdersForm;
            this.FlagSelectClothInOrder = flagSelectClothInOrder;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ClothsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_ткани". При необходимости она может быть перемещена или удалена.
            this.модели_тканиTableAdapter.Fill(this.automationAppDBDataSet.Модели_ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.automationAppDBDataSet.Ткани);
            
            if (FlagSelectClothInOrder)
            {
                TopPanel.Visible = true;
            }

            SetGroupingDataGrid();

        }

        public void SetGroupingDataGrid()
        {
            DataGridViewGrouper.DataGridView = ModelClothsDataGridView;
            DataGridViewGrouper.SetGroupOn(ModelClothsDataGridView.Columns["наименованиеDataGridViewTextBoxColumn"]);
            DataGridViewGrouper.DisplayGroup += GrouperDisplayGroup;
        }

        private void GrouperDisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void AddClothButton_Click(object sender, EventArgs e)
        {
            EditClothForm EditClothForm = new EditClothForm(this);
            EditClothForm.ShowDialog();
        }

        private void ModelClothsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectClothInOrder)
            {               
                EditClothInOrdersForm.ID_Cloth = Convert.ToInt32(((DataRowView)this.моделитканиBindingSource.Current).Row["ID_Ткани"]);
                EditClothInOrdersForm.ID_ModelCloth = Convert.ToInt32(((DataRowView)this.моделитканиBindingSource.Current).Row["ID_Модели_ткани"]);
                EditClothInOrdersForm.Cloth = Convert.ToString(((DataRowView)this.моделитканиBindingSource.Current).Row["Наименование"]);
                EditClothInOrdersForm.ModelCloth = Convert.ToString(((DataRowView)this.моделитканиBindingSource.Current).Row["Модель_ткани"]);

                this.Close();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModelClothsDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_ткани like '%" + SearchTextBox.Text + "%'";
                }

                this.fKМоделиткIDТк6C190EBBBindingSource.Filter = Query;
            }
            else
            {
                this.fKМоделиткIDТк6C190EBBBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.fKМоделиткIDТк6C190EBBBindingSource.Filter = "";
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

        private void ModelClothsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditClothForm EditClothForm = new EditClothForm(this, FlagEdit);
                EditClothForm.ShowDialog();
            }
        }

        private void ModelClothsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ModelClothsDataGridView.ClearSelection();
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

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
