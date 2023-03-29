// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Square(int A, int B)
{

    if (B == 0) return 1;
    B--;

    return Square(A, B) * A;
}

int A = int.Parse(System.Console.ReadLine()!);
int B = int.Parse(System.Console.ReadLine()!);
int sq = Square(A, B);
System.Console.WriteLine(sq);
