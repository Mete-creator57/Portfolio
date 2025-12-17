
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
/// also each reference has it's own FIXED size, so reference type values also have their FIXED sizes
/// and references stored directly on the Stack since they're fixed sized but the data itself stored on the Heap
/// </summary>
string[] words = new string[] { "C#", "I", "love" }; // this array(words) contains a REFERENCE to the array
                                                     // meanwhile the data itself located on the Heap
Console.WriteLine($"{words[1]} {words[2]} {words[0]}."); // displays I love C#.

/// <summary>
/// this array holds VALUE TYPE values, so unlike the previous array 
/// this one holds the data directly in itself
/// if we created an array with STRINGS this array would store only a reference(adress) to these strings(text)
/// BUT! Since arrays are ALWAYS a REFERENCE TYPE (it lives on the Heap)
/// the numbers { 6, 7...} are in the array, so these numbers on the Heap too!
/// only the variable names(pointer) lives on the stack
/// </summary>
int[] numbers = new int[] { 6, 7, 8, 9, 0 };

int a, b;
a = 4;
b = 5;

int f = 7, y = 10, z = 11; // by the way, you can create multiple variables on a sinle line



int i1, i2;
string s1, s2; // two of everything
int[] a1, a2;

i1 = 4; // assigning a value to the first of everything
s1 = "Super";
a1 = new int[] { 6, 5, 7 };

i2 = i1; // copying from first to second
s2 = s1;
// sharing THE SAME REFERENCE, so now if you change either of these arrays 
a2 = a1; // another one will change and have same reference as well

Console.WriteLine(s2);

i2 = 67;   // making some changes, i2 is 4 now. i1 still has a value of 4
a2[1] = 3; // now we've changed the second spot in the array to 3 and now the second index
           // of a1 has changed to 3 as well!!

s2 = "I don't know"; // only s2 has changed, s1 is still "Super"
Console.WriteLine(s2); // strings are immutable
Console.WriteLine(s1);

Console.WriteLine(a2[1]); // same same
Console.WriteLine(a1[1]); // arrays are mutable, you can change a reference
// BUT! if you change the data itself these two arrays won't be interconnected
a2 = new int[] { 4, 5, 7 };
Console.WriteLine(a2[1]);
Console.WriteLine(a1[1]);
