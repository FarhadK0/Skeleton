﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{ 
    // variable to store the primary key value of the record to deleted
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create a new instance of the customer book collection class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        // find the record to delete 
        CustomerBook.ThisCustomer.Find(CustomerID);
        // delete the record
        CustomerBook.Delete();
        //redirect back to the main page 
        Response.Redirect("CustomerList.aspx");
    }


    protected void btnNO_Click(object sender, EventArgs e)
    {
        //redirect back to the main page 
        Response.Redirect("CustomerList.aspx");
    }
}