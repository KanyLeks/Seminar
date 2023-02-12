/*Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
a = 5, b = 7-> max = 7
a = 2, b = 10-> max = 10
a = -9, b = -3-> max = -3*/

Console.Clear();
Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB) 
{
    Console.Write(numberB);
    Console.WriteLine(" MAX"); 
    Console.Write(numberA);
    Console.WriteLine(" MIN");  
}
else
{
    Console.Write(numberA);
    Console.WriteLine(" MAX"); 
    Console.Write(numberB);
    Console.WriteLine(" MIN"); 
}