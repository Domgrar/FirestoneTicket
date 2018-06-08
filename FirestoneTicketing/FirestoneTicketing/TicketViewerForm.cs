using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirestoneTicketing
{
    public partial class TicketViewerForm : Form
    {
        public DataGridViewRow row;

        public TicketViewerForm(DataGridViewRow _row)
        {
            row = _row;
            InitializeComponent();
        }

        private void TicketViewerForm_Load(object sender, EventArgs e)
        {
            DataRow row = null;
            Ticket thisTicket = null;
            string[] ticketInfo = new string[6];
            int i = 0;
            foreach (DataGridViewCell item in this.row.Cells)       // Make it into a ticket object from here 7 cells?
            {
                if(i == 0)
                {
                    labelTicketID.Text = item.FormattedValue.ToString();
                }else if(i == 1)
                {
                    richTextBoxDesc.Text = item.FormattedValue.ToString();
                }
                else if (i == 2)
                {
                    textBoxTechName.Text = item.FormattedValue.ToString();
                }
                else if (i == 3)
                {
                    textBoxOriginalTech.Text = item.FormattedValue.ToString();
                }
                else if (i == 4)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(item.FormattedValue.ToString());
                }
                else if (i == 5)
                {
                    labelIsProject.Text = item.FormattedValue.ToString();
                }
                else
                {
                    richTextBoxComment.Text = item.FormattedValue.ToString();
                }
                

                i++;
                
                    

                    //textBoxTechName.Text = thisTicket.CurrentTech;
                    //textBoxOriginalTech.Text = thisTicket.OriginalTech;
                    //labelTicketID.Text = thisTicket.TicketID;
                    //dateTimePicker1.Value = Convert.ToDateTime(thisTicket.DueDate);
                    //labelIsProject.Text = thisTicket.IsProject.ToString();
                    //richTextBoxComment.Text = thisTicket.TicketDescription;
                
            }

            for(int z =0; z < ticketInfo.Length; z++)
            {
                MessageBox.Show("Outside");
            }
            //Ticket thisTicket = new Ticket(ticketInfo);

            //textBoxTechName.Text = thisTicket.CurrentTech;
            //textBoxOriginalTech.Text = thisTicket.OriginalTech;
            //labelTicketID.Text = thisTicket.TicketID;
            //dateTimePicker1.Value = Convert.ToDateTime(thisTicket.DueDate);
            //labelIsProject.Text = thisTicket.IsProject.ToString();
            //richTextBoxComment.Text = thisTicket.TicketDescription;

            return;
            //Fill forms

        }
    }
}
