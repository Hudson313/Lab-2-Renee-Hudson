using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name?");

            Console.Write("(Enter your name):");
            string userName = Console.ReadLine();

            Console.WriteLine("Hi there " + userName + " Would you like to play a game? Enter \"yes\" or \"no\"");
            string ans = Console.ReadLine();

            if (ans == "yes")
            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon! What would you do? Enter \"FIGHT\" or \"RUN LIKE HELL\"");
                string ans2 = Console.ReadLine();

                if (ans2.ToUpper() == "FIGHT")
                {

                    Console.WriteLine("You approach the dragon. You see that it has __ heads. (Enter \"1\" or \"2\" or \"3\"");
                    string ans3 = Console.ReadLine();

                    string ans4 = "";

                    if (ans3 == "1")
                    {
                        Console.WriteLine("No one has ever faced a " + ans3 + "-headed dragon before! Choose your weapon. Enter \"sword\" or \"light sabor\" or \"mashete\"");
                        ans4 = Console.ReadLine();

                    }
                    else if (ans3 == "2")
                    {
                        Console.WriteLine("No one has ever faced a " + ans3 + "-headed dragon before! Choose your weapon. Enter \"sword\" or \"light sabor\" or \"mashete\"");
                        ans4 = Console.ReadLine();

                    }
                    else if (ans3 == "3")
                    {
                        Console.WriteLine("No one has ever faced a " + ans3 + "-headed dragon before! Choose your weapon. Enter \"sword\" or \"light sabor\" or \"mashete\"");
                        ans4 = Console.ReadLine();
                    }

                    
                else
                {
                    Console.WriteLine("Do you need glasses? You are lying, can't see and are going to die anyways");
                    Console.ReadLine();

                }
                    Console.WriteLine("Armed with your " + ans4 + " you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its ___ eyes and says \"" + userName + " I am going to kill you.\" Enter \"red\" or \"blue\" ");
                    string ans5 = Console.ReadLine();

                    Console.WriteLine("Oh thank goodness lucky for you " + ans5 + "-eyed dragons are friendly. You pet it and become friends. You name the dragon _______. Enter a name.");
                    string ans6 = Console.ReadLine();

                    Console.WriteLine("For now you, " + userName + " and " + ans6 + " live happily ever after.");
                    Console.ReadLine();
            }

                else
                {
                    Console.WriteLine("You are a coward! the Dragon has kidnapped the princess!");
                    Console.ReadLine();

              
                  }

                
                   
            }
            else
            {
                Console.WriteLine("That's fine " + userName + " I did not want to play with you anyway!");
                Console.ReadLine();               
            }




        }
    }
}
