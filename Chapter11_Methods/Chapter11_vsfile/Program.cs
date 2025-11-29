
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
        Console.WriteLine(current); // both methods and a variable use the same variable name with no error!!
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


// ---- PASSING DATA TO A METHOD and USING PARAMETRES ----

Count(5); // calling the method and defining value inside parentheses to initilize the parameter
          // (litterally assigning value to the parameter which is "int numberToCountTo"
void Count(int numberToCountTo) // defining method with the parameter in it
{
    for (int currentNum = 1; currentNum <= numberToCountTo; currentNum++) // starts from 1, goes till 5(numberToCountTo) 
                                                                          // its the number that we have initilized in parentheses
                                                                          // as a parameter
    {
        Console.WriteLine(currentNum);
    }
}
