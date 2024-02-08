int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

string result = GetProductSign(num1, num2, num3);

Console.WriteLine(result);
    static string GetProductSign(int a, int b, int c)
{
    int countNegative = 0;

    if (a == 0 || b == 0 || c == 0)
    {
        return "zero";
    }

    if (a < 0)
    {
        countNegative++;
    }

    if (b < 0)
    {
        countNegative++;
    }

    if (c < 0)
    {
        countNegative++;
    }

    return countNegative % 2 == 0 ? "positive" : "negative";
}