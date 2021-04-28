using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegex
{
   public class EmailSampleFile
    {
        public string Regex_Email = "^[a-z0-9A-Z]+([.+-/$#%][a-zA-Z0-9]{1,})?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,3})?$";
        public  string[] validEmails = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                                "abc-100@ABC.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com",
                                "abc+100@gmail.com"};
        public string[] inValidEmails = {"abc","abc123@gmail.a","abc123@.com","abc123@.com.com",
                                  "abc()*@gmail.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com",
                                  "abc@gmail.com.1a","abc@gmail.com.aa.au"};
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
    }
}
