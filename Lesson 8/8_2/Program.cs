// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

bool checkSquareMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    bool result = rows == columns;
    return result;
}

string transposition(bool square, int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    if (!square) return "no";

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < i; j++)
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);

    print2DArray(array);
    return "";
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
bool check = checkSquareMatrix(matrix);
string transMatrix = transposition(check, matrix);
System.Console.WriteLine(transMatrix);
System.Console.WriteLine();