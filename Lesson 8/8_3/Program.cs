// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[,] fill2DArray(int rows, int columns, int to)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(to);

    return array;
}

int[] freaquency(int[,] array, int maxValue)
{
    int[] dict = new int[maxValue + 1];

    foreach (int element in array)
        dict[element] += 1;

    return dict;
}

string printFreaquancy(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != 0)
            res += $" Number {i} apear {array[i]} times\n";
        else
            res += String.Empty;

    return res;
}

System.Console.WriteLine("Enter rows and columns");
int row = int.Parse(Console.ReadLine()!);
int col = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter max values");
int to = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,] matrix = fill2DArray(row, col, to);
print2DArray(matrix);
System.Console.WriteLine();

int[] dictionar = freaquency(matrix, to);
string res = printFreaquancy(dictionar);
System.Console.WriteLine(res);