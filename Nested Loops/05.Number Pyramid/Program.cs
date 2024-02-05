int n = int.Parse(Console.ReadLine());
int line = 1;
int i = 1;

while (i <= n)
{
    for (int pr = 1; pr <= line; pr++)
    {
        Console.Write(i + " ");
        i++;
        if (i > n)
        {
            break;
        }
    }
    Console.WriteLine();
    line++;
}