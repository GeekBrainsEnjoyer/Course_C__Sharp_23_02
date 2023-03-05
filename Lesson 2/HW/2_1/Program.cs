// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);

void secondNumber(int num)
{
    if(num < 100 | num > 999)
    {
        Console.WriteLine("Число должно быть трехзначным");
    }
    else
    {
    int operation1 = num / 10;
    int operation2 = operation1 % 10;
    Console.WriteLine(operation2);
    }
}

secondNumber(num);