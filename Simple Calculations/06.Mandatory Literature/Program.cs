int numberOfPages = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int reaingTime = numberOfPages / pages;
int hours = reaingTime / numberOfDays;

Console.WriteLine(hours);