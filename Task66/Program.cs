// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num2 + SumNumbers(num1, num2 - 1);
}

int res = 0;
if (numberM < numberN) res = SumNumbers(numberM, numberN);
else res = SumNumbers(numberN, numberM);
Console.WriteLine($"-> {res}");