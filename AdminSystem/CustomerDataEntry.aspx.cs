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
        //capture the CustomerName
        string CustomerName = txtName.Text;
        //capture the CustomerEmail
        string CustomerEmail = txtEamil.Text;
        //capture the CustomerPhone
        string CustomerPhone = txtPhone.Text;
        //capture the CustomerAddress
        string CustomerAddress = txtAddress.Text;
        //capture the Dateofbirth
        string Dateofbirth = txtDateofbirth.Text;
        //capture the hasPurcahse
        string hasPurchases = chkhasPurchases.Text;
        //variable to store any error message 
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
        if (Error == "")
        {


            //capture the CustomerName
            AnCustomer.CustomerName = txtName.Text;
            //capture the CustomerEmail
            AnCustomer.CustomerEmail = txtEamil.Text;
            //capture the CustomerPhone
            AnCustomer.CustomerPhone = txtPhone.Text;
            //capture the CustomerAddress
            AnCustomer.CustomerAddress = txtAddress.Text;
            //capture the Dateofbirth
            AnCustomer.Dateofbirth = Convert.ToDateTime(DateTime.Now);
            // store the customer in the sesion objrct
            Session["AnCustomer"] = AnCustomer;
            //navegate to view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
