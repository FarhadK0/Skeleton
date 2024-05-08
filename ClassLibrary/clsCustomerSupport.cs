using System;

namespace ClassLibrary
{
    public class clsCustomerSupport
    {
        public bool Active { get; set; }
        public int TicketID { get; set; }
        public string TicketType { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string TicketStatus { get; set; }
        public bool RaiseTicketStatus { get; set; }
    }
}