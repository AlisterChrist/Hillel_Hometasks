// Створюємо StringBuilder для збереження звіту
using System.Text;

StringBuilder report = new StringBuilder();

// Додаємо заголовок
report.AppendLine("-=-=- Event report -=-=-");

// Додаємо поточну дату
report.AppendLine("Date: " + DateTime.Now.ToString("dd.MM.yyyy"));
report.AppendLine(); // порожній рядок
report.AppendLine("List of events:");

// Цикл для введення подій
while (true)
{
    Console.Write("Enter the event (or type 'exit' to exit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (!string.IsNullOrWhiteSpace(input))
    {
        // Додаємо подію у список
        report.AppendLine("- " + input);
    }
}

// Виводимо сформований звіт
Console.WriteLine("\n=== Generated text report ===\n");
Console.WriteLine(report.ToString());