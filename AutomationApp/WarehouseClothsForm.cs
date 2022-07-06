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
using Microsoft.Reporting.WinForms;

namespace AutomationApp
{
    public partial class WarehouseClothsForm : Form
    {
        private readonly EditClothsInCardsForm EditClothsInCardsForm;
        private readonly bool FlagSelectClothsInOrder;

        public WarehouseClothsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public WarehouseClothsForm(EditClothsInCardsForm editClothsInCardsForm, bool flagSelectClothsInOrder)
        {
            InitializeComponent();
            this.EditClothsInCardsForm = editClothsInCardsForm;
            this.FlagSelectClothsInOrder = flagSelectClothsInOrder;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void WarehouseClothsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Склад_ткани". При необходимости она может быть перемещена или удалена.
            this.склад_тканиTableAdapter.Fill(this.automationAppDBDataSet.Склад_ткани);

            SetGroupingDataGrid();

            if (FlagSelectClothsInOrder)
            {
                CreateReprotButton.Visible = false;
                TopPanel.Visible = true;
            }
        }

        private void SetGroupingDataGrid()
        {
            DataGridViewGrouper.DataGridView = WarehouseClothsDataGridView;
            DataGridViewGrouper.SetGroupOn(WarehouseClothsDataGridView.Columns["наименованиеDataGridViewTextBoxColumn"]);
            DataGridViewGrouper.DisplayGroup += Grouper_DisplayGroup;
        }

        void Grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void WarehouseClothsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectClothsInOrder)
            {
                EditClothsInCardsForm.ID_ClothInWarehouse = Convert.ToInt32(((DataRowView)this.складтканиBindingSource.Current).Row["ID_Ткани_на_складе"]);
                EditClothsInCardsForm.ID_Cloth = Convert.ToInt32(((DataRowView)this.складтканиBindingSource.Current).Row["ID_Ткани"]);
                EditClothsInCardsForm.ID_ModelCloth = Convert.ToInt32(((DataRowView)this.складтканиBindingSource.Current).Row["ID_Модели_ткани"]);
                EditClothsInCardsForm.NameCloth = Convert.ToString(((DataRowView)this.складтканиBindingSource.Current).Row["Наименование"]);
                EditClothsInCardsForm.ModelCloth = Convert.ToString(((DataRowView)this.складтканиBindingSource.Current).Row["Модель_ткани"]);
                EditClothsInCardsForm.UnitDetermination = Convert.ToString(((DataRowView)this.складтканиBindingSource.Current).Row["Единица_измерения"]);
                EditClothsInCardsForm.CountCloths = Convert.ToInt32(((DataRowView)this.складтканиBindingSource.Current).Row["Количество"]);
                this.Close();
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
            if (WarehouseClothsDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_ткани like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Единица_измерения like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Количество, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Цена, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.складтканиBindingSource.Filter = Query;
            }
            else
            {
                this.складтканиBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.складтканиBindingSource.Filter = "";
            }         
        }

        private void WarehouseClothsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            WarehouseClothsDataGridView.ClearSelection();
        }

        private void CreateReprotButton_Click(object sender, EventArgs e)
        {
            ReportWarhouseClothForm warehouseClothForm = new ReportWarhouseClothForm();
            //ReportSheetsForm reportFormTwo = new ReportSheetsForm();

            /*ReportParameter[] parametrs = new ReportParameter[8];
            parametrs[0] = new ReportParameter("NumberSheet", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["ID_Маршрутного_листа"]));
            parametrs[1] = new ReportParameter("NumberTicketParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Номер_заказа"]));
            parametrs[2] = new ReportParameter("ItemParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Наименование"]));
            parametrs[3] = new ReportParameter("ModelParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Модель_изделия"]));
            parametrs[4] = new ReportParameter("GrowthParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Рост"]));
            parametrs[5] = new ReportParameter("SizeParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Размер"]));
            parametrs[6] = new ReportParameter("FullnessParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Полнота"]));
            parametrs[7] = new ReportParameter("ColorParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Код_цвета"]));

            reportFormTwo.SheetsReportViewer.LocalReport.SetParameters(parametrs);
            reportFormTwo.SheetsReportViewer.RefreshReport();*/

            warehouseClothForm.Show();
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
