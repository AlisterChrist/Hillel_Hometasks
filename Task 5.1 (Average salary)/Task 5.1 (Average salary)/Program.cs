
int employeeNumber;
double totalSalary = 0;

Console.WriteLine("How many employees on your workplace?");

while (!int.TryParse(Console.ReadLine(), out employeeNumber))
{
    Console.WriteLine("Incorrect symbols!");
}

for (int workersNum = 0; workersNum < employeeNumber; workersNum++)
{
    Console.WriteLine($"Enter the salary of the worker #{workersNum+1}");

    double salary;
    while (!double.TryParse(Console.ReadLine(), out salary))
    {
        Console.WriteLine("Incorrect symbols!");
    }

    totalSalary += salary;
}

Console.WriteLine($"Average salary in the company: {totalSalary / employeeNumber}");