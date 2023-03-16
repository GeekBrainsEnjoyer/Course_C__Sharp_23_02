// // Задача 2: Напишите программу, которая будет преобразовывать
// // десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string convertBin(int n)
{
    string result = "";
    for (int i = 0; n > 0; i++)
    {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

int num = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(convertBin(num));


// int[] createModArray(int n)
// {
//     int count = 0;
//     int[] modArray = new int[100];
//     for (int i = 0; n > 0; i++)
//     {
//     modArray[i] = n % 2;
//     n = n / 2;
//     count++;
//     }
//     Array.Resize(ref modArray, count);
//     return modArray;
// }

// void printArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count){
//         Console.Write($"{col[position]} ");
//         position++;
//     }
//     Console.WriteLine();
// }

// void turnArray(int[] mass)
// {
//     for (int i = 0; i < mass.Length / 2; i++)
//             (mass[i], mass[mass.Length - i - 1]) = (mass[mass.Length - i - 1], mass[i]);
    
// }

// System.Console.WriteLine("Enter number");
// int n = int.Parse(System.Console.ReadLine()!);
// int[] result = createModArray(n);
// System.Console.WriteLine();
// turnArray(result);
// printArray(result);
    




