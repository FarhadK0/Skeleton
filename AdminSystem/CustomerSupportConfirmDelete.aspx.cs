using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 TicketID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the ticket to be deleted from the session object
        TicketID = Convert.ToInt32(Session["TicketID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book collecton class
        clsCustomerSupportCollection CustomerSupport = new clsCustomerSupportCollection();

        //find the record to delete
        CustomerSupport.ThisCustomerSupport.Find(TicketID);

        //delete the record
        CustomerSupport.Delete();

        //redirect back to the main page
        Response.Redirect("CustomerSupportList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerSupportList.aspx");
    }
}