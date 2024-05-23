using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //var to store pk of the record to be deleted
    Int32 PianoId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        PianoId = Convert.ToInt32(Session["PianoId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //new instance of the piano collection
        clsPianoCollection allPianos = new clsPianoCollection();
        //find the record to delete
        allPianos.ThisPiano.Find(PianoId);
        //delete the record
        allPianos.Delete();
        //redirect back to main page
        Response.Redirect("PianoList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //simlpy head back to the piano list
        Response.Redirect("PianoList.aspx");
    }
}