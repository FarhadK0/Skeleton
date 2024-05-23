using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerSupportLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the CustomerSupport User Class
        clsCustomerSupportUser AnUser = new clsCustomerSupportUser();

        //create the variabels tp store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        //create a varibale to store the result of the user operation
        Boolean Found = false;

        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);

        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);

        //find the record 
        Found = AnUser.FindUser(UserName, Password);

        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter the Username";

        }

        
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter the Password";
        }

        //if record found
        else if (Found == true)
            {
            //redirect to the list Page
            Response.Redirect("CustomerSupportList.aspx");
        }

        else if (Found ==  false) 
        {
            //record the error
            lblError.Text = "Login Details are Incorrect. Please try again";
        }
                
    }
}