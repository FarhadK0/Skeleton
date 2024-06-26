﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Staff to be deleted from the session object 
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the staff book collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //delete the record 
        StaffBook.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");



    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");

    }


}