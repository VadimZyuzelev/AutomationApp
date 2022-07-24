using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.automationAppDBDataSet.Водители);
        }

        private void DriversDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditDriversForm EditDriversForm = new EditDriversForm(this, FlagEdit);
                EditDriversForm.ShowDialog();
            }

            if (e.ColumnIndex == 5)
            {
                try
                {
                    this.водителиBindingSource.RemoveCurrent();
                    this.водителиTableAdapter.Update(this.automationAppDBDataSet.Водители);
                    this.водителиTableAdapter.Fill(this.automationAppDBDataSet.Водители);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void AddIButton_Click(object sender, EventArgs e)
        {
            EditDriversForm EditDriverForm = new EditDriversForm(this);
            EditDriverForm.ShowDialog();
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DriversDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "ФИО like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Номер_водительского_удостоверения like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "CONVERT(Дата_выдачи_удостоверения, System.String) like '%" + SearchTextBox.Text + "%'";
                }

                this.водителиBindingSource.Filter = Query;
            }
            else
            {
                this.водителиBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.водителиBindingSource.Filter = "";
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
    }
}
