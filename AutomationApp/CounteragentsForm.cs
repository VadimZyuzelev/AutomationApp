using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class CounteragentsForm : Form
    {
        private readonly EditTradeNoteForm EditTradeNoteForm;

        private readonly bool FlagSelectSender;
        private readonly bool FlagSelectCargoReceiver;

        public CounteragentsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public CounteragentsForm(EditTradeNoteForm editTradeNoteForm, bool flagSelectSender, bool flagSelectCargoReceiver)
        {
            InitializeComponent();
            this.EditTradeNoteForm = editTradeNoteForm;
            this.FlagSelectSender = flagSelectSender;
            this.FlagSelectCargoReceiver = flagSelectCargoReceiver;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ConteragentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Контрагенты". При необходимости она может быть перемещена или удалена.
            this.контрагентыTableAdapter.Fill(this.automationAppDBDataSet.Контрагенты);

            if(FlagSelectSender || FlagSelectCargoReceiver)
            {
                TopPanel.Visible = true;
            }
        }

        private void CounteragentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectSender)
            {
                EditTradeNoteForm.ID_Sender = Convert.ToInt32(((DataRowView)this.контрагентыBindingSource.Current).Row["ID_Контрагента"]);
                EditTradeNoteForm.SenderName = Convert.ToString(((DataRowView)this.контрагентыBindingSource.Current).Row["Наименование"]) + ' ' + Convert.ToString(((DataRowView)this.контрагентыBindingSource.Current).Row["Адрес"]);
                this.Close();
            }

            if (FlagSelectCargoReceiver)
            {
                EditTradeNoteForm.ID_CargoReceiver = Convert.ToInt32(((DataRowView)this.контрагентыBindingSource.Current).Row["ID_Контрагента"]);
                EditTradeNoteForm.CargoReceiverName = Convert.ToString(((DataRowView)this.контрагентыBindingSource.Current).Row["Наименование"]) + ' ' + Convert.ToString(((DataRowView)this.контрагентыBindingSource.Current).Row["Адрес"]);             
                this.Close();
            }
        }

        private void CounteragentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditCounteragentsForm EditCounteragentsForm = new EditCounteragentsForm(this, FlagEdit);
                EditCounteragentsForm.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                try
                {
                    this.контрагентыBindingSource.RemoveCurrent();
                    this.контрагентыTableAdapter.Update(this.automationAppDBDataSet.Контрагенты);
                    this.контрагентыTableAdapter.Fill(this.automationAppDBDataSet.Контрагенты);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
            if (CounteragentsDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "УНП like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Адрес like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%'";
                }

                this.контрагентыBindingSource.Filter = Query;
            }
            else
            {
                this.контрагентыBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.контрагентыBindingSource.Filter = "";
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

        private void AddIButton_Click(object sender, EventArgs e)
        {
            EditCounteragentsForm EditForm = new EditCounteragentsForm(this);
            EditForm.ShowDialog();
        }
    }
}
