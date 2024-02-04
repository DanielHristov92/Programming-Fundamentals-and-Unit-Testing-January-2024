int num =  int.Parse(Console.ReadLine());
int max = 0;

for (int i = 0; i < num; i++)
{
 int current = int.Parse(Console.ReadLine());

    if (current > max)
    {
     max = current;
    }
}
Console.WriteLine(max);