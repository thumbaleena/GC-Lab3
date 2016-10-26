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
            string YesNo = "y";
            int Input, Square, Cube, Value;
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();

            while (YesNo == "y" || YesNo == "Y")
            {
                Console.WriteLine("Enter an integer: ");
                Input = int.Parse(Console.ReadLine());
                Value = Input;
                Console.WriteLine();
                Console.WriteLine("Number \t   Squared \tCubed");
                Console.WriteLine("====================================");
                for (Input = 1; Input<=Value; Input++)
                {
                    Square = Input * Input;
                    Cube = Input * Input * Input;
                    Console.WriteLine(Input + "\t   " + Square + "\t \t" + Cube);
                }
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                YesNo = Console.ReadLine();
                switch (YesNo)
                {
                    case "n":
                    case "N":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry, try again.");
                        YesNo = Console.ReadLine();
                        break;
                }
                while (YesNo.ToLower() != "yes"  && YesNo.ToLower() != "y" && YesNo.ToLower() != "no" && YesNo.ToLower() != "n")
                {
                    Console.Write("Invalid entry. Try again! ");
                    YesNo = Console.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
