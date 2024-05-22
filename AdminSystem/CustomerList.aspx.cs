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
        lstCustomerList.DataValueField = "CustomerName";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerPhone";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

