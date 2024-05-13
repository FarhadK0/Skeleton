using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        // get the data from the session objcet
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the Name for this entry
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.CustomerPhone);
        Response.Write(AnCustomer.CustomerAddress);
        Response.Write(AnCustomer.Dateofbirth);
    }
}