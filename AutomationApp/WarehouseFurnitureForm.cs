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
    public partial class WarehouseFurnitureForm : Form
    {
        private readonly EditFurnitureInCardsForm EditFurnitureInCardsForm;

        readonly bool FlagSelectionFurnitureInCard;
        public WarehouseFurnitureForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            SetGroupDataGridView();
        }
        
        public WarehouseFurnitureForm(EditFurnitureInCardsForm editFurnitureInCardsForm, bool flagSelectionFurnitureInCard)
        {
            InitializeComponent();
            this.EditFurnitureInCardsForm = editFurnitureInCardsForm;
            this.FlagSelectionFurnitureInCard = flagSelectionFurnitureInCard;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            SetGroupDataGridView();
        }

        private void WarehouseFurnitureForm_Load(object sender, EventArgs e)
        {   
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_фурнитуры". При необходимости она может быть перемещена или удалена.
            this.склад_фурнитурыTableAdapter.Fill(this.automationAppDBDataSet.Склад_фурнитуры);

            if (FlagSelectionFurnitureInCard)
            {
                CreateReprotButton.Visible = false;
                TopPanel.Visible = true;
            }
        }

        private void SetGroupDataGridView()
        {
            var grouper = new Subro.Controls.DataGridViewGrouper
            {
                DataGridView = WarehouseFurnitureDataGridView
            };
            grouper.SetGroupOn(WarehouseFurnitureDataGridView.Columns["наименованиеDataGridViewTextBoxColumn"]);
            grouper.DisplayGroup += grouper_DisplayGroup;
        }

        private void grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void WarehouseFurnitureDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectionFurnitureInCard)
            {
                EditFurnitureInCardsForm.ID_FurnitureWarehouse = Convert.ToInt32(((DataRowView)this.складфурнитурыBindingSource.Current).Row["ID_фурнитуры_на_складе"]);
                EditFurnitureInCardsForm.ID_ModelFurniture = Convert.ToInt32(((DataRowView)this.складфурнитурыBindingSource.Current).Row["ID_Модели_фурнитуры"]);
                EditFurnitureInCardsForm.Furniture = Convert.ToString(((DataRowView)this.складфурнитурыBindingSource.Current).Row["Наименование"]);
                EditFurnitureInCardsForm.ModelFurniture = Convert.ToString(((DataRowView)this.складфурнитурыBindingSource.Current).Row["Модель_фурнитуры"]);
                EditFurnitureInCardsForm.UnitDetermination = Convert.ToString(((DataRowView)this.складфурнитурыBindingSource.Current).Row["Единица_измерения"]);
                EditFurnitureInCardsForm.CountFurniture = Convert.ToInt32(((DataRowView)this.складфурнитурыBindingSource.Current).Row["Количество"]);
                this.Close();
            }
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
