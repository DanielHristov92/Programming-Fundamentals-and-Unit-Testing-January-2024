int nylonAmount = int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylon = (nylonAmount + 2) * 1.50;
double paint = (paintAmount * 1.1) * 14.50;
double thinnerAmount = thinner * 5;
double bagsPrice = 0.4;

double totalAmount = nylon + paint + thinnerAmount + bagsPrice;
double craftsmen = 0.3 * totalAmount;
double craftsManTotal = craftsmen * hours;
double totalCost = totalAmount + craftsManTotal;

Console.WriteLine(totalCost);