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

        //Instance Created
        clsPurchaseUser AnUser = new clsPurchaseUser();

        //Get data from the session object
        AnUser = (clsPurchaseUser)Session["AnUser"];

        //Display Username
        Response.Write("Logged in as: " + AnUser.UserName);
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be deleted
        Int32 PurchaseId;

        //If a record has been selected from the list
        if (lstPurchaseList.SelectedIndex != -1)
        {
            //Get the Primary Key value of the record delete
            PurchaseId = Convert.ToInt32(lstPurchaseList.SelectedValue);

            //Store the data in the session object
            Session["PurchaseId"] = PurchaseId;

            //Redirect to the delete page
            Response.Redirect("PurchasesConfirmDelete.aspx");
        }
        else  //If no record has been selected
        {
            //Display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //Instance Created
        clsPurchasesCollection APurchase = new clsPurchasesCollection();

        //set an empty string
        APurchase.ReportByCustomerName("");

        //Clear any existing filter to tidy up interface
        txtFilter.Text = "";

        //Set the data source to the list of addresses in the collection
        lstPurchaseList.DataSource = APurchase.PurchaseList;

        //Set the name of the primary key
        lstPurchaseList.DataValueField = "PurchaseId";

        //Set the name of the field to display
        lstPurchaseList.DataTextField = "CustomerName";

        //Bind the data to the list
        lstPurchaseList.DataBind();

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //Instance Created
        clsPurchasesCollection APurchase = new clsPurchasesCollection();

        //Retrieve the value or Customer Name from the presentation layer
        APurchase.ReportByCustomerName(txtFilter.Text);

        //Set the data source to the list of Purchases in the collection
        lstPurchaseList.DataSource = APurchase.PurchaseList;

        //Sets name of primary key
        lstPurchaseList.DataValueField = "PurchaseId";

        //Set the name of the field to display
        lstPurchaseList.DataTextField = "CustomerName";

        //Bind the data to the list
        lstPurchaseList.DataBind();

    }

    //protected void btnMainMenu_Click(object sender, EventArgs e)
    //{
    //    //Redirect to the data entry page
    //    Response.Redirect("TeamMainMenu.aspx");
    //}

    protected void btnMainmenu_Click(object sender, EventArgs e)
    {
        //Redirect to the data entry page
        Response.Redirect("TeamMainMenu.aspx");
    }
}