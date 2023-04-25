using PA4;

Game game = new Game();
game.StartGame("Player 1", "Player 2");


/*
class Program
{
    static Character player1;
    static Character player2;

    static bool playerOneTurn = true;
    static bool endGame = false;

    static void Main(string[] args)
    {
        WelcomeMessage();

        System.Console.WriteLine("Enter Player 1 name:");
        string pOneName = Console.ReadLine();

        System.Console.WriteLine("Enter Player 2 name:");
        string pTwoName = Console.ReadLine();


        System.Console.WriteLine($"Player 1 ({pOneName}), choose your character: 1) Davy Jones \t 2) Jack Sparrow \t 3) Will Turner");
        int pOneChoice = int.Parse(Console.ReadLine());


        System.Console.WriteLine($"Player 1 ({pTwoName}), choose your character: 1) Davy Jones \t 2) Jack Sparrow \t 3) Will Turner");
        int pTwoChoice = int.Parse(Console.ReadLine());


        switch(pOneChoice)
        {
            case 1:
                player1 = new DavyJones();
                break;
            case 2:
                player1 = new JackSparrow();
                break;
            case 3:
                player1 = new WillTurner();
                break;
            default:
                System.Console.WriteLine("Invalid character selection... Now you're stuck with Davy Jones");
                player1 = new DavyJones();
                break;
        }

        switch(pTwoChoice)
        {
            case 1:
                player2 = new DavyJones();
                break;
            case 2:
                player2 = new JackSparrow();
                break;
            case 3:
                player2 = new WillTurner();
                break;
            default:
                System.Console.WriteLine("Invalid character selection... Now you're stuck with Davy Jones");
                player2 = new DavyJones();
                break;
        }

        System.Console.WriteLine($"Player 1 has selected {player1.Name}");
        System.Console.WriteLine($"Player 2 has selected {player2.Name}");

        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("***************************");
        System.Console.WriteLine("Game Starting...");

        playerOneTurn = (new Random().Next(2) == 0);

        while(!endGame)
        {
            Character attacker;
            Character defender;

            if(playerOneTurn)
            {
                attacker = player1;
                defender = player2;
            }
            else
            {
                attacker = player2;
                defender = player1;
            }

            System.Console.WriteLine($"{attacker.Name}'s turn to attack...");

            attacker.AttackBehavior.Attack(attacker, defender);

            System.Console.WriteLine($"Player 1 ({player1.Name} stats: HP = {player1.HitPoints} \t Max Power = {player1.MaxPower})");
            System.Console.WriteLine($"Player 2 ({player2.Name} stats: HP = {player2.HitPoints} \t Max Power = {player2.MaxPower})");

            Thread.Sleep(2000);


            if(defender.HitPoints <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{defender.Name} has been defeated by {attacker.Name}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{attacker.Name} has won!");
                Console.ResetColor();
            }
        }
    }


    static void WelcomeMessage()
    {
            Console.BackgroundColor = ConsoleColor.Blue;

            System.Console.WriteLine(@"
                    |    |    |                 
                    )_)  )_)  )_)              
                    )___))___))___)\            
                )____)____)_____)\\
                _____|____|____|____\\\__
        ---------\                   /---------
        ^^^^^ ^^^^^^^^^^^^^^^^^^^^^
            ^^^^      ^^^^     ^^^    ^^
                ^^^^      ^^^
        ");

        System.Console.WriteLine("");
        System.Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom!");
        System.Console.WriteLine("");

        Console.ResetColor();
    }

    static void EndMessage()
    {

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("  _____          __  __ ______    ______      ________ _____  ");
        Console.WriteLine(" / ____|   /\\   |  \\/  |  ____|  / __ \\ \\    / /  ____|  __ \\ ");
        Console.WriteLine("| |  __   /  \\  | \\  / | |__    | |  | \\ \\  / /| |__  | |__) |");
        Console.WriteLine("| | |_ | / /\\ \\ | |\\/| |  __|   | |  | |\\ \\/ / |  __| |  _  / ");
        Console.WriteLine("| |__| |/ ____ \\| |  | | |____  | |__| | \\  /  | |____| | \\ \\ ");
        Console.WriteLine(" \\_____/_/    \\_\\_|  |_|______|  \\____/   \\/   |______|_|  \\_\\");

        Console.ResetColor();
    }

}

*/

