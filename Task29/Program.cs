// Задача 29: Напишите программу, 
//1.которая задаёт массив из 8 элементов и 
//2.выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] myArr = FillArray(8);
PrintArray(myArr);