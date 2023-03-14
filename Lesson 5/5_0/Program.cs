// Задача 1: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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

void sumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, Negative: {neg}");
}

Console.WriteLine("Введите размер массива");
int[] array = new int[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
int bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
int up = int.Parse(Console.ReadLine()!);
Console.WriteLine();

fillArray(array, bot, up);
printArray(array);
sumPosNeg(array);