int n = int.Parse(Console.ReadLine());

int numDividedBy2 = 0;
int numDividedBy3 = 0;
int numDividedBy4 = 0;
for (int i = 0; i < n; i++)
{
    int curreentNumber = int.Parse(Console.ReadLine());

    if (curreentNumber % 2 == 0)
    {
        numDividedBy2++;
    }
    if (curreentNumber % 3 == 0)
    {
        numDividedBy3++;
    }
    if (curreentNumber % 4 == 0)
    {
        numDividedBy4++;
    }
}
double numDividedBy2Percentage = (double)numDividedBy2 / n * 100;
double numDividedBy3Percentage = (double)numDividedBy3 / n * 100;
double numDividedBy4Percentage = (double) numDividedBy4 / n * 100;

Console.WriteLine($"{numDividedBy2Percentage:F2}%");
Console.WriteLine($"{numDividedBy3Percentage:F2}%");
Console.WriteLine($"{numDividedBy4Percentage:F2}%");