using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
   public partial class GameForm : Form
   {
      private Round.moves userMove;
      private Round.moves cpuMove;
      private Round currentRound;
      public List<Round> gameData;

      public GameForm()
      {
         InitializeComponent();

         // Set up drop down list with all values from the Round.moves
         // enumeration, and default to the 0th item
         drpAvailableMoves.Items.Clear();
         foreach (string moveName in Enum.GetNames(typeof(Round.moves)))
         {
            drpAvailableMoves.Items.Add(moveName);
         }
         drpAvailableMoves.SelectedIndex = 0;

         // Ensure that we have a new list to store all game data in
         gameData = new List<Round>();
      }

      private void btnUseMove_Click(object sender, EventArgs e)
      {
         // Parse the user input to a Round.moves enum value
         userMove = parseUserInput(drpAvailableMoves.SelectedItem.ToString());

         // Generate the data for this round
         cpuMove = generateGuess();
         currentRound = new Round(userMove, cpuMove);

         // Add the data from this round to the list of previous
         // rounds
         gameData.Add(currentRound);

         // Write the result of this round to the log
         rtbResults.AppendText("Game number: " + gameData.Count + Environment.NewLine);
         rtbResults.AppendText("______________" + Environment.NewLine);
         rtbResults.AppendText(currentRound.ToString() + Environment.NewLine);

         // Ensure we scroll to the end of the line
         rtbResults.ScrollToCaret();
      }

      /// <summary>
      /// Used to parse the user input move string to a Round.moves enum
      /// </summary>
      /// <param name="inUserInput">The user onput move string</param>
      /// <returns>A Round.moves enum</returns>
      private Round.moves parseUserInput(string inUserInput)
      {
         switch (inUserInput)
         {
            case "Rock":
               return Round.moves.Rock;
            case "Paper":
               return Round.moves.Paper;
            case "Scissors":
               return Round.moves.Scissors;
            case "Lizard":
               return Round.moves.Lizard;
            case "Spock":
               return Round.moves.Spock;
            default:
               throw new Exception("Move name cannot be found for user inputted value (" + inUserInput + ")");
         }
      }

      /// <summary>
      /// Weak random generation of cpu guess, using the number
      /// of seconds in the current minute as the seed for a
      /// randomly generated number. This number is then used
      /// as a basis for whether the cpu guess is Rock (1),
      /// Paper (2) or Scissors (3)
      /// </summary>
      /// <returns>Cpu guess (Rock, Paper or Scissors)</returns>
      private Round.moves generateGuess()
      {
         // Extremely bad algorithm for generating the CPU guess
         Random randChoice = new Random(System.DateTime.Now.Second);
         switch (randChoice.Next(1, 5))
         {
            case 1:
               return Round.moves.Rock;
            case 2:
               return Round.moves.Paper;
            case 3:
               return Round.moves.Scissors;
            case 4:
               return Round.moves.Lizard;
            case 5:
               return Round.moves.Spock;
            default:
               throw new Exception("Random value generated was not as expected");
         }
      }
   }
}
