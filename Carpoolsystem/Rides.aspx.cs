using System;
using System.Data.SqlClient;

namespace Carpoolsystem
{
    public partial class WebForm3: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddRide_Click(object sender, EventArgs e)
        {
            string origin = Origin.Text;
            string destination = Destination.Text;
            DateTime departureTime = Convert.ToDateTime(DepartureTime.Text);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Rides (Origin, Destination, DepartureTime, DriverId) VALUES (@Origin, @Destination, @DepartureTime, @DriverId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Origin", origin);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@DepartureTime", departureTime);
                    command.Parameters.AddWithValue("@DriverId", 1); // Replace with the actual driver's ID

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ltlResult.Text = "Ride added successfully!";
                        ClearInputs();
                    }
                    else
                    {
                        ltlResult.Text = "Failed to add ride.";
                    }
                }
            }
        }
        protected void calDepartureTime_SelectionChanged(object sender, EventArgs e)
        {
            DepartureTime.Text = calDepartureTime.SelectedDate.ToString();
            calDepartureTime.Visible = false;
        }
        private void ClearInputs()
        {
            Origin.Text = string.Empty;
            Destination.Text = string.Empty;
            DepartureTime.Text = string.Empty;
        }
    }
}

