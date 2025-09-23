#region Task "Finding the second largest element of an array" (Знаходження другого найбільшого елемента масиву)

int[] arr = { 10, 25, 3, 47, 15, 47, 6 };

int max = int.MinValue;
int secondMax = int.MinValue;

foreach (int num in arr)
{
    if (num > max)
    {
        secondMax = max;
        max = num;
    }
    else if (num > secondMax && num < max)
    {
        secondMax = num;
    }
}

Console.WriteLine("The second largest element: " + secondMax);

#endregion

#region Task "Sorting elements of a two-dimensional array in ascending order" (Сортування за зростанням елементів двовимірного масиву)

int[,] matrix = { { 51, 27, 33 }, { 5, 79, 34 }, { 55, 19, 80 } };

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

// Перетворюємо у масив
int[] temp = new int[rows * cols];
int index = 0;
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        temp[index++] = matrix[i, j];

// Сортуємо
Array.Sort(temp);

// Записуємо назад
index = 0;
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        matrix[i, j] = temp[index++];

Console.WriteLine("\nSorted array:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
}

#endregion

#region Task "Removing an element from an array by index" (Видалення елемента з масиву за індексом)

int[] array = { 10, 20, 30, 40, 50 };
int indexToRemove = 2; // Видалимо елемент з індексом 2 (тобто "30")

int[] newArr = new int[arr.Length - 1];

for (int i = 0, j = 0; i < arr.Length; i++)
{
    if (i == indexToRemove) continue;
    newArr[j++] = arr[i];
}

Console.WriteLine("\nArray after deletion:");
foreach (int num in newArr)
    Console.Write(num + " ");

#endregion

#region Task "Sum of diagonal elements in a two-dimensional array" (Сума елементів по діагоналі у двовимірному масиві)

int[,] matrix2 =
        {
            { 14, 46, 61 },
            { 32, 55, 2 },
            { 77, 90, 11 }
        };

int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);

int mainDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int i = 0; i < rows2; i++)
{
    mainDiagonalSum += matrix2[i, i]; // головна діагональ
    secondaryDiagonalSum += matrix2[i, cols2 - i - 1]; // побічна діагональ
}

Console.WriteLine("\n\nSum of the main diagonal: " + mainDiagonalSum);
Console.WriteLine("Sum of the side diagonal: " + secondaryDiagonalSum);

#endregion