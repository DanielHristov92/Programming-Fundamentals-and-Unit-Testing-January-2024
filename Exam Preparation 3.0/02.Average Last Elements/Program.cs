string[] inputArray = Console.ReadLine().Split();
int[] numbers = Array.ConvertAll(inputArray, int.Parse);

int num = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = numbers.Length - num; i < numbers.Length; i++)
{
    sum += numbers[i];
}

double average = (double)sum / num;

Console.WriteLine($"{average:F2}");



