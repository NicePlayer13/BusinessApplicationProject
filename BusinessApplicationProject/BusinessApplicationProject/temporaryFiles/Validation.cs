using System.Text.RegularExpressions;

namespace BusinessApplicationProject.temporaryFiles
{



    internal class Validation
    {
        private string? customerNumber;
        private string? email;
        private string? website;
        private string? password;



        public bool ValidateInput()
        {
            return (
                ValidateCustomerNr() &&
                ValidateEmailAdress() &&
                ValidateWebsite() &&
                ValidatePassword()
                );
        }

        private bool ValidateCustomerNr()
        {
            if (string.IsNullOrWhiteSpace(customerNumber))
                return false;

            var regex = new Regex(@"^CU\d{5}$");
            return regex.IsMatch(customerNumber);
        }

        private bool ValidateEmailAdress()
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);

            //fehlende Validierungsbegrenzungen für Emails:

            /*
             
            | Fall                          | Beispiel                          
            | ----------------------------- | --------------------------------- 
            | Zitate                        | `"John.Doe"@example.com`          
            | Kommentare                    | `john.doe(comment)@example.com`   
            | Umlaute (internationalisiert) | `jörg@beispiel.de`                
            | Punkt am Anfang/Ende          | `.john@doe.com`
            | Mehrere Punkte                | `john..doe@example.com`           
            | Domain-Literal                | `john@[192.168.0.1]`              
            | Top-Level-Domain numerisch    | `user@123.456.789.0`             

            */
        }

        private bool ValidateWebsite()
        {
            if (string.IsNullOrWhiteSpace(website))
                return false;

            var regex = new Regex(@"^(https?:\/\/)?(www\.)?[a-zA-Z0-9\-]+(\.[a-zA-Z]{2,})+(\/.*)?$");
            return regex.IsMatch(website);

        }

        private bool ValidatePassword()
        {
            if (string.IsNullOrEmpty(password)) return true;

            var regex = new Regex(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,})$");
            return regex.IsMatch(password);
        }

    }
}
