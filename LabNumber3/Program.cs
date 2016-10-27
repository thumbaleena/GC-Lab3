using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)

        {
            string YesNo = "y";  //yay or nay
            int Input, Square, Cube, Value;  
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();

            while (YesNo == "y" || YesNo == "Y")  //loop to continue when user chooses yes
            {
                GetNumber(out Input, out Value);
                for (Input = 1; Input <= Value; Input++)  //operate on numbers 1 - value of input
                {
                    Square = Input * Input;
                    Cube = Input * Input * Input;
                    Console.WriteLine(Input + "\t   " + Square + "\t \t" + Cube);
                }
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                YesNo = Console.ReadLine();
                YesNo = DoMath(YesNo);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static string DoMath(string YesNo)
        {
            switch (YesNo)
            {
                case "n":
                case "N":
                    Environment.Exit(0);  //user said no, kill the program
                    break;
                default:
                    Console.WriteLine("Invalid entry, try again.");  //input validation since there are only 2 right answers
                    YesNo = Console.ReadLine();
                    break;
            }
            while (YesNo.ToLower() != "yes" && YesNo.ToLower() != "y" && YesNo.ToLower() != "no" && YesNo.ToLower() != "n")
            {
                Console.Write("Invalid entry. Try again! "); //input validation since there are only 2 right answers
                YesNo = Console.ReadLine();
            }

            return YesNo;
        }

        private static void GetNumber(out int Input, out int Value)
        {
            Console.WriteLine("Enter an integer: ");
            Input = int.Parse(Console.ReadLine());
            Value = Input;  //created value so that we have something to compare Input against
            Console.WriteLine();
            Console.WriteLine("Number \t   Squared \tCubed");
            Console.WriteLine("====================================");
        }
    }
}
