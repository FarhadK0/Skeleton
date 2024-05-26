using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the Staff list 
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }

            set
            {
                //set the private data
                mStaffList = value;
            }
        }


        //public property for Count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }

            set
            {
                //saved for later

            }
        }

        //public property for thisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }

            set
            {
                //set the private data 
                mThisStaff = value;

            }
        }


        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

        //Add method
        public int Add()
        {
            //add a record to the database based on the the values of mThisStaff 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffRegisterDate", mThisStaff.StaffRegisterDate);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffAge", mThisStaff.StaffAge);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);

            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }

        //Update method
        public void Update()
        {
            //update an existing record based on the value of ThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffRegisterDate", mThisStaff.StaffRegisterDate);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffAge", mThisStaff.StaffAge);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            //execute the stroed procedure
             DB.Execute("sproc_tblStaff_Update");
        }
 
        //delete method
        public void Delete()
        {
            //delete the record pointed to by ThisStaff 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Delete");
        }

        //filter method 
        public void ReportByStaffAddress(string StaffAddress)
        {
            //filters the record based on a full or partial Staff Address 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the StaffAddress parameter to the database
            DB.AddParameter("@StaffAddress", StaffAddress);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffAddress");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

       void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current record 
                AStaff.IsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsManager"]);
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffRegisterDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffRegisterDate"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffAge = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffAge"]);
                //add the record to the private data member 
                mStaffList.Add(AStaff);
                //point at the next record 
                Index++;

            }
        }



    }
}