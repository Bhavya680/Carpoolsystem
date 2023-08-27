using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Carpoolsystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string table_name = "Register";
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True");

        public GridView GridView1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string emailId = this.EmailID.Text;
            string password = this.password.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();
                string query = $"INSERT INTO {table_name} (Username, EmailId, Password) VALUES (@Username, @EmailId, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@EmailId", SqlDbType.NVarChar).Value = emailId;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                    cmd.ExecuteNonQuery();
                }
            }
           
        }
       /*
        public void Display_data(string tableName, GridView gd)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Carpoolsystem\Carpoolsystem\App_Data\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();
                string query = $"SELECT * FROM {tableName}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    gd.DataSource = gd dataTable;
                    gd.DataBind();
                   
                }
            }
        }*/
        /* public void Display_data(String td, GridView gd)
         {
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandType = System.Data.CommandType.Text;
             cmd.CommandText = $"select * from {td}";
             cmd.ExecuteNonQuery();
             DataTable dataTable = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dataTable);
             gd.DataSource = dataTable;
             gd.DataBind();
         }*/
    }
}