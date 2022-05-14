# cse210-02
HiLo Game \n
This game is a HiLo game so the user will see a card value and then have to guess if the next card will be higher or lower. If they guess correctly they will gain 100 points if they guess it wrong they lose 75 points. The game goes until the player goes to or under 0 or they choose to end the game with their current score. Everytime the game starts the player will start with 300 points.
The following files are my HiLo game files. 
The project.cs is the main file running all the other class files.
card.cs is a class that holds attributes for the card mainly just the card's value so a number between 1-13. This class also has two methods the pull method is what I use to get a random value for the card, the other method is what I use to return the cards value.
dealer.cs is where most of the logic in my program is and controls the flow, checking for updates, inputs and doing constant updates on the game, such as pulling a new card everytime you play or checking which card is higher.
