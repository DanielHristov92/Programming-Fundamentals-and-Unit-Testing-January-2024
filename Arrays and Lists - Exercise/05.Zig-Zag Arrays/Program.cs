int n = int.Parse(Console.ReadLine());

int[] arr1 = new int[n];
int[] arr2 = new int[n];

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    arr1[i] = int.Parse(input[0]);
    arr2[i] = int.Parse(input[1]);
}

Array.Sort(arr1);
Array.Sort(arr2);

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
        Console.Write(arr1[i] + " ");
    else
        Console.Write(arr2[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
        Console.Write(arr2[i] + " ");
    else
        Console.Write(arr1[i] + " ");
}
Console.WriteLine();