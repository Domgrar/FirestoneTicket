using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FirestoneTicketing
{
    public partial class Form1 : Form
    {
        

        public SQLiteConnection ticket_dbConnection = new SQLiteConnection("Data Source=D:\\FireStoneTicketing\\TicketDB.db; Version=3;");

        public Form1()
        {
            InitializeComponent();
            string test = "hey";
        }

        private void listBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGrid(dataGridView1);


            SQLiteConnection ticket_dbConnection;
            List<string> ticketList = new List<string>();
            

            ticket_dbConnection = new SQLiteConnection("Data Source=D:\\FireStoneTicketing\\TicketDB.db; Version=3;");

            SelectLastRow(ticket_dbConnection);

            string sqlQuery = "SELECT * FROM TicketTable WHERE CurrentTech = 'Farmer, Jeremy'";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, ticket_dbConnection);

            try
            {
                ticket_dbConnection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] newRow = new string[] {reader["TicketID"].ToString(),
                        reader["TicketDesc"].ToString(), reader["CurrentTech"].ToString(),
                        reader["OriginalTech"].ToString(), reader["DueDate"].ToString(),
                        reader["IsProject"].ToString()};
                    dataGridView1.Rows.Add(newRow);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ticket_dbConnection.Close();
        }
        public static void InitializeDataGrid(DataGridView view)
        {
            view.ColumnCount = 7;
            view.Columns[0].Name = "TicketID";
            view.Columns[1].Name = "Description";
            view.Columns[2].Name = "Current Technician";
            view.Columns[3].Name = "Original Technician";
            view.Columns[4].Name = "Due Date";
            view.Columns[5].Name = "Is Project?";
            view.Columns[6].Name = "Comments";

            view.BorderStyle = BorderStyle.None;
            view.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            view.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            view.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            view.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            view.BackgroundColor = Color.White;

            view.EnableHeadersVisualStyles = false;
            view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            view.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
            view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public static string SelectLastRow(SQLiteConnection dbConnection)
        {
            string lastTicketID  = "";
            string sqlQuery = "SELECT * FROM TicketTable " + 
                               "ORDER BY TicketID DESC " + 
                               "LIMIT 1";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, dbConnection);

            try
            {
                dbConnection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lastTicketID = reader["TicketID"].ToString();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //MessageBox.Show( "test " + lastTicketID);



            dbConnection.Close();
            return lastTicketID;
            //Write a new row to the DB
        }

        public static void InsertRow(object sender, SQLiteConnection dbConnection)
        {
            Ticket newTicket = (Ticket)sender;
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO TicketTable (TicketID, TicketDesc, CurrentTech, OriginalTech, DueDate, IsProject) VALUES (@ID, @desc, @current, @original, @due, @project) ");
            insertSQL.Connection = dbConnection;

            insertSQL.Parameters.Add(new SQLiteParameter("@ID", newTicket.TicketID));
            insertSQL.Parameters.Add(new SQLiteParameter("@desc", newTicket.TicketDescription));
            insertSQL.Parameters.Add(new SQLiteParameter("@current", newTicket.CurrentTech));
            insertSQL.Parameters.Add(new SQLiteParameter("@original", newTicket.OriginalTech));
            insertSQL.Parameters.Add(new SQLiteParameter("@due", newTicket.DueDate));
            insertSQL.Parameters.Add(new SQLiteParameter("@project", newTicket.IsProject));

           

            try
            {
                dbConnection.Open();
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dbConnection.Close();
            return;
        }

        private void buttonNewTicket_Click(object sender, EventArgs e)
        {
            
            int newTicketID = (Convert.ToInt32(SelectLastRow(ticket_dbConnection).Split('_')[1]) + 1);

            NewTicketForm newForm = new NewTicketForm(newTicketID);

            newForm.insertRow = new NewTicketForm.InsertRow(InsertRow);

            newForm.Show();
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if(dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one row at a time");
                return;
            }

            //List<DataGridViewRow> SelectedRows = dataGridView1.SelectedRows;
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedRow = row;
                //foreach(DataGridViewCell cell in row.Cells)
                //{
                //    MessageBox.Show(cell.FormattedValue.ToString());
                //}
            }

            //Pass rowlist to ticket edit form *Delegate to update row contents?*
              TicketViewerForm viewForm = new TicketViewerForm(selectedRow);
              viewForm.Show();
        }
    }
}
