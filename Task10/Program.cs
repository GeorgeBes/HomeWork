// Задача 10: Напишите программу, 
// 1. которая принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите Трёхзначное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb >= 100 && numb <= 1000)
{
    int result = (numb / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {numb} это {result}");

}
else Console.WriteLine($"Число {numb} не трёхзнычное");
