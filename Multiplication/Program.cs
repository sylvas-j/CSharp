using System;

namespace Multiplication
{
    class Program
    {
        private const string V = "Your result is = ";

        static void Main(string[] args)
        {
            int fnumber, snumber, tnumber, result = 0;

            Console.Write("Enter the first number = ");
            fnumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number = ");
            snumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number = ");
            tnumber = int.Parse(Console.ReadLine());

            int v = fnumber * snumber;
            result = v * tnumber;

            Console.WriteLine("The result is = " + result);
        }
    }
}
