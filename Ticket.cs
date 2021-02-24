using System;
using System.Collections.Generic;

namespace TicketingWithClasses
{
    public class Ticket
    {
        public string ticketNumber {get; set;}
        public string ticketSummary {get; set;}
        public string ticketStatus {get; set;}
        public string ticketPriority {get; set;}
        public string ticketSubmitter {get; set;}
        public string ticketAssignedTo {get; set;}
        public List<string> ticketWatchers {get; set;}

        public Ticket()
        {
            
        }
    }
}
