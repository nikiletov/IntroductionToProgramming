/*
Problem 8. Square Root
Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.
*/
using System;
class Square
{
    static void Main()
    {
        int number = 12345;
        int square = number * number;
        Console.WriteLine("square of {0}  is {1}", number, square);
        Console.Read();
    }
}

