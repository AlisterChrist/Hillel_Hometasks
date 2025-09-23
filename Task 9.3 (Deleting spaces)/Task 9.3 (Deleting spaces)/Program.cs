// Вхідний рядок зі словами
string input = "Laptop, Smartphone, Tablet, Headphones, Monitor, Keyboard, Mouse, Printer";

Console.WriteLine("Origin string:");
Console.WriteLine(input);

// Видаляємо всі пробіли
string result = input.Replace(" ", "");

Console.WriteLine("\nString without spaces:");
Console.WriteLine(result);