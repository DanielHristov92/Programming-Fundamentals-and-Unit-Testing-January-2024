int number = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfEvenDigitFactorials(number));

    static long SumOfEvenDigitFactorials(int number)
{
    long sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;

        if (digit % 2 == 0)
        {
            long factorial = CalculateFactorial(digit);

            sum += factorial;
        }
    }

    return sum;
}

static long CalculateFactorial(int n)
{
    long factorial = 1;
    for (int i = 2; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}
