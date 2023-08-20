
//https://github.com/MichaelDSwope/Rochambeau_LAB.git
//ROSHAMBO: ROCK PAPER SCISSORS
//Objectives: Enumerations, Abstract Classes

//Task: Create a rock, paper, scissors game.

//What will the application do?
//The application prompts the player to enter a name and select an opponent.
//The application prompts the player to select rock, paper, or scissors. Then, the application displays the player’s choice, the opponent’s choice, and the result of the match.
//The application continues until the user doesn’t want to play anymore.
//If the user makes an invalid selection, the application should display an appropriate error message and prompt the user again until the user makes a valid selection.

//Build Specifications:
//Create an enumeration called Roshambo that has three values: rock, paper, and scissors.
//Create an abstract class named Player that stores a name and a Roshambo value. This class should include a method named GenerateRoshambo that allows an inheriting class to generate and return a Roshambo value.
//Create and name three player subclasses:
//RockPlayer - Always throws Rock 
//RandomPlayer - Picks and throws a value at random 
//HumanPlayer - Allows the user to select and throw a value. Upon creating an instance of this class, allow the user to input their name.
//Create a main where you create a HumanPlayer and then allow them to choose their opponent: either RockPlayer or RandomPlayer.
//Validate your user inputs throughout your app. Try catch blocks, if statements, or any other method of validation is good.

//Hints:
//Paper beats rock, rock beats scissors, scissors beats paper.

//Extra Challenges:
//Create a Validator class to handle validation of all console input. It could have methods like GetYN (gets Y/y or N/n), GetOtherPlayer(accepts the names of your two players), GetRoshambo(accepts r / p / s and / or rock / paper / scissors).
//Keep track of wins and losses, and display them at the end of each session.
Console.WriteLine("Welcome to Rock, Paper, Scissors!");

// Get Player 1 input
        Console.Write("Player 1, enter your choice (rock, paper, or scissors): ");
        string player1Choice = GetHiddenInput();
            
        // Get Player 2 input
        Console.Write("Player 2, enter your choice (rock, paper, or scissors): ");
        string player2Choice = GetHiddenInput();
            
        // Determine the GameWinner
        string winner = GameWinner(player1Choice, player2Choice);
            
        // Display the result
        Console.WriteLine($"Player 1 chose: {player1Choice}");
        Console.WriteLine($"Player 2 chose: {player2Choice}");
        Console.WriteLine($"The winner is: {winner}");
        
        
        static string GetHiddenInput()
        {
            string input = "";
            ConsoleKeyInfo keyAstrisk;
            
            do
            {
                keyAstrisk = Console.ReadKey(true);
                
                if (keyAstrisk.Key != ConsoleKey.Backspace && keyAstrisk.Key != ConsoleKey.Enter)
                {
                    input += keyAstrisk.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyAstrisk.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input.Substring(0, input.Length - 1);
                       
                    }
                }
            } while (keyAstrisk.Key != ConsoleKey.Enter);
            
            return input;
        }
        
        static string GameWinner(string choice1, string choice2)
        {
            if (choice1 == choice2) 
                return "It's a tie!";
            
            if ((choice1 == "rock" && choice2 == "scissors") ||
                (choice1 == "scissors" && choice2 == "paper") ||
                (choice1 == "paper" && choice2 == "rock"))
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }
        }

