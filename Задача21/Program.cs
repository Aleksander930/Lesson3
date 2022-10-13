// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите a1 ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c1 ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите a2 ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c2 ");
int c2 = Convert.ToInt32(Console.ReadLine());

double Distance(int arga1, int argb1, int argc1, int arga2, int argb2, int argc2)
{
    double result = Math.Sqrt((Math.Pow(arga2 - arga1, 2)) + (Math.Pow(argb2 - argb1, 2)) + (Math.Pow(argc2 - argc1, 2)));
    return result;
}

double res = Distance(a1, b1, c1, a2, b2, c2);
Console.WriteLine(Math.Round(res, 2, MidpointRounding.ToZero));