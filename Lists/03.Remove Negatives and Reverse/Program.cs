﻿using System.ComponentModel.Design;

List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
                    
for (int i = 0; i < numbers.Count; i++)
{
 if (numbers[i] < 0)
    {
        numbers.Remove(numbers[i]);
        i--;
    }
}

if (numbers.Count > 0)
{
    numbers.Reverse();
    Console.WriteLine(string.Join(" ", numbers));
}
else
{
    Console.WriteLine("empty");
}
