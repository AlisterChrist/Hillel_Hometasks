int number;
int current = 0;
int previous = 0;

Console.WriteLine("Enter the Number:");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Incorrect symbols!");
}

for (var i = 0; i < number; i++)
{
    if (current == 0) current = i;
    int buf = current;
    current += previous;
    previous = buf;
    Console.WriteLine(current);
}