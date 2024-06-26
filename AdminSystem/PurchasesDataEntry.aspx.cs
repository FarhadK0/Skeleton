﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with pag level scope
    Int32 PurchaseId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the Purchase to be processed
        PurchaseId = Convert.ToInt32(Session["PurchaseId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (PurchaseId != -1)
            {
                //Display the current data for the record
                DisplayPurchase();
            }
        }

    }

     protected void DisplayPurchase()
    {
        //Create an instance of the Purchase Book
        clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

        //Find the record to update
        AllPurchases.ThisPurchase.Find(PurchaseId);

        //Display the data for the record
        txtPurchaseId.Text = AllPurchases.ThisPurchase.PurchaseId.ToString();
        txtCustomerName.Text = AllPurchases.ThisPurchase.CustomerName;
        txtDeliveryOptions.Text = AllPurchases.ThisPurchase.DeliveryOptions;
        txtProductPrice.Text = AllPurchases.ThisPurchase.ProductPrice.ToString();
        txtQuantity.Text = AllPurchases.ThisPurchase.Quantity.ToString();
        txtOrderDate.Text = AllPurchases.ThisPurchase.OrderDate.ToString();
        txtTotalAmount.Text = AllPurchases.ThisPurchase.TotalAmount.ToString();
        chkOrderConfirmed.Checked = AllPurchases.ThisPurchase.OrderConfirmed;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsPurchases
        clsPurchases APurchase = new clsPurchases();

        //Capture the attributes
        string CustomerName = txtCustomerName.Text;
        string DeliveryOptions = txtDeliveryOptions.Text;
        string ProductPrice = txtProductPrice.Text;
        string Quantity = txtQuantity.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string OrderConfirmed = chkOrderConfirmed.Text;

        //Variable to store any error messages
        string Error = "";

        //Validate the data
        Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

        if (Error == "")
        {
            //Capture the attributes 2
            APurchase.PurchaseId = PurchaseId;
            APurchase.CustomerName = CustomerName;
            APurchase.DeliveryOptions = DeliveryOptions;
            APurchase.ProductPrice = Convert.ToDouble(ProductPrice);
            APurchase.Quantity = Convert.ToInt32(Quantity);
            APurchase.OrderDate = Convert.ToDateTime(OrderDate);
            APurchase.TotalAmount = Convert.ToDouble(TotalAmount);
            APurchase.OrderConfirmed = chkOrderConfirmed.Checked;

            //New instance created
            clsPurchasesCollection PurchaseList = new clsPurchasesCollection();

            //If this is a new record
            if (PurchaseId == -1)
            {
                //ThisPurchase property set
                PurchaseList.ThisPurchase = APurchase;

                //New record added
                PurchaseList.Add();
            }
            else
            {
                //Find ThisPurchase record to update
                PurchaseList.ThisPurchase.Find(PurchaseId);

                //ThisPurchase property set
                PurchaseList.ThisPurchase = APurchase;

                //Update the record
                PurchaseList.Update();
            }

            //Navigate to the list page
            Response.Redirect("PurchasesList.aspx");
        }
        else
        {
            //Display the error message
            lblError.Text = Error;
        } 
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("PurchasesList.aspx");
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

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //Redirect to the data entry page
        Response.Redirect("TeamMainMenu.aspx");
    }
}
