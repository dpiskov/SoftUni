namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            
            //Rules
            Console.WriteLine("What are the rules?");
            Console.WriteLine(" - If you choose Rock, you will win against Scissors but lose against Paper.");
            Console.WriteLine(" - If you choose Scissors, you will win against Paper but lose against Rock.");
            Console.WriteLine(" - If you choose Paper, you will win against Rock but lose against Scissors.");
            Console.WriteLine();
            Console.WriteLine($"The game ends when somebody gets 3 wins.");
            Console.WriteLine();

            while (true)
            {
                int playerWins = 0;
                int computerWins = 0;

                while (playerWins < 3 && computerWins < 3)
                {
                    const string Rock = "Rock";
                    const string Paper = "Paper";
                    const string Scissors = "Scissors";

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                    string playerMove = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;

                    if (playerMove == "r" || playerMove == "rock")
                    {
                        playerMove = Rock;
                    }
                    else if (playerMove == "p" || playerMove == "paper")
                    {
                        playerMove = Paper;
                    }
                    else if (playerMove == "s" || playerMove == "scissors")
                    {
                        playerMove = Scissors;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again...");
                        return;
                    }

                    Random random = new Random();
                    int computerRandomNumber = random.Next(1, 4);
                    string computerMove = "";

                    switch (computerRandomNumber)
                    {
                        case 1: computerMove = Rock; break;
                        case 2: computerMove = Paper; break;
                        case 3: computerMove = Scissors; break;
                    }

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"The computer chose {computerMove}.");

                    if ((playerMove == Rock && computerMove == Scissors) ||
                        (playerMove == Paper && computerMove == Rock) ||
                        (playerMove == Scissors && computerMove == Paper))
                    {
                        //Console.WriteLine("You win.");
                        Console.WriteLine($"Player wins the round.");
                        playerWins++;
                    }
                    else if ((playerMove == Rock && computerMove == Paper) ||
                        (playerMove == Paper && computerMove == Scissors) ||
                        (playerMove == Scissors && computerMove == Rock))
                    {
                        Console.WriteLine($"Computer wins the round.");
                        //Console.WriteLine("You lose.");
                        computerWins++;
                    }
                    else
                    {
                        //Console.WriteLine("This game was a draw.");
                        Console.WriteLine("This round was a draw.");
                    }


                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("Type [yes] to Play Again or [no] to quit: ");

                Console.ForegroundColor = ConsoleColor.White;

                string input = Console.ReadLine();
                Console.WriteLine();             

                if (input == "no")
                {                
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine();

                    if (playerWins == 3)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computerWins == 3)
                    {
                        Console.WriteLine("You lose!");
                    }

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;


                    Console.WriteLine("Score:");

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"Player: {playerWins}");
                    Console.WriteLine($"Computer: {computerWins}");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Thank you for playing!");

                    Console.ForegroundColor = ConsoleColor.White;

                    return;
                }

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Score:");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"Player: {playerWins}");
                Console.WriteLine($"Computer: {computerWins}");
                Console.WriteLine();
            }
        }
    }
}