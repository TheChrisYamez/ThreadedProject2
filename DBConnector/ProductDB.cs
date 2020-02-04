using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class ProductDB
    {
        /// <summary>
        /// Gets all packages from the database and returns a list of package objects
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            string command = "SELECT ProductId,ProdName From Products";

            SqlConnection con = TravelExpertsConnection.GetConnection();

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (read.Read())
                {

                    Product product = new Product()
                    {
                        ProductID = (int)read["ProductId"],
                        ProdName = (string)read["ProdName"],
                    };

                    products.Add(product);
                } //close while
            } // close command
            return products;
        }
    }
}
