
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPrime(number))
    Console.WriteLine($"Number {number} is prime!");
else
    Console.WriteLine($"Number {number} isn't prime!");
    

    static bool IsPrime(int num)
{
    if (num <= 1) return false;          // 0 та 1 не є простими
    if (num == 2) return true;           // 2 — просте
    if (num % 2 == 0) return false;      // усі парні > 2 — не прості

    return true;
}