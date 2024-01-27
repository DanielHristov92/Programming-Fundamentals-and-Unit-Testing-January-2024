int fee = int.Parse(Console.ReadLine());

double sneakers = fee - (fee * 0.4);
double team = sneakers - (sneakers * 0.2);
double basketball = team / 4;
double accesories = basketball / 5;
double total = fee + sneakers + team + basketball + accesories;

Console.WriteLine($"{total}");