// Напишите программу, которая принимает на вход координаты точки (X, Y), 
// причем X не равен 0, Y не равен 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Enter X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y:");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("1 quarter");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2 quarter");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3 quarter");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4 quarter");
}
else 
Console.WriteLine("Quarter undefined");