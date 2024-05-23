using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PianoLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create and instance of the piano user clas
        clsPianoUser anUser = new clsPianoUser();
        //create the vars to store the user entered username & password
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        //create a variable to store results for the find user operation
        Boolean Found = false;
        //convert un and pw to string just in case
        username = Convert.ToString(txtUsername.Text);
        password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = anUser.FindUser(username, password);

        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record error
            lblError.Text = "No username detected";
        }
        else if (txtPassword.Text == "")
        {
            //record error
            lblError.Text = "No password detected";
        }
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("PianoList.aspx");
        }
        else if (Found == false)
        {
            //record error
            lblError.Text = "Login details are incorrect; Try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}