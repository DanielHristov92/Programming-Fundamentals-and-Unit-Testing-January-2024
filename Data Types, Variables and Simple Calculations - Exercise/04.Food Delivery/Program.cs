int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegie = int.Parse(Console.ReadLine());

double chickenPrice = chicken * 10.35;
double fishPrice = fish * 12.40;
double vegiePrice = vegie * 8.15;
double totalMenuCost = chickenPrice + fishPrice + vegiePrice;
double dessert = totalMenuCost * 0.2;
double delivery = 2.5;
double totalOrderPrice = totalMenuCost + dessert + delivery;

Console.WriteLine(totalOrderPrice);