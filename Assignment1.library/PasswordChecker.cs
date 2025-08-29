// imports" that give us extra tools to work with
using System; //Basic tools for C# (like Console, strings, etc.)
using System.Linq; //Gives us ".Any()" which helps us check conditions inside strings

namespace Assignment1.library
{
    public class PasswordChecker
    {
        //method that checks how strong a password is
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
