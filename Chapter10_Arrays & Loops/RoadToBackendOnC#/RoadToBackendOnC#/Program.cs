
// console window title
Console.Title = "The Laws of Freach";

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

