using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
#region     Some
        static void Main(string[] args)
        {
            string age = Console.ReadLine();

            Console.WriteLine();

            int ageInt;

            bool some = int.TryParse(age, out ageInt);

            if (some == true)
                Console.WriteLine(age);

            else
                Console.WriteLine("Sorry, you not correct age");

            Console.ReadLine();
        }
        #endregion
    }
}