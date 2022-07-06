using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subro.Controls;

namespace AutomationApp
{
    public partial class FurnitureForm : Form
    {
        private readonly EditFurnitureInOrderForm EditFurnitureInOrderForm;
        
        private readonly bool FlagSelectFurnitureInOrder;

        public FurnitureForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public FurnitureForm(EditFurnitureInOrderForm editFurnitureInOrderForm, bool flagSelectFurnitureInOrder)
        {
            InitializeComponent();
            this.EditFurnitureInOrderForm = editFurnitureInOrderForm;
            this.FlagSelectFurnitureInOrder = flagSelectFurnitureInOrder;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }


        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Модели_фурнитуры". При необходимости она может быть перемещена или удалена.
            this.модели_фурнитурыTableAdapter.Fill(this.automationAppDBDataSet.Модели_фурнитуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_фурнитуры". При необходимости она может быть перемещена или удалена.
            //this.склад_фурнитурыTableAdapter.Fill(this.automationAppDBDataSet.Склад_фурнитуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.automationAppDBDataSet.Фурнитура);

            if (FlagSelectFurnitureInOrder)
            {
                TopPanel.Visible = true;
            }

            SetGroupingDataGrid();
        }

        public void SetGroupingDataGrid()
        {
            DataGridViewGrouper.DataGridView = ModelFurnitureDataGridView;
            DataGridViewGrouper.SetGroupOn(ModelFurnitureDataGridView.Columns["наименованиеDataGridViewTextBoxColumn"]);
            DataGridViewGrouper.DisplayGroup += GrouperDisplayGroup;
        }

        private void GrouperDisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void ModelFurnitureDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectFurnitureInOrder)
            {
                //EditFurnitureInOrderForm.ID_Cloth = Convert.ToInt32(((DataRowView)this.моделитканиBindingSource.Current).Row["ID_Ткани"]);
                EditFurnitureInOrderForm.ID_ModelFurniture = Convert.ToInt32(((DataRowView)this.модели_фурнитурыBindingSource.Current).Row["ID_Модели_фурнитуры"]);
                EditFurnitureInOrderForm.Furniture = Convert.ToString(((DataRowView)this.модели_фурнитурыBindingSource.Current).Row["Наименование"]);
                EditFurnitureInOrderForm.ModelFurniture = Convert.ToString(((DataRowView)this.модели_фурнитурыBindingSource.Current).Row["Модель_фурнитуры"]);
               
                this.Close();
            }
        }

        private void AddIFurnitureButton_Click(object sender, EventArgs e)
        {
            EditFurnitureForm EditFurnitureForm = new EditFurnitureForm(this);
            EditFurnitureForm.ShowDialog();
        }

        private void ModelFurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditFurnitureForm EditFurnitureForm = new EditFurnitureForm(this, FlagEdit);
                EditFurnitureForm.ShowDialog();
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModelFurnitureDataGridView.Rows.Count != 0)
            {
                string Query = "";
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_фурнитуры like '%" + SearchTextBox.Text + "%'";
                }

                this.модели_фурнитурыBindingSource.Filter = Query;
            }
            if (SearchTextBox.Text == "")
            {
                this.модели_фурнитурыBindingSource.Filter = "";
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
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

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
