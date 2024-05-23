using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //Variable to store the primary key value of the record to be deleted
    Int32 PurchaseId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the purchase to be deleted from the session object
        PurchaseId = Convert.ToInt32(Session["PurchaseId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //New instance created
        clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

        //Find the record to delete
        AllPurchases.ThisPurchase.Find(PurchaseId);

        //Delete the record
        AllPurchases.Delete();

        //Redirect back to main page
        Response.Redirect("PurchasesList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the main page
        Response.Redirect("PurchasesList.aspx");
    }
}