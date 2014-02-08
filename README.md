RockPaperScissors
=================

Basic Rock Paper Scissors game implemented in C#

### Game Loop

* The user is asked to enter their guess.
* A "random" number between 1 and 3 is generated, these map to Rock, Paper and Scissors (respectively)
* The number is used to represent the CPU guess
* Both the user and CPU guesses are used to generate the outcome of the round
* The outcome of the round is dumped to the console
* The details from the round are added to a list of rounds

When the user enters a "q", the game loop exits. Once the game loop has exited, each round is dumped to the console as a formatted string.
