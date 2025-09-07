
//Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
//Просте число - це число, яке ділиться лише на 1 і на себе.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1) Ввод числа N з перевіркою
int max;
while (true)
{
    Console.Write("Enter an integer N (not less than 2): ");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out max) && max >= 2)
        break;

    Console.WriteLine("Incorrect input. Example: 50");
}

// 2) Пошук та вивід простих чисел
int count = 0; // розрахунок простих чисел
Console.WriteLine($"\nPrime numbers from 1 to {max}:");

 for (int n = 2; n <= max; n++)
        {
            if (IsPrime(n))
            {
                Console.Write(n + " "); // одразу друкуємо
                count++;                // збільшуємо розрахунок
            }
        }

// 3) Результат
Console.WriteLine($"\n\nTotal number of prime numbers: {count}");

static bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    return true;
}