// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int num = new Random().Next(10000, 100000);
Console.WriteLine($"{num} -> Проверяемое число ");
int left = num;
int rev = 0;
while (Convert.ToBoolean(left))
{
    int r = left % 10;
    rev = rev * 10 + r;
    left = left / 10;
}
if (rev == num)
{
    Console.WriteLine($"{num} -> Является палиндромом");
}
else
{
    Console.WriteLine($"{num} -> Не является палиндромом");
}




// int num1 = reverse(num);
// Console.WriteLine(num1);
// if (num1 == num)
// {
//     Console.WriteLine("Палиндром");
// }
// else 
// {
//     Console.WriteLine("Не палиндром");
// }
//reverseDigits


// int n = 12345;
// int left = n;
// int rev = 0;
// while(Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
// {
//    int r = left % 10;
//    rev = rev * 10 + r;
//    left = left / 10;  //left = Math.floor(left / 10);
// }
// Console.WriteLine(rev);