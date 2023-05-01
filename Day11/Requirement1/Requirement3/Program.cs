using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 Valid Car registration Number");
            Console.WriteLine("2 Convert Car registration Number");
            Console.WriteLine("3 Valid Driving License");
            Console.WriteLine("Enter choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter car registration number:");
                    string carRegNumber = Console.ReadLine();
                    if (IsValidCarRegistrationNumber(carRegNumber))
                        Console.WriteLine(carRegNumber + " is Valid");
                    else
                        Console.WriteLine(carRegNumber + " is Invalid");
                    break;
                case 2:
                    Console.WriteLine("Enter car registration number:");
                    string carRegNumberToConvert = Console.ReadLine();
                    string convertedCarRegNumber = ConvertCarRegistrationNumber(carRegNumberToConvert);
                    Console.WriteLine(convertedCarRegNumber);
                    break;
                case 3:
                    Console.WriteLine("Enter driving license issue date (dd-MM-yyyy):");
                    DateTime issueDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    if (IsValidDrivingLicense(issueDate))
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + " years old license - expired");
                    else
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + " years old license - valid");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static bool IsValidCarRegistrationNumber(string carRegNumber)
        {
            string pattern = @"^[A-Z]{2}-\d{2}-[A-Z]{2}-\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(carRegNumber, pattern);
        }
        static string ConvertCarRegistrationNumber(string carRegNumber)
        { 
            return carRegNumber.Replace('@', '-').Replace('*', '-').ToUpper();
        }
        static bool IsValidDrivingLicense(DateTime issueDate)
        {
            DateTime currentdate = DateTime.Now;
            DateTime expirydate = issueDate.AddYears(10);
            return currentdate > expirydate;
        }
    }
}
