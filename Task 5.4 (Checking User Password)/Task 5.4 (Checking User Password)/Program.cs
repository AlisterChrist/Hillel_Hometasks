
double workHours;
double salaryPerDay = 0;

Console.WriteLine("How many hours do you work a day?");

while (!double.TryParse(Console.ReadLine(), out workHours))
{
    Console.WriteLine("Incorrect symbols!");
}

for (int i = 0; i < workHours; i++)
{
    Console.WriteLine($"How much money do you earn for the {i + 1} hour?");

    double salaryPerHour;
    while (!double.TryParse(Console.ReadLine(), out salaryPerHour))
    {
        Console.WriteLine("Incorrect symbols!");
    }

    salaryPerDay += salaryPerHour;
}

Console.WriteLine($"Your salary in the company: {salaryPerDay}$");