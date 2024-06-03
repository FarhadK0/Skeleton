using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    { 
        //if this the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an intance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        // set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

   
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // store  the data in the session
        Session["CustomerID"] = CustomerID;
        //redirect to data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click( object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 CustomerID;
        //  if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 CustomerID;
        //  if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an intance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrive the value of CustomerEmail from the presentastion layer
        AnCustomer.ReportByCustomerEmail(txtFilter.Text);
        //set the data source to the list of Customer in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //SET the name of the files to display 
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an intance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrive the value of CustomerEmail from the presentastion layer
        AnCustomer.ReportByCustomerEmail("");
        //clear any exiting filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of Customer in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //SET the name of the files to display 
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}



