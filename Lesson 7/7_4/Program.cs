// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

void findElement(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int count = 0;

    System.Console.WriteLine("Enter element");
    int element = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            if (element == array[i, j])
            {
                Console.Write($"[{i + 1}, {j + 1}]");
                count++;
            }
            if (count == 1) break;
        }
    if (count == 0) System.Console.WriteLine("not found");
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
findElement(matrix);
