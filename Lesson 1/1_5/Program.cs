//5. Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = -num1;

while(num2 <= num1) {
    Console.Write($"{num2} ");
    num2++;
}
