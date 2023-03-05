// 3. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);

void multiple(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        int a = num1 % num2;
        Console.WriteLine("не кратно, остаток " + a);
    }
}

multiple(number1, number2);