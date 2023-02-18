// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int num = new Random().Next(1, 99999);
Console.WriteLine(num);
if (num < 100)
{
    Console.WriteLine("Third digit is missing");
}
else if (99 < num && num < 10000)
{
    int num1 = (num / 10);
    int num2 = (num1 % 10);
    Console.WriteLine(num2);
}
else if (10000 < num && num < 100000)
{
    int num3 = (num / 100);
    int num4 = (num3 % 10);
    Console.WriteLine(num4);
}





//num++;
// if //(99 < num && num < 10000);
// {
//     //int num1 = (num / 10);
//     //Console.WriteLine(num1);
//     int num1 = (num % 10);
//     Console.WriteLine(num1);
// }
// else 
// {
//     int num3 = (num / 100);
//     int num4 = (num3 % 10);
//     Console.WriteLine(num4);

// }
// //if (num < 100)
// {
//     //Console.WriteLine("Third digit is missing");
// }
//int num2 = (num1 % 100);

// int num3 = (num / 10);
// int num4 = (num3 % 10 );
//Console.WriteLine(num4);

// int num5 = (num / 100);
// int num6 = (num5 % 10 );
// int res = (num5 * 10 + num6);
// Console.WriteLine(res);
//int num3 = (num1 * 10 + num2);
//Console.WriteLine(num3);
