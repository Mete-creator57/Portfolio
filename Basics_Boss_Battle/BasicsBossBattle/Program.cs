
Console.Title = "Destroying the Manticore";
 
/// <summary> 
/// critical point: we have to create a variable outside loops iw we want to use them later in code,
/// but if we create something inside loops it will remain there forever
/// however we can modify values of ALREADY CREATED variables inside loops 
/// and the variable outside will be modified as well
/// </summary>
int chosenNumber = 0;

Game(); // calling the method           
void Game()
{
    int theManticore = 10, city = 15, round = 1; // initializing variables early

    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
    

    while (true)
    {
        Console.Write("Choose a number from 0 to 100: ");
        chosenNumber = Convert.ToInt32(Console.ReadLine()); // parsing string to int

        if(chosenNumber < 100 && chosenNumber > 0) // if this number is in the range
        {
            break; // we use break to EXIT while loop, if we used return we would exit the whole method itself
          // no need to use "else" because we are already in the endless loop, the same quiestion will be asked if user enters a wrong number
          // the only way to exit this loop is entering a number in the range
        }
    }
    Console.Clear();
 
    while(theManticore > 0 && city > 0) // while both aren't destroyed yet
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Player 2, it's your turn");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round}  City: {city}/15  Manticore: {theManticore}/10 ");

        // CALCULATING DAMAGE
        int damage = 0; // initializing damage

        if(round % 5 == 0 && round % 3 == 0) // if round is multiplacation of both 3 and 5
        {
            damage = 10; 
            Console.ForegroundColor = ConsoleColor.Red; // super blast
        }


    }
   

}