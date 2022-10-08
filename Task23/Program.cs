// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N: ");
int digit = Convert.ToInt32(Console.ReadLine());

void QubeDigit(int number)
{
    int index =1;
    Console.WriteLine($"Таблица кубов числа {number}");
    while (index<=number)
    {
        Console.WriteLine($"|{index,4} |{Math.Pow(index,3),4} |");
        index++;
    }
}
QubeDigit(digit);