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
      public enum moves { rock, paper, scissors, lizard, spock, q };

      private moves _userMove;
      private moves _cpuMove;

      public Round(moves inUserMove, moves inCpuMove)
      {
         this._userMove = inUserMove;
         this._cpuMove = inCpuMove;
      }

      /// <summary>
      /// Used to calculate the result of the current round
      /// </summary>
      /// <returns>A string (either "user" or "cpu") which represents the winner of the round</returns>
      public string getResult()
      {
         switch (_userMove)
         {
            case moves.rock:
               if (_cpuMove == moves.scissors || _cpuMove == moves.lizard)
                  return "user";
               else if(_cpuMove == moves.spock || _cpuMove == moves.paper)
                  return "cpu";
               break;
            case moves.paper:
               if (_cpuMove == moves.rock || _cpuMove == moves.spock)
                  return "user";
               else if(_cpuMove == moves.lizard || _cpuMove == moves.scissors)
                  return "cpu";
               break;
            case moves.scissors:
               if (_cpuMove == moves.paper || _cpuMove == moves.lizard)
                  return "user";
               else if(_cpuMove == moves.spock || _cpuMove == moves.rock)
                  return "cpu";
               break;
            case moves.lizard:
               if (_cpuMove == moves.paper || _cpuMove == moves.spock)
                  return "user";
               else if(_cpuMove == moves.scissors || _cpuMove == moves.rock)
                  return "cpu";
               break;;
            case moves.spock:
               if (_cpuMove == moves.scissors || _cpuMove == moves.rock)
                  return "user";
               else if(_cpuMove == moves.paper || _cpuMove == moves.lizard)
                  return "cpu";
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
         string data = "User move:\t" + _userMove.ToString();
         data += "\t\tCpu move:\t" + _cpuMove.ToString();
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
            Console.WriteLine("Enter your choice (Rock, Paper, Scissors, Lizard or Spock - or \"q\" to quit): ");

            // Parse the user input to a Round.moves enum value
            Round.moves userMove = parseUserInput(Console.ReadLine().ToLower());

            //string userChoice = Console.ReadLine().ToLower();

            // As long as the user doesn't enter "q", we'll keep playing
            if (userMove != Round.moves.q)
            {
               // Generate the data for this round
               Round newRound = new Round(userMove, generateGuess());
               //Round newRound = new Round(userChoice, generateGuess());

               // Write the result of this round to the console
               Console.WriteLine(Environment.NewLine + newRound.getResult());

               // Add the data from this round to the list of previous
               // rounds
               previousRounds.Add(newRound);
            }
            else
               break;
         }

         // When the user/player decides to quit, dump the results
         // from each round to the console
         Console.WriteLine(Environment.NewLine);
         if (previousRounds.Count > 0)
         {
            foreach (Round prevRound in previousRounds)
            {
               Console.WriteLine(prevRound.ToString());
            }
         }
         else
         {
            Console.WriteLine("No rounds stored.");
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
      static Round.moves generateGuess()
      {
         // Extremely bad algorithm for generating the CPU guess
         Random randChoice = new Random(System.DateTime.Now.Second);
         switch (randChoice.Next(1, 5))
         {
            case 1:
               return Round.moves.rock;
            case 2:
               return Round.moves.paper;
            case 3:
               return Round.moves.scissors;
            case 4:
               return Round.moves.lizard;
            case 5:
               return Round.moves.spock;
            default:
               throw new Exception("Random value generated was not as expected");
         }
      }

      /// <summary>
      /// Used to parse the user input move string to a Round.moves enum
      /// </summary>
      /// <param name="inUserInput">The user onput move string</param>
      /// <returns>A Round.moves enum</returns>
      static Round.moves parseUserInput(string inUserInput)
      {
         switch (inUserInput)
         {
            case "rock":
               return Round.moves.rock;
            case "paper":
               return Round.moves.paper;
            case "scissors":
               return Round.moves.scissors;
            case "lizard":
               return Round.moves.lizard;
            case "spock":
               return Round.moves.spock;
            default:
               return Round.moves.q;
         }
      }
   }
}
