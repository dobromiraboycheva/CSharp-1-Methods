//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	    output
//Peter 	Hello, Peter!

using System;
using System.Collections.Generic;
using System.Linq;


class SayHello
{
    static void Main()
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Hello(name);
    }
    static void Hello(string names)
    {
        Console.WriteLine("Hello, {0}!",names);
    }
}

