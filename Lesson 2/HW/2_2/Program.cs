// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

int num = new Random().Next(100, 999);
Console.WriteLine(num);

void del(int num)
{
    int oper1 = num / 100;
    int oper2 = num % 10;
    Console.WriteLine($"{oper1}{oper2}");
}

del(num);