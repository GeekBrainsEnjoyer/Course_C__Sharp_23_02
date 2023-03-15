// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int countPositivуNum()
{
    int count = 0;
    System.Console.WriteLine("Enter the numbers");
    for (int i = 0; i < 999; i++)
    {
        string number = Console.ReadLine()!;
        if(String.IsNullOrEmpty(number)) break;
        int num = int.Parse(number);
        if(num > 0) count++;
    }
    System.Console.WriteLine();
    return count;
}

int result = countPositivуNum();
System.Console.WriteLine(result);