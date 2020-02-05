using System;
using System.Collections.Generic;
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
            string selectStatement = "SELECT s.SupplierID, s.SupName, p.ProdName, p.ProductID  " +
                                         "FROM Suppliers s " +
                                         "INNER JOIN Products_Suppliers ps " +
                                         "on s.SupplierID = ps.SupplierID " +
                                         "INNER JOIN Products p " +
                                         "on ps.ProductID = p.ProductID ";
                                         
            SqlCommand cmd = new SqlCommand(selectStatement, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) // while there are suppliers
                    {
                        sup = new Supplier();
                    sup.ProductID = (int)reader["ProductID"];
                    sup.SupplierID = (int)reader["SupplierID"];
                    sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
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
            public static List<Supplier> GetSupplier(int productID)
            {
            List<Supplier> suppliers = new List<Supplier>();

            Supplier sup = null;
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectStatement = "SELECT s.SupplierID, s.SupName, p.ProdName, p.ProductID  " +
                                         "FROM Suppliers s " +
                                         "INNER JOIN Products_Suppliers ps " +
                                         "on s.SupplierID = ps.SupplierID " +
                                         "INNER JOIN Products p " +
                                         "on ps.ProductID = p.ProductID " +
                                         "WHERE p.ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(selectStatement, con);
                cmd.Parameters.AddWithValue("@ProductID", productID); // value comes from the method's argument
                try
                {
                //add while loop in list form
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read()) // found a supplier
                {
                    sup = new Supplier();
                    sup.ProductID = (int)reader["ProductID"];

                    sup.SupplierID = (int)reader["SupplierID"];
                    sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
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
        }
    }

