List<int> numbers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

string command = Console.ReadLine();
while (command != "end")
{
    string[] tokens = command.Split();
    string action = tokens[0];
    int number = int.Parse(tokens[1]);

    switch (action)
    {
        case "Add":
            numbers.Add(number);
            break;
        case "Remove":
            numbers.Remove(number);
            break;
        case "RemoveAt":
            int indexToRemove = number;
            numbers.RemoveAt(indexToRemove);
            break;
        case "Insert":
            int indexToInsert = int.Parse(tokens[2]);
            numbers.Insert(indexToInsert, number);
            break;
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));