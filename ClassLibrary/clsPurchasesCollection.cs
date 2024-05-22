using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPurchasesCollection
    {

        //Private data member for the list
        List<clsPurchases> mPurchaseList = new List<clsPurchases>();

        //Private member data for thisPurchase
        clsPurchases mThisPurchase = new clsPurchases();

        //Constructor for the class
        public clsPurchasesCollection() 
        {
            //Variable for the index
            Int32 Index = 0;
            
            //Variable to store the record count
            Int32 RecordCount = 0;

            //Object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //Stored Procedure execution
            DB.Execute("sproc_tblPurchases_SelectAll");

            //Counts of records
            RecordCount = DB.Count;

            //While there are records to process
            while (Index < RecordCount)
            {
                //Blank Purchase created
                clsPurchases APurchase = new clsPurchases();

                //Read in the fields for the current record
                APurchase.PurchaseId = Convert.ToInt32(DB.DataTable.Rows[Index]["PurchaseId"]);
                APurchase.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                APurchase.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                APurchase.DeliveryOptions = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryOptions"]);
                APurchase.ProductPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ProductPrice"]);
                APurchase.TotalAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalAmount"]);
                APurchase.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                APurchase.OrderConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderConfirmed"]);

                //Add record to the private data member
                mPurchaseList.Add(APurchase);

                //Point at the next record
                Index++;

            }

        }

        //Public property for the Purchase list
        public List<clsPurchases> PurchaseList
        {
            get
            {
                //Return the private data
                return mPurchaseList;
            }
            set
            {
                //Set the private data
                mPurchaseList = value;
            }
        }
        public int Count
        {
            get
            {
                //Return the count of the list
                return mPurchaseList.Count;
            }
            set
            {
                //WORRY ABOUT THIS LATER
            }
        }

        public clsPurchases ThisPurchase
        {
            get
            {
                //return the private data
                return mThisPurchase;
            }
            set
            {
                //Set the private data
                mThisPurchase = value;
            }
        }

        public int Add()
        {
            //add a record to the DB basd on the values of mThisPurchase
            //connect to DB
            clsDataConnection DB = new clsDataConnection();

            //set params for the sproc
            DB.AddParameter("@OrderDate", mThisPurchase.OrderDate);
            DB.AddParameter("@ProductPrice", mThisPurchase.ProductPrice);
            DB.AddParameter("@CustomerName", mThisPurchase.CustomerName);
            DB.AddParameter("@DeliveryOptions", mThisPurchase.DeliveryOptions);
            DB.AddParameter("@OrderConfirmed", mThisPurchase.OrderConfirmed);
            DB.AddParameter("@TotalAmount", mThisPurchase.TotalAmount);
            DB.AddParameter("@Quantity", mThisPurchase.Quantity);

            //return the PrimaryKey of the new record
            return DB.Execute("sproc_tblPurchases_Insert");
        }
    }
}