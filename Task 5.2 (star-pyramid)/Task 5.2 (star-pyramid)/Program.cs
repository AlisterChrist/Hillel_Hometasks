
int numRows;

Console.WriteLine("How many stars will we build a pyramid from?");

if (!int.TryParse(Console.ReadLine(), out numRows))
{
    Console.WriteLine("Invalid number input!");
    return;
}

//One-sided Pyramid

for (int i = 1; i <= numRows; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}