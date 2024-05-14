using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

    }



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

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
}