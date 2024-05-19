using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayPurchases();
        }
    }
    void DisplayPurchases()
    {
        //Create an instance of the Purchase collection
        clsPurchasesCollection Purchases = new clsPurchasesCollection();

        //Set the data source to the list of addresses in the collection
        lstPurchaseList.DataSource = Purchases.PurchaseList;

        //Name of the primary key
        lstPurchaseList.DataValueField = "PurchaseId";

        //Data field to display
        lstPurchaseList.DataTextField = "CustomerName";

        //Bind the data to the list
        lstPurchaseList.DataBind();
    }
}