using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public static class TravelExpertsDB
    {
            public static SqlConnection GetConnection()
            {
                string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                return con;
            }
        }
    }

