
Console.Title = "Destroying the Manticore"; // console window title




Game(); // calling the method
/// <summary> 
/// we use "break" keyword to EXIT while loop,
/// if we used "return" we would exit the whole method itself
/// no need to use "else" because we are already in the endless loop,
/// the same quiestion will be asked if user enters a wrong number anyway.
/// The only way to exit this loop is entering a number in the range. 
/// if round is a multiplacation of both 3 and 5 (damage 10 will be dealt)
/// if only of 3 (damage 3 will be dealt)
/// if only of 5 (damage 3 will be dealt)
/// </summary>          
void Game()
{
    // --- PART 1: STATIONING THE MANTICORE ---
    int chosenNumber = 0;
    Console.ForegroundColor = ConsoleColor.Magenta; // setting color for the first user



    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");

    while (true) // eternal loop
    {
        Console.Write("Choose a number from 0 to 100: "); // asking a number from user
        chosenNumber = Convert.ToInt32(Console.ReadLine()); // parsing string to int (chosenNumber = 0 ---> user's number)

        // this "if" statement is the only way to exit this endless loop
        if (chosenNumber <= 100 && chosenNumber >= 0) // if this number is in the range
        {
            break; // exits loop
        }
    }
    Console.Clear(); // clears everything

    // --- PART 2: THE MAIN GAMEPLAY ---
    Console.ForegroundColor = ConsoleColor.White; // setting color back to default 

    int manticoreHP = 10, cityHP = 15; // initializing variables
    int round = 1;

    Console.WriteLine("Player 2, it's your turn");

    while (manticoreHP > 0 && cityHP > 0) // while both aren't destroyed yet
    {

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round}  City: {cityHP}/15  Manticore: {manticoreHP}/10 "); // round increases due to "round++"

        // CALCULATING DAMAGE FOR EACH ROUND
        int damage = 0; // initializing damage


        if (round % 3 == 0 && round % 5 == 0) // fire + electricity
        {
            damage = 10; // super blast which deals 10 damage
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This round is a multiplacation of both 3 and 5!");
        }
        else if (round % 3 == 0) // fire only
        {
            damage = 3; // deals 3 damage
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This round is multiplacation of 3!");
        }
        else if (round % 5 == 0) // electricity only
        {
            damage = 3; // deals 3 damage
            Console.ForegroundColor = ConsoleColor.Blue; // anything that will be printed out into the console is going to be blue
                                                         // but only in case if condition in the parenthesses is true
        }
        else // normal shot
        {
            damage = 1; // deals only 1 damage
            Console.ForegroundColor = ConsoleColor.White;
        }
        // damage depends only on round 
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

        Console.ForegroundColor = ConsoleColor.White; // setting back to default

        // ASKING USER TO SHOOT THE MANTICORE (to enter a number which has to match the 1st user's number, and if it does, substract specified damage)
        Console.Write("Enter desired cannon range: ");
        int guessedNumber = Convert.ToInt32(Console.ReadLine()); // converting string to int

        // LOGIC OF THE GAME

        if (guessedNumber > chosenNumber) // too big
        {
            Console.WriteLine("That round OVERSHOT the target. ");


        }
        else if (guessedNumber < chosenNumber) // too small
        {
            Console.WriteLine("That round FELL SHORT of the target.");


        }
        else // if guessedNumber == chosenNumber
        {
            Console.WriteLine("That round was a DIRECT HIT!");
            manticoreHP = manticoreHP - damage; // substracting HP from manticore (dealing damage) depending on the round counter
        }

        if (manticoreHP > 0) // if the manticore is still alive
        {
            cityHP = cityHP - 1; // substract 1 from city's health
        }

        round++; // since we don't know how many iterations there will be, we just increase round number by 1 each time
    }

    // FINAL
    if (manticoreHP <= 0) // if the manticore is destroyed
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        return; // exiting method
    }
    else // vice versa
    {
        Console.WriteLine("Our city is destroyed! You couldn't eliminate the Manticore...");
        Console.WriteLine("Restart the game and try again");
        return; // exiting method

    }
}


