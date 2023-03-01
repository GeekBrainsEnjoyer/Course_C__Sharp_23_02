//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.

Console.WriteLine("Напишите номер дня недели");
int num1 = int.Parse(Console.ReadLine()!);

if(num1 == 1){
    Console.WriteLine("Mo");
}
else if(num1 == 2){
    Console.WriteLine("Tu");
}
else if(num1 == 3){
    Console.WriteLine("We");
}
else if(num1 == 4){
    Console.WriteLine("Th");
}
else if(num1 == 5){
    Console.WriteLine("Fr");
}
else if(num1 == 6){
    Console.WriteLine("Sa");
}
else if(num1 == 7){
    Console.WriteLine("Su");
}
else{
   Console.WriteLine("Нету дня недели такого номера");
}