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
    public partial class EditTradeNoteForm : Form
    {
        private readonly TradeNoteForm TradeNoteForm;

        private int ID_TradeNote;

        private int id_CargoReceiver;
        private int id_Sender;

        private string cargoreceiverName;
        private string senderName;

        public int ID_CargoReceiver
        {
            set
            {
                id_CargoReceiver = value;
            }
            get
            {
                return id_CargoReceiver;
            }
        }

        public int ID_Sender
        {
            set
            {
                id_Sender = value;
            }
            get
            {
                return id_Sender;
            }
        }

        public string CargoReceiverName
        {
            set
            {
                cargoreceiverName = value;
            }
            get
            {
                return cargoreceiverName;
            }
        }

        public string SenderName
        {
            set
            {
                senderName = value;
            }
            get
            {
                return senderName;
            }
        }

        public EditTradeNoteForm()
        {
            InitializeComponent();
        }
        
        public EditTradeNoteForm(TradeNoteForm tradeNoteForm)
        {
            InitializeComponent();
            this.TradeNoteForm = tradeNoteForm;
        }

        private void EditTradeNoteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарный_раздел_товарной_накладной". При необходимости она может быть перемещена или удалена.
            this.товарный_раздел_товарной_накладнойTableAdapter.Fill(this.automationAppDBDataSet.Товарный_раздел_товарной_накладной);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automationAppDBDataSet.Товарные_накладные". При необходимости она может быть перемещена или удалена.
            this.товарные_накладныеTableAdapter.Fill(this.automationAppDBDataSet.Товарные_накладные);
        }

        private void SelectSenderButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectSender = true;
            bool FlagSelectCargoReceiver = false;

            CounteragentsForm counteragentsForm = new CounteragentsForm(this, FlagSelectSender, FlagSelectCargoReceiver);
            counteragentsForm.ShowDialog();

            SenderTextBox.TextName = SenderName;
        }

        private void SelectCargoReceiveButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectSender = false;
            bool FlagSelectCargoReceiver = true;

            CounteragentsForm counteragentsForm = new CounteragentsForm(this, FlagSelectSender, FlagSelectCargoReceiver);
            counteragentsForm.ShowDialog();

            CargoReceiveTextBox.TextName = CargoReceiverName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            DateTime date = DateCreateTimePicker.Value;

            TradeNoteForm.товарные_накладныеTableAdapter.Insert(date);
            TradeNoteForm.товарные_накладныеTableAdapter.Fill(TradeNoteForm.automationAppDBDataSet.Товарные_накладные);

            TradeNoteForm.товарныенакладныеBindingSource.MoveLast();
            ID_TradeNote = Convert.ToInt32(((DataRowView)TradeNoteForm.товарныенакладныеBindingSource.Current).Row["ID_Товарной_накладной"]);

            TradeNoteForm.контрагенты_товарной_накладнойTableAdapter.Insert(ID_TradeNote, ID_Sender, "Грузоотправитель");
            TradeNoteForm.контрагенты_товарной_накладнойTableAdapter.Fill(TradeNoteForm.automationAppDBDataSet.Контрагенты_товарной_накладной);

            TradeNoteForm.контрагенты_товарной_накладнойTableAdapter.Insert(ID_TradeNote, ID_CargoReceiver, "Грузополучатель");
            TradeNoteForm.контрагенты_товарной_накладнойTableAdapter.Fill(TradeNoteForm.automationAppDBDataSet.Контрагенты_товарной_накладной);

            int index = TradeNoteForm.TradeNoteDataGridView.CurrentRow.Index;

            TradeNoteForm.TradeNoteDataGridView.Rows[index].Cells[3].Value = "Грузполучатель";

        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            EditProductsInNoteForm editProductsNote = new EditProductsInNoteForm(TradeNoteForm, this);
            editProductsNote.ShowDialog();
        }
    }
}
