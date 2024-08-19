using System;

class IfElseExample
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }
    }
}