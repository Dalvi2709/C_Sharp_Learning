using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {
        public static void Main(string [] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr1 = new int[3];
            string[] city = { "satara", "pune", "mumbai", "kolhapur", "sangali", "patan", "nashik", "nagpur" };
            string[] city1 = new string[8]; 
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;


            for (int i = 0; i < city1.Length; i++)
            {
                Console.WriteLine("Enter the city name");
                city[i] = Console.ReadLine();
            }

            for (int i = 0; i < city1.Length; i++)
            {
                Console.WriteLine(city1[i]);
            }
            Console.ReadLine();
        }
    }
}
