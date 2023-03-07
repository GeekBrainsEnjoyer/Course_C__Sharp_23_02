// // Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int findCountNum(int num)
{
    int count = 1;
    while(num > 9)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int A = int.Parse(Console.ReadLine()!);
int result = findCountNum(A);
Console.WriteLine(result);