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
    public partial class TradeTransportNoteForm : Form
    {
        public TradeTransportNoteForm()
        {
            InitializeComponent();
        }

        private void TradeTransportNoteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарный_раздел_товарно_транспортной_накладной". При необходимости она может быть перемещена или удалена.
            this.товарный_раздел_товарно_транспортной_накладнойTableAdapter.Fill(this.automationAppDBDataSet.Товарный_раздел_товарно_транспортной_накладной);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарно_транспортные_накладные". При необходимости она может быть перемещена или удалена.
            this.товарно_транспортные_накладныеTableAdapter.Fill(this.automationAppDBDataSet.Товарно_транспортные_накладные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарный_раздел_товарно_транспортной_накладной". При необходимости она может быть перемещена или удалена.
            this.товарный_раздел_товарно_транспортной_накладнойTableAdapter.Fill(this.automationAppDBDataSet.Товарный_раздел_товарно_транспортной_накладной);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарно_транспортные_накладные". При необходимости она может быть перемещена или удалена.
            this.товарно_транспортные_накладныеTableAdapter.Fill(this.automationAppDBDataSet.Товарно_транспортные_накладные);

        }
    }
}
