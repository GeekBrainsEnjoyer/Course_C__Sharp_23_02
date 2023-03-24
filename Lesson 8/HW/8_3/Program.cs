// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

bool checkDemension(int[,] matrix1, int[,] matrix2)
{
    int columnsInFirst = matrix1.GetLength(1);
    int rowsInSecond = matrix2.GetLength(0);

    bool result = columnsInFirst == rowsInSecond;
    return result;
}

string multiplyingMatrices(bool check, int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);

    int[,] multiMatrix = new int[rows1, columns2];

    if (!check) return "Колличество столбцов первой матрицы должно ровняться колличеству строк второй!";

    for (int i = 0; i < rows1; i++)
    {
        multiMatrix[i, 0] = 0;
        for (int j = 0; j < columns1; j++)
            for (int m = 0; m < columns2; m++)
                multiMatrix[i, m] = multiMatrix[i, m] + matrix1[i, j] * matrix2[j, m];
    }
    System.Console.WriteLine("Результат умноженияж: ");
    System.Console.WriteLine();
    print2DArray(multiMatrix);
    return "";



}
System.Console.WriteLine("Enter rows and columns in the first matrix");
int row1 = int.Parse(Console.ReadLine()!);
int col1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter values from-to");
int from1 = int.Parse(Console.ReadLine()!);
int to1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix1 = fill2DArray(row1, col1, from1, to1);
print2DArray(matrix1);
System.Console.WriteLine();

System.Console.WriteLine("Enter rows and columns in the second matrix");
int row2 = int.Parse(Console.ReadLine()!);
int col2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter values from-to");
int from2 = int.Parse(Console.ReadLine()!);
int to2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix2 = fill2DArray(row2, col2, from2, to2);
print2DArray(matrix2);
System.Console.WriteLine();

bool check = checkDemension(matrix1, matrix2);
string multiMatrix = multiplyingMatrices(check, matrix1, matrix2);
System.Console.WriteLine(multiMatrix);
System.Console.WriteLine();