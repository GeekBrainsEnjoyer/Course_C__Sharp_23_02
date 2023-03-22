// Задача 1: Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

int[,] fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
           array[i, j] = i+j;
    
    return array;
}

System.Console.WriteLine("Enter rows and columns");
int ro = int.Parse(Console.ReadLine()!);
int cl = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Enter values from-to");
// int fr = int.Parse(Console.ReadLine()!);
// int to = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix = fill2DArray(ro, cl);
print2DArray(matrix);
System.Console.WriteLine();
