int num = int.Parse(Console.ReadLine());

int tempNum = num;
bool isSpecialNumber = true;
while (tempNum > 0)
{
  int currentDigit = tempNum % 10;
    tempNum /= 10;

    if (num % currentDigit != 0)
    {
        isSpecialNumber = false;
        break;
    }
}
if (isSpecialNumber)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}