using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to inducate this is a new record
        Session["TicketID"] = -1;

        //redirect to the data entry page
        Response.Redirect("CustomerSupportDataEntry.aspx");
    }
}


