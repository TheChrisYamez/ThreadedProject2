using DBConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2
{
    public static class PackageValidator
    {
        /// <summary>
        /// the error providor 
        /// </summary>
        public static ErrorProvider ErrorProvider { get; set; } = new ErrorProvider()
        {
            BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError,

        };

        /// <summary>
        /// the backgroud color of the control when an error is found
        /// </summary>
        private static Color ErrorColor { get; set; } = Color.FromArgb(255, 204, 204);

        /// <summary>
        /// the background color of the control after an error is corrected
        /// </summary>
        private static Color DefaultColor { get; set; } = Color.White;

        /// <summary>
        /// validates a string field and its charactor count
        /// </summary>
        /// <param name="input"></param>
        /// <param name="charCount"></param>
        /// <returns></returns>
        public static bool IsValidString(TextBox tb, int maxCharCount)
        {
            
            bool isValid;

            if (String.IsNullOrEmpty(tb.Text))
            {
                ErrorProvider.SetError(tb, "this field is required");
                isValid = false;
            }
            else if (tb.Text.Length > maxCharCount)
            {
                ErrorProvider.SetError(tb, $"{maxCharCount} charactor limit has been exceeded");
                isValid = false;
            }
            else
                isValid = true;

            if (isValid)
            {
                ErrorProvider.SetError(tb, String.Empty);
                tb.BackColor = DefaultColor;
            }
            else
                tb.BackColor = ErrorColor;

            return isValid;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool IsValidMonetaryValue(TextBox tb)
        {
            bool success = Decimal.TryParse(tb.Text, out _);
            bool isValid;

            if (String.IsNullOrEmpty(tb.Text))
            {
                ErrorProvider.SetError(tb, "this field is required");
                isValid = false;
            }
            else if (!success)
            {
                ErrorProvider.SetError(tb, "Only dollar values are allowed");
                isValid = false;
            }
            else
                isValid = true;

            if (isValid)
            {
                ErrorProvider.SetError(tb, String.Empty);
                tb.BackColor = DefaultColor;
            }
            else
                tb.BackColor = ErrorColor;

            return isValid;
        }
        /// <summary>
        /// Validates a package commission value
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool IsValidCommission(TextBox commission,TextBox basePrice)
        {
            //not an int, return false
            if (!IsValidMonetaryValue(commission))
                return false;

            bool isValid;
            decimal commissionValue = Convert.ToDecimal(commission.Text);
            decimal priceValue = Convert.ToDecimal(basePrice.Text);

            //commission cannot be greater then price, return false and set err providor.
            if (commissionValue > priceValue)
            {
                ErrorProvider.SetError(commission, "amount must be less than price");
                isValid = false;
            } else
            {
                ErrorProvider.SetError(commission, String.Empty);
                isValid = true;
            }

            if (isValid)
            {
                ErrorProvider.SetError(commission, String.Empty);
                commission.BackColor = DefaultColor;
            }
            else
                commission.BackColor = ErrorColor;

            return isValid;
        }

        /// <summary>
        /// Validates a package commission value
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool IsValidEndDate(DateTimePicker endDateDTP, DateTime startDate)
        {
            bool isValid;

            if (endDateDTP.Value.CompareTo(startDate) <= 0)
            {
                ErrorProvider.SetError(endDateDTP, "End date must be later then start date");
                isValid = false;
            }
            else
                isValid = true;


            if (isValid)
                ErrorProvider.SetError(endDateDTP, String.Empty);

            return isValid;
        }

        /// <summary>
        /// Validates a package commission value
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool IsPackageProductSupplierExisting(PackageProductSupplier packageProductSupplier)
        {
            bool isExisting;

            if (PackageProductSupplierDB.Get(packageProductSupplier) != null)
            {
                MessageBox.Show("This product is already part of the package","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                isExisting = true;
            }
            else
                isExisting = false;

            return isExisting;
        }
    }
}
