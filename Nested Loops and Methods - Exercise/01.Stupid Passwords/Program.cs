int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
{
    for (int j = 1; j <= N; j += 2)
    {
        int product = i * j;
        Console.Write($"{i}{j}{product} ");
    }
}
   