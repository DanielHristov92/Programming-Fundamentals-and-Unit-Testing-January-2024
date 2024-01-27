int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double dogFoodPrice = 2.50;
double catFoodPrice = 4.00;

double total = dogFood * 2.5 + catFood * 4.00;
Console.WriteLine($"{total:F2} lv.");