// Задача 50. Напишите программу, 
// 1. которая на вход принимает позиции элемента в двумерном массиве, 
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}



void SearchElement(int[,] matrix, int rows, int columns)
{
    if (rows > matrix.GetLength(0) || columns > matrix.GetLength(1)) Console.Write("-> Такого элемента в массиве нет");
    else Console.Write($"{rows + 1}, {columns + 1} -> {matrix[rows, columns]}");
}



int[,] arr2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(arr2D);

Console.WriteLine("Введите строку элемента: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int columns = Convert.ToInt32(Console.ReadLine());
SearchElement(arr2D, rows - 1, columns - 1);
