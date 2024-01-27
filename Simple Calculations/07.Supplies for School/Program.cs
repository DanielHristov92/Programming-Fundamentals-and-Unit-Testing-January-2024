int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalAmount = pens * 5.8 + markers * 7.20 + cleaner * 1.20;
double discountAmount = totalAmount * discount / 100;
double finalAmout = totalAmount - discountAmount;

Console.WriteLine(finalAmout);