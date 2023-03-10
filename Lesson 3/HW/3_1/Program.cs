// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void checkPalindrom(int num)
{
    if(num < 10000 || num > 100000) 
    {
        Console.WriteLine("Число должно быть пятизначным");
        return;
    }
    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    int fourthNum = num / 10 % 10;
    int fifthNum = num % 10;
    if(firstNum == fifthNum)
    {
        if(secondNum == fourthNum)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет");
    }
}
Console.WriteLine("Введите число");
checkPalindrom(int.Parse(Console.ReadLine()!));