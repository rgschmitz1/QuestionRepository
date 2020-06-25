using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TCSS445_Final_Project
{
    static class SqlManager
    {
        //private static string connectionString = ConfigurationManager.ConnectionStrings["TCSS445_Final_Project.Properties.Settings.Schmitz_Bob_dbConnectionString"].ConnectionString;

        // Internal helper method to connect to Sql Sever database
        private static SqlConnection connect()
        {
            // Created a temporary Azure SQL Server for this project.
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "schmitz-bob-tcss445.database.windows.net";
            builder.UserID = "rgs1";
            builder.Password = "fvhcDoWkOXGFCJNRl59E";
            builder.InitialCatalog = "Schmitz_Bob_db";

            return new SqlConnection(builder.ConnectionString);
            //return new SqlConnection(connectionString);
        }

        // Returns query result as datatable for easier parsing
        public static DataTable query(string theQuery)
        {
            // Open database connection
            SqlConnection cnn = connect();
            cnn.Open();

            SqlCommand cmd = new SqlCommand(theQuery, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatable = new DataTable();

            // Populate datatable
            datatable.Load(reader);

            // Clean-up
            reader.Close();
            cnn.Close();

            return datatable;
        }

        // Inserts data into table
        public static bool insert(string theQuery)
        {
            SqlConnection cnn = connect();
            cnn.Open();

            SqlCommand cmd = new SqlCommand(theQuery, cnn);
            var cnt = cmd.ExecuteNonQuery();

            cnn.Close();

            return (cnt == 0) ? false : true;
        }

        public static bool update(string theQuery)
        {
            return insert(theQuery);
        }
    }
}
