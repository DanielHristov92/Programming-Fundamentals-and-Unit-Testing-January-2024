double depositedAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine());

double acc = depositedAmount * rate / 100;
double interest = acc / 12;
double totalAmount = depositedAmount + months * interest;
Console.WriteLine($"{totalAmount:F2}");