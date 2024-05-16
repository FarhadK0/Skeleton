using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create  a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the Name
        AnCustomer.CustomerName = txtName.Text;
        AnCustomer.CustomerEmail = txtEamil.Text;
        AnCustomer.CustomerPhone = txtPhone.Text;
        AnCustomer.CustomerAddress = txtAddress.Text;
        AnCustomer.Dateofbirth = Convert.ToDateTime(DateTime.Now);
        // store the customer in the sesion objrct
        Session["AnCustomer"] = AnCustomer;
        //navegate to view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an intance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key 
        Int32 CustomerID;
        //Create a variable to store result of the find opertation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Find the record
        Found = AnCustomer.Find(CustomerID);
        // if found
        if (Found == true)
        {
            //display yhe value of the properties in the form
            txtName.Text = AnCustomer.CustomerName;
            txtEamil.Text = AnCustomer.CustomerEmail;
            txtPhone.Text = AnCustomer.CustomerPhone; 
            txtAddress.Text = AnCustomer.CustomerAddress;
            txtDateofbirth.Text = AnCustomer.Dateofbirth.ToString();
            chkhasPurchases.Checked = AnCustomer.hasPurchases;

        }
    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }
}
