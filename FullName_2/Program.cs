using System;
using System.Text;

namespace FullName_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //acquire the first name from the user
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            //acquire the last name from the user
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            //write the first and last name
            Console.WriteLine(GetFirstName(firstName, lastName));

            //keep the program open
            Console.ReadLine();

        }
        private static string GetFirstName(string firstName, string lastName)
        {
            //initialize a StringBuilder
            StringBuilder fullName = new StringBuilder();
            //add the first and last name to the StringBuilder
            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);
            //convert the first and last name from StringBuilder to string
            string fullNameStr = fullName.ToString();
            //pass the string back to Main
            return fullNameStr;
        }
    }
}
