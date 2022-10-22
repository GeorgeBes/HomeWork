// Задача 47. 
// 1. Задайте двумерный массив размером m×n, 
// 2. заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixRndDbl(int rows, int columns, int min, int max)
{
    var matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rndNum = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(rndNum, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");

        }
        Console.WriteLine();
    }
}


double[,] arr2D = CreateMatrixRndDbl(3, 4, -10, 10);
PrintMatrix(arr2D);


