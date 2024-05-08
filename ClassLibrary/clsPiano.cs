using System;

namespace ClassLibrary
{
    public class clsPiano
    {
        public int PianoId { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public bool IsInStock { get; set; }
        public string SerialNumber { get; set; }
    }
}