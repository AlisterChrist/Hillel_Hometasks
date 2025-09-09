bool isLenghtCorrect = false;
bool isContainsNumber = false;
bool isContainsSpecial = false;

do
{
    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();

    if (password.Length >= 8)
    { 
        isLenghtCorrect = true;
    }

    for (int i = 0; i < password.Length; i++)
    {
        if (password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' ||
            password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9' || password[i] == '0')
        {
            isContainsNumber = true;
            break;
        }
        
        isContainsNumber = false;
    }

    for (int i = 0; i < password.Length; i++)
    {
        if (password[i] == '!' || password[i] == '@' || password[i] == '#' || password[i] == '$' || password[i] == '%' ||
            password[i] == '^' || password[i] == '&' || password[i] == '*' || password[i] == '?')
        {
            isContainsSpecial = true;
            break;
        }
        
        isContainsSpecial = false;
    }

    Console.WriteLine(!(isLenghtCorrect && isContainsNumber && isContainsSpecial) ? "Password is Invalid!\nEnter any key to try again!" : "Password created! Well done!");
    Console.ReadKey();
    Console.Clear();

} while (!(isLenghtCorrect && isContainsNumber && isContainsSpecial));
