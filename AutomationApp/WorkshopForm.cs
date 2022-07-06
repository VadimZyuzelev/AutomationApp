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
    public partial class WorkshopForm : Form
    {

        private readonly EditCalculationCardsForm EditCalculationCardsForm;
        private readonly EditLimitCardsForm EditLimitCardsForm;

        private readonly bool FlagSelectWorkshopInCard;
        private readonly bool FlagSelectWorkshopInLimitCard;

        public WorkshopForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public WorkshopForm(EditCalculationCardsForm editCalculationCardsForm, bool flagSelectWorkshopInCard)
        {
            InitializeComponent();
            this.EditCalculationCardsForm = editCalculationCardsForm;
            this.FlagSelectWorkshopInCard = flagSelectWorkshopInCard;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public WorkshopForm(EditLimitCardsForm editLimitCardsForm, bool flagSelectWorkshopInLimitCard)
        {
            InitializeComponent();
            this.EditLimitCardsForm = editLimitCardsForm;
            this.FlagSelectWorkshopInLimitCard = flagSelectWorkshopInLimitCard;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void WorkshopForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.automationAppDBDataSet.Бригады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Цеха". При необходимости она может быть перемещена или удалена.
            this.цехаTableAdapter.Fill(this.automationAppDBDataSet.Цеха);

            if (FlagSelectWorkshopInCard || FlagSelectWorkshopInLimitCard)
            {
                TopPanel.Visible = true;
            }

            SetGroupingDataGrid();
        }
       
        private void AddWorkshopButton_Click(object sender, EventArgs e)
        {
            EditWorkshopForm EditWorkshopForm = new EditWorkshopForm(this);
            EditWorkshopForm.ShowDialog();
        }

        private void WorksopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditWorkshopForm EditWorkshopForm = new EditWorkshopForm(this, FlagEdit);
                EditWorkshopForm.ShowDialog();
            }

            if (e.ColumnIndex == 5)
            {
                this.бригадыBindingSource.RemoveCurrent();
                this.бригадыTableAdapter.Update(this.automationAppDBDataSet.Бригады);
                this.бригадыTableAdapter.Fill(this.automationAppDBDataSet.Бригады);
            }
        }

        private void WorksopDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectWorkshopInCard)
            {
                EditCalculationCardsForm.ID_Brigade = Convert.ToInt32(((DataRowView)this.бригадыBindingSource.Current).Row["ID_Бригады"]);
                EditCalculationCardsForm.Brigade = Convert.ToString(((DataRowView)this.бригадыBindingSource.Current).Row["Наименование"]);
                EditCalculationCardsForm.Workshop = Convert.ToString(((DataRowView)this.бригадыBindingSource.Current).Row["Цех"]);
                this.Close();
            }
            
            if (FlagSelectWorkshopInLimitCard)
            {
                EditLimitCardsForm.ID_Brigade = Convert.ToInt32(((DataRowView)this.бригадыBindingSource.Current).Row["ID_Бригады"]);
                EditLimitCardsForm.Brigade = Convert.ToString(((DataRowView)this.бригадыBindingSource.Current).Row["Наименование"]);
                EditLimitCardsForm.Workshop = Convert.ToString(((DataRowView)this.бригадыBindingSource.Current).Row["Цех"]);
                this.Close();
            }
        }

        public void SetGroupingDataGrid()
        {
            DataGridViewGrouper.DataGridView = WorksopDataGridView;
            DataGridViewGrouper.SetGroupOn(WorksopDataGridView.Columns["цехDataGridViewTextBoxColumn"]);
            DataGridViewGrouper.DisplayGroup += GrouperDisplayGroup;
        }

        private void GrouperDisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Header = " ";
            e.DisplayValue = e.DisplayValue;
            e.Summary = " ";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WorksopDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Цех like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%'";
                }

                this.бригадыBindingSource.Filter = Query;
            }
            else
            {
                this.бригадыBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.бригадыBindingSource.Filter = "";
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

        private void WorksopDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            WorksopDataGridView.ClearSelection();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void HideButton_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizedButton_Click_1(object sender, EventArgs e)
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

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
