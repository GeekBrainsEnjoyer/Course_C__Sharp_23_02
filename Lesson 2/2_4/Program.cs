// 4. Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

void div(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("da");
    }
    else
    {
        Console.WriteLine("net");
    }
}

div(num);