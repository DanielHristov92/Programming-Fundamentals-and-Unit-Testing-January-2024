string[] input = Console.ReadLine().Split();
int[] numbers = Array.ConvertAll(input, int.Parse);

int sumEven = 0;
int sumOdd = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumEven += number;
    }
    else
    {
        sumOdd += number;
    }
}

int difference = sumEven - sumOdd;

Console.WriteLine(difference);