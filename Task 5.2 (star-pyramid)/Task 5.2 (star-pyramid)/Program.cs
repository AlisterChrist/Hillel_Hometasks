
int numRows;

Console.WriteLine("How many stars will we build a pyramid from?");

if (!int.TryParse(Console.ReadLine(), out numRows))
{
    Console.WriteLine("Invalid number input!");
    return;
}

//One-sided Pyramid

for (int checkingRows = 1; checkingRows <= numRows; checkingRows++)
{
    for (int star = 0; star < checkingRows; star++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}