// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.


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

int[] fintIndexMinElement(int[,] array)
{
    int[] indixes = new int[2];
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int min = array[0, 0];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                indixes[0] = i;
                indixes[1] = j;
            }

    return indixes;
}

void printIndexes(int[] col)
{
    int count = col.Length;
    int position = 0;
    System.Console.Write("Minimum element indeces is ");
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

void printChengedArray(int[,] array, int[] removedIndexes)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int removedRow = removedIndexes[0];
    int removedColumn = removedIndexes[1];

    for (int i = 0; i < rows; i++)
    {
        if (i != removedRow)
            for (int j = 0; j < columns; j++)
                if (j != removedColumn)
                    System.Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
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

int[] indexes = fintIndexMinElement(matrix);
printIndexes(indexes);
System.Console.WriteLine();
printChengedArray(matrix, indexes);