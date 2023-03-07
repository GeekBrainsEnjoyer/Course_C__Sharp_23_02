// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int mutiplyNum(int num)
{
    int all_multi = 1;
    for (int i = 1; i <= num; i++)
        all_multi = all_multi * i;
    
    return all_multi;
}

int N = int.Parse(Console.ReadLine()!);
int result = mutiplyNum(N);
Console.WriteLine(result);

