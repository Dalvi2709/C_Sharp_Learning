using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class if_else
    {
        public static void Main(String[] args)
        {
            /*if else conditional statement*/
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();


            if (username == "Roshan@123" && pass == "123456")
            {
                Console.WriteLine("Welcome to dashboard");
            }
            else
            {
                Console.WriteLine("Invalid Username and Password");
            }

            Console.ReadLine();
        }
    }
}
