using System;
using System.Text;

namespace con_String
  {
    class Program
      {
        static void Main(string[] args)
          {
            Console.Write("Type the year of your birth: ");
            string userInput = Console.ReadLine();
            int yearOfBirth;
            int.TryParse(userInput, out yearOfBirth);

            int age = DateTime.Now.Year - yearOfBirth;

            Console.WriteLine("Your age is " + age);
          }
      }
}