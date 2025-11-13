
// console window title
Console.Title = "Arrays and Loops";

// "The Laws of Freach" exercise
// --- CALCULATING A MINIMUM VALUE IN AN ARRAY using "for" loop  ---


int[] numbers = new int[] { 131, 4, 2, 5, 67 }; // creating an array

int currentSmallest = int.MaxValue; // making the smallest number the biggest

for (int index = 0; index < numbers.Length; index++)
{
    if (numbers[index] < currentSmallest) // e.g  if 57 < 2147483647
                                          // then, 2147483647 = 57 ( so now the smallest value is 57)
                                          // 56 < 57? then now the smallest is 56
    {
        currentSmallest = numbers[index];
    }
}
Console.WriteLine($"The smallest number in this array is {currentSmallest} \"for\" loop");

// --- Calculating an average value in an array  using "for" loop --- 
float[] array = new float[] { 131, 4, 2.9f, 5, 67 };

float totalSum = 0;

for (int Index = 0; Index < array.Length; Index++)
{
    totalSum = totalSum + array[Index]; // e.g 0 = 0 + 1
                                        // 1 = 1 + 67 --> 1 = 68 (totalSum = 68)

}
float average = totalSum / array.Length; // total sum of all numbers and division by an amount of all numbers
Console.WriteLine($"Average value = {average} \"for\" loop");

// calculating a miminum value now using "foreach" loop

int[] array1 = new int[] { 131, 4, 2, 5, 67 };
int currentSmallest1 = int.MaxValue;
foreach (int aNumber in array1)
{
    if (aNumber < currentSmallest1)
    {
        currentSmallest1 = aNumber;
    }
}
Console.WriteLine($"This is the smallest value = {currentSmallest1} using \"foreach\" loop");

// calculating an average value using "foreach" loop

float[] array3 = new float[] { 131, 4, 2.9f, 5, 67 }; // creating an array
float total = 0f;

foreach (float Anumber in array3)
{
    total = total + Anumber;
}
float averageValue = total / array3.Length; // dividing the sum of all numbers by the amount of all items in an array
Console.WriteLine($"The average value is {averageValue} using \"foreach\" loop");

// Jagged arrays

int[][] matrix = new int[3][]; //  first [] in new int [] shows how many spots array can hold like a bookshelf
                               
matrix[0] = new int[] { 67, 69 }; // first shelf holds books which are 67 and 69
matrix[1] = new int[] { 1, 2, 4 };  // second shelf holds books which are 1 and 2
matrix[2] = new int[] { 4, 100 };
Console.WriteLine($"First spot, second number: {matrix[0][1]}"); // how do I access to the first book on the second shelf?
                                                           // first shelf, second book which prints 69

Console.WriteLine($"Second spot, third number: {matrix[1][2]}"); // prints 4
Console.WriteLine(matrix[2][1]); // prints 100

