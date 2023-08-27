using System;
using System.Data.SqlClient;

namespace Carpoolsystem
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string origin = txtOrigin.Text;
            string destination = txtDestination.Text;
            DateTime departureTime = calDepartureTime.SelectedDate;
            Response.Write("Search button clicked");
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();  

                string query = "SELECT COUNT(*) FROM Rides WHERE Origin = @Origin AND Destination = @Destination AND DepartureTime = @DepartureTime";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Origin", origin);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@DepartureTime", departureTime);

                    int rideCount = Convert.ToInt32(command.ExecuteScalar());

                    if (rideCount > 0)
                    {
                        divSearchResultBox.Visible = true;
                        lblNotAvailable.Visible = false;
                    }
                    else
                    {
                        divSearchResultBox.Visible = false;
                        lblNotAvailable.Visible = true;
                    }
                }
            }
            
                Session["RideOrigin"] = origin;
                Session["RideDestination"] = destination;
            Session["RideDepartureDate"] = departureTime;

        }   

        protected void btnCreateRide_Click(object sender, EventArgs e)
        {

        Response.Redirect("CreateMyRide.aspx");
        }
    }
}
