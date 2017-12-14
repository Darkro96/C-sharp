using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            bool l = true;
            do
            {
                Console.WriteLine("Wanna play again? y/n");

                if (Console.ReadKey(true).KeyChar == 'y')
                    l = false;
            } while (l);

            Console.WriteLine("Your choice: r/p/s");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'r':
                    playerChoice = "rock";
                    break;
                case 'p':
                    playerChoice = "paper";
                    break;
                case 's':
                    playerChoice = "scissor";
                    break;
            }
            
            switch (r.Next(0, 3))
            {
                case 0:
                    compChoice = "rock";
                    Console.WriteLine("The computer's choise: rock");
                    break;
                case 1:
                    compChoice = "paper";
                    Console.WriteLine("The computer's choise: paper");
                    break;
                case 2:
                    compChoice = "scissor";
                    Console.WriteLine("The computer's choise: scissor");
                    break;
            }

            if (
                playerChoice == "rock" && compChoice == "paper"
                ||
                (playerChoice == "paper" && compChoice == "scissor")
                ||
                (playerChoice == "scissor" && compChoice == "rock")
               )
            {
                Console.WriteLine("Lose! The scoreboard:\n Computer: {0}\nPlayer: {1}", ++compScore, playerScore);
            }

            else if (compChoice == playerChoice)
            {
                Console.WriteLine("Draw! The scoreboard:\n Computer: {0}\nPlayer: {1}", compScore, playerScore);
            }

            else
            {
                Console.WriteLine("Win! The scoreboard:\n Computer: {0}\nPlayer: {1}", compScore, ++playerScore);
            }
            Console.ReadKey();
        }
    }
}
