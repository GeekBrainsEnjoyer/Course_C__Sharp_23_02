// 1. На вводе четверть -> диапозон значений

void quarters(int qua)
{
    if(qua == 1)
        Console.WriteLine("x > 0 && y > 0");
    else if(qua == 2)
        Console.WriteLine("x < 0 && y > 0");
    else if(qua == 3)
        Console.WriteLine("x < 0 && y < 0");
    else if(qua == 4)
        Console.WriteLine("x > 0 && y < 0");
    else
        Console.WriteLine("error 404");
}

int num1 = int.Parse(Console.ReadLine()!);

quarters(num1);

