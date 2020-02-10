using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class SupplierDB
    {

            public static List<Supplier> GetAllSuppliers()
            {
                List<Supplier> suppliers = new List<Supplier>();
                Supplier sup = null;
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectStatement = "SELECT SupplierID, SupName " +
                                         "FROM Suppliers " +
                                         "ORDER BY SupplierID";
                SqlCommand cmd = new SqlCommand(selectStatement, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) // while there are customers
                    {
                        sup = new Supplier();
                        sup.SupplierID = (int)reader["SupplierID"];
                        sup.SupName = reader["SupName"].ToString();
                        suppliers.Add(sup);
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
                return suppliers;
            }
            public static Supplier GetSupplier(int supplierID)
            {
                Supplier sup = null;
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectStatement = "SELECT s.SupName, p.ProdName,  " +
                                         "FROM Suppliers s " +
                                         "INNER JOIN Products_Suppliers ps " +
                                         "on s.SupplierID = ps.ProductSupplierID " +
                                         "INNER JOIN Products p " +
                                         "on ps.ProductID = p.ProductID " +
                                         "WHERE SupplierID = @SupplierID";
                SqlCommand cmd = new SqlCommand(selectStatement, con);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID); // value comes from the method's argument
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read()) // found a supplier
                    {
                        sup = new Supplier();
                        sup.SupplierID = (int)reader["SupplierID"];
                        sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
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
                return sup;
            }

           
            public static int AddSupplier(Supplier sup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
                string insertStatement = "INSERT INTO Suppliers (SupplierID, SupName) " +
                                         "VALUES(@SupplierID, @SupName)";
                SqlCommand cmd = new SqlCommand(insertStatement, con);
                cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
                cmd.Parameters.AddWithValue("@SupName", sup.SupName);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); // run the insert command
                                           // get the generated ID - current identity value for  Customers table
                    string selectQuery = "SELECT IDENT_CURRENT('Suppliers') FROM Suppliers";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    int supplierID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                                // typecase (int) does NOT work!
                    return supplierID;
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

            public static bool DeleteSupplier(Supplier sup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
                string deleteStatement = "DELETE FROM Suppliers " +
                                         "WHERE SupplierID = @SupplierID " + // to identify the supplier to be  deleted
                                         "AND SupName = @SupName "; // remaining conditions - to ensure optimistic concurrency

                SqlCommand cmd = new SqlCommand(deleteStatement, con);
                cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
                cmd.Parameters.AddWithValue("@SupName", sup.SupName);

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

          
            public static bool UpdateSupplier(Supplier oldSup, Supplier newSup)
            {
                SqlConnection con = TravelExpertsDB.GetConnection();
                string updateStatement = "UPDATE Suppliers " +
                                         "SET SupplierID = @NewSupplierID, " +
                                         "    SupName = @NewSupName, " +
                                         "WHERE SupplierID = @OldSupplierID " +
                                         "AND SupName = @OldSupName ";
                SqlCommand cmd = new SqlCommand(updateStatement, con);
                cmd.Parameters.AddWithValue("@NewSupplierID", newSup.SupplierID);
                cmd.Parameters.AddWithValue("@NewSupName", newSup.SupName);
                cmd.Parameters.AddWithValue("@OldSupplierID", oldSup.SupplierID);
                cmd.Parameters.AddWithValue("@OldSupName", oldSup.SupName);
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
        /// <author> Brian Appleton</author>
        /// Gets all the suppliers attached to a specific product
        /// </summary>
        /// <param name="productId">the product id</param>
        /// <returns></returns>
        public static BindingList<Supplier> GetProductSuppliers(int productId)
        {
            BindingList<Supplier> suppliers = new BindingList<Supplier>();

            SqlConnection con = TravelExpertsDB.GetConnection();

            string selectStatement = "SELECT s.SupName,s.SupplierId,pr.ProdName " +
                                    "FROM Products_Suppliers as p " +
                                    "JOIN Suppliers as s " +
                                    "ON s.SupplierId = p.SupplierId " +
                                    "JOIN Products as pr " +
                                    "ON pr.ProductId = p.ProductId " +
                                    "WHERE pr.ProductID = @ProductID";


            using (SqlCommand cmd = new SqlCommand(selectStatement, con))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read()) // found a customer
                {
                    Supplier supplier = new Supplier()
                    {
                        SupName = (string)reader[0],
                        SupplierID = (int)reader[1],
                        ProdName = (string)reader[2],
                    };

                    suppliers.Add(supplier);
                }

                return suppliers;
            }
        }
    }
    }

