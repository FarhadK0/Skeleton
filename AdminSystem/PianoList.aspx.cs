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
}