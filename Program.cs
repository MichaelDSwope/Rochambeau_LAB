
        
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
