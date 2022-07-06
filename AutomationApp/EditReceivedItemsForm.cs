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
    public partial class EditReceivedItemsForm : Form
    {
        private ReceivedItemsForm ReceivedItemsForm;

        private int id_routeSheet;
        private int count;
        private int sort;
        private string nameItem;
        private string modelItem;

        public int ID_RouteSheet
        {
            get
            {
                return id_routeSheet;
            }
            set
            {
                id_routeSheet = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public int Sort
        {
            get
            {
                return sort;
            }

            set
            {
                sort = value;
            }
        }
        
        public string NameItem
        {
            get
            {
                return nameItem;
            }

            set
            {
                nameItem = value;
            }
        }

        public string ModelItem
        {
            get
            {
                return modelItem;
            }

            set
            {
                modelItem = value;
            }
        }

        public EditReceivedItemsForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        
        public EditReceivedItemsForm(ReceivedItemsForm receivedItemsForm)
        {
            InitializeComponent();
            this.ReceivedItemsForm = receivedItemsForm;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void EditReceivedItemsForm_Load(object sender, EventArgs e)
        {
            
            //CountTextBox.Text = Convert.ToString(Count);
            //SortItemTextBox.Text = Convert.ToString(Sort);

        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            //if (!CheckEmptyData())
            //{
                //if (!CheckRepeatData())
                //{
                    Count = Convert.ToInt32(CountTextBox.TextName);
                    Sort = Convert.ToInt32(SortItemTextBox.TextName);

                    ReceivedItemsForm.изделия_принятые_на_складTableAdapter.Insert(ID_RouteSheet, Count, Sort);
                    ReceivedItemsForm.изделия_принятые_на_складTableAdapter.Fill(ReceivedItemsForm.automationAppDBDataSet.Изделия_принятые_на_склад);
                //}
            //}
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool FlagSelectSheet = true;

            RouteSheetsForm RouteSheetsForm = new RouteSheetsForm(this, FlagSelectSheet);
            RouteSheetsForm.ShowDialog();

            NumberTextBox.TextName = Convert.ToString(ID_RouteSheet);
            ItemTextBox.TextName = Convert.ToString(NameItem);
            ModelTextBox.TextName = Convert.ToString(ModelItem);
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragSettings formDragSettings = new FormDragSettings(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private bool CheckEmptyData()
        { 

        }

        private bool CheckRepeatData()
        {

        }*/

    }
}
