using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    /// <summary>
    /// A static class for a connection string to the TravelExperts Database in SQL
    /// </summary>
    public class TravelExpertsConnection
    {
        /// <summary>
        /// Gets a SqlConnection to the travelexperts DB
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            //connection string to travelexperts
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
