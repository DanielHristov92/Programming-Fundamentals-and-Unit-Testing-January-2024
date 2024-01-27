string drink = Console.ReadLine();
string extra = Console.ReadLine();
double coffeePrice = 1.00;
double teaPrice = 0.60;
double sugarPrice = 0.40;
double finalPrice = 0.0;

if (drink == "coffee")
{
    finalPrice = coffeePrice + (extra == "sugar" ? sugarPrice : 0.0);
}
else if (drink == "tea")
{
    finalPrice = teaPrice + (extra == "sugar" ? sugarPrice : 0.0);
}
Console.WriteLine($"Final price: ${finalPrice:F2}");