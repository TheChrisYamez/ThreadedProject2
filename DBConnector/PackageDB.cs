using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is for updating and retrieve data from a sql db
 *
 *
 */

namespace DBConnector
{
    [DataObject(true)]
    public static class PackageDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        /// <summary>
        /// Gets all packages from the database and returns a list of package objects
        /// </summary>
        /// <returns></returns>
        public static List<Package> GetPackages()
        {
            List<Package> packages = new List<Package>();

            string command = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";

            SqlConnection con = TravelExpertsConnection.GetConnection();

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (read.Read())
                {
                    Package package = new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                        PkgStartDate = (read["PkgStartDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgStartDate"],
                        PkgEndDate = (read["PkgEndDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgEndDate"],
                        PkgDesc = (read["PkgDesc"] == DBNull.Value) ? String.Empty : (string)read["PkgDesc"],
                        PkgBasePrice = (decimal)read["PkgBasePrice"],
                        PkgAgencyCommission = (read["PkgAgencyCommission"] == DBNull.Value) ? 0 : (decimal)read["PkgAgencyCommission"],
                    };
                    packages.Add(package);
                } //close while
            } // close command
            return packages;
        }

        /// <summary>
        /// gets a package object by id from the database
        /// </summary>
        /// <param name="packageId"></param>
        /// <returns></returns>
        public static Package GetPackageById(int packageId)
        {

            Package package = null;

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                "FROM Packages " +
                "Where PackageId = @PackageId";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PackageId", packageId);

                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (read.Read())
                {
                    package = new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                        PkgStartDate = (read["PkgStartDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgStartDate"],
                        PkgEndDate = (read["PkgEndDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgEndDate"],
                        PkgDesc = (read["PkgDesc"] == DBNull.Value) ? String.Empty : (string)read["PkgDesc"],
                        PkgBasePrice = (decimal)read["PkgBasePrice"],
                        PkgAgencyCommission = (read["PkgAgencyCommission"] == DBNull.Value) ? (decimal?)null : (decimal)read["PkgAgencyCommission"],
                    };
                } //close while
            } // close command


            return package;
        }

        /// <summary>
        /// Gets all package ids and names
        /// </summary>
        /// <returns></returns>
        public static List<Package> GetPartialPackage()
        {
            List<Package> package = new List<Package>();

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command = "SELECT PackageId, PkgName FROM Packages";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (read.Read())

                    package.Add(new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                    });

            } // close command

            return package;
        }

        /// <summary>
        /// Gets all products linked to a specific package
        /// </summary>
        /// <param name="packageId">package id to retrieve products for</param>
        /// <returns>returns a list of packages</returns>
        public static List<Product> GetPackageProductsById(int packageId)
        {
            List<Product> products = new List<Product>();

            SqlConnection con = TravelExpertsConnection.GetConnection();

            //sql command to get all products tied to a specific package
            string command =
                "SELECT pkg.PackageId, pro.ProductId, pro.ProdName " +
                "FROM Packages AS pkg " +
                "JOIN Packages_Products_Suppliers as pps " +
                "ON pkg.PackageId = pps.PackageId " +
                "JOIN Products_Suppliers as s " +
                "ON s.ProductSupplierId = pps.ProductSupplierId " +
                "JOIN Products as pro " +
                "ON pro.ProductId = s.ProductId " +
                "WHERE pkg.PackageId = @PackageId";


            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PackageId", packageId);

                using (SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            Product product = new Product()
                            {
                                ProductID = (int)read[1],
                                ProdName = read[2].ToString()

                            };
                            products.Add(product);
                        }
                    }

                }// close data reader
            }// close command
            return products;
        }

        /// <summary>
        /// Updates a package by id in the database
        /// </summary>
        /// <param name="packageId">the package id to be updated</param>
        /// <returns></returns>
        public static bool UpdatePackageById(Package package)
        {
            Package oldPackage = GetPackageById(package.PackageId);

            //given package is null or no id
            if (Object.Equals(package, null) || package.PackageId == 0 || oldPackage.CompareTo(package))
                return false;

            string query =
                "Update Packages " +
                "SET PkgName = @PkgName " +
                "SET PkgStartDate = @PkgStartDate " +
                "SET PkgEndDate = @PkgEndDate " +
                "SET PkgDesc = @PkgDesc " +
                "SET PkgBasePrice = @PkgBasePrice " +
                "SET PkgAgencyCommission = @PkgAgencyCommission " +
                "WHERE PackageId = @PackageId";

            int rowsUpdated;

            SqlConnection connect = TravelExpertsConnection.GetConnection();

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                connect.Open();

                //Non-nullable params
                cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
                cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);

                //nullable params
                if (Object.Equals(package.PkgAgencyCommission, null))
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
                if (Object.Equals(package.PkgStartDate, null))
                    cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
                if (Object.Equals(package.PkgEndDate, null))
                    cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);

                rowsUpdated = cmd.ExecuteNonQuery();

                connect.Close();
            }

            //no rows updated.
            if (rowsUpdated == 0)
                return false;
            else
                return true;
        }


        /// <summary>
        /// Updates a specific package property
        /// </summary>
        /// <param name="packageId">the package id to be updated</param>
        /// <returns></returns>
        public static bool UpdatePackagePropertyById(string propertyNameToUpdate, Package package)
        {
            //given package is null or no id
            if (Object.Equals(package, null) || package.PackageId <= 0)
                return false;

            SqlConnection connect = TravelExpertsConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@PackageId", package.PackageId);

            string query = String.Empty;

            switch (propertyNameToUpdate)
            {
                case nameof(Package.PkgAgencyCommission):
                    query = "Update Packages SET PkgAgencyCommission = @PkgAgencyCommission WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgAgencyCommission, null))
                        cmd.Parameters.AddWithValue("@PkgAgencyCommission", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
                    break;

                case nameof(Package.PkgBasePrice):
                    query = "Update Packages SET PkgBasePrice = @PkgBasePrice WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
                    break;

                case nameof(Package.PkgDesc):
                    query = "Update Packages SET PkgDesc = @PkgDesc WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
                    break;

                case nameof(Package.PkgEndDate):
                    query = "Update Packages SET PkgEndDate = @PkgEndDate WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgEndDate, null))
                        cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
                    break;

                case nameof(Package.PkgName):
                    query = "Update Packages SET PkgName = @PkgName WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                    break;

                case nameof(Package.PkgStartDate):
                    query = "Update Packages SET PkgStartDate = @PkgStartDate WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgStartDate, null))
                        cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
                    break;

                default:
                    return false;
            }

            cmd.CommandText = query;
            cmd.Connection = connect;

            connect.Open();
            int rowsUpdated = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            //no rows updated.
            if (rowsUpdated == 0)
                return false;
            else
                return true;
        }
    }
}
