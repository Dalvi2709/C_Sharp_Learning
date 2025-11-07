using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class else_if_ladder
    {
        public static void Main(String [] args)
        {
            int marks = 82;

            if(marks > 90)
            {
                Console.WriteLine("Grade A");
            }else if(marks > 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks > 45)
            {
                Console.WriteLine("Grade c");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadLine();
        }
    }
}
