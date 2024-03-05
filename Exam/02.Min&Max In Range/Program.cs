int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = start; i <= end; i++)
{
    max = Math.Max(max, numbers[i]);
    min = Math.Min(min, numbers[i]);
}

int sum = max + min;

Console.WriteLine(sum);