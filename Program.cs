using System;

namespace CodeInTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Password : ");
            int password = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Agency : ");
            string agency = Console.ReadLine();
            int number = password % 10;
            int ten = (password % 100 - number)/10;
            int hundred = (password%1000 - password%100)/100;
            int thousand = (password%10000 - password%1000)/1000;
            int ten_thousand = (password%100000 - password%10000)/10000;
            int hundred_thousand = (password%1000000 - password%100000)/100000;

            /*for check number
            Console.WriteLine(number);
            Console.WriteLine(ten);
            Console.WriteLine(hundred);
            Console.WriteLine(thousand);
            Console.WriteLine(ten_thousand);
            Console.WriteLine(hundred_thousand);
            */

            if (agency == "CIA")
            {
                if (number % 3 == 0 && ten != 1 && ten != 3 && ten != 5 &&thousand >= 6 && thousand != 8)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if(agency == "FBI")
            {
                if (hundred_thousand >= 4 && hundred_thousand <= 7 && hundred%2 == 0 && hundred != 6 && ten_thousand%2 == 1)
                {

                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (agency == "NSA")
            {
                if (30 % number == 0 && hundred %3 == 0 && hundred % 2 == 1 && (number == 7 || ten== 7 || hundred ==7 ||thousand == 7 || ten_thousand == 7 || hundred_thousand == 7))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

            }
            else
            {
                Console.WriteLine("False");
            }
           
        }
    }
}
