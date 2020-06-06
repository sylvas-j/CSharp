using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            
            Console.WriteLine("Welcome to Control F7; what is your age?");
            age = int.Parse(Console.ReadLine());

            if(age > 65)
            {
                Console.WriteLine("You are not welcome for this interview; kindly settle for your retirement, you need rest. Thanks");
            }
            else
            {
                Console.WriteLine("You are welcome for the interview. Kindly make yourself comfortable. Thanks");
            }
        }
    }
}
