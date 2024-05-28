using System;
using System.Collections.Generic;
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
        if(IsPostBack == false)
        {
            //update the list box 
            DisplayStaffs();
        }
        //create a new instance of clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from the session object 
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);


    }

    void DisplayStaffs()
    {
        //create an instance of the staff collection 
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of staffs in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key 
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list 
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 StaffId;
        //if a record has been selected from the list 
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the data entry page
            Response.Redirect("StaffDataEntry.aspx");


        }
        else  //if no record has been selected 
        {
            //display error message
            lblError.Text = "Please select a record from the list to edit";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 StaffId;
        //if a record has been selected from the list 
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the data delete page
            Response.Redirect("StaffConfirmDelete.aspx");


        }
        else  //if no record has been selected 
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the staff object
        clsStaffCollection AStaff = new clsStaffCollection();
        //retrieve the value of staff address from the presentation layer 
        AStaff.ReportByStaffAddress(txtFilter.Text);
        //set the data source to the list of staffs in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffAddress";
        //bind the data to the list 
        lstStaffList.DataBind();
    }



    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the staff object
        clsStaffCollection AStaff = new clsStaffCollection();
        //set an empty string
        AStaff.ReportByStaffAddress("");
        //clear any existing filter to tidy up the interface 
        txtFilter.Text = "";
        //set the data source to the list of staffs in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffAddress";
        //bind the data to the list 
        lstStaffList.DataBind();
    }



    protected void btnMain_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}