int N = int.Parse(Console.ReadLine());
bool foundMagicNumber = false;

for (int number = 1; number <= N; number++)
{
    if (IsMagicNumber(number))
    {
        Console.Write(number + " ");
        foundMagicNumber = true;
    }
}

if (!foundMagicNumber)
{
    Console.WriteLine("no");
}
    static bool IsMagicNumber(int number)
{
    return IsAllDigitsPrime(number) && SumOfDigits(number) % 2 == 0;
}

static bool IsAllDigitsPrime(int number)
{
    while (number > 0)
    {
        int digit = number % 10;
        if (!IsPrime(digit))
        {
            return false;
        }
        number /= 10;
    }
    return true;
}

static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}