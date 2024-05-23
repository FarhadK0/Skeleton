using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPianoCollection
    {
        //private data memebr for the list
        List<clsPiano> mPianoList = new List<clsPiano>();
        //private data member for thisPiano
        clsPiano mThisPiano = new clsPiano();

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
        public clsPiano ThisPiano 
        {
            get
            {
                //return the private data
                return mThisPiano;
            }
            set
            {
                //set the private data
                mThisPiano = value;
            }
        }

        public int Add()
        {
            //add a record to the DB basd on the values of mThisPiano
            //connect to DB
            clsDataConnection db = new clsDataConnection();

            //set params for the sproc
            db.AddParameter("@DateAdded", mThisPiano.DateAdded);
            db.AddParameter("@Price", mThisPiano.Price);
            db.AddParameter("@Manufacturer", mThisPiano.Manufacturer);
            db.AddParameter("@ModelName", mThisPiano.ModelName);
            db.AddParameter("@IsInStock", mThisPiano.IsInStock);
            db.AddParameter("@SerialNumber", mThisPiano.SerialNumber);

            //return the PK of the new record
            return db.Execute("sproc_tblPiano_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed by thisPiano
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //add PianoId Param for sproc
            db.AddParameter("@PianoId", mThisPiano.PianoId);
            //exec sproc
            db.Execute("sproc_tblPiano_Delete");
        }

        public void Update()
        {
            //create a new db connection
            clsDataConnection db = new clsDataConnection();
            //set the parameters for the sproc
            db.AddParameter("@PianoId", mThisPiano.PianoId);
            db.AddParameter("@DateAdded", mThisPiano.DateAdded);
            db.AddParameter("@Price", mThisPiano.Price);
            db.AddParameter("@Manufacturer", mThisPiano.Manufacturer);
            db.AddParameter("@ModelName", mThisPiano.ModelName);
            db.AddParameter("@IsInStock", mThisPiano.IsInStock);
            db.AddParameter("@SerialNumber", mThisPiano.SerialNumber);
            //execute the sproc
            db.Execute("sproc_tblPiano_Update");
        }
    }
}