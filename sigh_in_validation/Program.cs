using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sigh_in_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] workersNo = {12,23,34,45,56};
            string[] workersNa = {"joy", "micheal", "philip", "tom", "adam"};

            //SIGH IN VALIDATION FORM
            Console.WriteLine("Sigh in validation form");
            Console.Write("Your password: ");
            int pass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your username: ");
            string word = Console.ReadLine();

            for(int i = 0; i < workersNo.Length; i++)
            {
                if(workersNo[i] == pass && workersNa[i] == word)
                {
                    Console.WriteLine("Welcome, you are log in");
                    break;                   
                }else if(i == 4)
                {
                    Console.WriteLine("Invalid credentials! \n Check password and username");
                };
                
            };
                
                //break;
            //Console.WriteLine("Hello World!");
        }
    }
}
