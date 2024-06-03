using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomerCollection()
        {
            //object for for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //populate the array list with the date table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameterDB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fiedls for the current record
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.Dateofbirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dateofbirth"]);
                AnCustomer.hasPurchases = Convert.ToBoolean(DB.DataTable.Rows[Index]["hasPurchases"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                // point at the next rrecord
                Index++;
            }
        }


        public int Count
        {
            get
            {
                //retun the count of the list
                return CustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsCustomer ThisCustomer
        {
            get
            {
                // retun the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        public int Add()
        {
            // adds a record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@Dateofbirth", mThisCustomer.Dateofbirth);
            DB.AddParameter("@hasPurchases", mThisCustomer.hasPurchases);

            //execute the query returning the primary key value
            return DB.Execute("sproc_Customer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@Dateofbirth", mThisCustomer.Dateofbirth);
            DB.AddParameter("@hasPurchases", mThisCustomer.hasPurchases);

            //execute the query returning the primary key value
            DB.Execute("sporc_Customer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection(); 
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            // execute the stored procedure
            DB.Execute("sproc_Customer_Delete");
        }

        public void ReportByCustomerEmail(string CustomerEmail)
        {
            // filters the records based on a full or partial CusstomerEmail
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerEmail parameter to the database 
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_Customer_FilterByCustomerEmail");
            ////poplulate the array list with the data table
            PopulateArray(DB);
        }
    }
}
