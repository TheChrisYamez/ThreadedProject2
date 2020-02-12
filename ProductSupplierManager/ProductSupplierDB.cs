using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductSupplierManager
{
    class ProductSupplierDB
    {
        public  static List<ProductSupplier> GetAllProductSuppliers()
        {
            List<ProductSupplier> productSuppliers = new List<ProductSupplier>();
            ProductSupplier supplier = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID " +
                                     "FROM TravelExperts " +
                                     "ORDER BY SupplierID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier = new ProductSupplier();
                    supplier.ProductSupplierId = (int)reader["ProductSuplierID"];
                    supplier.ProductID = (int)reader["ProductID"];
                    supplier.SupplierID = reader["SupplierID"].ToString();
                    productSuppliers.Add(supplier);
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
            return productSuppliers;
        }

        public static ProductSupplier GetProductSupplier(int productSupplierID)
        {
            ProductSupplier productSupplier = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID " +
                                     "FROM TravelExperts " +
                                     "WHERE ProductSupplierID = @ProductSupplierID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierID", productSupplierID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if(reader.Read())
                {
                    productSupplier = new ProductSupplier();
                    productSupplier.ProductSupplierId = (int)reader["ProductSupplierID"];
                    productSupplier.ProductID = (int)reader["ProductID"];
                    productSupplier.SupplierID = reader["SupplierID"].ToString();
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productSupplier;
        }
    }
}
