// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void MidlArifm(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double count = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            count = count + matrix[i, j];
        }
        count = count / matrix.GetLength(0);
        if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(count, 1)}; ");
        else Console.Write($"{Math.Round(count, 1)}. ");
    }
}

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] arr2D = CreateMatrixRndInt(3, 8, 1, 5);
PrintMatrix(arr2D);
MidlArifm(arr2D);
