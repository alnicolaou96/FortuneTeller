using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne_AlexandrosNicolaou
{
    class Program
    {
        static void Main(string[] args)
        {
            //varibales
            string firstName, lastName, color, vacationHome, money;
            int age, siblings, birthMonth;
            string transportation = " ";
            

  

            // Part One: user interface
            Console.WriteLine("Please enter your first name.");
            firstName=Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age =int.Parse(Console.ReadLine());
            Console.WriteLine("what month were born? (please write it as an integer)");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your favorite color from ROYGBIV \n type 'help' if you do not know what is ROYGBIV");
            color = Console.ReadLine().ToLower();
            if(color=="help")
            {
                Console.WriteLine("ROYGBIV is an acronym for the color spectrum \n R=Red\n O=Orange\n Y=Yellow\n G=Green\n B=Blue\n I=Indigo\n V=Violet\n");
                color = Console.ReadLine().ToLower();
            }
            Console.WriteLine("How many siblings do you have? (enter as an integer please)");
            siblings = int.Parse(Console.ReadLine());

            // is the years til retirement even or odd
            int ageEven = age % 2;
            if (ageEven == 0)
                age = 65 + age;
            else
                age = 5 + age;
            
            
            

            //vacation home
            if (siblings == 0)
                vacationHome = "France";
            else if (siblings == 1)
                vacationHome = "Russia";
            else if (siblings == 2)
                vacationHome = "Elyria, Ohio";
            else if (siblings == 3)
                vacationHome = "Hawaii";
            else if (siblings < 0)
                vacationHome = "mom's basement";
            else
                vacationHome = "the Andromeda Galaxy";


            //Color for Mode of Transportation
            switch(color)
            {
                case "red":
                    transportation = "2015 Toyota Corolla";
                    break;
                case "orange":
                    transportation = "Model S Tesla";
                    break;
                case "yellow":
                    transportation = "private jet";
                    break;
                case "green":
                    transportation = "Ford F-150";
                    break;
                case "blue":
                    transportation = "sailboat";
                    break;
                case "indigo":
                    transportation = "Horseback";
                    break;
                case "violet":
                    transportation = "bicycle";
                    break;
            }

            //money
            if ((birthMonth >= 1) && (birthMonth <= 4))
                money = "$50,000.01";
            else if ((birthMonth >= 5) && (birthMonth <= 8))
                money = "$200,000.45";
            else if ((birthMonth >= 9) && (birthMonth <= 12))
                money = "$1,223,116.34";
            else
                money = "$0.00";

            Console.WriteLine();
          
            // Part Two
            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4}, and a {5}.",firstName , lastName , age ,money ,vacationHome  ,transportation );





        }
    }
}
