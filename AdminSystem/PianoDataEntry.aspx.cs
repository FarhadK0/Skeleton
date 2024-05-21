using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 PianoId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the PianoId of the record to be processed
        PianoId = Convert.ToInt32(Session["PianoId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (PianoId != -1)
            {
                DisplayPiano();
            }
        }
    }

    void DisplayPiano()
    {
        //create an instance of the piano list
        clsPianoCollection allPianos = new clsPianoCollection();
        //find the record to update
        allPianos.ThisPiano.Find(PianoId);

        //display the data for the record
        txtPianoId.Text = allPianos.ThisPiano.PianoId.ToString();
        txtDateAdded.Text = allPianos.ThisPiano.DateAdded.ToString();
        txtPrice.Text = allPianos.ThisPiano.Price.ToString();
        txtManufacturer.Text = allPianos.ThisPiano.Manufacturer;
        txtModelName.Text = allPianos.ThisPiano.ModelName;
        txtSerialNumber.Text = allPianos.ThisPiano.SerialNumber;
        chkIsInStock.Checked = allPianos.ThisPiano.IsInStock;
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        /*                          */
        /* CAPTURING ALL ATTRIBUTES */
        /*                          */
        //Create a new instance of a Piano class
        clsPiano aPiano = new clsPiano();
        
        //capture data from the form
        string DateAdded = txtDateAdded.Text;
        string Price = txtPrice.Text;
        string Manufacturer = txtManufacturer.Text;
        string ModelName = txtModelName.Text;
        string IsInStock = chkIsInStock.Text;
        string SerialNumber = txtSerialNumber.Text;

        //variable to store errors
        string Error = "";
        //validate the data
        Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);

        if (Error == "")
        {
            //assign to object attributes
            aPiano.PianoId = PianoId;
            aPiano.DateAdded = Convert.ToDateTime(DateAdded);
            aPiano.Price = Convert.ToDouble(Price);
            aPiano.Manufacturer = Manufacturer;
            aPiano.ModelName = ModelName;
            aPiano.IsInStock = chkIsInStock.Checked;
            aPiano.SerialNumber = SerialNumber;

            //create a new instance of the piano collection
            clsPianoCollection allPianos = new clsPianoCollection();

            //if this is a new record
            if (PianoId == -1)
            {
                //set ThisPiano to aPiano
                allPianos.ThisPiano = aPiano;
                //add the aPiano
                allPianos.Add();
            }
            //otherwise if it is an update
            else
            {
                //find the record to update
                allPianos.ThisPiano.Find(PianoId);
                //set the ThisPiano property
                allPianos.ThisPiano = aPiano;
                //update the record
                allPianos.Update();
            }

            /*
            //create a new PianoList
            clsPianoCollection PianoList = new clsPianoCollection();
            //set the ThisPIano property
            PianoList.ThisPiano = aPiano;
            //add the new record
            PianoList.Add();
            */
            //redirect back to the list page
            Response.Redirect("PianoList.aspx");
        }
        else
        {
            //display error messages
            lblError.Text = Error;
        }



    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the piano class
        clsPiano aPiano = new clsPiano();
        //variable for storing primary key
        Int32 PianoId;
        //variable for storing find result
        Boolean Found = false;
        //retrieve PianoId from user entry
        PianoId = Convert.ToInt32(txtPianoId.Text);
        //Find the record
        Found = aPiano.Find(PianoId);

        //if found:
        if (Found == true)
        {
            txtDateAdded.Text = aPiano.DateAdded.ToString();
            txtPrice.Text = aPiano.Price.ToString();
            txtManufacturer.Text = aPiano.Manufacturer;
            txtModelName.Text = aPiano.ModelName;
            txtSerialNumber.Text = aPiano.SerialNumber;
            chkIsInStock.Checked = aPiano.IsInStock;
        }
    }
}