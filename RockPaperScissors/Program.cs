using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // = new random
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("DRAW");
                        } else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE!");
                        } else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        else
                        {
                            Console.WriteLine("DRAW!");
                        }
                        break;

                    default:
                        break;
                }

                Console.Write("Would you like to play again?: (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }

                 Console.WriteLine("Thanks for playing again :)");
            }
        }
    }
}
