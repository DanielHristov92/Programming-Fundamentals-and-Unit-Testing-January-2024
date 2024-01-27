int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int total = num1 + num2 + num3;

int timeMinutes = total / 60;
int timeSeconds = total % 60;

Console.WriteLine($"{timeMinutes}:{timeSeconds:D2}");