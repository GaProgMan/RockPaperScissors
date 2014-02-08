using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
   /// <summary>
   /// Represents a single round
   /// </summary>
   public class Round
   {
      private string _userInput;
      private string _cpuGuess;

      /// <summary>
      /// Default constructor
      /// </summary>
      /// <param name="inUserInput">The user input value (rock, paper or scissors)</param>
      /// <param name="inCpuGuess">The cpu chosen value (rock, paper or scissors)</param>
      public Round(string inUserInput, string inCpuGuess)
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

      /// <summary>
      /// Overidden ToString method. Used to format the most recent
      /// round, ready to output to the console
      /// </summary>
      /// <returns>The most recent round, as a formatted string</returns>
      public override string ToString()
      {
         string data = "User input:\t" + _userInput;
         data += "\t\tCpu guess:\t" + _cpuGuess;
         data += Environment.NewLine + "Result:\t" + getResult() + Environment.NewLine;
         return data;
      }
   }

   public class Program
   {
      static void Main(string[] args)
      {
         // Create a list of rounds to store all game data in
         List<Round> previousRounds = new List<Round>();

         // Primitive game loop - continue looping here until the
         // user/player wants to quit
         while (true)
         {
            Console.Write("Enter your choice (Rock, Paper or Scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            // As long as the user doesn't enter "q", we'll keep playing
            if (userChoice != "q")
            {
               // Generate the data for this round
               Round newRound = new Round(userChoice, generateGuess());

               // Write the result of this round to the console
               Console.WriteLine(newRound.getResult());

               // Add the data from this round to the list of previous
               // rounds
               previousRounds.Add(newRound);
            }
            else
               break;
         }

         // When the user/player decides to quit, dump the results
         // from each round to the console
         foreach (Round prevRound in previousRounds)
         {
            Console.WriteLine(prevRound.ToString());
         }

         // Give the user/player a chance to read the console data
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
         // Extremely bad algorithm for generating the CPU guess
         Random randChoice = new Random(System.DateTime.Now.Second);
         switch (randChoice.Next(1, 3))
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
