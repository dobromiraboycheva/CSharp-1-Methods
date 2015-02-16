//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter an positive number N (array's length): ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter {0} number(s) to array:", n);
        int[] array = InputArray(n);
        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Max element in interval [{0}, {1}] -> {2}", start, end, MaxElementInInterval(array, start, end));
        Console.WriteLine("Numbers in Ascending order: {0}", string.Join(" ", SortAscending(array)));
        Console.WriteLine("Numbers in Descending order: {0}", string.Join(" ", SortDescending(array)));
    }
    static int[] InputArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static int MaxElementInInterval(int[] numbers, int start, int end, int swapIndex = 0)
    {
        if (start < 0 || start >= numbers.Length || end < 0 || end >= numbers.Length)
        {
            throw new IndexOutOfRangeException();
        }
        int maxIndex = start;
        for (int i = start; i <= end; i++)
        {
            if (numbers[maxIndex] < numbers[i])
            {
                maxIndex = i;
            }
        }
        int temp = numbers[swapIndex];
        numbers[swapIndex] = numbers[maxIndex];
        numbers[maxIndex] = temp;
        return numbers[swapIndex];
    }
    static int[] SortAscending(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sorted[i] = MaxElementInInterval(array, 0, i, i);
        }
        return sorted;
    }
    static int[] SortDescending(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sorted[i] = MaxElementInInterval(array, i, array.Length - 1, i);
        }
        return sorted;
    }
}
