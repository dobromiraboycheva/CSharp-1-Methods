//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;

class SubtractingPolynomials
{
    static void Main()
    {
        decimal[] firstPolynom = EnterPolynom(out firstPolynom);
        Console.Write("Polynomial in normal form:");
        PrintPolynomial(firstPolynom);
        Console.WriteLine();
        decimal[] secondPolynom = EnterPolynom(out secondPolynom);
        Console.Write("Polynomial in normal form:");
        PrintPolynomial(secondPolynom);
        Console.WriteLine();
        Addition(firstPolynom, secondPolynom);
        Console.WriteLine();
        Subtraction(firstPolynom, secondPolynom);
        Console.WriteLine();
        Multiplication(firstPolynom, secondPolynom);
        Console.WriteLine();
    }

    static decimal[] EnterPolynom(out decimal[] polynom)
    {
        Console.Write("Enter your polynomial degree: ");
        byte degree = byte.Parse(Console.ReadLine());
        polynom = new decimal[degree + 1];
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + ": ");
            polynom[i] = decimal.Parse(Console.ReadLine());
        }
        return polynom;
    }
    static void Addition(decimal[] first, decimal[] second)
    {
        PrintPolynomial(first);
        Console.WriteLine("+");
        PrintPolynomial(second);
        Console.WriteLine("=");
        int lengthBigger = Math.Max(first.Length, second.Length);
        bool isFirstBigger = first.Length >= second.Length;
        bool isPolynomialZero = true;
        decimal[] result = new decimal[lengthBigger];
        for (int i = 0; i < lengthBigger; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] + second[i];
                if (result[i] != 0)
                    isPolynomialZero = false;
            }
            else if (isFirstBigger)
            {
                result[i] = first[i];
            }
            else
            {
                result[i] = second[i];
            }
        }
        if (isPolynomialZero) Console.Write("     0\n");
        else PrintPolynomial(result);
    }
    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (i == polynomial.Length - 1 && polynomial[i] != 0)
            {
                Console.Write("{0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
            }
            else if (i == 0)
            {
                if (polynomial[i] < 0) Console.Write("{0}{1} ", "- ", -polynomial[i]);
                else if (polynomial[i] > 0) Console.Write("{0}{1} ", "+ ", polynomial[i]);
            }
            else
            {
                if (polynomial[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
                else if (polynomial[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
            }
        }
        Console.WriteLine();
    }
    static void Subtraction(decimal[] first, decimal[] second)
    {
        PrintPolynomial(first);
        Console.WriteLine("-");
        PrintPolynomial(second);
        Console.WriteLine(" =");
        int lengthBigger = Math.Max(first.Length, second.Length);
        bool isFirstBigger = first.Length >= second.Length;
        bool isPolynomialZero = true;
        decimal[] result = new decimal[lengthBigger];
        for (int i = 0; i < lengthBigger; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] - second[i];
                if (result[i] != 0)
                    isPolynomialZero = false;
            }
            else if (isFirstBigger)
            {
                result[i] = first[i];
            }
            else
            {
                result[i] = -second[i];
            }
        }
        if (isPolynomialZero) Console.Write("0\n");
        else PrintPolynomial(result);
    }
    static void Multiplication(decimal[] first, decimal[] second)
    {
        PrintPolynomial(first);
        Console.WriteLine("*");
        PrintPolynomial(second);
        Console.WriteLine("=");
        decimal[] result = new decimal[first.Length + second.Length - 1];
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                result[i + j] += (first[i] * second[j]);
            }
        }
        PrintPolynomial(result);
    }
}