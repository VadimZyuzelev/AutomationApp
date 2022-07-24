using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AutomationApp
{
    public partial class ReceivedItemsForm : Form
    {
        public ReceivedItemsForm()
        {
            InitializeComponent();
        }

        private void ReceivedItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Маршрутные_листы". При необходимости она может быть перемещена или удалена.
            this.маршрутные_листыTableAdapter.Fill(this.automationAppDBDataSet.Маршрутные_листы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Изделия_принятые_на_склад". При необходимости она может быть перемещена или удалена.
            this.изделия_принятые_на_складTableAdapter.Fill(this.automationAppDBDataSet.Изделия_принятые_на_склад);
        }

        private void AddRecivedButton_Click(object sender, EventArgs e)
        {
            EditReceivedItemsForm EditReceivedItemsForm = new EditReceivedItemsForm(this);
            EditReceivedItemsForm.ShowDialog();
        }

        private void RecivedItemsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            RecivedItemsDataGridView.ClearSelection();
        }

        private void RecivedItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                string NumberSheet = null;
                string NumberTicket = null;
                string Item = null;
                string ModelItem = null;
                string GrowthItem = null;
                string SizeItem = null;
                string FullnessItem = null;
                string ColorItem = null;
                string CountItem;
                string SortItem;

                int CountRows = this.automationAppDBDataSet.Маршрутные_листы.Count;
                int SelectedRecievedItem = Convert.ToInt32(((DataRowView)this.изделияпринятыенаскладBindingSource.Current).Row["ID_Маршрутного_листа"]);

                for (int i = 0; i < CountRows; i++)
                {
                    if (this.automationAppDBDataSet.Маршрутные_листы[i].ID_Маршрутного_листа == SelectedRecievedItem)
                    {
                        NumberSheet = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].ID_Маршрутного_листа);
                        NumberTicket = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Номер_заказа);
                        Item = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Наименование);
                        ModelItem = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Модель_изделия);
                        GrowthItem = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Рост);
                        SizeItem = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Размер);
                        FullnessItem = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Полнота);
                        ColorItem = Convert.ToString(this.automationAppDBDataSet.Маршрутные_листы[i].Код_цвета);
                    }
                }

                CountItem = Convert.ToString(((DataRowView)this.изделияпринятыенаскладBindingSource.Current).Row["Количество"]);
                SortItem = Convert.ToString(((DataRowView)this.изделияпринятыенаскладBindingSource.Current).Row["Сорт"]);

                ReportReceivedItemForm reportForm = new ReportReceivedItemForm();

                ReportParameter[] parametrs = new ReportParameter[10];
                parametrs[0] = new ReportParameter("NumberSheet", NumberSheet);
                parametrs[1] = new ReportParameter("NumberTicketParameter", NumberTicket);
                parametrs[2] = new ReportParameter("ItemParameter", Item);
                parametrs[3] = new ReportParameter("ModelParameter", ModelItem);
                parametrs[4] = new ReportParameter("GrowthParameter", GrowthItem);
                parametrs[5] = new ReportParameter("SizeParameter", SizeItem);
                parametrs[6] = new ReportParameter("FullnessParameter", FullnessItem);
                parametrs[7] = new ReportParameter("ColorParameter", ColorItem);
                parametrs[8] = new ReportParameter("SortParameter", SortItem);
                parametrs[9] = new ReportParameter("CountParameter", CountItem);

                reportForm.reportViewer.LocalReport.SetParameters(parametrs);
                reportForm.reportViewer.RefreshReport();

                reportForm.ShowDialog();
            }
        }
    }
}
