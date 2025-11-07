using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class do_while_demo
    {
        public static void Main(String [] args)
        {
            /* Console.WriteLine("_______ATM______");

             int pin = 1234;
             int userpin;

             do
             {
                 Console.WriteLine("Enter correct pin");
                 userpin = Convert.ToInt32(Console.ReadLine());
             } while (pin != userpin);
             Console.ReadLine();*/

            int n = 50;

            do
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);   
                }
                n--;
            } while (n>=5);

            Console.ReadLine();
        }
    }
}
