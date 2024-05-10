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
        //Create a new instance of clsPurchases
        clsPurchases APurchase = new clsPurchases();

        //Get data from the session object
        APurchase = (clsPurchases)Session["APurchase"];

        //Display the PurchaseId for this entry
        Response.Write(APurchase.PurchaseId);

        //Display the CustomerName for this entry
        Response.Write(APurchase.CustomerName);

        //Display the DeliveryOptions for this entry
        Response.Write(APurchase.DeliveryOptions);

        //Display the ProductPrice for this entry
        Response.Write(APurchase.ProductPrice);
        
        //Display the Quantity for this entry
        Response.Write(APurchase.Quantity);

        //Display the OrderDate for this entry
        Response.Write(APurchase.OrderDate);

        //Display the TotalAmount for this entry
        Response.Write(APurchase.TotalAmount);
    }
}