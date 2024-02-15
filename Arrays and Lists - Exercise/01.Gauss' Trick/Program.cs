int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int length = numbers.Length;

for (int i = 0; i < (length + 1) / 2; i++)
{
    int sum = numbers[i] + (i != length - 1 - i ? numbers[length - 1 - i] : 0);

    Console.Write(sum + " ");
}

Console.WriteLine();