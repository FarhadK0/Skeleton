using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool hasPurchases;

        public int CustomerID { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
    }
}