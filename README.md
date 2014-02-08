RockPaperScissors
=================

Basic "Rock, Paper, Scissors, Lizard, Spock" game implemented in C#.

The rules for "Rock, Paper, Scissors, Lizard, Spock" can be viewed on wikipedia at this link: http://en.wikipedia.org/wiki/Rock-paper-scissors-lizard-Spock

Game Loop
---------

* The user is asked to enter their guess.
* A "random" number between 1 and 5 is generated, these map to Rock, Paper, Scissors, Lizard or Spock (respectively)
* The number is used to represent the CPU guess
* Both the user and CPU guesses are used to generate the outcome of the round
* The outcome of the round is dumped to the console
* The details from the round are added to a list of rounds

When the user enters a "q", the game loop exits. Once the game loop has exited, each round is dumped to the console as a formatted string.
