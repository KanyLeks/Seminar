// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
int firstNum = new Random().Next(100, 1000);
Console.WriteLine(firstNum);

int secondNum = firstNum / 10;
int thirdNum = secondNum % 10;
Console.WriteLine(thirdNum);


