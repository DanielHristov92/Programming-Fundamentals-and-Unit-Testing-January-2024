string[] numbersInput = Console.ReadLine().Split(' ');

int N = int.Parse(Console.ReadLine());

foreach (string numberStr in numbersInput)
{
    int number = int.Parse(numberStr);
    if (number > N)
    {
        Console.Write(number + " ");
    }
}