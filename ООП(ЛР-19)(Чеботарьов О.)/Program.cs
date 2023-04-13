using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {

        Console.Write("Enter any combination of numbers and spaces: ");
        string input = Console.ReadLine();
        string pattern = @"(?<!^\+?\d*)\D";

        Console.Write("Combination without spaces exept first one: ");
        string result = Regex.Replace(input, pattern, string.Empty);
        Console.WriteLine(result);
    }
}