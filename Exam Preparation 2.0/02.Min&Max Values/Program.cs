int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

int num = int.Parse(Console.ReadLine());

int max = numbers.Take(num).Max();
int min = numbers.Take(num).Min();

Console.WriteLine(max);
Console.WriteLine(min);