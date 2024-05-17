using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerSupportCollection
    {
        //private data member for the list
        List<clsCustomerSupport> cCustomerSupportList = new List<clsCustomerSupport>();

        //public property for the address list
        
        public List<clsCustomerSupport> CustomerSupportList
        {
             get
            {
                //return the private data
                return cCustomerSupportList;
            }
             set
            {
                //set the private data
                cCustomerSupportList = value;
            }
        }

        //public property for count
        public int Count 
        { 
            get
            {
                //return the count of the list
                return cCustomerSupportList.Count;
            }

            set 
            {
             //we will see this later
            }
                
            
        }
        public clsCustomerSupport ThisCustomerSupport { get; set; }

        public clsCustomerSupportCollection() 
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_CustomerSupport_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
             //create a blank address
             clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

                //read in the fields for the current record
                AnCustomerSupport.TicketID = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketID"]);
                AnCustomerSupport.TicketType = Convert.ToString(DB.DataTable.Rows[Index]["TicketType"]);
                AnCustomerSupport.Subject = Convert.ToString(DB.DataTable.Rows[Index]["Subject"]);
                AnCustomerSupport.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnCustomerSupport.SubmissionDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SubmissionDate"]);
                AnCustomerSupport.TicketStatus = Convert.ToString(DB.DataTable.Rows[Index]["TicketStatus"]);
                AnCustomerSupport.TicketElevated = Convert.ToBoolean(DB.DataTable.Rows[Index]["TicketElevated"]);

                //add the record to the private data member
                cCustomerSupportList.Add(AnCustomerSupport);

                //point at the next record
                Index++;
            }
        }
    }
}