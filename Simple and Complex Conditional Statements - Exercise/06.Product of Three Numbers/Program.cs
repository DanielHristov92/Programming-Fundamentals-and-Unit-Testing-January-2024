int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int operation = num1 * num2 * num3;

if (operation > 0)
{
    Console.WriteLine("positive");
}
else if (operation < 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("zero");
}