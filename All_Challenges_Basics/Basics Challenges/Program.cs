
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