using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Carpoolsystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve session variables
                string rideOrigin = (string)Session["RideOrigin"];
                string rideDestination = (string)Session["RideDestination"];
                DateTime rideDepartureDate = (DateTime)Session["RideDepartureDate"];

                // Populate labels with retrieved values
                lblOrigin.Text = rideOrigin;
                lblDestination.Text = rideDestination;
                lblDepartureDate.Text = rideDepartureDate.ToString("yyyy-MM-dd");
            }
        }
        protected void btnAdminRide_Click(object sender, EventArgs e)
        {
            Session["RideUserName"] = txtUserName.Text;
            Session["RideEmail"] = txtEmail.Text;
            Session["RideOrigin"] = lblOrigin.Text;
            Session["RideDestination"] = lblDestination.Text;
            DateTime rideDepartureDate = Convert.ToDateTime(Session["RideDepartureDate"]);



            Response.Redirect("AdminRide.aspx");
        }

    }
}