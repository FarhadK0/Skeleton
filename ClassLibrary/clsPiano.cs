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

        /**FIND METHOD**/
        public bool Find(int PianoId)
        {
            //create an instance of the data conection
            clsDataConnection db = new clsDataConnection();
            //add the parameter for the piano id to search for
            db.AddParameter("@PianoId", PianoId);
            //execute the stored procedure
            db.Execute("sproc_tblPiano_FilterByPianoId");

            //if and ONLY IF one record is found:
            if (db.Count == 1)
            {
                mPianoId = Convert.ToInt32(db.DataTable.Rows[0]["PianoId"]);
                mDateAdded = Convert.ToDateTime(db.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToDouble(db.DataTable.Rows[0]["Price"]);
                mManufacturer = Convert.ToString(db.DataTable.Rows[0]["Manufacturer"]);
                mModelName = Convert.ToString(db.DataTable.Rows[0]["ModelName"]);
                mIsInStock = Convert.ToBoolean(db.DataTable.Rows[0]["IsInStock"]);
                mSerialNumber = Convert.ToString(db.DataTable.Rows[0]["SerialNumber"]);

                return true;
            }
            //otherwise if NO record was found:
            else
            {
                //indicate there's a potential problem
                return false;
            }

        }
        /**VALIDATION METHOD**/
        public string Valid(string dateAdded, string price, string manufacturer, string modelName, string serialNumber)
        {
            //string for storing errors
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            //create a new variable for storing actual Price as double
            Double PriceAsDouble;

            //if the Manufacturer is blank or longer than 20 chars
            if (manufacturer.Length == 0)
            {
                //record the error (concatenate onto any other errors that may exist)
                Error = Error + "No manufacturer provided; \n";
            }
            if (manufacturer.Length > 20)
            {
                //record the error
                Error = Error + "Character limit exceeded for Manufacturer; \n";
            }

            //if the ModelName is blank or longer than 20 chars
            if (modelName.Length == 0)
            {
                //record the error (concatenate onto any other errors that may exist)
                Error = Error + "No model name provided; \n";
            }
            if (modelName.Length > 20)
            {
                //record the error
                Error = Error + "Character limit exceeded for Model Name; \n";
            }

            //if the serialNumber is blank or longer than 20 chars
            if (serialNumber.Length == 0)
            {
                //record the error (concatenate onto any other errors that may exist)
                Error = Error + "No serial number provided; \n";
            }
            if (serialNumber.Length > 20)
            {
                //record the error
                Error = Error + "Character limit exceeded for serial number; \n";
            }

            //to test the date...
            try 
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past; \n";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future; \n";
                }
            }
            catch 
            {
                //record the error
                Error = Error + "The date was an invalid date; \n";
            }

            //to test the Price...
            try
            {
                PriceAsDouble = Convert.ToDouble(price);
                // if the price is less than 0
                if (PriceAsDouble < 0)
                {
                    Error = Error + "The price cannot be smaller than £0.00; \n";
                }
            }
            catch 
            {
                //record the error if price is invalid data type
                Error = Error + "The price was an invalid number; \n";
            }
            
            //return error messages
            return Error;
        }
    }
}