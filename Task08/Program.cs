// Задача 8: Напишите программу, 
// 1. которая на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число, и я покажу все чётные числа до этого числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
Console.WriteLine("Все числа");

if (n>=res)
{
    res++;
    while (res<n)
    {
        Console.Write($"{res}  ");
        res = res + 2;
    }
}



// while (n>=1)
// {

// }


// if (n>=1)
// {
//     res +=1;
// }
// while (res <= n)
//     Console.Write($"Все числа {res}");
//     res +=2;
