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
        string StaffId = txtStaffId.Text;
        //capture the staff name
        string StaffName = txtStaffName.Text;
        //captures the staff email
        string StaffEmail = txtStaffEmail.Text;
        //captures the date of birth
        string StaffRegisterDate = txtStaffRegisterDate.Text;
        //captures the staff Address
        string StaffAddress = txtStaffAddress.Text;
        //captures the Staff Age
        string StaffAge = txtStaffAge.Text;
        //captures the Is manager? check box
        string IsManager = chkIsManager.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffName, StaffEmail, StaffRegisterDate, StaffAddress, StaffAge);
        if (Error == "")
        {
            //capture the staff Id
            AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
            //capture the Staff name
            AStaff.StaffName = StaffName;
            //captures the staff email
            AStaff.StaffEmail = StaffEmail;
            //captures the date of birth
            AStaff.StaffRegisterDate = Convert.ToDateTime(StaffRegisterDate);
            //captures the staff Address
            AStaff.StaffAddress = StaffAddress;
            //captures the Staff Age
            AStaff.StaffAge = Convert.ToInt32(StaffAge);
            //captre the Is manager
            AStaff.IsManager = chkIsManager.Checked;
            //create a new instance for the Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaff property
            StaffList.ThisStaff = AStaff;
            //add the new record 
            Response.Redirect("StaffList.aspx");


        }
        else
        {
            //display the error Message
            lblError.Text = Error;
        }


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
            txtStaffRegisterDate.Text = AStaff.StaffRegisterDate.ToString();
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffAge.Text = AStaff.StaffAge.ToString();
            txtStaffName.Text = AStaff.StaffName;
            chkIsManager.Checked = AStaff.IsManager;




        }


    }
    }