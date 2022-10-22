// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите сколько чисел будете вводить:");
int quantityDigit = Convert.ToInt32(Console.ReadLine());



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число и нажмите Enter: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumNumbbers(int[] array)
{
    int count=default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    
}

int[] createArr= CreateArray(quantityDigit);
PrintArray(createArr);
int sumNumbers= SumNumbbers(createArr);
Console.Write($" -> {sumNumbers}");

