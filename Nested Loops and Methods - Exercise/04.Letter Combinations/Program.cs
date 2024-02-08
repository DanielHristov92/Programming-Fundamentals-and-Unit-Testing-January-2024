char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char excluded = char.Parse(Console.ReadLine());

int count = 0;

for (char first = start; first <= end; first++)
{
    if (first == excluded)
    {
        continue;
    }

    for (char second = start; second <= end; second++)
    {
        if (second == excluded)
        {
            continue;
        }

        for (char third = start; third <= end; third++)
        {
            if (third == excluded)
            {
                continue;
            }

            Console.Write($"{first}{second}{third} ");
            count++;
        }
    }
}

Console.WriteLine();
Console.WriteLine(count);