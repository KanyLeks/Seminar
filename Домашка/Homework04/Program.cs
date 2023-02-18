/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if(numberA > numberС)
    Console.Write(numberA);
    else 
    Console.Write(numberС);
}
else
{
    if(numberB > numberС)
    Console.Write(numberB);
    else 
    Console.Write(numberС);
}


