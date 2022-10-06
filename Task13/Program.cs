// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число и мы узнаем его третью цифру: ");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit > 99)
{
    while (digit > 999)
    {
        digit = digit / 10;
    }
    int result = digit % 10;
    Console.WriteLine($"Третья цифра это {result}");
}
else Console.WriteLine($"В числе {digit} нет третьей цифры!");
