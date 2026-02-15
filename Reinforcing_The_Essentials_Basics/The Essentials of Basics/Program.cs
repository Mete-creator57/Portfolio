Console.Title = "All the Essentials"; // console window title

/* ----------------------------------------------------
 * ---------------- CALLING METHODS ---------------------

 ConsoleBasics(); // calling the method

 Comments();
 VarKeyword(); // calling the method */
// Mathematics();

// ComputingTriangleArea(); // calling the method
//  TheFourSistersAndTheDuckbear();

// TheDominionOfKings(); // calling the method
// PrefixPostfixNotations();
//  OperatorsLikeSqrtAndMathF();

// DefenseOfConsolas();
// AlignmentAndFormatting();


// SwitchStatements();
// PracticingSwitchStatements();
// PracticingSwitchesAgain();
// MultipleCasesTheSameArm(); // calling the method
// SwitchExpressionPractice(); // calling the method
// BuyingAndDiscountedInventory(); // calling the method */



/* WhileLoop();
PracticingWhileLoop();
DoWhileLoop();
ForLoop();
BreakAndContinue();
MultiplicationOfChosenNumber(); */
// NestingLoops();
// RowsAndColumns();
// ThePrototype();
// MagicCannon();
// PracticeNestingLoops();

// ArraysBasics();
// Ranges();

// SomeExamplesWithArrays();
ArraysLoopsExperiment();
// -------------------------------------------------------------------

#region Level 3,4,6, Var


// LEVEL 3 (First Programm)
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


// LEVEL 4 (Comments)
void Comments()
{
    Console.WriteLine("What kind of thing are we talking about?");
    string a = Console.ReadLine(); // getting input from the user and store a value of what usertyped in this variable

    Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
    string b = Console.ReadLine();

    string c = "of Doom";
    string d = "3000";
    // using concatenation
    Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!"); // the old method to represent variables with strings in a sentence
}


// LEVEL 6 (The C# Type System)
int variable1 = 10;
uint variable2 = 100000;
byte variable3 = 255;
long variable4 = 24333;
// and so on...


///<summary>
/// "var" keyword can be used only if compiler is sure of type of the variable
/// in this case, compiler undertands that "input" variable is an int type because we convert string to int later on
/// and assign it to "input" variable
/// </summary>
void VarKeyword()
{
    Console.WriteLine("What is your age, stranger?");
    var input = Convert.ToInt32(Console.ReadLine()); // converting string to int by using "var" keyword
    Console.WriteLine($"You are {input} years old!");
}
#endregion 

#region Level 7, Challenges


// Level 7 (Math)
void Mathematics()
{
    // both min and max values for int 
    int maxNum = int.MaxValue;
    int minNum = int.MinValue;

    // only "double" and "float" types can define a value for both negative infinity and positive infinity (expect decimal)
    double infinity = double.PositiveInfinity; // displays infinity
    float forever = float.NegativeInfinity; // displays infinity

    Console.WriteLine(infinity);
    Console.WriteLine(forever);

    // NaN (not a number) can be used only by "float" and "double" types 
    float notARealNumber = float.NaN;
    Console.WriteLine(notARealNumber);

    int g = 5;
    g -= 2; // equvilant of g = g - 2 but much shorter

    // increment and decrement operators
    g++; // the same as g = g + 1; or g += 1;
    g--;

}


void ComputingTriangleArea()
{
    Console.WriteLine("Both length and width will be represented in cm");
    Console.Write("Enter the base: ");
    var theBase = int.Parse(Console.ReadLine()); // converting string to int
    Console.Write("Enter the height: ");
    var height = Convert.ToInt32(Console.ReadLine()); // parsing string to int

    int area = theBase * height / 2; // computing an area based on what user has typed
    Console.WriteLine($"The triangle area is {area} ");

}


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
#endregion

#region Math Continues


// Prefix and Postfix Increment and Decrement Operators
void PrefixPostfixNotations()
{
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
}

void DiffTypesAndCasting()
{
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

}
void OperatorsLikeSqrtAndMathF()
{
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


}
#endregion

#region Console 2.0


/// <summary>
/// Understanding Custom Numeric Format Strings:
/// "0" (Zero placeholder): Replaces the zero with the corresponding digit if one is present; 
/// otherwise, appears as a zero. It ensures fixed precision.
/// "#" (Digit placeholder): Replaces the "#" symbol with the corresponding digit if one is present; 
/// otherwise, no digit appears. It hides insignificant zeros.
/// Summary: If there is 0 , 0.000 format will show it in the console (e.g. 45.20) 
/// If there is 0, #.### format will not show it in the console (e.g. 45.2)
/// </summary>
void AlignmentAndFormatting()
{
    // Alignment
    string[] ceoNames = new[] { "Steve Jobs", "Tim Cook", "Jeff Bezos", "Elon Musk" }; // creating an array to hold diff string values
    // variableName , desired length of whitespace
    Console.WriteLine($"1st: | {ceoNames[0],10}"); // leaving whitespace BEFORE the desired word
    Console.WriteLine($"2nd: | {ceoNames[1],10}");
    Console.WriteLine($"{ceoNames[2],-10} => 3rd"); // leaving whitespace AFTER the desired word
    Console.WriteLine($"{ceoNames[3],-10} => 4th");

    // ------------ FORMATTING --------
    // => determines how numbers appear (e.g. 67.000 => if we used #.### format there would be printed 67 ) removes unnecessary 0s

    // using a format string of 000.000 
    double someNum = 67.9959404950;

    // 0.000. Zeros after the decimal place show how many digits should be printed after (.)
    Console.WriteLine($"{someNum:0.000} using 0.000 format"); // on;y 3 numbers after decimal place will be shown
    Console.WriteLine($"{45.65554:0.000} using 0.000 format");

    // to use this, there should be interpolation involved
    Console.WriteLine($"{Math.PI:0.000} using 0.000 format");


    // in contrast, #.### format might be more useful if we don't want 0s to appear (if we don't want things like 45.0)
    Console.WriteLine($"{456.600034:#.##} using #.## format");
    Console.WriteLine($"{456.600034:0.00} using 0.00 format");

    Console.WriteLine($"{677.0000:0.00}"); // prints 677.00
    Console.WriteLine($"{677.0000:#.##}"); // prints only 677 (without 0s)

    // we can use 0.0% format as well
    double currentHealth = 10;
    double maxHealth = 100;
    Console.WriteLine(currentHealth / maxHealth); // fractional value (0.1)
    Console.WriteLine($"Your current health is: {currentHealth / maxHealth:0.0%}"); // value as percent (10%)

    // using 0.0% format
    double totalLoveRate = 200;
    double currentLoveRate = 0;
    Console.Write("Rate your love for Mete on a scale of 200: ");
    string response = Console.ReadLine();

    if (response == "I do not love him")
    {
        currentLoveRate = 0;
        Console.WriteLine($"{currentLoveRate:0.0%}"); // prints 0 but in percent (0%)
        return; // exiting the whole method
    }

    currentLoveRate = Convert.ToDouble(response);
    Console.WriteLine($"Your current love rate is: {currentLoveRate / totalLoveRate:0.0%}");





}
// Level 8 (Console 2.0) Challenge
void DefenseOfConsolas()
{
    // the main idea is to surround the fireball (bomb) and disarm it
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

    Console.Write("Press any key to continue: ");
    Console.ReadKey(true);


}
#endregion

#region Switches 10 Level


// Level 10 (Switches)
void SwitchStatements()
{
    Console.WriteLine("Avast, matey! What be ye desire?");
    Console.WriteLine("1 – Rest ");
    Console.WriteLine("2 – Pillage the port ");
    Console.WriteLine("3 – Set sail  ");
    Console.WriteLine("4 – Release the Kraken ");
    Console.WriteLine("What be the plan, Captain?");
    int choice = Convert.ToInt32(Console.ReadLine()); // parsing string to int and saving result to int variable


    switch (choice) // checking the variable "choice"
    {
        case 1: // if it stores the value 1 (if user typed 1)
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
            Console.WriteLine("Apologies, I do not know that one. Restart the programm and enter a valid number");
            break;

    }

    Console.Write("Write your name: ");
    string name = Console.ReadLine();

    // switch STATEMENT
    // any type of variable can be used and checked in switch statements

    switch (name) // checking name of the User (what user has typed in the console)
    {
        case "Mete":
            Console.WriteLine("That's a common Turkish name!");
            break;
        case "Daniel":
            Console.WriteLine("That's a common Italien name!");
            break;

        default: // if neither of conditions matches
            Console.WriteLine("I do not know that name, sorry");
            break;
    }
}


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
                break; // exiting switch statement and going back to endless while loop
                // so we start the loop again and the only way to exit it is to type either "yellow" or "blue"
        }
    }

}


void PracticingSwitchesAgain()
{
    bool isRunning = true; // creating bool variable to control when loop has to stop or run
    // the same as while (true)
    while (isRunning) // endless loop
    {

        Console.Write("Type your favorite car brand: ");
        string favBrand = Console.ReadLine(); // putting what user typed into the variable
                                              // now "favBrand" holds value that user typed in the console

        // if (favBrand == "BMW") 
        // {
        //  Console.WriteLine("BMW is better that Audi IMO");
        // }
        switch (favBrand) // checking the variable 
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

            default: // if neither of conditions match with what user types
                Console.WriteLine("Sorry, I don't know that car brand");
                break; // exiting switch statement and returning to the while loop
                       // and because while loop is "true" by default, question will be asked forever until 
                       // either "BMW" or "Audi" are typed in the console
        }
    }
}


void MultipleCasesTheSameArm()
{
    // Multiple Cases for the Same Arm
    Console.WriteLine("What periphirals do you have?");
    string device = Console.ReadLine();

    switch (device) // checking the value that "device" variable stores
    {
        case "mouse":
        case "keyboard": // all of these cases are valid and if user types one of these, 
        case "headphones": // result will remain the same.
            Console.WriteLine("That's good!");
            break;
    }
}


// switch EXPRESSION

/// <summary>
///  e.g. user selects and types number 1, then it gets checked and produces some text (cases) ,
/// after that the text that belongs to number 1 gets assigned to the other variable "message" 
/// which is a string type and so it can hold some text in itself. Finally some text displays
/// the console. SWITCH keyword is used here for converting things that belong to some specific number in 
/// "chosenNumber" variable to a string variable "message"
/// </summary>
void SwitchExpressionPractice()
{
    Console.Write("Type any number between 1 and 10: ");
    int chosenNumber = int.Parse(Console.ReadLine()); // parsing string to int

    string message;

    // literally ASSIGNING what comes from "chosenNumber" to "message" (like converting)
    // e.g. if chosenNumber = 1, then assign the text to another variable "message"

    // "switch" keyword here is for converting and assigning things from a variable that gets checked to another one
    message = chosenNumber switch // variable to assign value to = thing that gets checked + switch 
    {
        // the same as we have done in switch statements but without writing "case:" and "break;"

        // case 1:
        //  Console.WriteLine("The smallest number!");
        //  break;
        1 => "The smallest number!", // if chosenNumber stores "1" then => "..." some text
        2 => "2nd number!",
        3 => "3rd number!",
        4 => "4th number!",
        5 => "5th number!",
        6 => "6th number!",
        7 => "7th number!",
        8 => "8th number!",
        9 => "9th number!",
        10 => "10th number!",
        _ => "I don't know that number" // default
    };
    Console.WriteLine(message); // displaying the result of the assignment




    Console.Write("Write the payment status: ");
    string status = Console.ReadLine();

    string color;

    // assign  text to another variable
    color = status switch
    {
        // status (what user typed) => "text"
        "Paid" => "Green", // if user typed "paid" then "green"
        "Cancelled" => "Red",
        "Pending" => "Yellow",
        _ => "Gray", // default case


    };
    Console.WriteLine(color);
}





// Completing Challenge (Buying Inventory)
void BuyingAndDiscountedInventory()
{
    // Items List
    Console.WriteLine("The following items are available: ");
    Console.WriteLine("1 – Rope  ");
    Console.WriteLine("2 – Torches  ");
    Console.WriteLine("3 – Climbing Equipment  ");
    Console.WriteLine("4 – Clean Water  ");
    Console.WriteLine("5 – Machete  ");
    Console.WriteLine("6 – Canoe  ");
    Console.WriteLine("7 - Food Suplies ");


    Console.Write("Type an item number you would like to purchase: ");
    int num = Convert.ToInt32(Console.ReadLine()); // converting string to int

    // calculating how much each item costs by using switch expression
    int price = num switch
    {
        // e.g. if user choose 1, then it will be 10 gold for the first item (rope)
        // and price will be 10 too.  price = 10;
        1 => 10,
        2 => 15,
        3 => 25,
        4 => 1,
        5 => 20,
        6 => 200, // 6th item costs 200 gold (canoe)
        7 => 1,
        _ => -69,// default case
    };
    // it's like:
    // int price = 0; // initializing the variable
    // string nameOfAnItem;

    // switch(num)
    // {
    // case 1:
    //   price = 10;
    // nameOfAnItem = "Rope"
    //   break;
    // .... (case 2, 3, 4...) and price is getting changed with each case (number user entered = an item he'd like to buy)
    // }
    // 


    if (price == -69) // checking if default case gets executed
    {
        Console.WriteLine("Sorry, there is no such item avaliable in our shop");
        return; // exiting the whole method
    }
    // defining names of items
    string nameOfAnItem = num switch
    {
        1 => "Rope", // if user choose 1, then the name of the 1st item will be "Rope". This name gets assigned to the variable
                     // "nameOfAnItem" variable
        2 => "Torches",
        3 => "Climbing Equipment",
        4 => "Clean water",
        5 => "Machete",
        6 => "Canoe",
        7 => "Food Supplies",
        _ => "Invalid item"
    };
    Console.Write("Type your name here: ");
    string name = Console.ReadLine();

    if (name == "Mete") // if the name is Mete
    {
        Console.WriteLine($"Your name is {name}! Special discount code is activated and you get %50 off!");

        double discountPrice = price / 2.0; // calculating discount (%50 off)

        Console.WriteLine($"Discount has been applied. Now, item named \"{nameOfAnItem}\"costs {discountPrice} gold for you!");
        Console.WriteLine($"Original price: {price}");
    }
    else // if the user's name is something else 
    {
        Console.WriteLine($" Item \"{nameOfAnItem}\" costs {price} gold!"); // no discount, average price
    }
}
#endregion

#region Loops 11 Level


// Level 11 (Loops)
// WHILE LOOP
void WhileLoop()
{
    int barbaz = 10;
    while (barbaz <= 20) // 10 <= 20 , 11 <= 20 ...21 <= 20 (loop stops) 
    {
        Console.WriteLine($"This is {barbaz}"); // prints out the number in the console
        barbaz++; // each time, variable gets increased by 1
                  // 10 + 1 = 11 (now barbaz is 11, and still this condition is true!) 10 <= 20
    }
}


void PracticingWhileLoop()
{
    int playersNumber = -1;

    while (playersNumber < 0 || playersNumber > 10) // while (true), we have created "playersNumber"
                                                    // to make the condtion inside the parentheses true
    {
        Console.Write("Enter a number between 0 and 10: ");
        int aNumber = Convert.ToInt32(Console.ReadLine()); // converting string to int

        if (aNumber > 0 && aNumber < 10) // the way to exit the loop
        {
            return; // exit the method
        }
    }
}



/// <summary>
/// do/while loops guarantee that this or that code block will be executed at least once
/// unlike while loops where condition is checked first,
/// so you have to make the condition in parentheses true in order to execute code block 
/// at least once.
/// otherwise, you can't even enter the loop without making it true
/// </summary>
void DoWhileLoop() // often used for input validation like here
{
    int playersNum = 0;

    do // ensures that the question will be asked at least once before checking the condition
    {
        Console.Write("Enter a number between 20 and 30: ");
        playersNum = Convert.ToInt32(Console.ReadLine()); // convert string to int and assign whatever value user types to playerNum(if it's int)
    }
    while (playersNum < 20 || playersNum > 30); // at the end of the first iteration, checking playersNum
                                                // and if its greater than 30 and less than 20, question will be asked again
                                                // until a number in the range is typed

}

void ForLoop()
{
    for (int x = 10; x <= 31; x++) // initializing the variable, x has to be less or equal to 31
                                   // each time x is being increased by 1
    {
        Console.WriteLine(x); // prints out x, goes until x is 31
    }
    //  for (; ; ) // an alternative to while (true)...
    //  {
    //   Console.WriteLine("Endless loop"); 
    // }
}
void BreakAndContinue()
{
    while (true) // endless loop by default
    {
        Console.Write("Type a number you like: ");
        string response = Console.ReadLine();

        // if user types one of those in the console, exit the while loop
        if (response == "quit" || response == "exit" || response == "stop")
        {
            Console.WriteLine("Programm is stopped"); // the only way to exit the loop
            break; // exits the loop
        }
        int favNum = Convert.ToInt32(response); // converting string to int
        switch (favNum)
        {
            case 67:
                Console.WriteLine("This number is strange. Pick another one");
                continue; // goes back to the beginning of the loop (starts the loop again)
        }
        // code that will be executed, if user typed something else except 67
        // basically, if continue doesn't work
        Console.WriteLine($"I like every number except \"67\". I like {favNum}!");

    }
}
// Multiplication 
void MultiplicationOfChosenNumber()
{
    Console.WriteLine("This little game is going to show you a basic multiplication table of a number you select.");
    Console.WriteLine("Multiplication table is only until 10");
    Console.Write("Type a random number: ");
    // converting string to int
    string response = Console.ReadLine();
    var chosenNumber = Convert.ToInt32(response);

    // this loop gets repeated 10 times (each time "s" is increased by 1 until "s" is 10)
    for (int s = 1; s <= 10; s++)
    {
        // e.g. 6(nUmber) * 1(s) = 6
        Console.WriteLine($"{chosenNumber} * {s} = {chosenNumber * s}");
        // here the loop ends, going back to the start again (now s = 2);
    }
}

/// <summary>
/// first turn: "f" loop is being 1, internal loop starts executing all of it's iterations
/// so basically, f = 1 => g = 1, g = 2, g = 3... g = 10 (stop executing)
/// so we have 10 lines written by now. 2nd turn: f becomes 2
/// f = 2 => g = 1, g = 2, g = 3... g = 10
/// 3rd turn: now f is 3, and g loop starts and goes until it becomes 10 again
/// we have 30 lines by now... 
/// "f" (external loop) decides how many iterations there will be for "g" (internal loop)
/// without "f" external loop  "g" would print only 10 lines in the console and that's it
/// </summary>
void NestingLoops()
{
    for (int f = 1; f <= 10; f++)
    {
        Console.WriteLine($"Table for: {f}");

        for (int g = 1; g <= 10; g++)
        {
            // 1 * 1 = 1, 1 * 2 = 2.... 1 * 10 = 10
            // 2 * 1 = 2, 2 * 2 = 4
            Console.WriteLine($"{f} * {g} = {f * g}");
            // external loop * internal loop
        }
        // when internal loop (g) ends it goes back to the external loop (f) and continues
        // leaves some space for convinience after multiplication table
        Console.WriteLine();
    }
}
void RowsAndColumns()
{
    var totalRows = 20; // int variable
    var totalColumns = 10;

    for (int currentRow = 1; currentRow <= totalRows; currentRow++)
    {
        Console.WriteLine($"Row number: {currentRow} ");
        // currentRow = 1, currentColumn = 1, 2, 3..... 10
        for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
        {
            Console.Write("#");
        }
        // without it, there would be no space between rows like this: ##################
        Console.WriteLine(); // going to the next line (leaving some space)

    }
}
// Challenge
void ThePrototype()
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    string input = Console.ReadLine();


    // if user wants to leave
    if (input == "exit")
    {
        Console.WriteLine("Exiting the game...");
        return;
    }
    var pickedNumber = Convert.ToInt32(input); // converting string to int

    Console.Clear();

    for (; ; ) // ENDLESSS LOOP by default like while(true)
    {
        Console.Write("User 2, guess and type the number: ");
        int guessedNumber = Convert.ToInt32(Console.ReadLine()); // converting string to int



        // checking if user types 1 (error) using switch
        // EXPERIMENT (overengineering, just practicing with switch expressions!)
        // we could use if instead but for all negative numbers, not only "-1"
        // ---------------------------------------------------------
        string errorMessage = guessedNumber switch
        {
            -1 => "User 2, -1 is not in the range... Restart the programm",
            _ => ""
        };
        if (errorMessage != "") // if the value of "errorMessage" is not nothing (if -1 "user 2,...")
        {
            Console.WriteLine(errorMessage);
            return; // exit the whole method
        }

        // ------------------------------------------------------------

        if (guessedNumber < pickedNumber)
        {
            Console.WriteLine($"{guessedNumber} is too low");
            continue; // going back to the start (and asking the same question again)
        }
        else if (guessedNumber > pickedNumber)
        {
            Console.WriteLine($"{guessedNumber} is too high");
            continue;
        }
        else
        {
            Console.WriteLine($"{guessedNumber} is the perfect match! You won!");
            break; // exit the loop
        }

    }

}
/// <summary>
/// currentTurn = 1 => average blast (else block) 
/// and then the loop ends and goes back to the start. now currentTurn = 2
/// every time loop goes back to it's beggining until it reaches 100. 
/// currentTurn (turn number) increases by 1 each time (100 iterations)
/// when it reaches 100 the loop stops
/// </summary>
void MagicCannon()
{
    for (int currentTurn = 1; currentTurn <= 100; currentTurn++)
    {
        // if turn number can be divided by 3 and 5 without a remainder
        if (currentTurn % 3 == 0 && currentTurn % 5 == 0) // fire + electricity
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{currentTurn}: Combined Blast");
        }

        else if (currentTurn % 3 == 0) // fire
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{currentTurn}: Fire Blast");
        }

        else if (currentTurn % 5 == 0) // electricity
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{currentTurn}: Electric Blast");
        }

        else // average blast
        {
            Console.WriteLine($"{currentTurn}: Normal Blast");
        }
        // after all of the code blocks,each time setting color back to default
        // regardless of what the colors were before
        Console.ResetColor();

        // TODO: practice with nested loops a bit
    }




}
/*     H
     * H E
     * H E L           => what has to be printed in the console
     * H E L L
     * H E L L O    */

/// <summary>
///     1st TURN:
/// external loop is 0 , 0 < 5(string length)? Yes, moving inside the external loop
/// internal loop is 0, 0 <= 0(internal loop <= external loop)? Yes, going inside the internal loop 
/// then, internal loop prints out someText[0] which stands for the 1st letter "C"
/// after that internal loop continues working and evaluates to 1 by default (h++)
/// but now 1 <= 0 becomes false so the internal loop stops (only H is printed in the console rn)
/// then going back to external loop and moving to the next line
///     2nd TURN:
/// external loop is 1 (i++), 1 < 5? Yes, moving inside the external loop
/// internal loop is 0 , 0 <= 1? Yes, going inside the internal loop
/// then, internal loop prints someText[0] and the evaluates to 1 because of 1 <= 1 being true and prints someText[1] too
/// now, C
///      Ca letters are printed in the console
///  .... continues until the end
/// </summary>
void PracticeNestingLoops()
{
    string someText = "Camel"; // initializing the variable

    // 0 < length of the string (in this case 5) 0 < 5
    // if we made i <= 5 then i would be 5 at the end, which would result someText[5] because of h <= i (5 <= 5)
    for (int i = 0; i < someText.Length; i++)
    {
        for (int h = 0; h <= i; h++) // at the las turn,this will be 4 <= 4 and (someText[4])
        {
            Console.Write(someText[h]);
        }
        Console.WriteLine();
    }
}
#endregion

#region Arrays 12 Level

/// <summary>
/// Experiment: This code block is made for practice,
/// some features may not work properly or throw some errors in the console
/// Heap > Stack
/// Features: If we don't initialize arrays then each value in an array is 0 (new int[5]) 
/// 
/// </summary>
void ArraysBasics()
{


    // "new" keyword is used for allocating memory on the Heap
    // because we're not sure how many bytes should be reserved for numbers in arrays
    // e.g. user might select 1000 or more, and the Heap would have to allocate 4000 bytes for numbers
    int[] array = new int[4]; // user can choose size of the array himself

    array[0] = 67; // index 0 stores the number 67 in it
    array[1] = 77;
    array[1 + 1] = 34; // index 2 stores the number 34
    Console.WriteLine($"3rd index: {array[2]} ");
    // prints how long the array is
    Console.WriteLine(array.Length); // (how many values it can store)


    // --------------------------------------------------

    Console.Write("Type the size of an array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    // creating an array with size user selected (e.g. 5)
    int[] someArray = new int[size];

    // 1st turn: index is 0, 0 < 5, true; going inside the loop
    // this loop will continue until index(counter) reaches the end of an array
    // (user decides how many values an array can store)
    for (int index = 0; index < someArray.Length; index++)
    {
        // someArray[0] = 1
        // then printing out someArray[0] which is 1
        // then it starts all over again, index evaluates all way to 1,2...the last number
        someArray[index] = 1;
        Console.WriteLine(someArray[index]); // every number in the array is 1
    }




}

///<summary>
/// the 1st number in [0..9] is the index to start at
/// the last number here is the index to end at (not included)
/// so there will be only numbers which indexes are between 0 and 9 (9 not included)
/// </summary>
void Ranges()
{
    int[] anArray = new int[5]; // this array can store 5 values
                                // changing the size of the array
    anArray = new int[10];
    anArray[0] = 678;
    anArray[1] = 888;
    // .... and so on
    anArray[9] = 99;
    // indexing from the end
    int lastNumber = anArray[^1]; // like: lastNumber = anArray[9]
    Console.WriteLine(lastNumber); // prints 99

    // --------- RANGES (..) range operator ---------
    // creating a new array and assign the first 4 numbers of another array to it
    int[] firstFourNums = anArray[0..4];

    int[] fromMiddleToEnd = anArray[4..10]; // ranges replace this: anArray[4..anArray.Length];
    // or we can do this instead:
    int[] fromMiddleToEnd1 = anArray[4..]; // takes numbers from 4 to the end (9)
    // syntax sugar

    int[] fromThirdToSixth = anArray[2..6]; // 6 is not included
    int[] fromSecondToEnd = anArray[1..];

}
void OtherWaysToCreateArrays()
{
    // length and the number of values must match each other
    int[] numbers = new int[5] { 5, 6, 7, 8, 9 };
    int[] numbers1 = new int[] { 5, 6, 7, 8, 9 };
    int[] numbers2 = new[] { 5, 6, 7, 8, 9 }; // compiler is smart enough to get what type the array is

    int[] numbers3 = { 5, 6, 7, 8, 9 }; // syntax sugar => compiler looks at the numbers in
                                        // the array and guesses the type automatically.
                                        // Compiler also computes how many values in an array
                                        // and allocates space for them itself (new int[5])

    // guessing the type of an array by using the keyword "var"
    var numbers4 = new[] { 5, 6, 7, 8, 9 };

}
///<summary>
/// This example calculates the max value in an array.
/// numbers in the array get changed in loops, when a loop ends numbers change dependion on what we have done in loops
/// e.g. initially, if arr[0] was 0 and it evaluates to 7, then after the loop ends arr[0] remains 0
/// </summary>
void SomeExamplesWithArrays()
{
    Console.Write("Type size of an array: ");
    string response = Console.ReadLine();

    if (response == "exit" || response == "stop")
    {
        Console.WriteLine("The programm has been stopped");
        return; // exit the whole method
    }
    else if (response == " ")
    {
        Console.WriteLine("We don't accept text. Restart the programm and enter a numeric value");
        return;
    }

    int arrSize = Convert.ToInt32(response);

    if (arrSize < 2)
    {
        Console.WriteLine("Invalid input. Array's size can not be less than 2, that makes no sense");
        Console.Write("Press any key to end the programm: ");
        Console.ReadKey(true);
        return;
    }

    // array's length = arrSize (user chooses the size of an array himself)
    int[] arr = new int[arrSize];

    // PUTTING NUMBERS INTO THE ARRAY
    for (int index = 0; index < arrSize; index++) // at the end it will be 8 < 9
    {
        // arr[0] = (0 + 1) * 5 => 5  1st TURN , now arr[0] is 5
        // arr[1] = 2 * 5 = 10 2nd TURN
        // and so on until counter(index) reaches array's size (be 1 less than array's size)

        arr[index] = (index + 1) * 5;  // 5, 10, 15.. goes until the last number in array

    }

    Console.WriteLine($"Array of size {arrSize} created and filled:");

    // Calculating the biggest number in the created array (depending on it's size which is selected by the user)

    // e.g. 10 > int's minValue (-...) then the max value becomes 10
    int currentBiggest = int.MinValue; // we use minValue to ensure that the first number in the array will be greater than anything

    for (int counter = 0; counter < arrSize; counter++)
    {
        if (arr[counter] > currentBiggest) // if an element in the array is greater than the previous one
        {
            currentBiggest = arr[counter]; // then this element becomes the biggest itself

        }
        Console.WriteLine($"Current biggest number in the array is: {currentBiggest}");
    }

}
/// <summary>
/// first, we ask the user to create an array in the range (between 2 and 6)
/// by using do-while loop to guarantee that the question will be asked at least once.
/// If user enters anything above or below the range, the question gets asked again until
/// the number in the range is entered. Then, creating an array with the desired size 
/// and start filling the array with the numbers
/// </summary>
void ArraysLoopsExperiment()
{
    Console.WriteLine("RULES:");
    Console.WriteLine("Calculating an average value in an array...");
    Console.WriteLine("You choose size and contents in an array you create");
    Console.WriteLine("array's length (size) has to be between 2 and 6");
    Console.WriteLine("-------------------------------------------------------");
    int size = 0;

    do // ensures that the question will be asked at least once
    {
        Console.Write("Type the desired size of an array: ");
        string response = Console.ReadLine();
        switch (response)
        {
            case "exit":
            case "stop":
            case "finish":
                Console.WriteLine("The programm is stopped");
                return; // exit the method

            case " ": // if some other string gets inputted
                Console.WriteLine("Invalid input. Restart the programm");
                return;
        }

        size = Convert.ToInt32(response); // converting string to int

    } while (size < 2 || size > 6);

    // creating an array with size user selected
    int[] array = new int[size];
    Console.WriteLine($"An array with {size} values has been created! ");
    Console.Write("Press anything to continue: ");
    Console.ReadKey(true);

    Console.WriteLine(); // leave some space

    int value;

    // used for initializing the values (user decides)
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Initialize the int value at index [{index}]: ");
        value = Convert.ToInt32(Console.ReadLine());

        array[index] = value; // e.g. user typed 5, array[0] becomes 5 ,
                              // on the next iteration (index 0 -> 1), the question keeps printed again and now if user
                              // enters e.g. 67, then array[1] = 67 (value)
                              // this continues all way to the end of an array (e.g. 4 < 5)

    }
    // used for counting values
    for (int index = 0; index < array.Length; index++)
    {
        Console.WriteLine($"Index: {index}, element: {array[index]}");
    }

    // used for providing info about what number is at what index to the user
    Console.Write("Type an index you want to see a number at: ");
    int usersIndex = Convert.ToInt32(Console.ReadLine()); // converting string to int

    // e.g. usersIndex => 3, and if it's not greater than the array's size
    if (usersIndex >= 0 && usersIndex < array.Length)
    {
        // e.g. => another number = array[3] which is for example: 6, finalNumb becomes 6 
        int finalNum = array[usersIndex];
        Console.WriteLine(finalNum);

    }


}







#endregion