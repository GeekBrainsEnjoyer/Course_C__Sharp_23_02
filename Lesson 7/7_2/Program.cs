// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

int[,] squareEvenPositionsElements(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] newArr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                newArr[i, j] = array[i, j] * array[i, j];
            else newArr[i, j] = array[i, j];
        }

    return newArr;
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
int[,] matrix2 = squareEvenPositionsElements(matrix);
print2DArray(matrix2);
System.Console.WriteLine();
