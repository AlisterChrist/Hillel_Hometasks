using System.ComponentModel.Design;

Console.Write("Enter your age:");
int age;
if (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Invalid number input!");
    return;
}
if (age >= 18)
{
    Console.Write("Welcome again, my friend!");
}
else
{
    Console.Write("Sorry, you're not old enough for this.");
}