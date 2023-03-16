// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

void existsTriangle(int a, int b, int c)
{

    if(a < b + c && b < a + c && c < a + b)
        System.Console.WriteLine("yes");
    else
        System.Console.WriteLine("no");
}

System.Console.WriteLine("enter 'a'");
int a = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("enter 'b'");
int b = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("enter 'c'");
int c = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine();
existsTriangle(a, b, c);