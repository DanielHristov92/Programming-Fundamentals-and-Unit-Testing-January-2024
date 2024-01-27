string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double discount = 0;
double pricePerNight = 0;

if (season == "Spring")
{
    discount = 0.2;
    if (type == "Hotel")
    {
        pricePerNight = 30;
    }
    else if (type == "Camping")
    {
        pricePerNight = 10;
    }

}
else if (season == "Summer")
{
    discount = 0;
    if (type == "Hotel")
    {
        pricePerNight = 50;
    }
    else if (type == "Camping")
    {
        pricePerNight = 30;
    }

}
else if (season == "Autumn")
{
    discount = 0.3;
    if (type == "Hotel")
    {
        pricePerNight = 20;
    }
    else if (type == "Camping")
    {
        pricePerNight = 15;
    }

}
if (season == "Winter")
{
    discount = 0.1;
    if (type == "Hotel")
    {
        pricePerNight = 40;
    }
    else if (type == "Camping")
    {
        pricePerNight = 10;
    }

}
double totalPriceNoDiscount = pricePerNight * days;
double totalPrice = totalPriceNoDiscount - (totalPriceNoDiscount * discount);

Console.WriteLine($"{totalPrice:F2}");