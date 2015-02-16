//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter how many element will be in your array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = InputArray(n);
        Console.Write("Enter which posistion do you want to check: ");
        int position = int.Parse(Console.ReadLine());
        while (position < 0 || position > array.Length - 1)
        {
            Console.WriteLine("Check possition must be >=0 ang <{0}", array.Length);
            position = int.Parse(Console.ReadLine());
        }
        bool result = CkeckNeighbours(array, position);
        if (result)
        {
            Console.WriteLine("{0} is larger than its two neighbours", array[position]);
        }
        else
        {
            Console.WriteLine("{0} is NOT larger than its two neighbours", array[position]);
        }
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
    static bool CkeckNeighbours(int[] array, int position)
    {
        bool result = false;
        if (position == 0)
        {
            return result = array[0] > array[1];
        }
        else if (position == array.Length - 1)
        {
            return result = array[position] > array[position - 1];
        }
        else
        {
            return result = (array[position] > array[position - 1] && array[position] > array[position + 1]);
        }
        return result;
    }
}
