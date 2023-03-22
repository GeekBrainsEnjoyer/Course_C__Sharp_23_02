// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int sumElementsOnMainDiagonal(int[,] mass)
{
    int sum = 0;
    int rows = mass.GetLength(0);
    int columns = mass.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            if(i == j) sum = sum + mass[i, j];

    return sum;
}

System.Console.WriteLine("Enter rows and columns");
int ro = int.Parse(Console.ReadLine()!);
int cl = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter values from-to");
int fr = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix = fill2DArray(ro, cl, fr, to);
print2DArray(matrix);
System.Console.WriteLine();
int sum = sumElementsOnMainDiagonal(matrix);
System.Console.WriteLine(sum);
