List<int> firstSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> secondSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

int minLength = Math.Min(firstSequence.Count, secondSequence.Count);

for (int i = 0; i < minLength; i++)
{
    result.Add(firstSequence[i]);
    result.Add(secondSequence[i]);
}

if (firstSequence.Count > minLength)
{
    result.AddRange(firstSequence.GetRange(minLength, firstSequence.Count - minLength));
}
else if (secondSequence.Count > minLength)
{
    result.AddRange(secondSequence.GetRange(minLength, secondSequence.Count - minLength));
}

Console.WriteLine(string.Join(" ", result));