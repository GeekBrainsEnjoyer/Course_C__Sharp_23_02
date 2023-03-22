// // Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string showElementValue(int[,] array, int userRow, int userColumn)
{
    int arrRows = array.GetLength(0);
    int arrColumns = array.GetLength(1);

    if (userRow <= arrRows && userColumn <= arrColumns)
        return ($"{array[userRow - 1, userColumn - 1]}");
    else return ("такого числа в массиве нет");
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

System.Console.WriteLine("Enter row number");
int rowI = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter column number");
int colJ = int.Parse(Console.ReadLine()!);
string result = showElementValue(matrix, rowI, colJ);
System.Console.WriteLine();
System.Console.WriteLine($"Value is {result}");
