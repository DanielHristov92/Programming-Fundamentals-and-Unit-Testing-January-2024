string input = Console.ReadLine();
string[] numbers = input.Split(' ');

int[] array = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    array[i] = int.Parse(numbers[i]);
}

int middleStart = array.Length / 2 - 1;
int middleEnd = array.Length / 2;
int sum = 0;
for (int i = middleStart; i <= middleEnd; i++)
{
    sum += array[i];
}

double average = (double)sum / (middleEnd - middleStart + 1);
Console.WriteLine($"{average:F2}");
