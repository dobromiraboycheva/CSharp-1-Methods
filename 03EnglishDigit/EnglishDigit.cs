//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	    output
//512	    two
//1024	    four
//12309 	nine

using System;
using System.Collections.Generic;
using System.Linq;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitAsWord(n));
    }
    private static string LastDigitAsWord(int number)
    {
        int digit = number % 10;
        string result = string.Empty;
        switch (digit)
        {
            case 1:
                return result="one"; break;
            case 2:
                return result = "two"; break;
            case 3:
                return result = "three"; break;
            case 4:
                return result = "four"; break;
            case 5:
                return result = "five"; break;
            case 6:
                return result = "six"; break;
            case 7:
                return result = "seven"; break;
            case 8:
                return result = "eight"; break;
            case 9:
                return result = "nine"; break;
            case 0:
                return result = "zero"; break;      
        }
        return result;
    }
}
