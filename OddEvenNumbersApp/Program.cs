using System;
using System.Collections.Generic;
using System.Linq;

static void printNumbers(string title, IEnumerable<int> numbers)
{
    Console.Write($"{title}: [");
    foreach (var n in numbers)
    {
        Console.Write($"{n}, ");
    }
    Console.WriteLine($"]");
}

static bool IsEven(int number) => number % 2 == 0;


static bool IsOdd(int number) => !IsEven(number);


int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

printNumbers("Numbers", numbers);
printNumbers("Even Numbers", numbers.Where(x => IsEven(x)));
printNumbers("Odd Numbers", numbers.Where(x => IsOdd(x)));

Console.WriteLine("Hello, World!");
Console.ReadKey();  // Remove or replace if using non-interactive console environments
