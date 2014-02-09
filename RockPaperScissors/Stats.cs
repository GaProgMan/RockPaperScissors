using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
   public class Stats
   {
      #region properties

      private int _winsField;
      private int _lossesField;
      private int _drawsField;
      private int _numberOfGames;

      private int _rockCPU;
      private int _paperCPU;
      private int _scissorsCPU;
      private int _lizardCPU;
      private int _spockCPU;

      private int _rockUser;
      private int _paperUser;
      private int _scissorsUser;
      private int _lizardUser;
      private int _spockUser;

      #endregion

      /// <summary>
      /// Default constructor
      /// </summary>
      public Stats()
      {
         this._winsField = 0;
         this._lossesField = 0;
         this._drawsField = 0;
         this._numberOfGames = 0;

         this._rockCPU = 0;
         this._scissorsCPU = 0;
         this._paperCPU = 0;
         this._lizardCPU = 0;
         this._spockCPU = 0;

         this._rockUser = 0;
         this._scissorsUser = 0;
         this._paperUser = 0;
         this._lizardUser = 0;
         this._spockUser = 0;
      }

      /// <summary>
      /// Used to generate the stats for the given game data
      /// </summary>
      /// <param name="inGameData">An array of game data to generate stats from</param>
      public void generateStats(List<Round> inGameData)
      {
         games = inGameData.Count;

         // Calculate outcome (wins, losses and draws) stats
         foreach (Round game in inGameData)
         {
            switch (game.getResult())
            {
               case Round.result.Win:
                  ++wins;
                  break;
               case Round.result.Loss:
                  ++losses;
                  break;
               case Round.result.Draw:
                  ++draws;
                  break;
            }

            // Calculate user move stats
            switch (game.UsersMove)
            {
               case Round.moves.Rock:
                  ++RockUser;
                  break;
               case Round.moves.Paper:
                  ++PaperUser;
                  break;
               case Round.moves.Scissors:
                  ++ScissorsUser;
                  break;
               case Round.moves.Lizard:
                  ++LizardUser;
                  break;
               case Round.moves.Spock:
                  ++SpockUser;
                  break;
            }

            // Calculate CPU move stats
            switch(game.CpuMove)
            {
               case Round.moves.Rock:
                  ++RockCPU;
                  break;
               case Round.moves.Paper:
                  ++PaperCPU;
                  break;
               case Round.moves.Scissors:
                  ++ScissorsCPU;
                  break;
               case Round.moves.Lizard:
                  ++LizardCPU;
                  break;
               case Round.moves.Spock:
                  ++SpockCPU;
                  break;
            }
         }
      }

      /// <summary>
      /// Used to convert all of the stats to a string
      /// </summary>
      /// <returns>The string representation of all stats</returns>
      public override string ToString()
      {
         string data = "";

         data += "Game Stats"    + Environment.NewLine;
         data += "\tWins: "      + this.wins + Environment.NewLine;
         data += "\tLosses:"     + this.losses + Environment.NewLine;
         data += "\tDraws: "     + this.draws + Environment.NewLine + Environment.NewLine;

         data += "User move stats"        + Environment.NewLine;
         data += "\tRock usage (%): "     + ((float)this.RockUser / (float)this.games) * 100 + Environment.NewLine;
         data += "\tPaper usage (%):"     + ((float)this.PaperUser / (float)this.games) * 100 + Environment.NewLine;
         data += "\tScissors usage (%): " + ((float)this.ScissorsUser / (float)this.games) * 100 + Environment.NewLine;
         data += "\tLizard usage (%): "   + ((float)this.LizardUser / (float)this.games) * 100 + Environment.NewLine;
         data += "\tSpock usage (%): "    + ((float)this.SpockUser / (float)this.games) * 100 + Environment.NewLine + Environment.NewLine;

         data += "CPU move stats"         + Environment.NewLine;
         data += "\tRock usage (%): "     + ((float)this.RockCPU / (float)this.games) * 100 + Environment.NewLine;
         data += "\tPaper usage (%):"     + ((float)this.PaperCPU / (float)this.games) * 100 + Environment.NewLine;
         data += "\tScissors usage (%): " + ((float)this.ScissorsCPU / (float)this.games) * 100 + Environment.NewLine;
         data += "\tLizard usage (%): "   + ((float)this.LizardCPU / (float)this.games) * 100 + Environment.NewLine;
         data += "\tSpock usage (%): "    + ((float)this.SpockCPU / (float)this.games) * 100 + Environment.NewLine + Environment.NewLine;

         return data;
      }

      #region Basic game data accessors and mutators

      /// <summary>
      /// Accessor and mutator for _winsField
      /// </summary>
      public int wins
      {
         get
         {
            return this._winsField;
         }
         set
         {
            this._winsField = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for _lossesField
      /// </summary>
      public int losses
      {
         get
         {
            return this._lossesField;
         }
         set
         {
            this._lossesField = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for _drawsField
      /// </summary>
      public int draws
      {
         get
         {
            return this._drawsField;
         }
         set
         {
            this._drawsField = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for number of games
      /// </summary>
      public int games
      {
         get
         {
            return this._numberOfGames;
         }
         set
         {
            this._numberOfGames = value;
         }
      }

      #endregion

      #region CPU usage accessors and mutators

      /// <summary>
      /// Accessor and mutator for rock CPU usage
      /// </summary>
      public int RockCPU
      {
         get
         {
            return this._rockCPU;
         }
         set
         {
            this._rockCPU = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Paper CPU usage
      /// </summary>
      public int PaperCPU
      {
         get
         {
            return this._paperCPU;
         }
         set
         {
            this._paperCPU = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Scissors CPU usage
      /// </summary>
      public int ScissorsCPU
      {
         get
         {
            return this._scissorsCPU;
         }
         set
         {
            this._scissorsCPU = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Lizard CPU usage
      /// </summary>
      public int LizardCPU
      {
         get
         {
            return this._lizardCPU;
         }
         set
         {
            this._lizardCPU = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Spock CPU usage
      /// </summary>
      public int SpockCPU
      {
         get
         {
            return this._spockCPU;
         }
         set
         {
            this._spockCPU = value;
         }
      }

      #endregion

      #region User usage accessors and mutators

      /// <summary>
      /// Accessor and mutator for rock User usage
      /// </summary>
      public int RockUser
      {
         get
         {
            return this._rockUser;
         }
         set
         {
            this._rockUser = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Paper User usage
      /// </summary>
      public int PaperUser
      {
         get
         {
            return this._paperUser;
         }
         set
         {
            this._paperUser = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Scissors User usage
      /// </summary>
      public int ScissorsUser
      {
         get
         {
            return this._scissorsUser;
         }
         set
         {
            this._scissorsUser = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Lizard User usage
      /// </summary>
      public int LizardUser
      {
         get
         {
            return this._lizardUser;
         }
         set
         {
            this._lizardUser = value;
         }
      }

      /// <summary>
      /// Accessor and mutator for Spock User usage
      /// </summary>
      public int SpockUser
      {
         get
         {
            return this._spockUser;
         }
         set
         {
            this._spockUser = value;
         }
      }

      #endregion
   }
}
