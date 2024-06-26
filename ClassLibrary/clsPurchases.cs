﻿using System;
using System.Security.Cryptography.X509Certificates;

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



        //Private data member for the OrderDate property
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

        //Private data member for the CustomerName property
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

        //Private data member for the DeliveryOptions property
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

        //Private data member for the ProductPrice property
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

        //Private data member for the Quantity property
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

        //Private data member for the TotalAmount property
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

        //Private data member for the OrderConfirmed property
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

        /**VALIDATION METHOD**/
        public string Valid(string customerName, string deliveryOptions, string productPrice, string quantity, string orderDate, string totalAmount)
        {
            //This is the Valid Method

            //String variable to store error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //Create instance of DateTime to compare with DateTemp
            //In the if statements
            DateTime DateComp = DateTime.Now.Date;

            //Create new variable for storing actual productPrice & totalAmount as double
            Double ProductPriceAsDouble;
            Double TotalAmountAsDouble;

            //Create new variable for storing actual Quanitity as Int
            Int32 QuantityAsInt32;

            //If the CustomerName is blank
            if (customerName.Length == 0)
            {
                //Record the error
                Error = Error + "The Customer name can't be blank: <br>  ";
            }
            //If the CustomerName is greater than 50 Characters
            if (customerName.Length > 50)
            {
                //Record the error
                Error = Error + "The Customer name must be less than 50 characters: <br>  ";
            }

            //If the DeliveryOptions is blank
            if (deliveryOptions.Length == 0)
            {
                //Record the error
                Error = Error + "The delivery options can't be blank: <br>  ";
            }
            //If the DeliveryOptions is greater than 50 Characters
            if (deliveryOptions.Length > 150)
            {
                //Record the error
                Error = Error + "The delivery options must be less than 150 characters: <br>  ";
            }

            try
            {
                ProductPriceAsDouble = Convert.ToDouble(productPrice);

                //If ProductPrice is less than 0
                if (ProductPriceAsDouble < 0)
                {
                    Error = Error + "The Product Price can't be smaller than £0.00: <br> ";
                }
            }
            catch
            {
                //Error being recorded cause of invalid data type
                Error = Error + "Please input the Product Price: <br>";
            }

            try
            {
                TotalAmountAsDouble = Convert.ToDouble(totalAmount);

                //If Total Amount is less than 0
                if (TotalAmountAsDouble < 0)
                {
                    Error = Error + "The Total Amount can't be smaller than £0.00: <br> ";
                }
            }
            catch
            {
                //Error being recorded cause of invalid data type
                Error = Error + "Please  input the Total Amount: <br>";
            }

            try
            {
                QuantityAsInt32 = Convert.ToInt32(quantity);

                //If the Quantity is less than 1
                if (QuantityAsInt32 < 1)
                {
                    Error = Error + "The quantity can't be less than one: <br>  ";
                }
                //If the Quantity is greater than 250
                if (QuantityAsInt32 > 250)
                {
                    Error = Error + "The quantity can't be more than 250: <br>  ";
                }
            }
            catch
            {
                Error = Error + "Please input a Quantity: <br>  ";
            }
        
            try
            {
                //Copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                //Check to see if data is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Order Date can't be in the past: <br> ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Order Date can't be in the future: <br> ";
                }
            }
            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date: <br> ";
            }

            //Return any error messages
            return Error;

        }
    }
}
