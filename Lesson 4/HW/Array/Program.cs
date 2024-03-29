﻿// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции 

// void fillArray(int[] collection, int botLine, int upLine)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length){
//         collection[index] = new Random().Next(botLine, upLine);
//         index++;
//     }
// }

// void printArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count){
//         Console.Write($"{col[position]} ");
//         position++;
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int[] array = new int[int.Parse(Console.ReadLine()!)];

// Console.WriteLine("Введите нижнюю границу массива");
// int bot = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите верхнюю гранцу массива");
// int up = int.Parse(Console.ReadLine()!);

// fillArray(array, bot, up);
// printArray(array);

void fillDoubleArray(double[] collection, double botLine, double upLine)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().NextDouble() * (upLine - botLine) + botLine;
        index++;
    }
}

void printDoubleArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
double[] array = new double[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
double bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
double up = int.Parse(Console.ReadLine()!);

fillDoubleArray(array, bot, up);
printDoubleArray(array);