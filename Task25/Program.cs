// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int digitA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int digitB = Convert.ToInt32(Console.ReadLine());

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;

    }
    Console.WriteLine($"{a}, {b} -> {result}");

}

Degree(digitA, digitB);

