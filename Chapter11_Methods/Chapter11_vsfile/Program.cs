
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
     // so in order to fix that problem we should create variables inside methods
}
DisplayText();

Console.WriteLine("Press any key to continue working");
Console.ReadKey(true);

Console.Write("Type anything: ");
Print();
void Print()
{
    string answer = Console.ReadLine(); // no dependecy on the main method
    Console.WriteLine($"You typed {answer}");
}

Console.Write("Press anything to continue: ");
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

/// gets user's name and returns it 
/// using while loop(true) which never ends till user types something in the console
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

void PrintNumber(int number) => Console.WriteLine(number); // use body expressions if you can represent the whole thing
                                                           // in a single line
PrintNumber(67);

// more practice using bool variables
Console.WriteLine("We accept only people who are named Mete ");
Console.Write("Type Mete: ");
if (CheckingName())
{
    Console.WriteLine("System access granted");
}


bool CheckingName()
{
    string response = Console.ReadLine();

    // bool isMete = true; (if user typed Mete")
    bool isMete = response == "Mete"; // basically if, response = Mete, then assign it to "isMete" variable
    if(isMete) // so literally we save the result of user's input to the variable, if user typed "Alex" 
               // this code wouldn't run
    {
        return true; // returning value that "isMete" variable holds and assign it to the method
                    // now CheckingName() = true
    }
    else // if user types anything else instead of "Mete"
    {
        while (true) // goes for ever
        {
            Console.Write("Type Mete: "); // continue asking untill user types "Mete"
            string retry = Console.ReadLine();
            if (retry == "Mete")
                return true; // now CheckingName() = true
        }
    }
}

Console.WriteLine("Press anything to continue:");
Console.ReadKey(true);


Console.Write("Type whether you're hungry or not using only \"yes\" or \"no\": ");
string answer1 = Console.ReadLine();

bool isHungry = answer1 == "yes"; // if a value that "answer1" variable holds is "yes" then assign it to "isHungry" (bool variable)
                                // and make it true. isHungry = true;
bool isNotHungry = answer1 == "no";

if(isHungry) // if user types "yes"
{
    Console.WriteLine("have dinner then!");
}
else if(isNotHungry)
{
    Console.WriteLine("You are not hungry then");
}
else
{
    Console.WriteLine("I said you to use only \"yes\" or \"no\"");
    Console.WriteLine("Restart the programm please");
}

Console.WriteLine("Type anything to continue");
Console.ReadKey(true);

// --- XML Documentation Comments --- (used to describe what a method or something else in code does, using ///)

/// <summary> 
/// this method counts to 5 using for loop 
/// also this method doesn't return anything
/// since it's a void method, only prints (executes things inside it)
/// </summary>
void CountToFive()
{
    for(int i = 1; i <= 5; i++) 
    {
        Console.WriteLine(i); // 1, 2, 3... goes until 5
    }
}
CountToFive();

// challenge
int height = AskForNumber("What is your height? (type in cm, only numbers) "); // assigning returned value (age that user typped) to a variable
                                                                               // e.g. now height = 165;
Console.WriteLine($"You are {height}cm tall!");

/// <summarry>
/// first asking user for a number, then converting user's answer to int (string --> int)
/// finally, returning the number
/// </summarry>
int AskForNumber(string question)
{
    Console.WriteLine(question); //  printing the question, if we didn't write this line our programm WOULDN'T PRINT the question

    string usersResponse = Console.ReadLine();
    int number = int.Parse(usersResponse); // converting string to an int
    return number; // return the value, exit method
}

AskForNumberInRange("Select a number you want to type in range: ", 60, 70);

/// <summary>
/// first giving instructions to user, then printing the sentence
/// then using while(true) loop which will never end
/// next, converting user's input to an int 
/// next, checking if user's number is in the range
/// if it is, returning user's input and exit the method
/// else, ask user to choose another number again
/// </summary>
int AskForNumberInRange(string sentence, int min, int max)
{
    Console.WriteLine("Your number will be returned only if it's in the range"); // giving instructions
    Console.Write(sentence); // this is the crucial point to print the sentence, if we didn't
    // write this code, parameter(string sentence) would be useless

    while (true)
    {
      int selectedNumber = int.Parse(Console.ReadLine()); // parsing string to an int

        if (selectedNumber >= min && selectedNumber <= max) // if the selected number is greater than min value and less than max
                                                            // that means it's in the range
        {
            Console.WriteLine($"Your number in the range! {selectedNumber}");
            return selectedNumber; // if this condition is true, return the value and exit the method
        }
        else
            Console.Write("Select another number: "); // if it's not in range, keep asking quiestion until user
                                                      // guess a correct one
    }
}

// --- The Basics Of Recursion ---

/// <summary> 
/// factorial is multiplication of all numbers before a number user selected
/// e.g. 6 --> 5 * 4 * 3 * 2 * 1 = ...
/// </summary>
int Factorial(int number) // creating simple method
{
    if (number == 1) // ---> base case, if number gets to 1 ---> method ends and returns 1
        return 1; // now number = 1

    return number * Factorial(number - 1); // e.g. 6 * result of the Factorial(6 - 1) 
                                           // compiler doesn't know about the result of Factorial(5)
                                           // so it skips it and moves to the next by calling the method itself
}
Factorial(6);

// challenge
Console.Write("Select a number: ");
string input = Console.ReadLine();
int choosenNum = int.Parse(input);

CountDown(choosenNum);
/// <summary>
/// base case ENDS the recursion by using return statement
/// if code block is our base case, code block below must get closer and closer
/// with each repetition to our base case
/// in this case, method calls itself and shrinks by 1
/// this code will repeat until 0 which is the BASE CASE
/// rule: everytime you call a method in it's own method, 
/// it gets restarted and gets repetead until base case
/// it's basically a loop but now we're using recursion to call the method itself again instead of "for"
/// or "while" loops. 
/// Method calls itself inside itself
/// </summary>
void CountDown(int number)
{
    // base case
    if (number == 0) // if an argument is 0 
        return; // end this method (stop executing)

    Console.WriteLine(number); // prints the number
    CountDown(number - 1); // after 15 is printed ---> 15 - 1 = 14 ---> then Console.WriteLine(number) prints 14...
                           // it's basically a loop 
}

// --- Memory Managment ---
int x = 67; // reserving place for int variable
float y = 67.67777f; // reserving place float variable

/// <summary>
/// stack is a temporary storage where such things like: variables and other little
/// things are stored. When a method is executed, stack cleans up memory for other things.
/// this method can be called and reused Method(something); anywhere
/// </summary>
void Method(int n)
{
    Console.WriteLine(n);
    double smth = 5.0;
    decimal anth = 44.4444m;
}
Method(x); // prints 67