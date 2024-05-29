using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //Redirect to the Customer loign page
        //Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnCustomerSupport_Click(object sender, EventArgs e)
    {
        //Redirect to the Customer loign page
        Response.Redirect("CustomerSupportLogin.aspx");
    }

    protected void btnPiano_Click(object sender, EventArgs e)
    {
        //Redirect to the Customer loign page
        Response.Redirect("PianoLogin.aspx");
    }

    protected void btnPurchases_Click(object sender, EventArgs e)
    {
        //Redirect to the Customer loign page
        Response.Redirect("PurchaseLogin.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //Redirect to the Customer loign page
        //Response.Redirect("StaffLogin.aspx");
    }
}