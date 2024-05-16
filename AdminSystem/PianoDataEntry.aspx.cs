using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            aPiano.DateAdded = Convert.ToDateTime(DateAdded);
            aPiano.Price = Convert.ToDouble(Price);
            aPiano.Manufacturer = Manufacturer;
            aPiano.ModelName = ModelName;
            //aPiano.IsInStock = Convert.ToBoolean(IsInStock);
            aPiano.SerialNumber = SerialNumber;

            //store the model name in the session object
            Session["aPiano"] = aPiano;

            //nav to the view page
            Response.Redirect("PianoViewer.aspx");
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