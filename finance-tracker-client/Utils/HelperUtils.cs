using System;
using System.Globalization;

namespace finance_tracker_client.Utils
{
    public static class HelperUtils
    {
        // Function to format the number with commas as thousand separators
        public static string FormatCurrency(string amount)
        {
            if (decimal.TryParse(amount, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedAmount))
            {
                // Return the formatted string with comma as thousand separator and two decimal places
                return parsedAmount.ToString("#,0.00", CultureInfo.InvariantCulture);
            }
            else
            {
                throw new ArgumentException("Invalid number format.");
            }
        }
    }
}


