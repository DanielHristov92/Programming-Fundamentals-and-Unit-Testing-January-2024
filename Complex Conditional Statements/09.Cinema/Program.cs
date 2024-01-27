string type = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

if (type == "Premiere")
{
    double totalAmount = count * seats;
    double premiere = 12.00;
    double totalCost = totalAmount * premiere;
    Console.WriteLine($"{totalCost:F2}");
}
if (type == "Normal")
{
    double totalAmount = count * seats;
    double normal = 7.50;
    double totalCost = totalAmount * normal;
    Console.WriteLine($"{totalCost:F2}");
}
if (type == "Discount")
{
    double totalAmount = count * seats;
    double discount = 5.00;
    double totalCost = totalAmount * discount;
    Console.WriteLine($"{totalCost:F2}");
}