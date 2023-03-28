// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] findSumInRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] sumInRow = new int[rows];
    int sum = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum = sum + array[i, j];
            sumInRow[i] = sum;
        }
        sum = 0;
    }
    return sumInRow;
}

void printArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"Sum in row {position + 1} = {col[position]}");
        position++;
    }
    Console.WriteLine();
}

int numMinSumRow(int[] sumInRow)
{
    int numRow = 0;

    for (int i = 0; i < sumInRow.Length - 1; i++)
        for (int j = 1; j < sumInRow.Length - i; j++)
            if (sumInRow[j] < sumInRow[numRow])
                numRow = j;

    return (numRow + 1);
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
int[] sum = findSumInRow(matrix);
printArray(sum);
int num = numMinSumRow(sum);
System.Console.WriteLine($"Min value in row number {num}!");
