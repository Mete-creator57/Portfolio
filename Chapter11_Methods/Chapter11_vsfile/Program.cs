
// console title
Console.Title = "Methods";

Console.WriteLine("What is your current age?");
string answer = Console.ReadLine();
int current = Convert.ToInt32(answer); // using the same variable name, no error!!

if(current < 18)
{
    Console.WriteLine($"You are not allowed to drive a car since you are {current}");
}
else
{
    Console.WriteLine("You can drive a car!");
}
Console.WriteLine("Press any key if you want to continue...");
Console.ReadKey(true); // pressing any key

CountToTen();
CountToTwenty(); // calling the method

// this is a definition of a method which is not enough to run this code block (for loop)
// you should CALL a method to make this code block run
void CountToTwenty() // defining a method ( basically creating a method)
{
    for (int current = 1; current <= 20; current++) // start counting from 1 to 20
    {
        Console.WriteLine(current);
    }
}
void CountToTen()
{
    for(int current = 1; current <= 10; current++)
    {
        Console.WriteLine(current); // both methods and the variable use the same name (current)
                                    // with no error!!
    }
}

CountToTwenty(); // this method can be called anywhere since it is a LOCAL FUNCTION
//  CountToTwenty(); method can be called from anywhere because it lives in our MAIN Method

Console.Write("Write something: ");
string userInput = Console.ReadLine();

 void DisplayText()
{
    Console.WriteLine($"You typed: {userInput}"); // Danger!!
     // if you accidently change the variable name, this function will be broken because to run the code above
     // this method gets the value of the variable from the main method,
     // which causes dependence on the variable (userInput)
}
DisplayText();

Console.WriteLine("Press any key to continue working");
Console.ReadKey(true);

Console.Clear();


// ---- PASSING DATA (arguments) TO A METHOD and USING PARAMETERS ----

Count(5); // calling the method and passing the argument --> (5) inside parentheses to initilize the parameter
          // (litterally assigning value to the parameter which is "int numberToCountTo")
void Count(int numberToCountTo) // defining method with the PARAMETER named "numberToCountTo" in it
{
    for (int i = 1; i <= numberToCountTo; i++) // starts from 1, goes till 5(numberToCountTo) 
                                                                          // its the number that we have initilized in parentheses
                                                                          // as an argument (5) , so basically this loop gets repeated 5 times
                                                                          // (printing currentNum e.g 1, 2, 3...)
                                                                          // due to the number --> (5) which is an argument that defines an amount of repetitions
    {
        Console.WriteLine(i);
    }
}

// multiple parameters
int foo = 10; 
int bar = 30; // 10 --- 30
CountBetween(foo, bar); // copied the value from "foo" and "bar" and to the method
                        // and set up these as arguments
void CountBetween(int start, int end) // multiple parameters inside the parentheses
{
    for(int currentNum = start; currentNum <= end; currentNum++)
    {
        Console.WriteLine($"This is {currentNum}"); // 30, 31....50
    }
}
Console.WriteLine("Press any key to continue");
Console.ReadKey(true);

Console.Clear();

//--- RETURNING A VALUE FROM A METHOD ---
// (void method doesn't return anything you can assign to a variable)

Console.WriteLine("How high should I count?"); // asking user
Console.Write("Your response = ");
int chosenNumber = ReadNumber();
Count(chosenNumber); // this is the method which we've created
                     // that counts as many times as user wants (e.g. 5)

int ReadNumber()
{
    string userResponse = Console.ReadLine();
    int number = int.Parse(userResponse);
    return number;
}
Console.WriteLine("Press any key to continue");
Console.ReadKey(true);

// more practice...
Console.WriteLine("Do you like Visual Studio?");
string userAnswer = Console.ReadLine();

if(userAnswer == "yes")
{
    string baz = SomeText(); 
    Console.WriteLine(baz); // or you could have done like this: Console.WriteLine(SomeText());
}
else
{
    Console.WriteLine(SomeText()); // prints "Okay, got it"
}

    string SomeText() // RETURNS string
    {
        string message = "Okay, got it"; 
        return message; // returned the string, now you can assign it to other variables
                        // e.g. string foobar = SomeText(); ---> now, if you use the variable "foobar"
                        // it will print "okay, got it" to the console
    }
Console.WriteLine("Press anything to continue");
Console.ReadKey(true);

Console.Clear();

// --- RETURNING EARLY ---

Console.Write("Type your name here: "); 
string name = GetUserName();
Console.WriteLine($"Your name is {name}, right?");

string GetUserName()
{
    while (true) // never ends
    {
        string usersName = Console.ReadLine();
        if(usersName != "") // if user typed something, basically if a thing that "usersName" variable holds 
                            // is not empty,
        {
            return usersName; // then return the value that "usersName" variable holds and end the method
        }
        Console.WriteLine("Please, try again"); // if user keeps not typing, then this question will be asked for ever 
                                                // since it's while(true) loop
    }
}
// using void method
Console.Write("Type a number to count to: ");
int number = int.Parse(Console.ReadLine()); // converting userInput (string) to int
CountTill(number); // defining a number that user selected as an argument, basically "number" = "numberToCountTo"

void CountTill(int numberToCountTo)
{
    if (numberToCountTo < 1) // if an argument is less than 1
        return; // in this case, return doesn't return anything since it's a void method, 
                // just stops doing this method and exits
    else
    {
        for(int a = 1; a <= numberToCountTo; a++)
        {
            Console.WriteLine($"This is {a} number");
        }
    }
}

// more practice using void and return...
Console.WriteLine("Choose numbers to count numbers in between");
Console.Write("Select your 1st number: ");
int usersAnswer1 = int.Parse(Console.ReadLine());
Console.Write("Select your 2nd number: ");
int usersAnswer2 = int.Parse(Console.ReadLine());

InBetween(usersAnswer1, usersAnswer2); // assigning user's answers to the variables "beggining" 
                                       // and "end"
                                       // so basicly, usersAnswer1 = beggining, usersAnswer2 = end
void InBetween(int beggining, int end)
{
    if(beggining == 0 || end == 0) // if 1st or 2nd number is 0
    {
        Console.WriteLine("Sorry, one of your numbers is 0, restart the programm and select again");
        return; // ends the method
    }
    else if(beggining == end)
    {
        Console.WriteLine("How can I count in between if you selected the same number? Restart the programm");
        return; // ends the method
    }
        for (int currentNum = beggining; currentNum <= end; currentNum++) // currentNum = 20; 20 <= 30; 20++
        {
            Console.WriteLine(currentNum); // prints numbers in between
        }
}

Console.WriteLine("Press anything to continue");
Console.ReadKey(true);
Console.Clear();

// --- METHOD OVERLOADING ---

// you can perform many diffrent tasks such as: printing strings, ints, bool values
// using the same method name, however since we are in our main method we can't 
// overload methods for now
Console.WriteLine("I love coding");  // prints string
Console.WriteLine(67); // prints number
Console.WriteLine(); // moves to the next line

// --- Simple Methods with Expressions ---

Console.WriteLine(TripleAndAddThree(4));
int TripleAndAddThree(int value)
{
    value = value * 3 + 3;
    return value;
}
int DoubleAndSubstractOne(int value) => value * 2 - 1; // instead of using curly braces, we could have done like this
Console.WriteLine(DoubleAndSubstractOne(3));

PrintTwice(69);
void PrintTwice(int number) 
{
    Console.WriteLine(number); // these can't be printed using an expression body
    Console.WriteLine(number); // because here are 2 actions to perform
}
void PrintOnce(string message) => Console.WriteLine(message); // can be printed since it's a single expression(action to do)
PrintOnce("C# is pretty fast language to work on");