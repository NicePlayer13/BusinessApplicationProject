using System.Text.RegularExpressions;

namespace BusinessApplicationProject.Helpers
{
    /// <summary>
    /// Provides validation methods for customer-related input fields such as Customer Number, Email, Website, and Password.
    /// </summary>
    public static class CustomerValidation
    {
        /// <summary>
        /// Regex for validating a customer number (Format: CU + 5 digits).
        /// </summary>
        private static readonly Regex CustomerNrRx = new(@"^CU\d{5}$", RegexOptions.Compiled);

        /// <summary>
        /// Regex for validating email addresses (common cases).
        /// </summary>
        private static readonly Regex EmailRx = new(@"^[A-Za-z0-9._%+\-]+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        /// <summary>
        /// Regex for validating a website URL. Supports http/https, www, subdomains, and TLDs.
        /// </summary>
        private static readonly Regex WebsiteRx = new(
            @"^(?:https?:\/\/)?(?:(?:[A-Za-z0-9\-]+\.)+)[A-Za-z]{2,}(?:\/[^\s]*)?$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        /// <summary>
        /// Regex for validating secure passwords: min. 8 characters, at least one lowercase, one uppercase, and one digit.
        /// </summary>
        private static readonly Regex PasswordRx = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            RegexOptions.Compiled);

        /// <summary>
        /// Validates whether a given customer number is in the correct format.
        /// </summary>
        public static bool CustomerNr(string? value) =>
            !string.IsNullOrWhiteSpace(value) && CustomerNrRx.IsMatch(value);

        /// <summary>
        /// Validates whether a given email address is in a common valid format.
        /// </summary>
        public static bool Email(string? value) =>
            !string.IsNullOrWhiteSpace(value) && EmailRx.IsMatch(value);

        /// <summary>
        /// Validates whether a given website URL is in a commonly accepted format.
        /// </summary>
        public static bool Website(string? value) =>
            !string.IsNullOrWhiteSpace(value) && WebsiteRx.IsMatch(value);

        /// <summary>
        /// Validates whether a password meets basic security requirements.
        /// </summary>
        public static bool Password(string? value) =>
            !string.IsNullOrEmpty(value) && PasswordRx.IsMatch(value);
    }
}
