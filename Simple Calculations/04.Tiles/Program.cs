double bathW = double.Parse(Console.ReadLine());
double bathH = double.Parse(Console.ReadLine());
double tileW = double.Parse(Console.ReadLine());
double tileH = double.Parse(Console.ReadLine());

double area = bathW * bathH;
double surplus = area * 0.1;
double totalBathArea = area + surplus;
double tilearea = tileW * tileH;
double tilesNeeded = totalBathArea / tilearea;

Console.WriteLine($"{tilesNeeded:F0}");