// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число и мы узнаем сумму цифр в числе: ");
int digit = Convert.ToInt32(Console.ReadLine());
Sum(digit);

void Sum(int sum)
{
    int res = default;
    int num = default;
    while (sum > 0) 
    {
        num = sum % 10; // 0
        sum /= 10; // 9
        res += num; //3
    }
    Console.WriteLine($"{sum}->{res}");
}    


