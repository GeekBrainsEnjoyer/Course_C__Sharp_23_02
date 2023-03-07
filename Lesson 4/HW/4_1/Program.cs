// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

int expanentiation(int num, int exp)
{
    int n = 1;
    for (int i = 0; i < exp; i++)
    {
        n = n * num;
    }
    return n;
}

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите степень В");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int result = expanentiation(A, B);
Console.WriteLine(result);