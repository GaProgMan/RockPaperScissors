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
      public enum moves { Rock, Paper, Scissors, Lizard, Spock };

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
            case moves.Rock:
               if (_cpuMove == moves.Scissors || _cpuMove == moves.Lizard)
                  return "User";
               else if (_cpuMove == moves.Spock || _cpuMove == moves.Paper)
                  return "Cpu";
               break;
            case moves.Paper:
               if (_cpuMove == moves.Rock || _cpuMove == moves.Spock)
                  return "User";
               else if (_cpuMove == moves.Lizard || _cpuMove == moves.Scissors)
                  return "Cpu";
               break;
            case moves.Scissors:
               if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
                  return "User";
               else if (_cpuMove == moves.Spock || _cpuMove == moves.Rock)
                  return "Cpu";
               break;
            case moves.Lizard:
               if (_cpuMove == moves.Paper || _cpuMove == moves.Spock)
                  return "User";
               else if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
                  return "Cpu";
               break;;
            case moves.Spock:
               if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
                  return "User";
               else if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
                  return "Cpu";
               break;
         }
         return "Draw";
      }

      /// <summary>
      /// Overidden ToString method. Used to format the most recent
      /// round, ready to output to the console
      /// </summary>
      /// <returns>The most recent round, as a formatted string</returns>
      public override string ToString()
      {
         string data = "User move:\t" + _userMove.ToString() + Environment.NewLine;
         data += "Cpu move:\t" + _cpuMove.ToString() + Environment.NewLine;
         data += "Result:\t\t" + getResult() + Environment.NewLine;
         return data;
      }
   }

   public class Program
   {
      static void Main(string[] args)
      {
            GameForm newGameForm = new GameForm();
            newGameForm.ShowDialog();
      }
   }
}
