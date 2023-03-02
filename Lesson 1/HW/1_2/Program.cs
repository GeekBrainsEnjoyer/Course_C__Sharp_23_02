//Задача 2: Напишите программу, которая принимает
//на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Напишите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите второе число");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите третье число");
int num3 = int.Parse(Console.ReadLine()!);


if(num1 > num2 && num1 > num3){

    int max = num1;
    Console.WriteLine(max);
}
else if(num2 > num1 && num2 > num3){
    int max = num2;
    Console.WriteLine(max);
}
else{
   int max = num3;
   Console.WriteLine(max);
}
