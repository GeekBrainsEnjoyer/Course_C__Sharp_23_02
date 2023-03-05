// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int num = int.Parse(Console.ReadLine()!);

void holidays(int num)
{
    if(num < 1 | num > 7)
    {
        Console.WriteLine("нет такого дня недели");
    }
    else if( num == 6 | num ==7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

holidays(num);