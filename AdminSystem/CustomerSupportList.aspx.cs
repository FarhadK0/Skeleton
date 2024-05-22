using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
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

    protected void DisplayCustomerSupports()
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of the record to be edited
        Int32 TicketID;

        //if a record has been selected from the list
        if (lstCustomerSupportList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            TicketID = Convert.ToInt32(lstCustomerSupportList.SelectedValue);

            //store the data in the session object
            Session["TicketID"] = TicketID;

            //redirec to the edit page
            Response.Redirect("CustomerSupportDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be delete
        Int32 TicketID;

        //if a record has been selected from the list
        if (lstCustomerSupportList.SelectedIndex != -1)
        {
            //get the primary key value of he record delete
            TicketID = Convert.ToInt32(lstCustomerSupportList.SelectedValue);

            //store the data in the seesion object
            Session["TicketID"] = TicketID;

            //redirect to the deletepage
            Response.Redirect("CustomerSupportConfirmDelete.aspx");
        }

        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}