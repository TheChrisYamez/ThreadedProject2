using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    /// <summary>
    /// A class object representing a package from a database
    /// </summary>
    public class Package
    {

//        Make sure that you validate the data before creating the package:
//a)	the Agency Commission cannot be greater than the Base Price
//b)	the Package End Date must be later than Package Start Date
//c)	Package Name and Package Description cannot be null


        //not nullable
        public int PackageId { get; set; }
        
        //not nullable
        public string PkgName { get; set; }

        public DateTime? PkgStartDate { get; set; }

        public DateTime? PkgEndDate { get; set; }

        //nullable
        public string  PkgDesc { get; set; }

        //not nullable
        public decimal PkgBasePrice { get; set; }

        public decimal? PkgAgencyCommission { get; set; }
    }
}
