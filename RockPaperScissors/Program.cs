using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Battle
    {
        private string _userInput;
        private string _cpuGuess;

        public Battle(string inUserInput, string inCpuGuess)
        {
            this._userInput = inUserInput;
            this._cpuGuess = inCpuGuess;
        }

        /// <summary>
        /// Used to work out the result of the user and cpu guesses.
        /// Was originally called "battleItOut"
        /// </summary>
        /// <returns>Whether the user or cpu has won, or whether a draw occurred</returns>
        public string getResult()
        {
            switch (_userInput)
            {
                case "rock":
                    if (_cpuGuess == "paper") return "cpu";
                    else if (_cpuGuess == "scissors") return "user";
                    break;
                case "paper":
                    if (_cpuGuess == "scissors") return "cpu";
                    else if (_cpuGuess == "rock") return "user";
                    break;
                case "scissors":
                    if (_cpuGuess == "rock") return "cpu";
                    else if (_cpuGuess == "paper") return "user";
                    break;
            }
            return "draw";
        }

        public override string ToString()
        {
            string data = "User input:\t" + _userInput;
            data += "\t\tCpu guess:\t" + _cpuGuess;
            data += Environment.NewLine + "Result:\t" + getResult() + Environment.NewLine;
            return data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Battle> battleSteps = new List<Battle>();
            while(true)
            {
                Console.Write("Enter your choice (Rock, Paper or Scissors): ");
                string userChoice =  Console.ReadLine().ToLower();

                // As long as the user doesn't enter "q", we'll keep playing
                if (userChoice != "q")
                {
                    Battle newBattle = new Battle(userChoice, generateGuess());
                    Console.WriteLine(newBattle.getResult());

                    battleSteps.Add(newBattle);
                }
                else
                    break;
            }

            foreach(Battle battle in battleSteps)
            {
                Console.WriteLine(battle.ToString());
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Weak random generation of cpu guess, using the number
        /// of seconds in the current minute as the seed for a
        /// randomly generated number. This number is then used
        /// as a basis for whether the cpu guess is rock (1),
        /// paper (2) or scissors (3)
        /// </summary>
        /// <returns>Cpu guess (rock, paper or scissors)</returns>
        static string generateGuess()
        {
            Random randChoice = new Random(System.DateTime.Now.Second);
            switch (randChoice.Next(1,3))
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                default:
                    throw new Exception("Random value generated was not as expected");
            }
        }
    }
}
