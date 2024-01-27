int point = int.Parse(Console.ReadLine());

if (point >= 0 && point <= 3)
{
    point = point + 5;
}
else if (point >= 4 && point <= 6)
{
    point = point + 15;
}
else if (point >= 7 && point <= 9)
{
    point = point + 20;
}
Console.WriteLine(point);