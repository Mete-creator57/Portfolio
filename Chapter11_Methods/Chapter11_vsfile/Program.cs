
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
int bar = 30;
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
    Console.WriteLine(SomeText());
}

    string SomeText() // RETURNS string
    {
        string message = "Okay, got it"; 
        return message; // returned the string, now you can assign it to other variables
                        // e.g. string foobar = SomeText(); ---> now, if you use the variable "foobar"
                        // it will print "okay, got it" to the console
    }
