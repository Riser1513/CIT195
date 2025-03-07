using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers should be added to the array?");
        string tempStr = Console.ReadLine();
        int len;
        while (!int.TryParse(tempStr, out len))
        {
            Console.WriteLine("That's not a valid number, silly.");
            Console.WriteLine("How many numbers should be added to the array?");
            tempStr = Console.ReadLine();
        }
        int[] numbers = new int[len];
        for (int i = 0; i < len; i++)
        {
            int tempNum = r.Next(1, 10);
            if (tempNum == 0)
            {
                tempNum = 1;
            }
            numbers[i] = tempNum;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Total of the numbers added = " + Add(numbers));
        Console.WriteLine("Product of the numbers multiplied = " + Multiply(numbers));
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}