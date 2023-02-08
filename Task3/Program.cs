// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];
int[,] array2 = new int[row, col];
int[,] totalArray = new int[row, col];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();

FillArrayRandom2(array2);
PrintArray2(array2);

Console.WriteLine();

if (array.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine("Ошибка!!! Нельзя перемножить!!! Читайте мат. часть не грамотные люди))) ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        totalArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            totalArray[i, j] += array[i, k] * array2[k, j];
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    {
        Console.WriteLine("Матрица 1:");
    }
}
void FillArrayRandom2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 10);
        }
    }
    {
        Console.WriteLine("Матрица 2:");
    }
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Произведение матриц: ");
PrintArray2(totalArray);
