Console.Write("Choose the number of the day: ");
string dow = Console.ReadLine();
bool valid = true;

switch (dow)
{
    case "1": dow = "Monday"; break;
    case "2": dow = "Tuesday"; break;
    case "3": dow = "Wednesday"; break;
    case "4": dow = "Thursday"; break;
    case "5": dow = "Friday"; break;
    case "6": dow = "Saturday"; break;
    case "7": dow = "Sunday"; break;
    default: Console.WriteLine("Wrong symbols! Try to pick from 1 to 7!"); valid = false; break;
}

if (valid)
    Console.WriteLine($"It's {dow}!");