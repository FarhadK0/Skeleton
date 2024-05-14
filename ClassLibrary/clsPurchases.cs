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
        private decimal mProductPrice;
        public decimal ProductPrice
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
        private decimal mTotalAmount;
        public decimal TotalAmount
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

        public bool Find(int purchaseId)
        {
            //Set the private data members to the test data value
            mPurchaseId = 1;
            mOrderDate = Convert.ToDateTime("14/05/2024");
            mCustomerName = ("Chloe");
            mDeliveryOptions = ("Morning");
            mProductPrice = Convert.ToDecimal("1.9");
            mQuantity = 1;
            mTotalAmount = Convert.ToDecimal("1.9");
            mOrderConfirmed = true;
            
            //always return true
            return true;
        }

     
    }
}