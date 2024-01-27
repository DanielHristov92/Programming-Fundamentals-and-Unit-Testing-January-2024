int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int aqquarium = length * width * height;
double liters = aqquarium * 0.001;
double occupied = percentage / 100;
double required = liters * (1 - occupied);

Console.WriteLine($"{required:F2}");