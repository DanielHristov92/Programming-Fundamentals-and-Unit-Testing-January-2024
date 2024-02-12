int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool areIdentical = Enumerable.SequenceEqual(firstArray, secondArray);

if (areIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
