// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели и мы узнаем выходной это или нет: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.WriteLine("Будний день");
else if (day == 2) Console.WriteLine("Будний день");
else if (day == 3) Console.WriteLine("Будний день");
else if (day == 4) Console.WriteLine("Будний день");
else if (day == 5) Console.WriteLine("Будний день");
else if (day == 6) Console.WriteLine("Выходной");
else if (day == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Под такой цифрой дня недели не бывает!");