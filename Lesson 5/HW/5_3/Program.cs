// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void fillArray(double[] collection, double botLine, double upLine)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().NextDouble() * (upLine - botLine) + botLine;
        index++;
    }
}

void printArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

double difMinMax(double[] mass)
{
    double min, max;
    min = max = mass[0];
    double dif = 0;
    for (int i = 1; i < mass.Length; i++)
    {
        if(mass[i] > max)
            max = mass[i];
        else if(mass[i] < min)
            min = mass[i];
        dif = max - min;
    }
    return dif;
}

Console.WriteLine("Введите размер массива");
double[] array = new double[int.Parse(Console.ReadLine()!)];

Console.WriteLine("Введите нижнюю границу массива");
double bot = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю гранцу массива");
double up = int.Parse(Console.ReadLine()!);

fillArray(array, bot, up);
printArray(array);
Console.WriteLine();
double result = difMinMax(array);
Console.WriteLine(result);