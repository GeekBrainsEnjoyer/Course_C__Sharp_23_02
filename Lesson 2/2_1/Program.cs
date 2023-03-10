// 1. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

// int num = new Random().Next(100, 1000);

int takeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = takeNum(new Random().Next(100, 1000));

Console.WriteLine(result);

// Console.WriteLine(num);
// Console.WriteLine(num % 10);