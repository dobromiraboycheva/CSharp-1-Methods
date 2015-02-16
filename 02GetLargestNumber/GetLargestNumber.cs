//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        int p = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(n, m), p);
        Console.WriteLine("Larger number is: {0}", max);
    }

    private static int GetMax(int first, int second)
    {

        if (first > second)
        {
            return first;
        }
        else if (first < second)
        {
            return second;
        }
        else return first;
    }
}
