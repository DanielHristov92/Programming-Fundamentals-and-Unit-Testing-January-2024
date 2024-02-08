int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factorial1 = CalculateFactorial(num1);
int factorial2 = CalculateFactorial(num2);

int result = factorial1 / factorial2;

Console.WriteLine(result);
 static int CalculateFactorial(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}
