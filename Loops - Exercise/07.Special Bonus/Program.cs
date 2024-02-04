int stopNumber = int.Parse(Console.ReadLine());

int previousNumber = 0;

while (true)
{
    int number = int.Parse(Console.ReadLine());
    if (number == stopNumber)
    {
        Console.WriteLine(previousNumber * 1.2);
        break;
    }
    previousNumber = number;
}