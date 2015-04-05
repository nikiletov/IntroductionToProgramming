/*
Problem 14.* Current Date and Time
Create a console application that prints the current date and time.
Find out how in Internet.using System;
*/
using System;
class Program
{
    class Employee
    {
        public DateTime HiringDate { get; set; }
    }

    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Employee employee = new Employee() { HiringDate = now };
        Console.WriteLine(employee.HiringDate);
        Console.Read();
    }
}