
double number;

Console.Write("Enter number: ");
if (!double.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid number input!");
    return;
}

for (int fromOnetoTen = 1; fromOnetoTen <= 10; fromOnetoTen++)
{
    double result = number * fromOnetoTen;

    Console.WriteLine($"{number} * {fromOnetoTen} = {result}");
}