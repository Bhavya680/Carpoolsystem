using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Carpoolsystem
{
    public partial class AdminRide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Fetch ride details from Session (set these in About.aspx)
                string rideOrigin = Session["RideOrigin"] as string;
                string rideDestination = Session["RideDestination"] as string;
                string rideUserName = Session["RideUserName"] as string;
                string rideEmail = Session["RideEmail"] as string;

                // Handle DepartureTime using TryParse
                DateTime rideDepartureTime;
                if (!DateTime.TryParse(Session["RideDepartureDate"].ToString(), out rideDepartureTime))
                {
                    // Handle the case when parsing DepartureTime fails
                    // For example, set a default value or display an error message
                    // You can also redirect to an error page
                    return;
                }

                if (!string.IsNullOrEmpty(rideOrigin) && !string.IsNullOrEmpty(rideDestination))
                {
                    // Store ride details in the database
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True";
                    if (rideDepartureTime >= SqlDateTime.MinValue.Value && rideDepartureTime <= SqlDateTime.MaxValue.Value)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string insertQuery = "INSERT INTO ARides (Origin, Destination, UserName, Email, DepartureTime) VALUES (@Origin, @Destination, @UserName, @Email, @DepartureTime)";

                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Origin", rideOrigin);
                                command.Parameters.AddWithValue("@Destination", rideDestination);
                                command.Parameters.AddWithValue("@UserName", rideUserName);
                                command.Parameters.AddWithValue("@Email", rideEmail);
                                command.Parameters.AddWithValue("@DepartureTime", rideDepartureTime);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
