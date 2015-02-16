//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter how many element will be in your array: ");
        int n=int.Parse(Console.ReadLine());
        int[] array = InputArray(n);
        Console.Write("Enter the number that will be search:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is {1}times in your array!",num,Counter(num,array));
        Console.WriteLine();
        Test();
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
    static int Counter(int number,int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
                count++;
        }
        return count;
    }
     static void Test()
    {
        int[] test1 = { 0, 0, 0, 0, 0 };
        int num1=0;
        int tester1 = Counter(num1, test1);
        int[] test2 = {2,3,2,3,4,2,2};
        int num2 = 2;
        int tester2 = Counter(num2, test2);
         if(tester1==5&&tester2==4)
         {
             Console.WriteLine("Your method work correct!");
         }
         else
         {
             Console.WriteLine("Tour method NOT work correct!");
         }
       
    }
}
