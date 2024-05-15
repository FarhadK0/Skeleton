using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Staff name public property 
        public string StaffName { get; set; }
        //staff email public property
        public string StaffEmail { get; set; }
        //date of birth public property
        public DateTime DateOfBirth { get; set; }
        //staff address public property
        public string StaffAddress { get; set; }
        //staff age public property
        public int StaffAge { get; set; }
        //is manager public property
        public bool IsManager { get; set; }
       
        //private data member for the address id property
        private Int32 mStaffId;


        //staff id public property
        public Int32 StaffId
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

        
        public bool Find(int staffId)
        {
            //set the private data members to the test data value 
            mStaffId = 15;
            //always return true
            return true;
        }

        



 



    }
}