
using System.Text.RegularExpressions;

namespace src
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone,@"^(?:(?:010|011|012|015)\d{8}|\+20(?:10|11|12|15)\d{8})$");
        }

        public static bool IsValidEgyptianNationalId(this string nationalId)
        {
            if (string.IsNullOrWhiteSpace(nationalId))
                return false;

            return Regex.IsMatch(nationalId, @"^[23]\d{13}$");
        }
    }
}
