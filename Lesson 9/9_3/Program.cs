// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumElements(int n)
{
    if (n == 0) return 0;

    return SumElements(n / 10) + n % 10;
}

int n = int.Parse(System.Console.ReadLine()!);
int sum = SumElements(n);
System.Console.WriteLine(sum);
