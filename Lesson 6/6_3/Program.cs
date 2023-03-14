// Задача 3: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void giveFibonacci(int n)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i <= n - 1; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, b + a);
    }

}

System.Console.WriteLine("Enter the number");
int num = int.Parse(System.Console.ReadLine()!);
giveFibonacci(num);