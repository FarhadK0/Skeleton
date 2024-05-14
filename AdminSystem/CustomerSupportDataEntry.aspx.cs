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
        AnCustomerSupport.TicketElevated = chkTicketElevated.Checked;

        //store the Ticket in the sesssion object
        Session["AnCustomerSupport"] = AnCustomerSupport;
        //navigate to the CustomerPage
        Response.Redirect("CustomerSupportViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

        //create a variable to store the primary key
        Int32 TicketID;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key enter by the user
        TicketID = Convert.ToInt32(txtTicketID.Text);

        //find the record
        Found = AnCustomerSupport.Find(TicketID);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtTicketType.Text = AnCustomerSupport.TicketType;
            txtSubject.Text = AnCustomerSupport.Subject;
            txtDescription.Text = AnCustomerSupport.Description;
            txtSubmissionDate.Text = AnCustomerSupport.SubmissionDate.ToString();
            txtTicketStatus.Text = AnCustomerSupport.TicketStatus;
            chkTicketElevated.Checked = AnCustomerSupport.TicketElevated;


        }
    }
}