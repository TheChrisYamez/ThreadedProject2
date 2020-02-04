using DBConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProject2
{
    public static class PackageValidator
    {
        /// <summary>
        /// Checks if the properties of the object are valid
        /// </summary>
        /// <param name="package">the package to validate</param>
        /// <returns></returns>
        public static bool IsPackageValid(Package package)
        {
            if (Object.Equals(package, null))
            {
                return false;
            }
            else if (package.PackageId <= 0)
            {
                return false;
                //invalid
            }
            else if (package.PkgDesc.Length > 50)
            {
                return false;
                //to long
            }
            else if (package.PkgName.Length > 50)
            {
                return false;
                // to long
            }
            else
                return true;
        }
    }
}
