using System;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace ClassLibrary
{
    public class clsCustomerSupportCollection
    {
        //private data member for the list
        List<clsCustomerSupport> cCustomerSupportList = new List<clsCustomerSupport>();

        //private member data for thisCustomerSupport
        clsCustomerSupport cThisCustomerSupport = new clsCustomerSupport();

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

        //public property for ThisCustomerSupport
        public clsCustomerSupport ThisCustomerSupport 
        {
            get
            {
                //return the private data
                return cThisCustomerSupport;
            }
                set
            {
                //set the private data
                cThisCustomerSupport= value;
            }
        }

        //constructor for the class
        public clsCustomerSupportCollection() 
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_CustomerSupport_SelectAll");

            //populate the array list with the data tabel
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a record to the database based on the values of cThisCustomerSupport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@TicketType", cThisCustomerSupport.TicketType);
            DB.AddParameter("@Subject", cThisCustomerSupport.Subject);
            DB.AddParameter("@Description", cThisCustomerSupport.Description);
            DB.AddParameter("@SubmissionDate", cThisCustomerSupport.SubmissionDate);
            DB.AddParameter("@TicketStatus", cThisCustomerSupport.TicketStatus);
            DB.AddParameter("@TicketElevated", cThisCustomerSupport.TicketElevated);

            //execute the query returning the primary key value
            return DB.Execute("sproc_CustomerSupport_Insert");

        }

        public void Update()
        {
            //add a record to the database based on the values of cThisCustomerSupport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@TicketID", cThisCustomerSupport.TicketID);
            DB.AddParameter("@TicketType", cThisCustomerSupport.TicketType);
            DB.AddParameter("@Subject", cThisCustomerSupport.Subject);
            DB.AddParameter("@Description", cThisCustomerSupport.Description);
            DB.AddParameter("@SubmissionDate", cThisCustomerSupport.SubmissionDate);
            DB.AddParameter("@TicketStatus", cThisCustomerSupport.TicketStatus);
            DB.AddParameter("@TicketElevated", cThisCustomerSupport.TicketElevated);

            //execute the query returning the primary key value
             DB.Execute("sproc_CustomerSupport_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomerSupport
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@TicketID", cThisCustomerSupport.TicketID);

            //execute the stored procedure
            DB.Execute("sproc_CustomerSupport_Delete");
             
        }

        public void ReportByTicketType(string TicketType)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //send the tickettype parameter to the database
            DB.AddParameter("@TicketType", TicketType);

            //execute the stored procedure
            DB.Execute("sproc_CustomerSupport_FilterByTicketType");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data tabel in the parameter DB
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private arry list
            cCustomerSupportList = new List<clsCustomerSupport>();

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