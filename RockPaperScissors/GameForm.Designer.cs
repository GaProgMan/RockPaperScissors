namespace RockPaperScissors
{
   partial class GameForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
         this.grpResults = new System.Windows.Forms.GroupBox();
         this.rtbResults = new System.Windows.Forms.RichTextBox();
         this.drpAvailableMoves = new System.Windows.Forms.ComboBox();
         this.lblUSerMoveHEader = new System.Windows.Forms.Label();
         this.btnUseMove = new System.Windows.Forms.Button();
         this.pbRules = new System.Windows.Forms.PictureBox();
         this.grpResults.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbRules)).BeginInit();
         this.SuspendLayout();
         // 
         // grpResults
         // 
         this.grpResults.Controls.Add(this.pbRules);
         this.grpResults.Controls.Add(this.rtbResults);
         this.grpResults.Location = new System.Drawing.Point(12, 39);
         this.grpResults.Name = "grpResults";
         this.grpResults.Size = new System.Drawing.Size(460, 183);
         this.grpResults.TabIndex = 0;
         this.grpResults.TabStop = false;
         this.grpResults.Text = "Results";
         // 
         // rtbResults
         // 
         this.rtbResults.Location = new System.Drawing.Point(6, 19);
         this.rtbResults.Name = "rtbResults";
         this.rtbResults.ReadOnly = true;
         this.rtbResults.Size = new System.Drawing.Size(222, 158);
         this.rtbResults.TabIndex = 0;
         this.rtbResults.Text = "";
         // 
         // drpAvailableMoves
         // 
         this.drpAvailableMoves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.drpAvailableMoves.FormattingEnabled = true;
         this.drpAvailableMoves.Location = new System.Drawing.Point(110, 12);
         this.drpAvailableMoves.Name = "drpAvailableMoves";
         this.drpAvailableMoves.Size = new System.Drawing.Size(130, 21);
         this.drpAvailableMoves.TabIndex = 1;
         // 
         // lblUSerMoveHEader
         // 
         this.lblUSerMoveHEader.AutoSize = true;
         this.lblUSerMoveHEader.Location = new System.Drawing.Point(12, 15);
         this.lblUSerMoveHEader.Name = "lblUSerMoveHEader";
         this.lblUSerMoveHEader.Size = new System.Drawing.Size(92, 13);
         this.lblUSerMoveHEader.TabIndex = 2;
         this.lblUSerMoveHEader.Text = "Select your move:";
         // 
         // btnUseMove
         // 
         this.btnUseMove.Location = new System.Drawing.Point(347, 10);
         this.btnUseMove.Name = "btnUseMove";
         this.btnUseMove.Size = new System.Drawing.Size(125, 23);
         this.btnUseMove.TabIndex = 3;
         this.btnUseMove.Text = "Perform Move";
         this.btnUseMove.UseVisualStyleBackColor = true;
         this.btnUseMove.Click += new System.EventHandler(this.btnUseMove_Click);
         // 
         // pbRules
         // 
         this.pbRules.Image = ((System.Drawing.Image)(resources.GetObject("pbRules.Image")));
         this.pbRules.Location = new System.Drawing.Point(262, 17);
         this.pbRules.Name = "pbRules";
         this.pbRules.Size = new System.Drawing.Size(160, 160);
         this.pbRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pbRules.TabIndex = 1;
         this.pbRules.TabStop = false;
         // 
         // GameForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 234);
         this.Controls.Add(this.btnUseMove);
         this.Controls.Add(this.lblUSerMoveHEader);
         this.Controls.Add(this.drpAvailableMoves);
         this.Controls.Add(this.grpResults);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "GameForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Rock, Paper, Scissors, Lizard, Spock";
         this.grpResults.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pbRules)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox grpResults;
      private System.Windows.Forms.RichTextBox rtbResults;
      private System.Windows.Forms.ComboBox drpAvailableMoves;
      private System.Windows.Forms.Label lblUSerMoveHEader;
      private System.Windows.Forms.Button btnUseMove;
      private System.Windows.Forms.PictureBox pbRules;
   }
}