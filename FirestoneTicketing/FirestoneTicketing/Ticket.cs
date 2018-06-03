﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirestoneTicketing
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public string TicketDescription { get; set; }
        public string CurrentTech { get; set; }
        public string OriginalTech { get; set; }
        public string DueDate { get; set; }
        public int IsProject { get; set; } // will be 0 or 1 for boolean representation

        public Ticket()
        {

        }
        public Ticket(string _ticketID, string _ticketDescription, string _currentTech, string _originalTech, string _dueDate, int _isProject)
        {
            this.TicketID = _ticketID;
            this.TicketDescription = _ticketDescription;
            this.CurrentTech = _currentTech;
            this.OriginalTech = _originalTech;
            this.DueDate = _dueDate;
            this.IsProject = _isProject;
        }
    }
}
