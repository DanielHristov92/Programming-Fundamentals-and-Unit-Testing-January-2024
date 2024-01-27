double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

if (mathOperator == "+")
{
    double sum = number1 + number2;
    Console.WriteLine($"{number1} {mathOperator} {number2} = {sum:F2}");
}
else if (mathOperator == "-")
{
    double minus = number1 - number2;
    Console.WriteLine($"{number1} {mathOperator} {number2} = {minus:F2}");
}
else if (mathOperator == "*")
{
    double plus = number1 * number2;
    Console.WriteLine($"{number1} {mathOperator} {number2} = {plus:F2}");
}
else if (mathOperator == "/")
{
    double asc = number1 / number2;
    Console.WriteLine($"{number1} {mathOperator} {number2} = {asc:F2}");
}