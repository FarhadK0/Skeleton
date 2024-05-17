using System;

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
        private DateTime mDateOfBirth;
        //Date of birth public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
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
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
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
    }
}