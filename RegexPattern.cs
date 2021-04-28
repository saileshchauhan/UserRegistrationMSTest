using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegex
{
  public class RegexPattern
    {
        public string Regex_Password = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";
        public string Regex_Mobile = "^[+][0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        public string Regex_Email = "^[a-z0-9A-Z]+([.+-/$#%][a-zA-Z0-9]{1,})?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,3})?$";
        public string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public string Regex_Pincode = "^[1-9]{1}[0-9]{2,2}[ ]?[0-9]{3}$";
        public bool ValidatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName,Regex_LastName);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool ValidateMobileFormat(string Format)
        {
            return Regex.IsMatch(Format, Regex_Mobile);
        }
        public bool CatchInValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
    }
}
