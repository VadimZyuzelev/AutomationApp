using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class SettingsUserControl : UserControl
    {
        private static SettingsUserControl _instance;

        public static SettingsUserControl Instance 
        { 
            get
            {
                if(_instance == null)
                {
                    _instance = new SettingsUserControl();
                }
                return _instance;
            }
        }

        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SetSettingsFromTextBox()
        { 
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["DataSource"].Value = DataSourceTextBox.Text;
            configuration.AppSettings.Settings["InitialCatalog"].Value = InitialCatalogTextbox.Text;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");  
        }
        
        public void SetTextColor()
        {         
            if(DataSourceTextBox.Text == "Имя/адрес сервера")
            {
                DataSourceTextBox.ForeColor = Color.FromArgb(172, 178, 192);         
            }
            else
            {
                DataSourceTextBox.ForeColor = Color.Black;
            }

            if(InitialCatalogTextbox.Text == "Имя базы данных")
            {
                InitialCatalogTextbox.ForeColor = Color.FromArgb(172, 178, 192);             
            }
            else
            {
                InitialCatalogTextbox.ForeColor = Color.Black;
            }
        }

        public void SetSettingsFromConfiguration()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            DataSourceTextBox.Text = configuration.AppSettings.Settings["DataSource"].Value;
            InitialCatalogTextbox.Text = configuration.AppSettings.Settings["InitialCatalog"].Value;
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            SetSettingsFromConfiguration();
            SetTextColor();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {
                SetSettingsFromTextBox();
                SetTextColor();
                SettingsUserControl.Instance.SendToBack();
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SetSettingsFromConfiguration();
            SetTextColor();

            DataSourceErrorLabel.Visible = false;
            InitialCatalogErrorLabel.Visible = false;

            SettingsUserControl.Instance.SendToBack();
        }

        private void DataSourceTextBox_Click(object sender, EventArgs e)
        {
            if (DataSourceTextBox.Text == "Имя/адрес сервера")
            {
                DataSourceTextBox.Text = "";
                DataSourceErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void InitialCatalogTextbox_Click(object sender, EventArgs e)
        {
            if (InitialCatalogTextbox.Text == "Имя базы данных")
            {
                InitialCatalogTextbox.Text = "";
                InitialCatalogErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void DataSourceTextBox_Leave(object sender, EventArgs e)
        {
            if (DataSourceTextBox.Text == "")
            {
                DataSourceTextBox.Text = "Имя/адрес сервера";
                SetTextColor();
            }
        }

        private void InitialCatalogTextbox_Leave(object sender, EventArgs e)
        {
            if (InitialCatalogTextbox.Text == "")
            {
                InitialCatalogTextbox.Text = "Имя базы данных";
                SetTextColor();
            }           
        }   

        private void DataSourceTextBox_Enter(object sender, EventArgs e)
        {
            if (DataSourceTextBox.Text == "Имя/адрес сервера")
            {
                DataSourceTextBox.Text = "";
                DataSourceErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void InitialCatalogTextbox_Enter(object sender, EventArgs e)
        {
            if (InitialCatalogTextbox.Text == "Имя базы данных")
            {
                InitialCatalogTextbox.Text = "";
                InitialCatalogErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void DataSourcePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.DataSourcePanel.ClientRectangle, Color.FromArgb(227, 227, 227), ButtonBorderStyle.Solid);
        }

        private void InitialCatalogPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.InitialCatalogPanel.ClientRectangle, Color.FromArgb(227, 227, 227), ButtonBorderStyle.Solid);
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (DataSourceTextBox.Text == "Имя/адрес сервера" || DataSourceTextBox.Text == "")
            {
                DataSourceErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (InitialCatalogTextbox.Text == "Имя базы данных" || InitialCatalogTextbox.Text == "")
            {
                InitialCatalogErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (FlagEmpty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
