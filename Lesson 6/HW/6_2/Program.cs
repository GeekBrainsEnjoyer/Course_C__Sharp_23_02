// Задача 2. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

void findCrossPoint(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 == b2)
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if(k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    System.Console.WriteLine($"({x}; {y})");
    }
    
}

System.Console.WriteLine("Введите параметры");
int b1 = int.Parse(System.Console.ReadLine()!);
int k1 = int.Parse(System.Console.ReadLine()!);
int b2 = int.Parse(System.Console.ReadLine()!);
int k2 = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine();
findCrossPoint(b1, k1, b2, k2);