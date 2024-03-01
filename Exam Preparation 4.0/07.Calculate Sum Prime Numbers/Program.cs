int N = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();

for (int i = 0; i < N; i++)
{
    int num = int.Parse(Console.ReadLine());
    numbers.Add(num);
}

int sum = SumOfPrimes(numbers);
Console.WriteLine(sum);

        static bool IsPrime(int num)
{
    if (num <= 1)
    {
        return false;
    }

    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}
static int SumOfPrimes(List<int> numbers)
{
    int sum = 0;
    foreach (int num in numbers)
    {
        if (IsPrime(num))
        {
            sum += num;
        }
    }
    return sum;
}