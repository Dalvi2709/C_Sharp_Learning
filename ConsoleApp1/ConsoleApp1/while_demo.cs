using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class while_demo
    {
        public static void Main(String[] args)
        {
            /*int number = 121, digit = 0, rev = 0;
            int temp = number;
            int sum = 0;
            int count = 0;

            while (number > 0)
            {
                digit = number % 10;
                count++;
                rev = rev * 10 + digit;
                sum = sum + digit;
                number = number / 10;

            }

            if (rev == temp)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }

            Console.WriteLine(rev);
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.ReadLine();
            }*/

            Console.WriteLine("Enter start number");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End number");
            int e = Convert.ToInt32(Console.ReadLine());
            while (s<=e)
            {
                Console.WriteLine(s);
                s++;
            }



            Console.ReadLine();

        }

    }
}


