string[] numbers = Console.ReadLine().Split();
int rotations = int.Parse(Console.ReadLine());

int[] sequence = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    sequence[i] = int.Parse(numbers[i]);
}

for (int i = 0; i < rotations; i++)
{
    int firstElement = sequence[0];
    for (int j = 0; j < sequence.Length - 1; j++)
    {
        sequence[j] = sequence[j + 1];
    }
    sequence[sequence.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", sequence));