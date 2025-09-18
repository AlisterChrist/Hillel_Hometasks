using System;

char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // ігрове поле
char currentPlayer = 'X'; // X ходить перший

int moves = 0;
bool gameOver = false;

while (!gameOver)
{
    Console.Clear();
    DisplayBoard();
    Console.WriteLine($"\nPlayer's move {currentPlayer}. Choose a cell (1-9):");

    string input = Console.ReadLine();
    if (int.TryParse(input, out int cell) && cell >= 1 && cell <= 9)
    {
        if (board[cell - 1] != 'X' && board[cell - 1] != 'O')
        {
            board[cell - 1] = currentPlayer;
            moves++;

            if (CheckWin())
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine($"\nPlayer {currentPlayer} won!");
                gameOver = true;
            }
            else if (moves == 9)
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine("\nDraw!");
                gameOver = true;
            }
            else
            {
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; // зміна гравця
            }
        }
        else
        {
            Console.WriteLine("This cell is already taken. Press Enter to continue...");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Press Enter to continue...");
        Console.ReadLine();
    }
}

// Функція відображення поля
void DisplayBoard()
{
    Console.WriteLine("-------------");
    for (int i = 0; i < 9; i += 3)
    {
        Console.WriteLine($"| {board[i]} | {board[i + 1]} | {board[i + 2]} |");
        Console.WriteLine("-------------");
    }
}

// Функція перевірки на перемогу
bool CheckWin()
{
    int[,] winConditions = new int[,]
    {
            {0,1,2}, {3,4,5}, {6,7,8}, // рядки
            {0,3,6}, {1,4,7}, {2,5,8}, // стовпці
            {0,4,8}, {2,4,6}           // діагоналі
    };

    for (int i = 0; i < winConditions.GetLength(0); i++)
    {
        if (board[winConditions[i, 0]] == currentPlayer &&
            board[winConditions[i, 1]] == currentPlayer &&
            board[winConditions[i, 2]] == currentPlayer)
        {
            return true;
        }
    }
    return false;
}
