// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива

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

int[,] swapFirstWithLastStrings(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            (array[0, j], array[rows - 1, j]) = (array[rows - 1, j], array[0, j]);

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
int[,] newArray = swapFirstWithLastStrings(matrix);
print2DArray(newArray);