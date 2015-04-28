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
      public enum result { Win, Loss, Draw };

      private moves _userMove;
      private moves _cpuMove;
      private result _result;

      public Round(moves inUserMove, moves inCpuMove)
      {
         this._userMove = inUserMove;
         this._cpuMove = inCpuMove;
      }

      ///// <summary>
      ///// Used to calculate the result of the current round
      ///// </summary>
      ///// <returns>A string (either "user" or "cpu") which represents the winner of the round</returns>
      //public string getResult()
      //{
      //   switch (_userMove)
      //   {
      //      case moves.Rock:
      //         if (_cpuMove == moves.Scissors || _cpuMove == moves.Lizard)
      //            return "User";
      //         else if (_cpuMove == moves.Spock || _cpuMove == moves.Paper)
      //            return "Cpu";
      //         break;
      //      case moves.Paper:
      //         if (_cpuMove == moves.Rock || _cpuMove == moves.Spock)
      //            return "User";
      //         else if (_cpuMove == moves.Lizard || _cpuMove == moves.Scissors)
      //            return "Cpu";
      //         break;
      //      case moves.Scissors:
      //         if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
      //            return "User";
      //         else if (_cpuMove == moves.Spock || _cpuMove == moves.Rock)
      //            return "Cpu";
      //         break;
      //      case moves.Lizard:
      //         if (_cpuMove == moves.Paper || _cpuMove == moves.Spock)
      //            return "User";
      //         else if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
      //            return "Cpu";
      //         break; ;
      //      case moves.Spock:
      //         if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
      //            return "User";
      //         else if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
      //            return "Cpu";
      //         break;
      //   }
      //   return "Draw";
      //}

      /// <summary>
      /// Calculates and returns the result fo the current round
      /// </summary>
      /// <returns>The result fo the current round</returns>
      public result getResult()
      {
         generateResult();
         return this._result;
      }

      /// <summary>
      /// Used to calculate the result of the current round - storing
      /// it in the local restul variable
      /// </summary>
      private void generateResult()
      {
		 // Default value - not caught by the switch or if statements
		 // as there are too many possible instances
		 this._result = draw;
         switch (_userMove)
         {
            case moves.Rock:
               if (_cpuMove == moves.Scissors || _cpuMove == moves.Lizard)
                  this._result = result.Win;
               else if (_cpuMove == moves.Spock || _cpuMove == moves.Paper)
                  this._result = result.Loss;
               break;
            case moves.Paper:
               if (_cpuMove == moves.Rock || _cpuMove == moves.Spock)
                  this._result = result.Win;
               else if (_cpuMove == moves.Lizard || _cpuMove == moves.Scissors)
                  this._result = result.Loss;
               break;
            case moves.Scissors:
               if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
                  this._result = result.Win;
               else if (_cpuMove == moves.Spock || _cpuMove == moves.Rock)
                  this._result = result.Loss;
               break;
            case moves.Lizard:
               if (_cpuMove == moves.Paper || _cpuMove == moves.Spock)
                  this._result = result.Win;
               else if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
                  this._result = result.Loss;
               break; ;
            case moves.Spock:
               if (_cpuMove == moves.Scissors || _cpuMove == moves.Rock)
                  this._result = result.Win;
               else if (_cpuMove == moves.Paper || _cpuMove == moves.Lizard)
                  this._result = result.Loss;
               break;
            default:
               this._result = result.Draw;
               break;
         }
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

      /// <summary>
      /// Accessor and mutator for _userMove
      /// </summary>
      public moves UsersMove
      {
         get
         {
            return this._userMove;
         }
         set
         {
            this._userMove = value;
         }
      }

      /// <summary>
      /// Accessor and Mutator for _cpuMove
      /// </summary>
      public moves CpuMove
      {
         get
         {
            return this._cpuMove;
         }
         set
         {
            this._cpuMove = value;
         }
      }
   }
}
