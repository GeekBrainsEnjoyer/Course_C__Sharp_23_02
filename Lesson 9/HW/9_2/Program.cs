// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumFromMToN(int M, int N)
{

    if (N == M - 1) return 0;

    return SumNumFromMToN(M, N - 1) + N;
}

System.Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
int sum = SumNumFromMToN(M, N);
System.Console.WriteLine(sum);