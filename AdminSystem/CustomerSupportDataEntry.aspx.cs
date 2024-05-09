using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsCutsomerSupport
        clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

        //capture Ticket Type
        AnCustomerSupport.TicketType = txtTicketType.Text;
        AnCustomerSupport.Subject = txtSubject.Text;
        AnCustomerSupport.Description = txtDescription.Text;
        AnCustomerSupport.SubmissionDate = Convert.ToDateTime(DateTime.Now);
        AnCustomerSupport.TicketStatus = txtTicketStatus.Text;
        AnCustomerSupport.RaiseTicketStatus = chkActive.Checked;

        //store the Ticket in the sesssion object
        Session["AnCustomerSupport"] = AnCustomerSupport;
        //navigate to the CustomerPage
        Response.Redirect("CustomerSupportViewer.aspx");
    }
}