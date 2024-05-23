using System;

namespace ClassLibrary
{
    public class clsPianoUser
    {
        //private data member for the user id property
        private Int32 mUserId;
        //private data member for the user name property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;

        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                //set the private data
                mUserId = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private dat
                mDepartment = value;
            }
        }

        public bool FindUser(string username, string password)
        {
            //create an instance of the data connection
            clsDataConnection db = new clsDataConnection();
            //add the parameters for the user username and password to search for
            db.AddParameter("@UserName", username);
            db.AddParameter("@Password", password);
            //execute the stored procedure
            db.Execute("sproc_tblUsers_FindUserNameAndPasswordForPiano");
            //if one record is found (there should be either one or none)
            if (db.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserId = Convert.ToInt32(db.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(db.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(db.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(db.DataTable.Rows[0]["Department"]);
                //return true to confirm evertying worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}