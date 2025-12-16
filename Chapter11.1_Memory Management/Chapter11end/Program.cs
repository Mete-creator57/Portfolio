
// --- Memory Managment ---
// STACK

/// <summary>
/// stack can only use fixed sized frames,
/// e.g. it can't store tons of millions of values
/// it can only store size of this or that method which's size is fixed.
/// used to store methods, return adresses...
/// </summary>

int x = 67;// reserved 4 bytes for int (stack)
float foo = 67.08493f;
char foobar = 'g';

Method(foobar); // here foobar variable copied and placed as an argument that corresponds to "char d"
                // foobar copied into the parameter d
void Method(char d)
{
    int a = 5;
    int b = 44;
}
// HEAP
/// <summary>
/// stack in this situation only holds a REFERENCE 
/// that shows where exactly this string is located
/// basically holds a map which shows the location in the programm
/// meanwhile HEAP holds the variable's value (C#) itself
/// because it's capable of holding non - fixed items 
/// STRINGS and ARRAYS are always in the Heap because these are unpredictable types
/// strings and arrays can change their values in them
/// which can cause increase or deacrease of their size.
/// </summary>
int baz = 68; // fixed size (4 bytes)
string text = "C#";  // non-fixed size, depends on an amount of letters in quotes

/// <summary>
/// even though it uses a Value type(int), it's a reference type because it's an ARRAY
/// !!! all arrays and strings are located on heap since the're unpredictable !!!
/// the variable "array" is in the STACK (holds adress) ---> reference
/// meanwhile numbers { 5, 67, 88, 99 } are in the HEAP
/// </summary>
int[] array = new int[4] { 5, 67, 88, 99 };
Console.WriteLine(array[1]); // displays the 2nd number in the array
Console.WriteLine(array[0]);

// rule: if you want to separate strings in an array, use "" to separate and make each item separated from another
/// <summary>
/// same thing with arrays here, we use strings but each one has it's own memory allocated for itself
/// </summary>
string[] words = new string[] { "C#", "I", "love" }; // this array(words) contains a REFERENCE to the array
Console.Write($"{words[1]} {words[2]} {words[0]}."); // displays I love C#.