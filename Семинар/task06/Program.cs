// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число: {num}");

int firstNum = num / 100;
int lastNum = num % 10;

int res = firstNum * 10 + lastNum;
Console.WriteLine(res);