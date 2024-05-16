using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPianoCollection
    {
        //private data memebr for the list
        List<clsPiano> mPianoList = new List<clsPiano>();

        public clsPianoCollection()
        {
            //create an instance of a piano
            clsPiano TestItem = new clsPiano();
            //set its properties
            TestItem.PianoId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 123.99;
            TestItem.Manufacturer = "Yamaha";
            TestItem.ModelName = "Electric Piano";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "jsdoasd0a9s";
            //add the test item to the test list

        }

        public List<clsPiano> PianoList 
        {
            get
            {
                //return the private data
                return mPianoList;
            }
            
            set
            { 
                //set the private data
                mPianoList = value; 
            }
        
        }
        public int Count 
        {
            get
            {
                //return the length of the list
                return mPianoList.Count;
            }
            set
            {
                // TODO
            }
        }
        public clsPiano ThisPiano { get; set; }
    }
}