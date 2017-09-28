using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {


            string UserInput;
            Console.WriteLine(" Welcome to the Grand Circus Casino");
            Console.WriteLine("Roll the dice?");
            UserInput = Console.ReadLine();
            //user decides to play or not

            bool userDecision = true;
            while (userDecision == true)
            {
                if (UserInput == "Yes" || UserInput == "yes")
                    
                {


                    Console.WriteLine("Good Luck!");
                    Console.WriteLine("How many sides each dice will have?");
                    string sideOfDice;
                    sideOfDice = Console.ReadLine();


                    Console.WriteLine(Dice(1, int.Parse(sideOfDice)));
                    Console.WriteLine(Dice(1, int.Parse(sideOfDice)));
                    Console.WriteLine("Would You like to play again?");

                }

                else
                {
                    Console.WriteLine("Good, we dont wanna see you here!");
                   
                }

                   
                string userAnswer = Console.ReadLine();
                if (userAnswer == "No" || userAnswer == "no")
                {
                    userDecision = false;
                    Console.WriteLine("Adios!");
                }

                 
            }



        }
        static Random dice = new Random();
        public static int Dice(int x, int y)

        {
           
            int Result1 = dice.Next(x, y);

            return Result1;

        }


    }



}

