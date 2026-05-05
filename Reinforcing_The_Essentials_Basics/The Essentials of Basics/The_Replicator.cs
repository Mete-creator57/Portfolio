
using System;

public class TheReplicator
{
    public void Run()
    {
        // The Replicator D'TO Challenge
        int[] arr = new int[5];

      // The Replicator D'TO Challenge

        for (int x = 0; x < arr.Length; x++)
            {
                Console.Write("Enter your number: ");
                int num = int.Parse(Console.ReadLine());


                arr[x] = num;
            }

        var arr_2 = new int[5];



        for (int i = 0; i < arr.Length; i++)
        {
            arr_2[i] = arr[i];
        }

        Console.WriteLine("This is the 1st array: ");
        foreach(int el in arr)
        {
            Console.WriteLine(el);
        }

        Console.WriteLine("This is the 2nd one: ");
        foreach (int el in arr_2)
        {
            Console.WriteLine(el);
        }

    }
}



