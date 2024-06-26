﻿using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff Id property
        private Int32 mStaffId;
        //staff id public property
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }


        //private data member for the staff name property
        private string mStaffName;
        //staff name public property
        public string StaffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        //private data member for the house no property
        private string mStaffEmail;
        //staff email public property
        public string StaffEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }


        //private data member for the Date of birth property
        private DateTime mStaffRegisterDate;
        //Date of birth public property
        public DateTime StaffRegisterDate
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffRegisterDate;
            }
            set
            {
                //this line of code allows data into the property
                mStaffRegisterDate = value;
            }
        }

        //private data member for the Staff Address property
        private string mStaffAddress;
        //Staff Address public property
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAddress = value;
            }
        }


        //private data member for the staff age property
        private Int32 mStaffAge;
        //Staff age public property
        public int StaffAge
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAge;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAge = value;
            }
        }


        //private data member for the house no property
        private Boolean mIsManager;
        //Is manager? public property
        public bool IsManager
        {
            get
            {
                //this line of code sends data out of the property
                return mIsManager;
            }
            set
            {
                //this line of code allows data into the property
                mIsManager = value;
            }
        }

        /*****FIND METHOD*******/

        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff id to search for 
            DB.AddParameter("@StaffID", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database  to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffRegisterDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffRegisterDate"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffAge = Convert.ToInt32(DB.DataTable.Rows[0]["StaffAge"]);
                mIsManager = Convert.ToBoolean(DB.DataTable.Rows[0]["IsManager"]);
                //everything works fine 
                return true;

            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem 
                return false;
            }



        }

        public string Valid(string staffName, string staffEmail, string staffRegisterDate, string staffAddress, string staffAge)
        {
            //create a string variable to store the error
            String Error = "";
            //create  a temporary variable to store the date value 
            DateTime DateTemp;
            //create  a temporary variable to store the age value 
            Int32 AgeTemp;
            //if the StaffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Name may not be blank : ";

            }
            //if the StaffName is greater than 50
            if (staffName.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Name must be less than 50 characters: ";

            }

            //if the StaffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Email may not be blank : ";

            }

            //if the StaffEmail is greater than 50
            if (staffEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Email must be less than 50 characters: ";

            }

            //if the StaffAddress is blank
            if (staffAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Address may not be blank : ";

            }

            //if the StaffAddress is greater than 50
            if (staffAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Address must be less than 50 characters: ";

            }

            //Define too old
            Int32 TooOld = 65;
            Int32 TooYoung = 18;


            try
            {
                // Copy the staffAge value to the AgeTemp variable
                AgeTemp = Convert.ToInt32(staffAge);
                // Check if the staff age is less than 18
                if (AgeTemp < TooYoung)
                {
                    // Record the error
                    Error = Error + "The staff age must be less than 65 years old: ";
                }

                // Check if the age is greater than 65
                if (AgeTemp > TooOld)
                {
                    // Record the error
                    Error = Error + "The staff age is too young: ";
                }

            }
            catch (FormatException)
            {

                // Record the error for invalid date format
                Error = Error + "The staff age is not valid: ";
            }


            // Define the currentDate to today's date
            DateTime CurrentDate = DateTime.Now.Date;
            
            
              
            try
            {
                // Copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffRegisterDate);
                // Check if the date of birth is less than the extreme minimum date
                if (DateTemp < CurrentDate)
                {
                    // Record the error
                    Error = Error + "Registration date cannot be in the past ";
                }

                // Check if the date of birth is greater than today's date
                if (DateTemp > CurrentDate)
                {
                    // Record the error
                    Error = Error + "Registration date cannot be in the future: ";
                }

                

            }
            catch (FormatException)
            {
              
                // Record the error for invalid date format
                Error = Error + "Registration Date is not a valid date: ";
            }


            //return any error messages
            return Error;
        }
    }
}