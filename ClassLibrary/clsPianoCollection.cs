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
            //variable for the index
            Int32 index = 0;
            //variable to store the record count
            Int32 recordCount = 0;

            //instance of object for db connection
            clsDataConnection db = new clsDataConnection();
            //execute stored procedure for retrieving all records
            db.Execute("sproc_tblPiano_SelectAll");
            //retrieve the number of records
            recordCount = db.Count;

            //while there are records to be processed
            while (index < recordCount) 
            { 
                //instance of a piano
                clsPiano aPiano = new clsPiano();
                //read & fill in the fields
                aPiano.PianoId = Convert.ToInt32(db.DataTable.Rows[index]["PianoId"]);
                aPiano.DateAdded = Convert.ToDateTime(db.DataTable.Rows[index]["DateAdded"]);
                aPiano.Price = Convert.ToDouble(db.DataTable.Rows[index]["Price"]);
                aPiano.Manufacturer = Convert.ToString(db.DataTable.Rows[index]["Manufacturer"]);
                aPiano.ModelName = Convert.ToString(db.DataTable.Rows[index]["ModelName"]);
                aPiano.IsInStock = Convert.ToBoolean(db.DataTable.Rows[index]["IsInStock"]);
                aPiano.SerialNumber = Convert.ToString(db.DataTable.Rows[index]["SerialNumber"]);
                //add the record to the private data member
                mPianoList.Add(aPiano);
                //increment to next index
                index++;
            }

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