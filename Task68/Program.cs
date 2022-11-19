// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое число m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число n");
int numberN = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0) return AkkermanFunction(numM - 1, 1);
    else return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
}

int res = 0;
if (numberM < 0 || numberN < 0) Console.WriteLine("Числа отрицательны");
else
{
    res = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"A({numberM},{numberN}) = {res}");
}
