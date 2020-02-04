using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class ProductDB
    {

    public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            Product prod = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "FROM Products " +
                                     "ORDER BY ProductID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are customers
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return products;
        }
        public static Product GetProduct(int productID)
        {
            Product prod = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "FROM Orders " +
                                     "WHERE OrderID = @OrderID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@OrderID", productID); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a customer
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return prod;
        }

        /// <summary>
        /// Adds a new customer to the Customers table in MMABooks database
        /// </summary>
        /// <param name="cust"> Customer object that cotaing data for the new record</param>
        /// <returns>generated CustomerID</returns>
        public static int AddProduct(Product prod)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string insertStatement = "INSERT INTO Products (ProductID, ProdName) " +
                                     "VALUES(@ProductID, @ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                // get the generated ID - current identity value for  Customers table
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int productID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                             // typecase (int) does NOT work!
                return productID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool DeleteProduct(Product prod)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductID = @ProductID " + // to identify the customer to be  deleted
                                     "AND ProdName = @ProdNAme "; // remaining conditions - to ensure optimistic concurrency
                                     
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);
           
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Updates existing customer record
        /// </summary>
        /// <param name="oldCust">data before update</param>
        /// <param name="newCust">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateProduct(Product oldProd, Product newProd)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProductID = @NewProductID, " +
                                     "    ProdName = @NewProdName, " +
                                     "WHERE ProductID = @OldProductID " +
                                     "AND ProdName = @OldProdName ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewProductID", newProd.ProductID);
            cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            cmd.Parameters.AddWithValue("@OldProductID", oldProd.ProductID);
            cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
