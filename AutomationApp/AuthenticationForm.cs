using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationApp
{
    public partial class AuthenticationForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;
       
        public string Login { get; set; }
        
        public AuthenticationForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void SetTextColor()
        {
            if (LoginTextBox.Text == "Логин")
            {
                LoginTextBox.ForeColor = Color.FromArgb(172, 178, 192);
            }
            else
            {
                LoginTextBox.ForeColor = Color.Black;
            }

            if (PasswordTextbox.Text == "Пароль")
            {
                PasswordTextbox.ForeColor = Color.FromArgb(172, 178, 192);
            }
            else
            {
                PasswordTextbox.ForeColor = Color.Black;
            }
        }

        private void SetFormColor()
        {
            LoginTextBox.ForeColor = Color.FromArgb(172, 178, 192);
            PasswordTextbox.ForeColor = Color.FromArgb(172, 178, 192);
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            SetFormColor();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyData())
            {                
                ConnectDataBase connect = new ConnectDataBase();

                try
                {
                    connect.CreateStringConnection(LoginTextBox.Text, PasswordTextbox.Text);
                    connect.OpenConnection();

                    if (connect.CheckOpenConnection())
                    {
                        
                        MainForm mf = new MainForm(this);
                        Login = LoginTextBox.Text;                             
                        mf.ShowDialog();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.CloseConnection();
                }
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(SettingsUserControl.Instance);
            SettingsUserControl.Instance.Dock = DockStyle.Fill;
            SettingsUserControl.Instance.BringToFront();
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Логин")
            {
                LoginTextBox.Text = "";
                LoginErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void PasswordTextbox_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Пароль")
            {                
                PasswordTextbox.Text = "";
                PasswordTextbox.UseSystemPasswordChar = true;
                PasswordTextbox.Refresh();
                PasswordErrorLabel.Visible = false;                                   
                SetTextColor();
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Логин";                
                SetTextColor();
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = "Пароль";
                SetTextColor();
            }
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Пароль")
            {
                PasswordTextbox.Text = "";
                PasswordErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Логин")
            {
                LoginTextBox.Text = "";
                LoginErrorLabel.Visible = false;
                SetTextColor();
            }
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(Handle, 0x112, 0xf012, 0);
        }

        private void TypeUserPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.TypeUserPanel.ClientRectangle, Color.FromArgb(227, 227, 227), ButtonBorderStyle.Solid);
        }

        private void PasswordPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.PasswordPanel.ClientRectangle, Color.FromArgb(227, 227, 227), ButtonBorderStyle.Solid);
        }

        private bool CheckEmptyData()
        {
            bool FlagEmpty = false;

            if (LoginTextBox.Text == "Логин" || LoginTextBox.Text == "")
            {                
                LoginErrorLabel.Visible = true;
                FlagEmpty = true;
            }

            if (PasswordTextbox.Text == "Пароль" || PasswordTextbox.Text == "")
            {                
                PasswordErrorLabel.Visible = true;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь к системному администратору!");
        }
    }
    
}