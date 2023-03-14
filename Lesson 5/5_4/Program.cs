// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] multElements(int[] mass)
{
    int size = mass.Length;
    int[] newMass = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2 + 1; i++)
        if(size % 2 == 0)
            newMass[i] = mass[i] * mass[size - 1 - i];
        else
        {
            newMass[i] = mass[i] * mass[size - 1 - i];
            newMass[size / 2] = mass[i];
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
Console.WriteLine();
int[] result = multElements(array);
printArray(result);
