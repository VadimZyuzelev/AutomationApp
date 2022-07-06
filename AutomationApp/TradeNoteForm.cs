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
    public partial class TradeNoteForm : Form
    {
        public TradeNoteForm()
        {
            InitializeComponent();
        }

        private void TradeNoteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Контрагенты_товарной_накладной". При необходимости она может быть перемещена или удалена.
            this.контрагенты_товарной_накладнойTableAdapter.Fill(this.automationAppDBDataSet.Контрагенты_товарной_накладной);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарный_раздел_товарной_накладной". При необходимости она может быть перемещена или удалена.
            this.товарный_раздел_товарной_накладнойTableAdapter.Fill(this.automationAppDBDataSet.Товарный_раздел_товарной_накладной);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарные_накладные". При необходимости она может быть перемещена или удалена.
            this.товарные_накладныеTableAdapter.Fill(this.automationAppDBDataSet.Товарные_накладные);

        }

        private void AddTradeNoteButton_Click(object sender, EventArgs e)
        {
            EditTradeNoteForm EditTradeNoteForm = new EditTradeNoteForm(this);
            EditTradeNoteForm.ShowDialog();
        }
    }
}
