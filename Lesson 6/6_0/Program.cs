// Задача 1: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] turnArray(int[] mass)
{
    int length = mass.Length;
    int[] newMass = new int[length];
    for (int i = 0; i < mass.Length; i++)
        if(length % 2 == 0)
            newMass[i] = mass[length - i - 1];
        else
        {
            newMass[i] = mass[length - i - 1];
            newMass[length / 2] = mass[i / 2];
        }
    return newMass;

}

Console.WriteLine("Введите размер массива");
int[] array = new int[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
int bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
int up = int.Parse(Console.ReadLine()!);

fillArray(array, bot, up);
printArray(array);
System.Console.WriteLine();
int[] result = turnArray(array);
printArray(result);