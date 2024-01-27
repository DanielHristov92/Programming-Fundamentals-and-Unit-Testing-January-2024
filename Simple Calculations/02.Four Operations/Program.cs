double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());

double adding = firstNum + secondNum;
double subtraction = firstNum - secondNum;
double multiplication = firstNum * secondNum;
double division = firstNum / secondNum;

Console.WriteLine($"{firstNum:F2} + {secondNum:F2} = {adding:F2}");
Console.WriteLine($"{firstNum:F2} - {secondNum:F2} = {subtraction:F2}");
Console.WriteLine($"{firstNum:F2} * {secondNum:F2} = {multiplication:F2}");
Console.WriteLine($"{firstNum:F2} / {secondNum:F2} = {division:F2}");