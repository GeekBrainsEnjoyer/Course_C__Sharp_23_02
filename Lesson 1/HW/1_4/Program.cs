
//Задача 4: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все
//чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine()!);
 
int count = 2;
 Console.WriteLine("Четные числа до " + num1);
while(count <= num1){

    Console.WriteLine($"{count} ");
    count = count + 2;

}
