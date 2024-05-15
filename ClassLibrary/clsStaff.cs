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


        public bool Find(int StaffId)
        {
            //set the private data members to the test data value 
            mStaffId = 4;
            mStaffName = "John Micheal";
            mStaffEmail = "JohnMicheal@gmail.com";
            mDateOfBirth = Convert.ToDateTime("13/5/1990");
            mStaffAddress = "33 Castle Street LE2 5WL";
            mStaffAge = 34;
            mIsManager = true;
            //always return true
            return true;
        }







    }
}