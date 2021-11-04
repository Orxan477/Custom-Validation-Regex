using System;
using ValidationsLibrary;

namespace Validations
{
    class Program
    {
        static void Main(string[] args)
        {
            TryAgain:
            try
            {
                Console.Write("Name:");
                Console.WriteLine(Validation.NameValidation(Console.ReadLine()));
                Console.Write("Surname:");
                Console.WriteLine(Validation.SurnameValidation(Console.ReadLine()));
                Console.Write("Username:");
                Console.WriteLine(Validation.UsernameValidation(Console.ReadLine()));
                Console.Write("Email:");
                Console.WriteLine(Validation.EmailValidation(Console.ReadLine()));
                Console.Write("Password:");
                Console.WriteLine(Validation.PasswordValidation(Console.ReadLine()));
                Console.Write("Number:");
                Console.WriteLine(Validation.NumberValidation(Console.ReadLine()));
                Console.Write("Date:");
                Console.WriteLine(Validation.DateValidation(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Correct Input!!!");
                goto TryAgain;
            }
        }
    }
}
