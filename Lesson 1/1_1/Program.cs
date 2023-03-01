//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.

Console.WriteLine("Введите квадрат числа");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число");
int num2 = int.Parse(Console.ReadLine()!);

if(num2*num2 == num1){

    Console.WriteLine("yes");
}
else{

    Console.WriteLine("no");

}