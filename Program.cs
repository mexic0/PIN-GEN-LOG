using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generating a pin in the console
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1000, 9999));

            



            //PIN Login
            int pin = rnd.Next(1000, 9999);
            //pin.Send on Discord / Database..

            Console.WriteLine("");
            Console.Write("Enter your pin: ");
            string result = Console.ReadLine();

            if (int.Parse(result) == pin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("False pin !");
            }
            
            

        }
    }
}
