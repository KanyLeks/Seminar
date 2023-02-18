// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> да
//-4, 16 -> да
// 25, 5 -> да
//  8, 9 -> нет


Console.Clear();
Console.Write("Please enter first number, ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number, ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum * firstNum == secondNum || secondNum * secondNum == firstNum)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}