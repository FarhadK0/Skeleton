using System;
using System.Web;

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

        public string Valid(string ticketType, string subject, string description, string submissionDate, string ticketStatus)
        {
            //This is TicketType Valid Method

            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the TicketType is blank
            if (ticketType.Length == 0)
            {
                //record the error
                Error = Error + "Please fill the TicketType field <br>";
            }

            //if the TicketType is greater than 20 characters
            if (ticketType.Length > 20)
            {
                Error = Error + "The TicketType must be less than 20 characters <br>";

            }

            //This is Subject Valid Method

            //if the Suject is blank
            if (subject.Length == 0)
            {
                //record the error
                Error = Error + "Please fill the Subject field <br>";
            }

            //if the Subject is greater than 20 characters
            if (subject.Length > 20)
            {
                Error = Error + "The Subject must be less than 20 characters <br>";

            }


            //This is Description Valid Method

            //if the Description is blank
            if (description.Length == 0)
            {
                //record the error
                Error = Error + "Please fill the Description field <br>";
            }

            //if the Description is greater than 20 characters
            if (description.Length > 100)
            {
                Error = Error + "The Description must be less than 100 characters <br>";

            }

            //This is TicketStatus Valid Method

            //if the TicketStatus is blank
            if (ticketStatus.Length == 0)
            {
                //record the error
                Error = Error + "Please fill the TicketStatus field <br>";
            }

            //if the TicketStatus is greater than 20 characters
            if (ticketStatus.Length > 16)
            {
                Error = Error + "The TicketStatus must be less than 16 characters <br>";

            }

            DateTime DateComp = DateTime.Now.Date;

            try 
            {
                DateTemp = Convert.ToDateTime(submissionDate);

                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(submissionDate);
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : <br> ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : <br> ";
                }
            }
            catch 
            {
                //record the error
                Error = Error + "The date was not a valid date <br>";
            }

            
            


            //return any error message
            return Error;
        }
    }
}