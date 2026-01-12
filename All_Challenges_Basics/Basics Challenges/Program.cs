
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


