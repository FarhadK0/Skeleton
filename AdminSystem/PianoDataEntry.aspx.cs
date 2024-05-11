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

        //capture data from the forms
        aPiano.PianoId = Convert.ToInt32(txtPianoId.Text);
        aPiano.DateAdded = Convert.ToDateTime(DateTime.Now);
        aPiano.Price = Convert.ToDouble(txtPrice.Text);
        aPiano.Manufacturer = txtManufacturer.Text;
        aPiano.ModelName = txtModelName.Text;
        aPiano.IsInStock = chkIsInStock.Checked;
        aPiano.SerialNumber = txtSerialNumber.Text;

        //store the model name in the session object
        Session["aPiano"] = aPiano;

        //nav to the view page
        Response.Redirect("PianoViewer.aspx");

    }
}