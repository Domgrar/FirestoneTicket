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
            foreach (DataGridViewCell item in this.row.Cells)       // Make it into a ticket object from here
            {
                
                MessageBox.Show("Ticket Form : " + item.FormattedValue.ToString());
                richTextBoxDesc.AppendText(item.FormattedValue.ToString());
            }

            //Fill forms
            
        }
    }
}
