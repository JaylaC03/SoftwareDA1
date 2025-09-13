// imports" that give us extra tools to work with
using System; //Basic tools for C# (like Console, strings, etc.)
using System.Linq; //Gives us ".Any()" which helps us check conditions inside strings

namespace Assignment1.library
{
    public class PasswordChecker
    {
        /// <summary>
        /// Evaluates the strength of a given password based on length and character variety.
        /// </summary>
        /// <param name="password">The password string to evaluate.</param>
        /// <returns>
        /// Returns a string indicating the password's strength:
        /// - "INELIGIBLE" if the password is too short or meets no criteria
        /// - "WEAK" if it meets only one criterion
        /// - "MEDIUM" if it meets two or three criteria
        /// - "STRONG" if it meets all four criteria (uppercase, lowercase, digit, special character)
        /// </returns>
        public string CheckPassword(string password)
        {
            if (password.Length > 1 && password.Length < 8)
            {
                return "INELIGIBLE"; //Too short, doesnt qualify
            }

            bool hasUpper = password.Any(char.IsUpper); //checks if there's at least one uppercase letter
            bool hasLower = password.Any(char.IsLower); //checks if there's at least one lowercase letter
            bool hasDigit = password.Any(char.IsDigit); //checks if there's at least one digit
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch)); //checks if there's at least one special character

            int criteriaMet = 0; //counter for how many criteria are met

            if (hasUpper) criteriaMet++;
            if (hasLower) criteriaMet++;
            if (hasDigit) criteriaMet++;
            if (hasSpecial) criteriaMet++;

            // Determine strength based on criteria met and length

            return criteriaMet switch
            {
                0 => "INELIGIBLE",
                1 => "WEAK",
                2 or 3 => "MEDIUM",
                4 => "STRONG",
                _ => "INELIGIBLE" 
            };

        }
    }
}
                            //UUIDS
//32 characters long, only restriction: 1 bit thats currently set.
//m & n are the only ones that jave set numbers
//
