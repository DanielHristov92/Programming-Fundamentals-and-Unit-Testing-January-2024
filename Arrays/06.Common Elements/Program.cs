string[] input1 = Console.ReadLine().Split();
string[] input2 = Console.ReadLine().Split();

string commonElements = FindCommonElements(input1, input2);

Console.WriteLine(commonElements);
    static string FindCommonElements(string[] arr1, string[] arr2)
{
    string result = "";
    foreach (var element1 in arr1)
    {
        foreach (var element2 in arr2)
        {
            if (element1 == element2)
            {
                result += element1 + " ";
                break;
            }
        }
    }
    return result.Trim();
}