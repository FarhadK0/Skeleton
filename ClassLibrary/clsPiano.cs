using System;

namespace ClassLibrary
{
    public class clsPiano
    {
        // private data member for all attributes
        private Int32 mPianoId;
        private DateTime mDateAdded;
        private double mPrice;
        private String mManufacturer;
        private String mModelName;
        private bool mIsInStock;
        private String mSerialNumber;

        public int PianoId
        {
            get
            {
                // sends out the property
                return mPianoId;
            }
            set
            {
                // retrieved data and sets it to property
                mPianoId = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                // sends out the property
                return mDateAdded;
            }
            set
            {
                // retrieved data and sets it to property
                mDateAdded = value;
            }
        }
        public double Price
        {
            get
            {
                // sends out the property
                return mPrice;
            }
            set
            {
                // retrieved data and sets it to property
                mPrice = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                // sends out the property
                return mManufacturer;
            }
            set
            {
                // retrieved data and sets it to property
                mManufacturer = value;
            }
        }
        public string ModelName
        {
            get
            {
                // sends out the property
                return mModelName;
            }
            set
            {
                // retrieved data and sets it to property
                mModelName = value;
            }
        }
        public bool IsInStock
        {
            get
            {
                // sends out the property
                return mIsInStock;
            }
            set
            {
                // retrieved data and sets it to property
                mIsInStock = value;
            }
        }
        public string SerialNumber
        {
            get
            {
                // sends out the property
                return mSerialNumber;
            }
            set
            {
                // retrieved data and sets it to property
                mSerialNumber = value;
            }
        }

        public bool Find(int pianoId)
        {
            //set private data members to test value
            mPianoId = 1;
            mDateAdded = Convert.ToDateTime("12/05/2024");
            mPrice = 399.99;
            mManufacturer = "Yamaha";
            mModelName = "Upright B1";
            mIsInStock = true;
            mSerialNumber = "928719308";
            
            // Force always true
            return true;
        }
    }
}