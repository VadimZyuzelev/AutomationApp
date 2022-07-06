using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AutomationApp
{
    public partial class RouteSheetsForm : Form
    {
        //private MenuCutPickerUser MenuCutPickerUser;
        private readonly EditReceivedItemsForm EditReceivedItemsForm;

        private readonly bool FlagSelectSheet;

        private ExtendedPanel pan;

        public RouteSheetsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public RouteSheetsForm(EditReceivedItemsForm editReceivedItemsForm, bool flagSelectSheet)
        {
            InitializeComponent();
            this.EditReceivedItemsForm = editReceivedItemsForm;
            this.FlagSelectSheet = flagSelectSheet;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        /*public RouteSheetsForm(MenuCutPickerUser MenuCutPickerUserTwo)
        {
            InitializeComponent();
            //this.MainForm = MainFormTwo;
          */


        /*public int ID_Model
        {
            get { return id_model = Convert.ToInt32(((DataRowView)маршрутные_листыBindingSource.Current).Row["ID_Модели_изделия"]); }
        }*/
        /*public RouteSheetsForm(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }*/

        public void SetPanel()
        {
            this.pan = new ExtendedPanel();
            pan.Size = new Size(this.Width, this.Height);
            this.Controls.Add(pan);
            pan.BringToFront();
            pan.Opacity = 30;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Маршрутные_листы". При необходимости она может быть перемещена или удалена.
            this.маршрутные_листыTableAdapter.Fill(this.automationAppDBDataSet.Маршрутные_листы);

            if (FlagSelectSheet)
            {
                RouteSheetsDataGridView.Columns[11].Visible = false;
                RouteSheetsDataGridView.Columns[12].Visible = false;
                RouteSheetsDataGridView.Columns[13].Visible = false;

                AddSheetButton.Visible = false;
                TopPanel.Visible = true;
            }
        }

        // Отключение выделения в таблице при открытии формы.
        private void маршрутные_листыDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            RouteSheetsDataGridView.ClearSelection();
        }

        private void маршрутные_листыDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectSheet)
            {
                EditReceivedItemsForm.ID_RouteSheet = Convert.ToInt32(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["ID_Маршрутного_листа"]);              
                EditReceivedItemsForm.NameItem = Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Наименование"]);
                EditReceivedItemsForm.ModelItem = Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Модель_изделия"]);
                this.Close();              
            }
        }

        private void RouteSheetsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                bool FlagEdit = true;
                EditRouteSheetsForm editForm = new EditRouteSheetsForm(this, FlagEdit);
                editForm.ShowDialog();
            }

            if (e.ColumnIndex == 12)
            {

            }

            if (e.ColumnIndex == 13)
            {
                ReportSheetsForm reportFormTwo = new ReportSheetsForm();

                ReportParameter[] parametrs = new ReportParameter[8];
                parametrs[0] = new ReportParameter("NumberSheet", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["ID_Маршрутного_листа"]));
                parametrs[1] = new ReportParameter("NumberTicketParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Номер_заказа"]));
                parametrs[2] = new ReportParameter("ItemParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Наименование"]));
                parametrs[3] = new ReportParameter("ModelParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Модель_изделия"]));
                parametrs[4] = new ReportParameter("GrowthParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Рост"]));
                parametrs[5] = new ReportParameter("SizeParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Размер"]));
                parametrs[6] = new ReportParameter("FullnessParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Полнота"]));
                parametrs[7] = new ReportParameter("ColorParameter", Convert.ToString(((DataRowView)this.маршрутныелистыBindingSource.Current).Row["Код_цвета"]));

                reportFormTwo.SheetsReportViewer.LocalReport.SetParameters(parametrs);
                reportFormTwo.SheetsReportViewer.RefreshReport();

                reportFormTwo.Show();
            }


            //var senderGrid = (DataGridView)sender;

            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("ЫАЫЫ");
            }*/
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RouteSheetsDataGridView.Rows.Count != 0)
            {
                string Query = "";
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(ID_Маршрутного_листа, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }
                
                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Номер_заказа, System.String) like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                { 
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or "; 
                }


                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Модель_изделия like '%" + SearchTextBox.Text + "%'";
                }

                this.маршрутныелистыBindingSource.Filter = Query;
            }
            if (SearchTextBox.Text == "")
            {
                this.маршрутныелистыBindingSource.Filter = "";
                //SearchTextBox.Text = "Введите ваш запрос";
                //SearchTextBox.ForeColor = Color.FromArgb(164, 167, 180);
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

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void AddSheetButton_Click(object sender, EventArgs e)
        {
            EditRouteSheetsForm EditSheetsForm = new EditRouteSheetsForm(this);
            EditSheetsForm.ShowDialog();
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
