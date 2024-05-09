using System;

namespace ClassLibrary
{
    public class clsPurchases
    {
        public int PurchaseId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryOptions { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    }
}