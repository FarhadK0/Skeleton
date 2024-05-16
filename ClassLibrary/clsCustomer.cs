using System;

namespace ClassLibrary
{
    public class clsCustomer
    {



        // private data member for the customer id property
        private Int32 mCustomerID;
        //CustomerID public property
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        //private data member for the date added property
        private DateTime mDateofbirth;
        //date added public property
        public DateTime Dateofbirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateofbirth;
            }
            set
            {
                // this line of code allow data into the property
                mDateofbirth = value;
            }
        }
        //private data member for the house no property
        private string mCustomerName;
        //house no public property
        public string CustomerName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }
        //private data member for the street property
        private string mCustomerEmail;
        //street public property
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }
        //private data member for the town property
        private string mCustomerPhone;
        //town public property
        public string CustomerPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhone;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhone = value;
            }
        }
        //private data member for the town property
        private string mCustomerAddress;
        //town public property
        public string CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }
        //private data member for the active property
        private Boolean mhasPurchases;
        //active public property
        public bool hasPurchases
        {
            get
            {
                //this line of code sends data out of the property
                return mhasPurchases;
            }
            set
            {
                //this line of code allows data into the property
                mhasPurchases = value;
            }
        }



        public bool Find(int CustomerID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_Customer_FilterByCustomerID");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateofbirth = Convert.ToDateTime(DB.DataTable.Rows[0]["Dateofbirth"]);
                mhasPurchases = Convert.ToBoolean(DB.DataTable.Rows[0]["hasPurchases"]);
                //  aslways return true
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}












