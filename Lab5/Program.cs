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
                string sideOfDice;
                
                if (UserInput == "Yes" || UserInput == "yes")
                    
                {
                    bool answer1 = true;
                    while (answer1 == true)
                    {
                        Console.WriteLine("How many sides each dice will have?");
                        sideOfDice = Console.ReadLine();
                        Console.WriteLine(Dice(1, int.Parse(sideOfDice) + 1));
                        Console.WriteLine(Dice(1, int.Parse(sideOfDice) + 1));
                        Console.WriteLine("Would You like to play again?");

                        string answer = Console.ReadLine();


                        if (answer == "no" || answer == "No" || answer == "NO")
                        {
                            userDecision = false;
                            break;
                            
                        }

                        else if (answer == "yes" || answer == "YES" || answer == "Yes")
                        {

                            Console.WriteLine("Good Luck!");


                        }


                    }
                    

                }

                else
                {
                    Console.WriteLine("Good, we dont wanna see you here!");
                    userDecision = false;
                }

                 

                
                 
            }



        }

        public static int Dice(int x, int y) 
       
        {

            Random dice = new Random(Guid.NewGuid().GetHashCode()); ///generates two different random numbers
            int Result1 = dice.Next(x, y);

            return Result1;

        }


    }



}

