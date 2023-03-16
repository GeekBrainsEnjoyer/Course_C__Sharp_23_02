// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[,] fillArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(from, to);
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,] copyArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int[,] newArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            newArray[i, j] = array[i, j];
    return newArray;
}


int[,] result = fillArray(5, 5, 1, 9);
printArray(result);
System.Console.WriteLine();
int[,] result2 = copyArray(result);
printArray(result2);