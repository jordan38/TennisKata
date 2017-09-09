# Tennis Kata

The goal of the Tennis kata are reproduced the score of the tennis Game

## Feature 1 - Scoring a Game in Real Time

We want a program that can be used to score a game in real time, so we can use it for all of the tennis related endeavours we plan to undertake in the future. To begin with, we're going to need a way to update the score when a player wins a point, see what the current score is after each service, and see if their is a winner based on the current score and the rules above.

### Winning a Point increases Score Correctly

* Given the score is 0:0
When the server wins a point
Then the score is 15:0

* Given the score is 15:15
When the receiver wins a point
Then the score is 15:30

* Given the score is 30:30
When the server wins a point
Then the score is 40:30

### Deuce and Advantage are Scored Correctly

* Given the score is 40:40
When the receiver wins a point
Then the score should be 40:A

* Given the score is A:40
When the receiver wins a point
Then the score should be 40:40

### Winning Points are Scored Correctly

* Given the score is 40:30
When the server wins a point
Then the server should win

* Given the score is 40:A
When the receiver wins a point
Then the receiver should win

@Source http://agilekatas.co.uk/katas/Tennis-Kata
