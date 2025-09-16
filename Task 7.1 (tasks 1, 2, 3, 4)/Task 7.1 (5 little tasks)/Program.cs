#region Task 1 and 2
//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random 
//Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)

//2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.

// Створюємо масив із 10 елементів
int[] arr = new int[10];
Random rnd = new Random();

// Заповнюємо масив випадковими числами від -10 до 10
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 11); // верхня межа не включається, тому 11
}

Console.WriteLine("All elements of the array:");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine("\n\nElements with even indices:");
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0) // парний індекс
    {
        Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
}

// Підрахунок суми
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

Console.WriteLine($"\n\nSum of array elements = {sum}");

// Перевірка знаку суми
if (sum > 0)
    Console.WriteLine("The sum is positive.");
else if (sum < 0)
    Console.WriteLine("The sum is negative.");
else
    Console.WriteLine("The sum is zero.");

#endregion

#region Task 3
//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1,
//у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

// Створюємо двовимірний масив 9x9
int[,] table = new int[9, 9];

// Заповнюємо таблицю множення
for (int i = 0; i < 9; i++)         // рядки (множники 1..9)
{
    for (int j = 0; j < 9; j++)     // стовпці (множники 1..9)
    {
        table[i, j] = (i + 1) * (j + 1);
    }
}

// Виводимо таблицю на екран
Console.WriteLine("\nMultiplication table 9x9:\n");
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(table[i, j].ToString().PadLeft(3) + " ");
    }
    Console.WriteLine();
}

#endregion

#region Task 4
//4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран:
//а) максимальний елемент масиву; б) мінімальний елемент масиву;
//в) координати мінімального елемента масиву. г) координати максимального елемента масиву.

// Створюємо двовимірний масив 5x5
int[,] arr2 = new int[5, 5];
Random rnd2 = new Random();

// Заповнюємо масив випадковими числами від -50 до 50
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr2[i, j] = rnd.Next(-50, 51);
    }
}

// Виводимо масив
Console.WriteLine("\n5x5 array:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr2[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

// Змінні для пошуку мінімуму і максимуму
int min = arr2[0, 0], max = arr2[0, 0];
int minRow = 0, minCol = 0;
int maxRow = 0, maxCol = 0;

// Пошук мінімального і максимального елементів
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arr2[i, j] < min)
        {
            min = arr2[i, j];
            minRow = i;
            minCol = j;
        }

        if (arr2[i, j] > max)
        {
            max = arr2[i, j];
            maxRow = i;
            maxCol = j;
        }
    }
}

// Вивід результатів
Console.WriteLine($"\nMaximum element: {max} (coordinates: [{maxRow},{maxCol}])");
Console.WriteLine($"Minimum element: {min} (coordinates: [{minRow},{minCol}])");

#endregion