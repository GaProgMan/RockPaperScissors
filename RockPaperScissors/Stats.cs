﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
   public class Stats
   {
      private int _winsField;
      private int _lossesField;
      private int _drawsField;

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

      /// <summary>
      /// Default constructor
      /// </summary>
      public Stats()
      {
         this._winsField = 0;
         this._lossesField = 0;
         this._drawsField = 0;

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
      public void generateStats(Round[] inGameData)
      {
         // Calculate outcome (wins, losses and draws) stats
         foreach (Round game in inGameData)
         {
            switch (game.getResult())
            {
               case Round.result.Win:
                  ++this._winsField;
                  break;
               case Round.result.Loss:
                  ++this._lossesField;
                  break;
               case Round.result.Draw:
                  ++this._drawsField;
                  break;
            }

            // Calculate user move stats
            switch (game.UsersMove)
            {
               case Round.moves.Rock:
                  ++this._rockUser;
                  break;
               case Round.moves.Paper:
                  ++this._paperUser;
                  break;
               case Round.moves.Scissors:
                  ++this._scissorsUser;
                  break;
               case Round.moves.Lizard:
                  ++this._lizardUser;
                  break;
               case Round.moves.Spock:
                  ++this._spockUser;
                  break;
            }

            // Calculate CPU move stats
            switch(game.CpuMove)
            {
               case Round.moves.Rock:
                  ++this._rockCPU;
                  break;
               case Round.moves.Paper:
                  ++this._paperCPU;
                  break;
               case Round.moves.Scissors:
                  ++this._scissorsCPU;
                  break;
               case Round.moves.Lizard:
                  ++this._lizardCPU;
                  break;
               case Round.moves.Spock:
                  ++this._spockCPU;
                  break;
            }
         }
      }

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
   }
}
