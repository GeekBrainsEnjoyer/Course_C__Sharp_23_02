// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void fillArray(int[] collection, int botLine, int upLine)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(botLine, upLine);
        index++;
    }
}

void printArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

int sumOddElements(int[] mass)
{
    int sum = mass[0];
    for (int i = 2; i < mass.Length; i += 2)
        sum = sum + mass[i];
    return sum;
}

Console.WriteLine("Введите размер массива");
int[] array = new int[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
int bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
int up = int.Parse(Console.ReadLine()!);

fillArray(array, bot, up);
printArray(array);
Console.WriteLine();
int result = sumOddElements(array);
Console.WriteLine(result);