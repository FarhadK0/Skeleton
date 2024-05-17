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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomerSupports();
        }
    }

    void DisplayCustomerSupports()
    {
        //create an instance of the CustomerSupport collection
        clsCustomerSupportCollection CustomerSupports = new clsCustomerSupportCollection();

        //set the data source to list of CustomerSupports in the colection
        lstCustomerSupportList.DataSource = CustomerSupports.CustomerSupportList;

        //set the name of the primary key
        lstCustomerSupportList.DataValueField = "TicketID";

        //set the data field to display
        lstCustomerSupportList.DataTextField = "TicketType";

        //bind the data to the list
        lstCustomerSupportList.DataBind();
    }
}