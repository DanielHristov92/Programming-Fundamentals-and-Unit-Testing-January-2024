List<int> numbers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

string command = Console.ReadLine();
while (command != "end")
{
    string[] tokens = command.Split();
    string action = tokens[0];

    switch (action)
    {
        case "Contains":
            int numberToCheck = int.Parse(tokens[1]);
            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;
        case "PrintEven":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
            break;
        case "PrintOdd":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
            break;
        case "GetSum":
            Console.WriteLine(numbers.Sum());
            break;
        case "Filter":
            string condition = tokens[1];
            int filterNumber = int.Parse(tokens[2]);
            numbers = FilterList(numbers, condition, filterNumber);
            break;
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
    static List<int> FilterList(List<int> numbers, string condition, int filterNumber)
{
    switch (condition)
    {
        case "<":
            return numbers.Where(n => n < filterNumber).ToList();
        case ">":
            return numbers.Where(n => n > filterNumber).ToList();
        case "<=":
            return numbers.Where(n => n <= filterNumber).ToList();
        case ">=":
            return numbers.Where(n => n >= filterNumber).ToList();
        default:
            return numbers;
    }
}