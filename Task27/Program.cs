// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число и мы узнаем сумму цифр в числе: ");
int digit = Convert.ToInt32(Console.ReadLine());

int Sum(int sum)
{
    int res = default;
    int num = default;
    while (num > 0)
    {
        int num = sum % 10;
        sum = sum / 10;
        res = res + num;
    }
    return res;
}
int result = Console.WriteLine(Sum);
