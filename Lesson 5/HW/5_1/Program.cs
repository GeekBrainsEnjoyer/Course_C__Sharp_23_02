// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int findEvenNum(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if(mass[i] % 2 == 0)
            count++;
    }
    return count;
    
}
Console.WriteLine("Введите размер массива");
int[] array = new int[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
int bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
int up = int.Parse(Console.ReadLine()!);

fillArray(array, bot, up);
printArray(array);
int result = findEvenNum(array);
Console.WriteLine(result);
