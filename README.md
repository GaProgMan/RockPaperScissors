RockPaperScissors
=================

Short Description
-----------------

Basic "Rock, Paper, Scissors, Lizard, Spock" game implemented in C#.

The rules for "Rock, Paper, Scissors, Lizard, Spock" can be viewed on wikipedia at this link: http://en.wikipedia.org/wiki/Rock-paper-scissors-lizard-Spock

A pictorial version of the rules can be seen in the following image (via wikipedia)

!["Rock, Paper, Scissors, Lizard, Spock" rules](http://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Rock_Paper_Scissors_Lizard_Spock_en.svg/500px-Rock_Paper_Scissors_Lizard_Spock_en.svg.png)

Game Loop
---------

* The user is asked to pick their move from a list of available moves.
* A "random" number between 1 and 5 is generated, these map to Rock, Paper, Scissors, Lizard or Spock (respectively)
* The number is used to represent the CPU move
* Both the user and CPU moves are used to generate the outcome of the round
* The outcome of the round is dumped to the console
* The details from the round are added to a list of rounds

The game continues until the user/player closes the main game form.

Compiled Binary Download
------------------------

I have prepared a pre-compiled x86 binary for Microsoft Windows within a compressed zip file at the following link: http://gaprogman.com/CompiledBinaries/RockPaperScissors.zip

It was compiled using Microsoft Visual Studio 2013 (version 12.0.21005.1 REL) against .NET version 4.5.50938. In order to run this binary, you may need to upgrade the version of the .NET framework that your computer is running.