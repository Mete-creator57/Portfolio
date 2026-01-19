
Console.Title = "All the Challenges"; // console window title

ConsoleBasics(); // calling the method
// LEVEL 3
void ConsoleBasics()
{
    Console.WriteLine("Hello World!");
    Console.WriteLine($"Something besides \"Hello World\"");
    Console.WriteLine("My name is James");
    Console.WriteLine("This is VS");
    Console.WriteLine($"VS stands for \"Visual Studio\"");
    Console.WriteLine("This programm is powered by VS");
    Console.WriteLine("Bread is ready. Who is the bread for?");
    string answer = Console.ReadLine();
    Console.WriteLine(answer + " got bread"); // using the old method to display thing that user typed

}
// LEVEL 4
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // getting input from the user and store a value of what usertyped in this variable

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();

string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!"); // the old method to represent variables with strings in a sentence

// LEVEL 6
int variable1 = 10;
uint variable2 = 100000;
byte variable3 = 255;
long variable4 = 24333;
// and so on...

// "var" keyword
///<summary>
/// "var" keyword can be used only if compiler is sure of type of the variable
/// in this case, compiler undertands that "input" variable is an int type because we convert string to int later on
/// and assign it to "input" variable
/// </summary>
VarKeyword(); // calling the method
void VarKeyword()
{
    Console.WriteLine("What is your age, stranger?");
    var input = Convert.ToInt32(Console.ReadLine()); // converting string to int using "var" keyword
    Console.WriteLine($"You are {input} years old!");
}
// Level 7 (Math)
// both min and max values for int 
int maxNumber = int.MaxValue;
int minNumber = int.MinValue;

// only "double" and "float" types can define a value for both negative infinity and positive infinity (expect decimal)
double infinity = double.PositiveInfinity;
float infinity1 = float.NegativeInfinity;

// NaN (not a number) can be used only by "float" and "double" types as well
float notARealNumber = float.NaN;

ComputingTriangleArea(); // calling the method
void ComputingTriangleArea()
{
    Console.WriteLine("Both length and width will be represented in cm");
    Console.Write("Enter the base: ");
    var basee = int.Parse(Console.ReadLine()); // converting string to int
    Console.Write("Enter the height: ");
    var height = Convert.ToInt32(Console.ReadLine()); // parsing string to int

    int area = basee * height / 2; // computing area based on what user has typed
    Console.WriteLine($"The triangle area is {area} ");

}

TheFourSistersAndTheDuckbear();
void TheFourSistersAndTheDuckbear()
{
    Console.Write("Enter the number of chocolate eggs gathered that day: ");
    var eggsTotal = int.Parse(Console.ReadLine()); // parsing string to int
    int sistersNumber = 4;

    // using "/" division here, we compute how many eggs are for each sister
    int eggsForEachSister = eggsTotal / sistersNumber; // computing an amount of eggs each sister will get 
                                                       // at the end of the day

    // using "%" here , we compute how many eggs ARE LEFT  for the Duckbear
    int eggsForDuckbear = eggsTotal % sistersNumber; // e.g. 11 % 4 = 3 (left for Duckbear)
                                                     // (remainder)

    Console.WriteLine($"Each sister gets {eggsForEachSister} eggs"); // new method
    Console.WriteLine("The Duckbear gets " + eggsForDuckbear + " eggs"); // old method


}
int g = 5;
g -= 2; // equvilant of g = g - 2 but much shorter

// increment and decrement operators
g++; // the same as g = g + 1; or g += 1;
g--;

TheDominionOfKings(); // calling the method
void TheDominionOfKings()
{
    // estate: 1 point , duchy: 3 points , province: 6 points
    Console.Write("Enter an amount of provinces you have in your custody: ");
    var provinces = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter an amount of duchies you have in your custody: ");
    var duchies = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter an amount of estates you have in your custody: ");
    var estates = Convert.ToInt32(Console.ReadLine());

    int totalScore = (estates * 1) + (duchies * 3) + (provinces * 6);
    Console.WriteLine("Your point total is " + totalScore);
}
// Prefix and Postfix Increment and Decrement Operators
int x;

// PREFIX NOTATION
// first, the value of X is being incremented by 1 (5 ---> 6)
// then, this value is being ASSIGNED to both Y and X (x = 6, y = 6)
// RESULT: Both X and Y are equal to 6
x = 5;
int y = ++x;
// BOTH X AND Y ARE EQUAL TO 6
Console.WriteLine($"X: {x} and Y: {y}");

// POSTFIX NOTATION
// first, the value of X is being ASSIGNED to z (original value) (z = 5)
// then, this value is being incremented  and assigned to X (5 ---> 6) (x = 6)
// NOTE: Z has the original value of X, while X is being INCREMENTED by 1
// RESULT: X is 6, Z is 5
x = 5;
int z = x++;
// ONLY X IS EQUAL TO 6, WHILE Z STILL REMAINS 5
Console.WriteLine($"X: {x} and Z: {z}");

// more practice 
int foo = 45;
int baz = foo++; // baz remains 45, foo evolves into 46
// Foo is 46, baz is 45 (just copies the original value of 45 and increase foo by 1)

int bar = 45;
int bazbar = ++bar; // bar gets an increase of 1, then it's being assigned to bazbar
// RESULT: Both bar and bazbar are 46

// WORKING WITH DIFFERENT TYPES AND CASTING

// so now, int stores byte's value
byte aByte = 6;
int anInt = aByte; // impicit conversion because int is bigger than byte
Console.WriteLine($"Byte: {aByte}"); // byte is 6
Console.WriteLine($"Int: {anInt}"); // int is 6 as well

// (a type to convert to)someInt
// so you place a type co convert to into parentheses to make an explicit conversion
// and continue converting (assigning one type to another)
int someInt = 6;
byte someByte = (byte)someInt; // explicit conversion
// in this case, casting operator has to be used in order to assure compiler that 
// we know what we're doing

short first = 7888;
short second = 9999;
int result = first + second; // implicitly converts short to int automatically

// but if we do want to do the same thing but using short type to store a result
// we could have done like this:
short first1 = 7888;
short second2 = 9999;
short result1 = (short)(first + second); // equation takes precedence over (short) due to how C# was created
// RULE: place a type you want to convert to inside parentheses BEFORE converting
int firstNum = 100;
int secondNum = 10000;
double computation = firstNum / secondNum; // this one is done by integer divison, 
                                           // so the result in here is simply 0
Console.WriteLine($"Double: {computation}");

// so we need to CONVERT EQUATION to double
double calculation = (double)firstNum / secondNum; // (double) takes precedence over equation because it's in the pparentheses
Console.WriteLine($"Double: {calculation}");

// Math and MathF Classes
double radius = 3.0;
double areaOfCircle = Math.PI * radius * radius;
Console.WriteLine(areaOfCircle);

double aNumber = 67.2;
double numSquared = Math.Pow(aNumber, 3); // power operator
double squareRoot = Math.Sqrt(numSquared); // square root
Console.WriteLine(aNumber);

// absolute value (- 2 ---> 2)
int smth = Math.Abs(-2); // now this variable is 2

// trigonometric functions
double sin = Math.Sin(30); // 1/2
double cos = Math.Cos(60); // 1/2
double tan = Math.Tan(45); // 1

// Min, Max and Clamp
int something = Math.Min(67, 100); // prints 67 because 100 > 67
int anything = Math.Max(67, 100); // prints 100

// Math.Round (rounding to the nearest integer) 
double rounding = Math.Round(6.7); // rounds number to the nearest integer
Console.WriteLine(rounding);

// Expicit and Implicit conversions practice
int rounding1 = (int)Math.Round(6.7); // converting double to int (explicit conversion)
Console.WriteLine(rounding1);

// when there is a situation where is a half (7.5, 8,5..) it rounds to the nearest EVEN number
// Consider this code:
double roundToEven = Math.Round(7.5); // rounds to 8 because it's an even number
int roundToEvenAgain = (int)Math.Round(6.5); // rounds to 6
Console.WriteLine($"{roundToEven} and {roundToEvenAgain}"); // here is no data loss

double smthing = 6.7;
int anthing = (int)smthing; // explicit conversion from double to int
                            // data loss occurs and 6.7 turns into simple 6
                            // RULE: Int truncates(removes) anything that comes after "." and turns numbers into integers
Console.WriteLine(anthing);

Console.Clear(); // clears the window



// Level 8 (Console 2.0) Challenge

// The Defense of Consolas
// the main idea is to surround the fireball (or bomb) and disarm it
Console.Write("Enter the target row: ");
int row = Convert.ToInt32(Console.ReadLine()); // convert string to int
Console.Write("Enter the target column: ");
int column = int.Parse(Console.ReadLine()); // parsing string to int

Console.ForegroundColor = ConsoleColor.Yellow; // changing foreground colors

Console.WriteLine("Deploy to: ");
Console.WriteLine($"({row}, {column - 1} )"); // column number decreases by 1
Console.WriteLine($"({row - 1}, {column} )"); // row number decreases by 1, column number stays still
Console.WriteLine($"({row}, {column + 1} )"); // ...
Console.WriteLine($"({row + 1}, {column} )");

Console.Beep(); // producing a sound

Console.ResetColor(); // setting colors back to default

Console.Write("Press any key to continue: ");
Console.ReadKey(true); // requesting the User to press any key in order to continue

// Conditional Operator (Level 9) if-else statements
int score = 100;
// condition expression ? expression if true : expression if false
string textToDisplay = score > 50 ? "You passed!" : "You failed";
Console.WriteLine(textToDisplay);

Console.Clear();

// Level 10 (Switches)
Console.WriteLine("Avast, matey! What be ye desire?");
Console.WriteLine("1 – Rest ");
Console.WriteLine("2 – Pillage the port ");
Console.WriteLine("3 – Set sail  ");
Console.WriteLine("4 – Release the Kraken ");
Console.WriteLine("What be the plan, Captain?");
int choice = Convert.ToInt32(Console.ReadLine()); // parsing string to int

// using switch STATEMENT
switch (choice)
{
    case 1:
        Console.WriteLine("Ye rest and recover your health.");
        break;
    case 2:
        Console.WriteLine("Raiding the port town get ye 50 gold doubloons");
        break;
    case 3:
        Console.WriteLine("The wind is at your back; the open horizon ahead.");
        break;
    case 4:
        Console.WriteLine("Tis but a baby Kraken, but still eats toy boats.");
        break;
    default:
        Console.WriteLine("Apologies. I do not know that one. Restart the programm and enter a valid number");
        break;

}

Console.Write("Write your name: ");
string name = Console.ReadLine();

// switch STATEMENT
// any type of variable can be used and checked in switch statements

switch (name) // checking name of the User (of what user typed)
{
    case "Mete": // using string type 
        Console.WriteLine("That's a common Turkish name!");
        break;
    case "Daniel":
        Console.WriteLine("That's a common Italien name!");
        break;

    default: // if neither of conditions matches
        Console.WriteLine("I do not know that name, sorry");
        break;
}



PracticingSwitchStatements();
// more practice with switch statements...
void PracticingSwitchStatements()
{
    while (true)
    {
        Console.Write("Enter your favorite color: ");
        string favColor = Console.ReadLine();

        switch (favColor)
        {
            case "yellow":
                Console.WriteLine("It's a great and bright color!");
                // if we used "break" instead, we would exit only SWITCH STATEMENT but not the whole loop istelf
                return; // exit the whole loop itself!

            case "blue":
                Console.WriteLine("It seems you like seas!");
                return;

            default: // if neither of conditions match with what user typed
                break;
        }
    }

}

PracticingSwitchesAgain();

void PracticingSwitchesAgain()
{
    bool isRunning = true; // creating bool variable to control when loop has to stop or run
    // the same as while(true)
    while (isRunning) // endless loop
    {

        Console.Write("Type your favorite car: ");
        string favCar = Console.ReadLine();

        switch (favCar)
        {
            case "BMW":
                Console.WriteLine("BMW is better that Audi IMO");
                isRunning = false; // making the condition of loop false.
                                   // so now this while loop is literally not endless anymore
                break; // exiting only this switch statement and going to the while loop
                       // which is currently not endless anymore, so we can exit the loop now

            case "Audi":
                Console.WriteLine("Audi is a great brand!");
                isRunning = false;
                break;

            default:
                Console.WriteLine("Sorry, I don't know that car brand");
                break; // exiting switch statement and returning to the while loop
                       // and because while loop is "true" by default, question will be asked forever
        }
    }
}

