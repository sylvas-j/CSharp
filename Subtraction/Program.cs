using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task, subtraction calculator

            int fnumber, snumber, result = 0;

            Console.Write("Enter the first number = ");
            fnumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number = ");
            snumber = int.Parse(Console.ReadLine());

            result = fnumber - snumber;
            
            Console.WriteLine("Your reult is = " + result);
        }
    }
}
