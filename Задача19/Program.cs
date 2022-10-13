// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


bool number(int n)
{
    return (n % 10 == n / 10000) && ((n % 100) / 10 == (n / 1000) % 10);
}

bool num = number(n);
if (num)
{
    Console.WriteLine($"{n} да");
}
else Console.WriteLine($"{n} нет");
