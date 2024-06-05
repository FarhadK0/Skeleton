using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerBookingLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the customer users class
        clsCustomerUser AnUser = new clsCustomerUser();
        //create the variables to store the usernmae and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the userName entered by User
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        if (txtUserName.Text == "") 
        {
            //record the error
            lblError.Text = "Enter a Username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the List Page
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found ==false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }
}