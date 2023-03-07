// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int sumInNum(int num)
{
    int mod = 0;
    for (int i = 0; num > 0; i++)
    {
        mod = mod + num % 10;
        num = num / 10;
    }
    return mod;
}

Console.WriteLine("Введите число");
int result = sumInNum(int.Parse(Console.ReadLine()!));
Console.WriteLine(result);