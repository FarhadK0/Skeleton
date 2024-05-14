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

        public string Valid(string dateAdded, string Price, string manufacturer, string modelName, string serialNumber)
        {
            return "";
        }
    }
}