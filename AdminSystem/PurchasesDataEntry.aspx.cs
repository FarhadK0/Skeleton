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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsPurchases
        clsPurchases APurchase = new clsPurchases();

        //Capture a PurchaseId
        APurchase.PurchaseId = Convert.ToInt32(txtPurchaseId.Text);

        //Capture a CustomerName
        APurchase.CustomerName = txtCustomerName.Text;

        //Capture a DeliveryOptions
        APurchase.DeliveryOptions = txtDeliveryOptions.Text;

        //Capture a ProductPrice
        APurchase.ProductPrice = Convert.ToDouble(txtProductPrice.Text);

        //Capture a Quantity
        APurchase.Quantity = Convert.ToInt32(txtQuantity.Text);

        //Capture a OrderDate
        APurchase.OrderDate = Convert.ToDateTime(DateTime.Now);

        //Capture a TotalAmount
        APurchase.TotalAmount = Convert.ToDouble(txtTotalAmount.Text);

        //Capture a Checkbox
        APurchase.OrderConfirmed = chkOrderConfirmed.Checked;

        //Store a Purchase in the session object
        Session["APurchase"] = APurchase;

        //Navigate to the view page
        Response.Redirect("PurchasesViewer.aspx");
    }

    protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the Purchase Class
        clsPurchases APurchase = new clsPurchases();

        //create a variable to store the primary key
        Int32 PurchaseId;

        //Create a variable to store the result of the find operation
        Boolean Found = false;

        //Get the primary key entered by the user
        PurchaseId = Convert.ToInt32(txtPurchaseId.Text);

        //Find the record
        Found = APurchase.Find(PurchaseId);

        //If Found
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtCustomerName.Text = APurchase.CustomerName;
            txtDeliveryOptions.Text = APurchase.DeliveryOptions;
            txtProductPrice.Text = APurchase.ProductPrice.ToString();
            txtQuantity.Text = APurchase.Quantity.ToString();
            txtOrderDate.Text = APurchase.OrderDate.ToString();
            txtTotalAmount.Text = APurchase.TotalAmount.ToString();
            chkOrderConfirmed.Checked = APurchase.OrderConfirmed;
        }
    }
}
