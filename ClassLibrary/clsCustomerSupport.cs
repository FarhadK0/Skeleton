using System;

namespace ClassLibrary
{
    public class clsCustomerSupport
    {
        //private data member for the TicketID property
        private Int32 cTicketID;

        //TicketID public property
        public Int32 TicketID
        {
            get
            {
                //this line of code sends data out of the property
                return cTicketID;
            }
            set
            {
                //this line of code allows data into the property
                cTicketID = value;
            }
        }

        //private data member for the TicketType Property
        private string cTicketType;

        //TicketType public property
        public string TicketType 
        { 
            get
            {
                //this line of code send data out of the property
                return cTicketType;
            }

            set
            {
                //this line of the code allows data into the property
                cTicketType = value;
            } 
        }

        //private data member for the Subject Property
        private string cSubject;

        //Subjec public property
        public string Subject 
        {
            get
            {
                //this line of the code send data out of the property
                return cSubject;
            }

            set
            {
                //this line of the code allows data into the property
                cSubject = value;
            }

        }

        //private data member for the Subject Property
        private string cDescription;

        //Description public property
        public string Description 
        {
            get
            {
                //this line of the code send data out of the property
                return cDescription;
            }
            set
            {
                //this line of the code allows data into the property
                cDescription = value;
            }
        }

        //private data member for the SubmissionDate property
        private DateTime cSubmissionDate;

        //SubmissionDate public Property
        public DateTime SubmissionDate 
        {
            get
            {
                //this line of the code send data out of the property
                return cSubmissionDate;
            }

            set
            {
                //this line of the code allows data into the property
                cSubmissionDate = value;
            }
        }

        //private data member for the SubmissionDate property
        private string cTicketStatus;

        //TicketStatus public property
        public string TicketStatus
        { 
            get
            {
                //this line of the code send data out of the property
                return cTicketStatus;
            }
            
            set
            {
                //this line of the code allows data into the property
                cTicketStatus = value;
            }
        }

        //private data member for the SubmissionDate property
        private Boolean cTicketElevated;

        //TicketElevated public property
        public bool TicketElevated
        {
            get
            {
                //this line of the code send data out of the property
                return cTicketElevated;
            }
                
            set
            {
                //this line of the code allows data into the property
                cTicketElevated = value;
            }
        }

        public bool Find(int TicketID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the TicketID to search for
            DB.AddParameter("@TicketID", TicketID);

            //execute the stores procedure
            DB.Execute("sproc_CustomerSupport_FilterByTicketID");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                cTicketID = Convert.ToInt32(DB.DataTable.Rows[0]["TicketID"]);
                cTicketType = Convert.ToString(DB.DataTable.Rows[0]["TicketType"]);
                cSubject = Convert.ToString(DB.DataTable.Rows[0]["Subject"]);
                cDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                cSubmissionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SubmissionDate"]);
                cTicketStatus = Convert.ToString(DB.DataTable.Rows[0]["TicketStatus"]);
                cTicketElevated = Convert.ToBoolean(DB.DataTable.Rows[0]["TicketElevated"]);

                //return that everthing worked ok
                return true;



            }

            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }
    }
}