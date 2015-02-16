//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class SolveTasks
{
    static void Main()
    {
        string user = "0";
        while (user == "0")
        {
            Console.WriteLine("Program options: ");
            Console.WriteLine("1) Reverses the digits of a number");
            Console.WriteLine("2) Calculates the average of a sequence of integers");
            Console.WriteLine("3) Solves a linear equation 'a * x + b = 0'");
            Console.Write("Enter your choice: ");
            user = Console.ReadLine();
            switch (user)
            {
                case "1": ReverseDigits();
                    return;
                case "2": AverageSumOfSequence();
                    return;
                case "3": SolveLinearEquation();
                    return;
                default:
                    Console.Clear();
                    user = "0";
                    break;
            }
        }
    }

    static void ReverseDigits()
    {
        decimal number = 0;
        do
        {
            Console.Write("Enter a non-negative number (real or integer): ");
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);
        string temp = number.ToString(CultureInfo.InvariantCulture);
        string result = string.Empty;
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            result += temp[i];
        }
        Console.WriteLine("Result: {0} -> {1}", number, decimal.Parse(result));
        return;
    }
    static void AverageSumOfSequence()
    {
        int n = 0;
        do
        {
            Console.Write("Enter a non-negative number N (size of array): ");
            n = int.Parse(Console.ReadLine());
        }
        while (n <= 0);
        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nAverage sum = {0}", numbers.Average());
        return;
    }
    static void SolveLinearEquation()
    {
        decimal a = 0;
        do
        {
            Console.Write("Enter a non-zero number A: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);
        Console.Write("Enter a number B: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("\nResult -> x = -b / a = {0}", -b / a);
    }
}
