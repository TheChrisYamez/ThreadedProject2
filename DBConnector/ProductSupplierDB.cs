using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
  public class ProductSupplierDB
    {


                    public static List<ProductSupplier> GetAllProductSuppliers()
            {
                List<ProductSupplier> productsuppliers = new List<ProductSupplier>();
                ProductSupplier prodsup = null;
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID " +
                                         "FROM Products_Suppliers " +
                                         "ORDER BY ProductSupplierID";
                SqlCommand cmd = new SqlCommand(selectStatement, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) // while there are customers
                    {
                        prodsup = new ProductSupplier();
                        prodsup.ProductSupplierID = (int)reader["ProductSupplierID"];
                        prodsup.ProductID = (int)reader["ProductID"];
                        prodsup.SupplierID = (int)reader["SupplierID"];

                    productsuppliers.Add(prodsup);
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
                return productsuppliers;
            }
            public static ProductSupplier GetProductSupplier(int productsupplierID)
            {
                ProductSupplier prodsup = null;
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID " +
                                         "FROM Products_Suppliers " +
                                         "WHERE ProductSupplierID = @ProductSupplierID";
                SqlCommand cmd = new SqlCommand(selectStatement, con);
                cmd.Parameters.AddWithValue("@ProductSupplierID", productsupplierID); // value comes from the method's argument
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read()) // found a customer
                    {
                        prodsup = new ProductSupplier();
                        prodsup.ProductSupplierID = (int)reader["ProductSupplierID"];
                        prodsup.ProductID = (int)reader["ProductID"];
                        prodsup.SupplierID = (int)reader["SupplierID"];
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
            return prodsup;
            }


            public static int AddProductSupplier(ProductSupplier prodsup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
                string insertStatement = "INSERT INTO Products_Suppliers (ProductSupplierID, ProductID, SupplierID) " +
                                         "VALUES(@ProductSupplierID, @ProductID, @SupplierID)";
                SqlCommand cmd = new SqlCommand(insertStatement, con);
                cmd.Parameters.AddWithValue("@ProductSupplierID", prodsup.ProductSupplierID);
                cmd.Parameters.AddWithValue("@ProductID", prodsup.ProductID);
               cmd.Parameters.AddWithValue("@SupplierID", prodsup.SupplierID);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); // run the insert command
                                           // get the generated ID - current identity value for  Products_Suppliers table
                    string selectQuery = "SELECT IDENT_CURRENT('ProductSuppliers') FROM Products_Suppliers";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    int productsupplierID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                                 // typecase (int) does NOT work!
                    return productsupplierID;
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

            public static bool DeleteProductSupplier(ProductSupplier prodsup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
                string deleteStatement = "DELETE FROM Products_Suppliers " +
                                         "WHERE ProductSupplierID = @ProductSupplierID " + // to identify the supplier to be  deleted
                                         "AND ProductID = @ProductID " +
                                         "AND SupplierID = @SupplierID "; // remaining conditions - to ensure optimistic concurrency

                SqlCommand cmd = new SqlCommand(deleteStatement, con);
                cmd.Parameters.AddWithValue("@ProductSupplierID", prodsup.ProductSupplierID);
            cmd.Parameters.AddWithValue("@ProductID", prodsup.ProductID);

            cmd.Parameters.AddWithValue("@SupplierID", prodsup.SupplierID);

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


            public static bool UpdateSupplier(ProductSupplier oldProdSup, ProductSupplier newProdSup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers " +
                                     "SET ProductSupplierID = @NewProductSupplierID, " +
                                     "    ProductID = @NewProductID, " +
                                     "    SupplierID = @NewSupplierID " +
                                     "WHERE ProductSupplierID = @OldProductSupplierID " +
                                     "AND ProductID = @OldProductID " +
                                     "AND SupplierID = @OldSupplierID ";
                SqlCommand cmd = new SqlCommand(updateStatement, con);
                cmd.Parameters.AddWithValue("@NewProductSupplierID", newProdSup.ProductSupplierID);
                cmd.Parameters.AddWithValue("@NewProductID", newProdSup.ProductID);
                cmd.Parameters.AddWithValue("@NewSupplierID", newProdSup.SupplierID);
                cmd.Parameters.AddWithValue("@OldProductSupplierID", oldProdSup.ProductSupplierID);
                cmd.Parameters.AddWithValue("@OldProductID", oldProdSup.ProductID);
                cmd.Parameters.AddWithValue("@OldSupplierID", oldProdSup.SupplierID);
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

        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            List<ProductSupplier> productsuppliers = new List<ProductSupplier>();
            ProductSupplier prodsup = null;

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productsuppliers;

        }
    }
