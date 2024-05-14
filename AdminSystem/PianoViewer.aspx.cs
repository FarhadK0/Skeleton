using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsPiano
        clsPiano aPiano = new clsPiano();

        //get the data from the session object
        aPiano = (clsPiano)Session["aPiano"];

        //display all attributes for this entry
        Response.Write(aPiano.PianoId);
        Response.Write(aPiano.DateAdded);
        Response.Write(aPiano.Price);
        Response.Write(aPiano.Manufacturer);
        Response.Write(aPiano.ModelName);
        Response.Write(aPiano.IsInStock);
        Response.Write(aPiano.SerialNumber);
    }

   
}