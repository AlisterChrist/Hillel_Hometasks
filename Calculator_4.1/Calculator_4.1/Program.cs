using System;

double num1, num2, result = 0;
char op;
bool valid = true;

Console.WriteLine("Enter first number:");
if (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Invalid number input!");
    return;
}

Console.WriteLine("Enter operator (+, -, *, /):");
if (!char.TryParse(Console.ReadLine(), out op))
{
    Console.WriteLine("Invalid operator input!");
    return;
}

Console.WriteLine("Enter second number:");
if (!double.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Invalid number input!");
    return;
}

switch (op)
{
    case '+': result = num1 + num2; break;
    case '-': result = num1 - num2; break;
    case '*': result = num1 * num2; break;
    case '/':
        if (num2 != 0) result = num1 / num2;
        else { Console.WriteLine("Error: Cannot be divided by zero."); valid = false; }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        valid = false;
        break;
}

if (valid)
    Console.WriteLine($"{num1} {op} {num2} = {result}");