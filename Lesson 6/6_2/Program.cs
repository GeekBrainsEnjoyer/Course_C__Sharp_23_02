// // Задача 2: Напишите программу, которая будет преобразовывать
// // десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] createModArray(int n)
{
    int count = 0;
    int[] modArray = new int[100];
    for (int i = 0; n > 0; i++)
    {
    modArray[i] = n % 2;
    n = n / 2;
    count++;
    }
    Array.Resize(ref modArray, count);
    return modArray;
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
System.Console.WriteLine("Enter number");
int n = int.Parse(System.Console.ReadLine()!);
int[] result = createModArray(n);
int[] result2 = turnArray(result);
printArray(result2);
    




