using System;

    class Calculator
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Chooes Operation");
            Console.WriteLine("1 for Addition");
            Console.WriteLine("2 for Substraction");
            Console.WriteLine("3 for Multiplication");
            Console.WriteLine("4 for Divide");

            int ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NUmber 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

             int res;


            switch (ch)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("Result is : " + res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("Result is : " + res);
                    break;
                case 3:
                    res = num1 * num2;
                    Console.WriteLine("Result is : " + res);
                    break;
                case 4:
                    res = num1 / num2;
                    Console.WriteLine("Result is : " + res);
                    break;

                default:
                    Console.WriteLine("Envalid Choice");
                    break;

            }

            Console.ReadLine();

        }
        
    }

