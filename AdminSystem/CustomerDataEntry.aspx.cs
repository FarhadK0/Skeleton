using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is the not new record
            if (CustomerID != -1)
            {
                //display the current data for record
                DisplayCustomer();
            }
        }



    }
    void DisplayCustomer()
    {
        // create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the recor to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for the record
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtName.Text = CustomerBook.ThisCustomer.CustomerName.ToString();
        txtEamil.Text = CustomerBook.ThisCustomer.CustomerEmail.ToString();
        txtPhone.Text = CustomerBook.ThisCustomer.CustomerPhone.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.CustomerAddress.ToString();
        txtDateofbirth.Text = CustomerBook.ThisCustomer.Dateofbirth.ToString();
        chkhasPurchases.Checked = CustomerBook.ThisCustomer.hasPurchases;
    }

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
            AnCustomer.CustomerID = CustomerID;
            //capture the CustomerName
            AnCustomer.CustomerName = CustomerName;
            //capture the CustomerEmail
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture the CustomerPhone
            AnCustomer.CustomerPhone = CustomerPhone;
            //capture the CustomerAddress
            AnCustomer.CustomerAddress = CustomerAddress;
            //capture the Dateofbirth
            AnCustomer.Dateofbirth = Convert.ToDateTime(Dateofbirth);
            // capture hasPurchases
            AnCustomer.hasPurchases = chkhasPurchases.Checked;
            //create a new instance of the the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            // if this is a new record i.e CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //Update record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
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
            txtCustomerID.Text =AnCustomer.CustomerID.ToString();
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
