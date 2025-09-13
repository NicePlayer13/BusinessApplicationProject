using System.Text.RegularExpressions;

namespace BusinessApplicationProject.Validation
{
    public static class CustomerValidation
    {
        // CU + exactly 5 digits
        private static readonly Regex CustomerNrRx = new(@"^CU\d{5}$", RegexOptions.Compiled);

        // Pragmatic email: handles normal cases; see notes below for excluded edge cases.
        private static readonly Regex EmailRx = new(@"^[A-Za-z0-9._%+\-]+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        /*
        Exceptions:

        | Case                          | Example                          
        | ----------------------------- | --------------------------------- 
        | Quotes                        | "John.Doe"@example.com   
        | Brackets                      | john.doe(comment)@example.com   
        | Umlaut                        | jörg@beispiel.de              
        | Domain-Literal                | john@[192.168.0.1]            

        */

        // Website: optional http/https, optional www., allow subdomains, require TLD, optional path/query/fragment
        // Accepts 'google.com', 'www.google.com', 'http://google.com', 'https://sub.domain.co.uk/path?a=1#x'
        private static readonly Regex WebsiteRx = new(
            @"^(?:https?:\/\/)?(?:(?:[A-Za-z0-9-]+\.)+)[A-Za-z]{2,}(?:\/[^\s]*)?$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        // Password: ≥8, at least one lower, one upper, one digit (you can add special-char rule if desired)
        private static readonly Regex PasswordRx = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            RegexOptions.Compiled);

        public static bool CustomerNr(string? value) => !string.IsNullOrWhiteSpace(value) && CustomerNrRx.IsMatch(value);
        public static bool Email(string? value) => !string.IsNullOrWhiteSpace(value) && EmailRx.IsMatch(value);
        public static bool Website(string? value) => !string.IsNullOrWhiteSpace(value) && WebsiteRx.IsMatch(value);
        public static bool Password(string? value) => !string.IsNullOrEmpty(value) && PasswordRx.IsMatch(value);
    }
}
