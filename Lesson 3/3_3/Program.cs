// 3. Таблица квадратов от 1 до N

void sqaureTab(int num)
{
    for (int i = 1; i < num; i++)
    {
        Console.WriteLine(Math.Pow(i,2));
    }
}
sqaureTab(int.Parse(Console.ReadLine()!));