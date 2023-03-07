// /Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.

void massive(int mas)
{
    int[] nums = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        nums[i] = new Random().Next(2);
        Console.WriteLine(nums[i]);
    }
}

massive(int.Parse(Console.ReadLine()!));
