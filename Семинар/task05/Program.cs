// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольщую цифру числа

//78 -> 8

Console.Clear();

int num = new Random().Next(10, 100);
Console.WriteLine($"Число: {num}");

int firstValue = num / 10;
int secondValue = num % 10;

int max = firstValue;
if (secondValue > max)
{
    max = secondValue;
}

Console.WriteLine($"Максимальная цифра в числе: {max}");