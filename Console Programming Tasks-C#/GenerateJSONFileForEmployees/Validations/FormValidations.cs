using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Validations
{
    /// <summary>
    /// This Class  will validate the inputs as per the required format, and aslo throw the exceptions as if araises.
    /// </summary>
    public class FormValidations
    {
        /// <summary>
        /// This method will throw error for empty value and also format missing.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        /// <exception cref="IOException"></exception>
        public bool IsValidName(string Name)
        {
            if (Name != null || Name != "")
            {
                if (Regex.Match(Name, "^[A-Z][a-zA-Z\\s]*$").Success)
                {
                    return true;
                }
                else
                {
                    throw new IOException("Input format should be matched");
                    return false;
                }
            }
            else
            {
                throw new IOException("input cannot be empty");
                return false;
            }
            
        }
        public bool IsValidId(string Id )
        {
            if (Id != null || Id != "")
            {
                if (Regex.Match(Id, "^[A-Z][a-zA-Z]*$").Success)
                {
                    return true;
                }
                else
                {
                    throw new IOException("Input format should be matched");
                    return false;
                }
            }
            else
            {
                throw new IOException("input cannot be empty");
                return false;
            }
        } 
        public bool isValidPhone(string Phone)
        {
            if (Phone != null || Phone != "")
            {
                if (Regex.Match(Phone, "^\\+?[1-9][0-9]{7,14}$").Success)
                {
                    return true;
                }
                else
                {
                    throw new IOException("Input format should be matched");
                    return false;
                }
            }
            else
            {
                throw new IOException("input cannot be empty");
                return false;
            }
        }
        public bool isValidEmail(string Email)
        {
            if (Email != null || Email != "")
            {
                if (Regex.Match(Email, "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$").Success)
                {
                    return true;
                }
                else
                {
                    throw new IOException("Input format should be matched");
                    return false;
                }
            }
            else
            {
                throw new IOException("input cannot be empty");
                return false;
            }
        }
    }
}