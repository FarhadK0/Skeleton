using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PurchaseLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create and instance of the piano user clas
        clsPurchaseUser anUser = new clsPurchaseUser();

        //create the vars to store the user entered username & password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;

        //create a variable to store results for the find user operation
        Boolean Found = false;

        //convert un and pw to string just in case
        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);

        //find the record
        Found = anUser.FindUser(Username, Password);

        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record error
            lblError.Text = "Please Input your Username";
        }
        else if (txtPassword.Text == "")
        {
            //record error
            lblError.Text = "Please Input your Password";
        }
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("PurchasesList.aspx");
        }
        else if (Found == false)
        {
            //record error
            lblError.Text = "Your Login details are incorrect; Please Try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}