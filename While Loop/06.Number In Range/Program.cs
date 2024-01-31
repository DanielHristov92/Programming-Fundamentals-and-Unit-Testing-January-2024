int num = int.Parse(Console.ReadLine());

bool isInRange = num >= 1 && num <= 100;

while (!isInRange)
{
    num = int.Parse(Console.ReadLine());
    isInRange = num >= 1 && num <= 100;
}
Console.WriteLine(num);