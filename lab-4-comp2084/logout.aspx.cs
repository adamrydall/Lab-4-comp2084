using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_4_comp2084
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kill the session
            Session["InstructorID"] = null;
            Session.Abandon();

            //redirect to default
            Response.Redirect("default.aspx");
        }
    }
}