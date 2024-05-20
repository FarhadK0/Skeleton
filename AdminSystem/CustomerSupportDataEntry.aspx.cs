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
        //create a new instance of clsCustomerSupport
        clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

        //capture the TicketType
        string TicketType = txtTicketType.Text;

        //capture the Subject
        string Subject = txtSubject.Text;

        //capture the Description
        string Description = txtDescription.Text;

        //capture the submissionDate
        string SubmissionDate = txtSubmissionDate.Text;

        //capture the TicketStatus
        string TicketStatus = txtTicketStatus.Text;

        //capture TicketElevated check box
        string TicketElevated = chkTicketElevated.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);
        if (Error == "")
        {
            //capture the TicketType
            AnCustomerSupport.TicketType = TicketType;

            //capture the Subject
            AnCustomerSupport.Subject = Subject;

            //capture the description
            AnCustomerSupport.Description = Description;

            //capture the submission date 
            AnCustomerSupport.SubmissionDate = Convert.ToDateTime(SubmissionDate);

            //capture the TicketStatus
            AnCustomerSupport.TicketStatus = TicketStatus;

            //capture TicketElevated
            AnCustomerSupport.TicketElevated = chkTicketElevated.Checked;

            //create a new instance of the customerSupport collection
            clsCustomerSupportCollection CustomerSupportList = new clsCustomerSupportCollection();

            //set the ThisCustomerSupport property
            CustomerSupportList.ThisCustomerSupport = AnCustomerSupport;

            //add the new record
            CustomerSupportList.Add();

            //redirect back to the list page
            Response.Redirect("CustomerSupportList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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