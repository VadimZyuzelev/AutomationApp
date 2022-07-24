using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class ProvidersForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        private readonly EditOrdersForm EditOrdersForm;
        private readonly EditClothOrdersForm EditForm;
        private readonly bool FlagSelectProvidersInOrder;
        private readonly bool FlagSelectProvidersInFurnitureOrder;

        public ProvidersForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public ProvidersForm(EditClothOrdersForm edtiForm, bool flagSelectProvidersInOrder)
        {
            InitializeComponent();
            this.EditForm = edtiForm;
            this.FlagSelectProvidersInOrder = flagSelectProvidersInOrder;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public ProvidersForm(EditOrdersForm editOrdersForm, bool flagSelectProvidersInFurnitureOrder)
        {
            InitializeComponent();
            this.EditOrdersForm = editOrdersForm;
            this.FlagSelectProvidersInFurnitureOrder = flagSelectProvidersInFurnitureOrder;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.automationAppDBDataSet.Поставщики);

            if (FlagSelectProvidersInOrder)
            {
                TopPanel.Visible = true;
            }

            if (FlagSelectProvidersInFurnitureOrder)
            {
                TopPanel.Visible = true;
            }
        }

        private void ProvidersDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FlagSelectProvidersInOrder)
            {                
                EditForm.ID_Provider = Convert.ToInt32(((DataRowView)this.поставщикиBindingSource.Current).Row["ID_Поставщика"]);
                EditForm.Provider = Convert.ToString(((DataRowView)this.поставщикиBindingSource.Current).Row["Наименование"]) + ' ' + Convert.ToString(((DataRowView)this.поставщикиBindingSource.Current).Row["Адрес"]);                
                this.Close();
            }
            
            if (FlagSelectProvidersInFurnitureOrder)
            {               
                EditOrdersForm.ID_Provider = Convert.ToInt32(((DataRowView)this.поставщикиBindingSource.Current).Row["ID_Поставщика"]);
                EditOrdersForm.Provider = Convert.ToString(((DataRowView)this.поставщикиBindingSource.Current).Row["Наименование"]) + ' ' + Convert.ToString(((DataRowView)this.поставщикиBindingSource.Current).Row["Адрес"]);                
                this.Close();
            }
        }

        private void AddProviderButton_Click(object sender, EventArgs e)
        {
            EditProvidersForm EditProvidersForm = new EditProvidersForm(this);
            EditProvidersForm.ShowDialog();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProvidersDataGridView.Rows.Count != 0)
            {
                string Query = "";

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Наименование like '%" + SearchTextBox.Text + "%' or ";
                }

                if (SearchTextBox.Text != string.Empty)
                {
                    Query += "Адрес like '%" + SearchTextBox.Text + "%'";
                }

                this.поставщикиBindingSource.Filter = Query;
            }
            else
            {
                this.поставщикиBindingSource.Filter = "";
            }

            if (SearchTextBox.Text == "")
            {
                this.поставщикиBindingSource.Filter = "";
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

        private void ProvidersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool FlagEdit = true;

                EditProvidersForm EditProvidersForm = new EditProvidersForm(this, FlagEdit);
                EditProvidersForm.ShowDialog();
            }

            if (e.ColumnIndex == 5)
            {
                this.поставщикиBindingSource.RemoveCurrent();
                this.поставщикиTableAdapter.Update(this.automationAppDBDataSet.Поставщики);
                this.поставщикиTableAdapter.Fill(this.automationAppDBDataSet.Поставщики);
            }
        }

        private void ProvidersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProvidersDataGridView.ClearSelection();
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

        private void HideButton_MouseDown(object sender, MouseEventArgs e)
        {
            HideButton.IconColor = Color.White;
        }

        private void HideButton_MouseUp(object sender, MouseEventArgs e)
        {
            HideButton.IconColor = Color.Gray;
        }

        private void MaximizedButton_MouseDown(object sender, MouseEventArgs e)
        {
            MaximizedButton.IconColor = Color.White;
        }

        private void MaximizedButton_MouseUp(object sender, MouseEventArgs e)
        {
            MaximizedButton.IconColor = Color.Gray;
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.White;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.IconColor = Color.Gray;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
