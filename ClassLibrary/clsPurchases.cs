using System;

namespace ClassLibrary
{
    public class clsPurchases
    {
        //Private data member for the Purchase ID property
        private Int32 mPurchaseId;
        public int PurchaseId
        {
            get
            {
                //This line of code sends data out of the property
                return mPurchaseId;
            }
            set
            {
                //This line of code allows data into the property
                mPurchaseId = value;
            }
        }



        //Private data member for the Purchase ID property
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                //This line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //This line of code allows data into the property
                mOrderDate = value;
            }
        }

        //Private data member for the Purchase ID property
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                //This line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //This line of code allows data into the property
                mCustomerName = value;
            }
        }

        //Private data member for the Purchase ID property
        private string mDeliveryOptions;
        public string DeliveryOptions
        {
            get
            {
                //This line of code sends data out of the property
                return mDeliveryOptions;
            }
            set
            {
                //This line of code allows data into the property
                mDeliveryOptions = value;
            }
        }

        //Private data member for the Purchase ID property
        private double mProductPrice;
        public double ProductPrice
        {
            get
            {
                //This line of code sends data out of the property
                return mProductPrice;
            }
            set
            {
                //This line of code allows data into the property
                mProductPrice = value;
            }
        }

        //Private data member for the Purchase ID property
        private int mQuantity;
        public int Quantity
        {
            get
            {
                //This line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //This line of code allows data into the property
                mQuantity = value;
            }
        }

        //Private data member for the Purchase ID property
        private double mTotalAmount;
        public double TotalAmount
        {
            get
            {
                //This line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //This line of code allows data into the property
                mTotalAmount = value;
            }
        }

        //Private data member for the Purchase ID property
        private Boolean mOrderConfirmed;
        public bool OrderConfirmed
        {
            get
            {
                //This line of code sends data out of the property
                return mOrderConfirmed;
            }
            set
            {
                //This line of code allows data into the property
                mOrderConfirmed = value;
            }
        }

        //Find Method

        public bool Find(int PurchaseId)
        {
            //Create an Instance of the Data Connection
            clsDataConnection db = new clsDataConnection();

            //Add parameter for the PurchaseId to search for
            db.AddParameter("@PurchaseId", PurchaseId);

            //Execute the Stored Procedure
            db.Execute("sproc_tblPurchases_FilterByPurchaseID");

            //If one record is found 
            if (db.Count == 1)
            {
                //Set the private data members to the test data value
                mPurchaseId = Convert.ToInt32(db.DataTable.Rows[0]["PurchaseId"]);
                mOrderDate = Convert.ToDateTime(db.DataTable.Rows[0]["OrderDate"]);
                mCustomerName = Convert.ToString(db.DataTable.Rows[0]["CustomerName"]);
                mDeliveryOptions = Convert.ToString(db.DataTable.Rows[0]["DeliveryOptions"]);
                mProductPrice = Convert.ToDouble(db.DataTable.Rows[0]["ProductPrice"]);
                mQuantity = Convert.ToInt32(db.DataTable.Rows[0]["Quantity"]);
                mTotalAmount = Convert.ToDouble(db.DataTable.Rows[0]["TotalAmount"]);
                mOrderConfirmed = Convert.ToBoolean(db.DataTable.Rows[0]["OrderConfirmed"]);

                //return that everything worked OK
                return true;
            }
            //if No record found
            else
            {
                //return false indicating there is a problem
                return false;

            }



        }
    }
}
