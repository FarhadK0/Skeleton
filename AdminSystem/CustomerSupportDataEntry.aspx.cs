using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 TicketID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the ticket to be processed
        TicketID = Convert.ToInt32(Session["TicketID"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (TicketID !=-1)
            {
                //display the current data for the record
                DisplayCustomerSupport();
            }
        }
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
            //capture the ticket id
            AnCustomerSupport.TicketID = TicketID;

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

            //if this is a new record i.e TicketID = -1 then add the data
            if (TicketID == -1)
            {
                //set the ThisCustomerSupport property
                CustomerSupportList.ThisCustomerSupport = AnCustomerSupport;

                //add the new record
                CustomerSupportList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerSupportList.ThisCustomerSupport.Find(TicketID);

                //set the ThisCustomerSupport property
                CustomerSupportList.ThisCustomerSupport = AnCustomerSupport;

                //update the record
                CustomerSupportList.Update();
            }

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

    protected void DisplayCustomerSupport()
    {
        //create an instance of the customersupport
        clsCustomerSupportCollection CustomerSupport = new clsCustomerSupportCollection();

        //find the record to update
        CustomerSupport.ThisCustomerSupport.Find(TicketID); 

        //display the data for the record
        txtTicketID.Text = CustomerSupport.ThisCustomerSupport.TicketID.ToString();
        txtTicketType.Text = CustomerSupport.ThisCustomerSupport.TicketType;
        txtSubject.Text = CustomerSupport.ThisCustomerSupport.Subject;
        txtDescription.Text = CustomerSupport.ThisCustomerSupport.Description;
        txtSubmissionDate.Text = CustomerSupport.ThisCustomerSupport.SubmissionDate.ToString();
        txtTicketStatus.Text = CustomerSupport.ThisCustomerSupport.TicketStatus;
        chkTicketElevated.Checked = CustomerSupport.ThisCustomerSupport.TicketElevated;

    }
}