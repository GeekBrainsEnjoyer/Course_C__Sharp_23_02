// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

void thirdNum(int num)
{
    if(num < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if(num > 999)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        Console.WriteLine(num % 10);
    }
    else
    {
        Console.WriteLine(num % 10);
    }
}
thirdNum(num);
