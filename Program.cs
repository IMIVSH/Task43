/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
Значения b1, k1, b2 и k2 задаются пользователем.*/

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int FindX(int k1, int k2, int b1, int b2)
{
    int result = (b2-b1)/(k1-k2);
    return result;
}

int FindY(int k1, int x, int b1)
{
    int result = k1*x+b1;
    return result;
}

int k1 = GetUserData("Введите k1");
int k2 = GetUserData("Введите k2");
int b1 = GetUserData("Введите b1");
int b2 = GetUserData("Введите b2");
int x = FindX(k1, k2, b1, b2);
int y = FindY(k1, x, b1);
Console.WriteLine($"Точка пересечения прямых с данными координатами ({x}, {y}).");