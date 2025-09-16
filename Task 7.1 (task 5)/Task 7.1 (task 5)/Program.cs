// Enum для днів тижня

Console.Write("Enter the number of the days: ");

if (int.TryParse(Console.ReadLine(), out int days))
{
// Обчислення індексу дня тижня
int dayIndex = days % 7; // залишок від ділення на 7
Days resultDay = (Days)dayIndex;

Console.WriteLine($"In {days} days will be: {resultDay}");
}
else
{
Console.WriteLine("Wrong input!");
}

enum Days
{
    Monday = 0,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}