using System;

class ArrayExample
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Orange" };

        Console.WriteLine("Fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}