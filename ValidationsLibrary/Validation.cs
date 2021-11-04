using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationsLibrary
{
    public class Validation
    {
        /// <summary>
        /// Checks if the name is salt
        /// </summary>
        /// <param name="name">string type name</param>
        /// <returns>True or Flase</returns>
        public static bool NameValidation(string name)
        {
            string pattern = @"^[a-zA-Z]+$";
            bool IsMatch = Regex.IsMatch(name, pattern);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Name");
            }

        }

        /// <summary>
        /// Checks if the surname is salt
        /// </summary>
        /// <param name="surname">string type surname</param>
        /// <returns>True or False</returns>
        public static bool SurnameValidation(string surname)
        {
            string pattern = @"^[a-zA-Z]+$";
            bool IsMatch = Regex.IsMatch(surname, pattern);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Surname");
            }
        }

        /// <summary>
        /// Checks if the username is salt
        /// </summary>
        /// <param name="username">string type username</param>
        /// <returns>True or False</returns>
        public static bool UsernameValidation(string username)
        {
            string pattern = @"^[\.\w]+$";
            bool IsMatch = Regex.IsMatch(username, pattern);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Username");
            }
        }

        /// <summary>
        /// Checks if the email is salt
        /// </summary>
        /// <param name="email">string type email</param>
        /// <returns>True or False</returns>
        public static bool EmailValidation(string email)
        {
            string pattern = @"^([A-Za-z][\w]+@[A-Za-z-\.]+\.[A-Za-z]{2,4})$";
            bool IsMatch = Regex.IsMatch(email, pattern);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Email");
            }
        }

        /// <summary>
        /// Checks if the password is salt
        /// </summary>
        /// <param name="password">string type password</param>
        /// <returns>True or False</returns>
        public static bool PasswordValidation(string password)
        {
            string patter = @"^[\s\w\W]{8,}$";
            bool IsMatch = Regex.IsMatch(password, patter);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Password");
            }
        }

        /// <summary>
        /// Checks if the number is salt
        /// </summary>
        /// <param name="number">string type number</param>
        /// <returns>True or False</returns>
        public static bool NumberValidation(string number)
        {
            string patter = @"^([+][9][9][4]([5][015]|[7][07]|[9][9]|[1][28]|[2][0-6]|[3][6])[2-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
            bool IsMatch = Regex.IsMatch(number, patter);
            if (IsMatch)
            {
                return IsMatch;
            }
            else
            {
                throw new NotFoundException("InCorrect Number");
            }
        }

        /// <summary>
        /// Checks if the date is salt
        /// </summary>
        /// <param name="date">string type date</param>
        /// <returns>True or False</returns>
        public static bool DateValidation(string date)
        {
           
            string pattern = @"^([0][1-9]|[12][0-9]|[3][0-1])[.]([0][13578]|[1][02])[.]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9]|[3][1])[\/]([0][13578]|[1][02])[\/]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9]|[3][1])[-]([0][13578]|[1][02])[-]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9]|[3][0])[.]([0][469]|[1][1])[.]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9]|[3][0])[\/]([0][469]|[1][1])[\/]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9]|[3][0])[-]([0][469]|[1][1])[-]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9])[.]([0][2])[.]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9])[\/]([0][2])[\/]([1-9][0-9][0-9][0-9])|([0][1-9]|[12][0-9])[-]([0][2])[-]([1-9][0-9][0-9][0-9])$";
            bool IsMatch = Regex.IsMatch(date,pattern);
            if (IsMatch)
            {
                return true;
            }
            else
            {
                throw new NotFoundException("InCorrect Date");
            }
        }
        
        
       
        
        


    }
}
