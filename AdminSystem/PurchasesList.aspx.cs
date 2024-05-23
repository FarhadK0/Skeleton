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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["PurchaseId"] = -1;

        //Redirect to the data entry page
        Response.Redirect("PurchasesDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited
        Int32 PurchaseId;

        //If a record as been selected from the list
        if (lstPurchaseList.SelectedIndex != -1)
        {
            //Primary Key value of the record to edit
            PurchaseId = Convert.ToInt32(lstPurchaseList.SelectedValue);

            //Store the data in the session object
            Session["PurchaseId"] = PurchaseId;

            //Redirect to edit page
            Response.Redirect("PurchasesDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}