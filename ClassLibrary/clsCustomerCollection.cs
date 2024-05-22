using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        public clsCustomerCollection()
        {
            //variable for the class
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fiedls for the current record
                AnCustomer.hasPurchases = Convert.ToBoolean(DB.DataTable.Rows[Index]["hasPurchases"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.Dateofbirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dateofbirth"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                // point at the next rrecord
                Index++;
            }
                //create the items of test data
                clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.hasPurchases = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jainish";
            TestItem.CustomerEmail = "Jainish@gmail.com";
            TestItem.Dateofbirth = DateTime.Now.Date;
            TestItem.CustomerPhone = "0099887766";
            TestItem.CustomerAddress = "1234 Leicster ";
            //add the test item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.hasPurchases = false;
            TestItem.CustomerID = 2;
            TestItem.CustomerName = "Fard";
            TestItem.CustomerEmail = "Fard@gmail.com";
            TestItem.Dateofbirth = DateTime.Now.Date;
            TestItem.CustomerPhone = "0987654329";
            TestItem.CustomerAddress = "22 Leicester";
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
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

        public clsCustomer ThisCustomer { get; set; }
    }
}
