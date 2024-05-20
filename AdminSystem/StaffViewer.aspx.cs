using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff Id for this entry 
        Response.Write(AStaff.StaffId + "<br />");
        //display the staff name for this entry 
        Response.Write(AStaff.StaffName + "<br />");
        //display the staff emial for this entry
        Response.Write(AStaff.StaffEmail + "<br />");
        //display the date of birth for this entry 
        Response.Write(AStaff.StaffRegisterDate + "<br />" );
        //display the Staff Address
        Response.Write(AStaff.StaffAddress + "<br />");
        //display the staff Age
        Response.Write(AStaff.StaffAge + "<br />");
        //display true or false for is mananger
        Response.Write(AStaff.IsManager + "<br />");

    }
}