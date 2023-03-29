// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void SeriesNumFromTo(int M, int N)
{
    if (N == M - 1) return;
    SeriesNumFromTo(M, N - 1);
    if (N % 2 == 0)
        System.Console.Write($"{N} ");

}
System.Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
SeriesNumFromTo(M, N);