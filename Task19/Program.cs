// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit > 10000 && digit < 100000)
{
    int firstDigit = digit / 10000;
    int secondDigit = digit / 1000 % 10;
    int fourthDigit = digit / 10 % 10;
    int fifthDigit = digit % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Число не пятизначное!!!");