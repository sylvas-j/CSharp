using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //guessing game that alow the user to select the level s\he wants to play
            //These lines of codes alow the user to select level by entering number corresponding to the level
            Console.WriteLine("There are three levels in this guessing game.\n Enter 1 for easy level.\n Enter 2 for normal level.\n Enter 3 for hard level!");
            Console.WriteLine(" ");
            Console.Write("Enter your desire level to start: ");
            int level = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] luckyNo = {8, 17, 24};
            // In each level the user is alow to guess the lucky number with a limited number of triads

            //These lines are reponsible for level one
            if(level == 1){
                //The first line of codee to be executed when level one is select
                Console.WriteLine("\nIn this level you have only 6 guesses between 1 -10.\nGood lock!\n");    
                Console.Write("Please enter guess: ");    
                count = 6;

                for(int i = 0; i<=6; i++){
                    //The next line of code to be executed if the user fail the first trial.
                    if(count < 6){
                        Console.Write("please enter another guess: ");
                    };
                    int guess = Convert.ToInt32(Console.ReadLine());
                    count--;
                    if(guess < 1 || guess > 10){
                        //This code is executed when the user exceed the spicified interval of lucky number
                        Console.WriteLine("Please enter a valid number between 1 and 10!");
                        Console.WriteLine("Your have " + count + " guesses left.\n");
                    }else if(guess == luckyNo[0]){
                        Console.WriteLine("You got it right!");
                        break;
                    }else if(count < 1){
                        Console.WriteLine("Game over!");
                        break;
                    }else{
                        
                        Console.WriteLine("Your are wrong!\nYour have " + count + " guesses left.\n");
                    };
                };
            };

//These lines are reponsible for level two
            if(level == 2){
                //The first line of codee to be executed when level one is select
                Console.WriteLine("\nIn this level you have only 4 guesses between 1 - 20.\nGood lock!\n");    
                Console.Write("Please enter guess: ");    
                count = 4;

                for(int i = 0; i<=4; i++){
                    
                    if(count < 4){
                        //The next line of code to be executed if the user fail the first trial.
                        Console.Write("please enter another guess: ");
                    };
                    int guess = Convert.ToInt32(Console.ReadLine());
                    count--;
                    if(guess == luckyNo[1]){
                        Console.WriteLine("You got it right!");
                        break;
                    }else if(count < 1){
                        Console.WriteLine("\nGame over!");
                        break;
                    }else if(guess < 1 || guess > 20){
                        //This code is executed when the user exceed the spicified interval of lucky number
                        Console.WriteLine("Please enter a valid number between 1 and 20!");
                        Console.WriteLine("Your have " + count + " guesses left.\n");
                    }else {
                        
                        Console.WriteLine("Your are wrong!\nYour have " + count + " guesses left.\n");
                    };
                };
            };

//These lines are reponsible for level three
            if(level == 3){
                //The first line of codee to be executed when level one is select
                Console.WriteLine("\nIn this level you have only 3 guesses between 1 - 50.\nGood lock!\n");    
                Console.Write("Please enter guess: ");    
                count = 3;

                for(int i = 0; i<=3; i++){
                   
                    if(count < 3){
                        //The next line of code to be executed if the user fail the first trial.
                        Console.Write("please enter another guess: ");
                    };
                    int guess = Convert.ToInt32(Console.ReadLine());
                    count--;
                    if(guess == luckyNo[2]){
                        Console.WriteLine("You got it right!");
                        break;
                    }else if(count < 1){
                        Console.WriteLine("Game over!");
                        break;
                    }else if(guess < 1 || guess > 50){
                        //This code is executed when the user exceed the spicified interval of lucky number
                        Console.WriteLine("Please enter a valid number between 1 and 50!");
                        Console.WriteLine("Your have " + count + " guesses left.\n");
                    }else {
                        
                        Console.WriteLine("Your are wrong!\nYour have " + count + " guesses left.\n");
                    };
                };
            };


        }
    }
}
