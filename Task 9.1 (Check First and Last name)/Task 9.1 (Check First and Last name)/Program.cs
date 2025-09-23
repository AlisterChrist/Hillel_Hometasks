Console.Write("Enter your first and last name: ");
string fullName = Console.ReadLine();

// Розбиваємо рядок на ім’я та прізвище
string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (parts.Length < 2)
{
    Console.WriteLine("Please enter both your first and last name!");
    return;
}

string firstName = parts[0];
string lastName = parts[1];

// Перевіряємо перші літери (регістр неважливий)
if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
{
    Console.WriteLine("Last name begins with the same letter as first name.");
}
else
{
    Console.WriteLine("The last name does not start with the same letter as the first name.");
}