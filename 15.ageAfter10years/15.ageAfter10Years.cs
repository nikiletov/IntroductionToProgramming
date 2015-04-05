/*
Problem 15.* Age after 10 Years
Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/
using System;
class ageAfter10Years
{
    static void Main()
    {
        Console.Write("wath is your birth year?");
        int birthData = int.Parse(Console.ReadLine());
        int courentYears = DateTime.Now.Year - birthData;
        int futureAge = courentYears + 10;
        Console.WriteLine("your are {0} years old,\nand you will be {1} years old after 10 years. ", courentYears, futureAge);
        Console.Read();
    }
}

