using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is for 
 *
 *
 */

namespace DBConnector
{
    public static class PackageDB
    {



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
                    Package package = new Package() {
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
        /// Gets all package ids
        /// </summary>
        /// <returns></returns>
        public static BindingList<int> GetPackageIds()
        {
            BindingList<int> packageIds = new BindingList<int>();

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command = "SELECT PackageId FROM Packages";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (read.Read())
                    packageIds.Add((int)read["PackageId"]);

            } // close command

            return packageIds;
        }


        /// <summary>
        /// Updates a package by id in the database
        /// </summary>
        /// <param name="packageId">the package id to be updated</param>
        /// <returns></returns>
        public static bool UpdatePackageById(int packageId)
        {
            Package package = GetPackageById(packageId);

            return true; //success
        }

    }
}
