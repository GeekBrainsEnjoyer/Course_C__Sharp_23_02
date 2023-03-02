//Задача 1: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число
//большее, а какое меньшее.

Console.WriteLine("Напишите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите второе число");
int num2 = int.Parse(Console.ReadLine()!);


if(num1 > num2){
    int max = num1;
    Console.Write("max = ");
    Console.Write(max);
}
else if(num1 < num2){
    int max = num2;
    Console.Write("max = ");
    Console.Write(max);
}
else{
    Console.WriteLine("Числа равны");
}