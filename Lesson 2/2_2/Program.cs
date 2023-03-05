// 2. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int findMax(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num % 10;
    int max = num1;

    if(num2 > max)
    {
        max = num2;
    }
    return max;
}

int result = findMax(new Random().Next(1, 99));

Console.WriteLine(result);
