﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the pae is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayPianos();
        }
    }

    private void DisplayPianos()
    {
        //create an instance of a piano list
        clsPianoCollection Pianos = new clsPianoCollection();
        //set the data source to list of pianos in the collection
        lstPianoList.DataSource = Pianos.PianoList;
        //set hte name of the pk
        lstPianoList.DataValueField = "PianoId";
        //set the data field to display
        lstPianoList.DataTextField = "ModelName";
        //bind the data to the list
        lstPianoList.DataBind();
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //store -1 into session object to indicate this is a new record
        Session["PianoId"] = -1;
        //Redirect to DataEntry Page
        Response.Redirect("PianoDataEntry.aspx");
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //PK of the record to be edited
        Int32 PianoId;
        //if a record has been selected from the list
        if (lstPianoList.SelectedIndex != -1)
        {
            //get PK of the record to edit
            PianoId = Convert.ToInt32(lstPianoList.SelectedValue);
            //store the data in session object
            Session["PianoId"] = PianoId;
            //Redirect to edit page
            Response.Redirect("PianoDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //PK of the record to be edited
        Int32 PianoId;
        //if a record has been selected from the list
        if (lstPianoList.SelectedIndex != -1)
        {
            //get PK of the record to edit
            PianoId = Convert.ToInt32(lstPianoList.SelectedValue);
            //store the data in session object
            Session["PianoId"] = PianoId;
            //Redirect to edit page
            Response.Redirect("PianoConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}