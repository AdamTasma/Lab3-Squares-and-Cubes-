using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Learn your squares and cubes kid!");
            Calculate();
        }
        public static void Calculate()
        {
            Console.WriteLine("Enter an integer please");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Number   Squared  Cubed");
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(i + "        " + (i * i) + "       " + (i * i * i));
            }
            //repeat
            Console.WriteLine("Would you like to continue? (y/n)");
            char repeat = char.Parse(Console.ReadLine().ToUpper());
            if (repeat.Equals(Char.Parse("Y")))
            {
                Calculate();
            }
            else
            {
                Console.WriteLine("Ok goodbye");
                Console.ReadLine();
            }
        }
    }
}
