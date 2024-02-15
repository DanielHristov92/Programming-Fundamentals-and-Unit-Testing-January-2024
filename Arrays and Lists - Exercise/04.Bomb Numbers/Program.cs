int[] numbers = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

int[] bombParameters = Console.ReadLine()
    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int bombNumber = bombParameters[0];
int bombPower = bombParameters[1];

int index = Array.IndexOf(numbers, bombNumber);
while (index != -1)
{
    int left = Math.Max(0, index - bombPower);
    int right = Math.Min(numbers.Length - 1, index + bombPower);
    numbers = numbers.Take(left).Concat(numbers.Skip(right + 1)).ToArray();
    index = Array.IndexOf(numbers, bombNumber);
}

int sum = numbers.Sum();
Console.WriteLine(sum);