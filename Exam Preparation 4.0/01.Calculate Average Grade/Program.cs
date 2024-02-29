int N = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 0; i < N; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sum += grade;
}

double averageGrade = sum / N;
Console.WriteLine($"{averageGrade:F2}");
