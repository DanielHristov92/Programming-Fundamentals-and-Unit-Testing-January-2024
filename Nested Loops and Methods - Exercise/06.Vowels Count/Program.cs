string text = Console.ReadLine();
int vowelCount = CountVowels(text);
Console.WriteLine(vowelCount);
    static int CountVowels(string text)
{
    int count = 0;
    foreach (char c in text)
    {
        if (IsVowel(c))
        {
            count++;
        }
    }
    return count;
}

static bool IsVowel(char c)
{
    c = char.ToLower(c);
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}
