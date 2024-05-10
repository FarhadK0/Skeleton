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
        APurchase.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);

        //Capture a Quantity
        APurchase.Quantity = Convert.ToInt32(txtQuantity.Text);

        //Capture a OrderDate
        APurchase.OrderDate = Convert.ToDateTime(DateTime.Now);

        //Capture a TotalAmount
        APurchase.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);

        //Store a Purchase in the session object
        Session["APurchase"] = APurchase;

        //Navigate to the view page
        Response.Redirect("PurchasesViewer.aspx");
    }
}