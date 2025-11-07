using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nested_if
    {
        public static void Main(String [] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter the Role");
            string role = Console.ReadLine();


            if (username == "Roshan@123" && pass == "123456")
            {
                if (role == "Admin")
                {
                    Console.WriteLine("Welcome to  Admin dashboard");
                }
            }
            else
            {
                Console.WriteLine("Invalid Username and Password");
            }

            Console.ReadLine();
        }
    }
}
