using System;
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

        //create a new instance of the clsPianoUser
        clsPianoUser anUser = new clsPianoUser();
        //obtain data from the session object
        anUser = (clsPianoUser)Session["anUser"];
        //display the username
        Response.Write("Logged in as: " + anUser.UserName);
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

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an isnatnce of the piano list
        clsPianoCollection allPianos = new clsPianoCollection();
        //retrieve the value of the serial number from the textbox
        allPianos.ReportByModelName(txtFilterByModelName.Text);
        //set the data source to list of pianos in the collection
        lstPianoList.DataSource = allPianos.PianoList;
        //set hte name of the pk
        lstPianoList.DataValueField = "PianoId";
        //set the data field to display
        lstPianoList.DataTextField = "ModelName";
        //bind the data to the list
        lstPianoList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {

        //create an isnatnce of the piano list
        clsPianoCollection allPianos = new clsPianoCollection();
        //retrieve the value of the serial number from the textbox
        allPianos.ReportByModelName("");
        //set the data source to list of pianos in the collection
        lstPianoList.DataSource = allPianos.PianoList;
        //set hte name of the pk
        lstPianoList.DataValueField = "PianoId";
        //set the data field to display
        lstPianoList.DataTextField = "ModelName";
        //bind the data to the list
        lstPianoList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //return to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}