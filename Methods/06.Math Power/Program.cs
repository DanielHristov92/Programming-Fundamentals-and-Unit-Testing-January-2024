int baseNum = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(baseNum, p));
static int MathPower(int baseNum, int power)
{
    int output = baseNum;
    for (int i = 2; i <= power; i++)
    {
        output *= baseNum;
    }
    return output;
}