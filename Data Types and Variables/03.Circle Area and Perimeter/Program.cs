double radius = double.Parse(Console.ReadLine());
double area = radius * radius * 3.14159265359;
double perimeter = 2 * 3.14159265359 * radius;
Console.WriteLine($"Area = {area:f2}");
Console.WriteLine($"Perimeter = {perimeter:F2}");