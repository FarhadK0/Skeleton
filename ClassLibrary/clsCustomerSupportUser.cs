using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsCustomerSupportUser
    {

        //private data member for the UserID property
        private Int32 cUserID;

        //private data member for the UserName property
        private String cUserName;

        //private data member for the Password property
        private string cPassword;

        //private data member for the Department property
        private string cDepartment;

        public int UserID 
        {
            get
            {
                //return the private
                return cUserID;
            }
            
            set
            {
                //set the private data
                cUserID = value;
            }
        }
        public string UserName 
        { 
            get
            {
                //return the private
                return cUserName;
            }
                set
            {
                //set the private data
                cUserName = value;
            }
        }
        public string Password 
        {
            get
            {
                //return the private
                return cPassword;
            }

            set
            {
                //set the private data
                cPassword = value;
            }
        }
        public string Department 
        {
            get
            {
                //return the private
                return cDepartment;
            }

            set
            {
                //set the private data
                cDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
          //create an instance of the data connection
          clsDataConnection DB = new clsDataConnection();

            //add the parameters for the user user name and password to search for 
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);

            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");

            //if one record is found (there should be eithe one or more)
            if (DB.Count ==1)
            {
                //copy the data form the database to the private data members
                cUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                cUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                cPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                cDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
              
               //return true to confirm everthing worked ok
               return true;
               
            }
            else
            {
             return false;
            }
            

        }
    }
}