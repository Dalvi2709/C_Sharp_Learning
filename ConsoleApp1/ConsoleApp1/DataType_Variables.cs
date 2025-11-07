using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DataType_Variables
    {
        public static void Main(String [] args)
        {
            /*data types and variables*/
            /*value type and reference type*/
            /*local,global and instance and static variable*/
            int a = 10;
            Console.WriteLine("Interger value :"+a);

            byte b = 5;
            Console.WriteLine("Interger value :" + b);

            short c = 4;
            Console.WriteLine("Interger value :" + c);

            long d = 123456543;
            Console.WriteLine("Interger value :" + d);

            float f = 10.17f;
            Console.WriteLine("Float value :" + f);

            double g = 212.311;
            Console.WriteLine("Double value :" + g);

            decimal h = (decimal)120.21;  // M,m
            Console.WriteLine("Decimal value :" + h);

            char i = 'A';
            Console.WriteLine("Character Value : " + i);

            string name = "Roshan Ramchandra Dalvi";
            Console.WriteLine(name);

            bool run = false;
            if (run)
            {
                Console.WriteLine("Boolean Value is True");
            }
            else
            {
                Console.WriteLine("Boolean Value is False");
            }






            Console.ReadLine();
        }
    }
}
