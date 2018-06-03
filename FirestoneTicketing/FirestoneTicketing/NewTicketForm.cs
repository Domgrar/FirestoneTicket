using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirestoneTicketing
{
    public partial class NewTicketForm : Form
    {
        public SQLiteConnection ticket_dbConnection = new SQLiteConnection("Data Source=D:\\FireStoneTicketing\\TicketDB.db; Version=3;");

        public delegate void InsertRow(object sender, SQLiteConnection dbConnection);

        public InsertRow insertRow;

        public int ticketNumber;

        public NewTicketForm(int _ticketNumber)
        {
            InitializeComponent();
            ticketNumber = _ticketNumber;
        }

        private void NewTicketForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           // string todayDate = DateTime.Now.ToString("MMddyy");
            //int ticketNumber = (Convert.ToInt32(SelectLastRow(ticket_dbConnection).Split('_')[1]) + 1);
            int numberOfZeroes = 6 - ticketNumber.ToString().Length;
            //string beginning = "I" + todayDate;

            string ID = "I" + DateTime.Now.ToString("MMddyy") + "_" + String.Concat(Enumerable.Repeat("0", numberOfZeroes)) + ticketNumber.ToString();
            MessageBox.Show(ID);

            Ticket newTicket = new Ticket();
            newTicket.TicketID = ID;
            newTicket.TicketDescription = "Testing";
            newTicket.CurrentTech = "Current test";
            newTicket.OriginalTech = "Original test";
            newTicket.DueDate = "Test date";
            newTicket.IsProject = 0;
            
            if(insertRow != null)
            {
                insertRow(newTicket, ticket_dbConnection);
            }
            this.Hide();
        }

        
    }
}
