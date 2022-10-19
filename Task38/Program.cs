// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size, int min, int max) // Метод для создания массива double
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
    }
    return array;
}

void PrintArray(double[] array) // Метод печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}

double SearchMax(double[] arrMax) // Поиск максимального
{
    double max = arrMax[0];
    for (int i = 1; i < arrMax.Length; i++)
    {
        if (arrMax[i] > max) max = arrMax[i];
    }
    return max;
}

double SearchMin(double[] arrMin)
{
    double min = arrMin[0];
    for (int i = 1; i < arrMin.Length; i++)
    {
        if (arrMin[i] < min) min = arrMin[i];
    }
    return min;
}


double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArray(arr);

// Console.WriteLine();
double max = SearchMax(arr);
// Console.WriteLine($"Max {Math.Round(max, 2)}");

double min = SearchMin(arr);
// Console.WriteLine($"Min {Math.Round(min, 2)}");

Console.Write($"-> {Math.Round(max - min, 2)}");