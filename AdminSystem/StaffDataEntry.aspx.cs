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

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffId_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //caputres the staff Id
        AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        //captures the staff email
        AStaff.StaffEmail = txtStaffEmail.Text;
        //captures the date of birth
        AStaff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //captures the staff Address
        AStaff.StaffAddress = txtStaffAddress.Text;
        //captures the Staff Age
        AStaff.StaffAge = Convert.ToInt32(txtStaffAge.Text);
        //captures the Is manager? check box
        AStaff.IsManager = chkIsManager.Checked;
        //store the name in the session object
        Session["AStaff"] = AStaff;
        //navigates to the view page
        Response.Redirect("StaffViewer.aspx");
    }



    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key 
        Int32 StaffId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the priamary key entered by the user 
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record 
        Found = AStaff.Find(StaffId);
        //if found 
        if (Found == true)
        {
            //display the values of the propertiesin the form 
            txtStaffName.Text = AStaff.StaffName;
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffAge.Text = AStaff.StaffAge.ToString();
            txtStaffName.Text = AStaff.StaffName;
            chkIsManager.Checked = AStaff.IsManager;




        }


    }
    }