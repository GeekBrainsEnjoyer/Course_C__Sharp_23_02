// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 


void print2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            System.Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,] fill2DArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(from, to);

    return array;
}

int[,] minMaxMass(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns - 1; j++)
            for (int k = 1; k < columns - j; k++)
                if (array[i, k - 1] < array[i, k])
                {
                    int min = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = min;
                }

    return array;
}

System.Console.WriteLine("Enter rows and columns");
int row = int.Parse(Console.ReadLine()!);
int col = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter values from-to");
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix = fill2DArray(row, col, from, to);
print2DArray(matrix);
System.Console.WriteLine();
int[,] res = minMaxMass(matrix);
print2DArray(res);
System.Console.WriteLine();