// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();

Console.WriteLine("Enter Number Quarter:");

int num = int.Parse(Console.ReadLine());

if (num ==1)
{
    Console.WriteLine("(X > 0 , Y > 0)");
}

if (num ==2)
{
Console.WriteLine("(X < 0 , Y > 0)");
}
if (num ==3)
{
Console.WriteLine("(X < 0 , Y < 0)");
}

if (num ==4)
{
Console.WriteLine("(X > 0 , Y < 0)");
}
else 
{
    Console.WriteLine("Quarter undefined");
}
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("1 quarter");
// }
// else if (X < 0 && Y > 0)
// {
//     Console.WriteLine("2 quarter");
// }
// else if (X < 0 && Y < 0)
// {
//     Console.WriteLine("3 quarter");
// }
// else if (X > 0 && Y < 0)
// {
//     Console.WriteLine("4 quarter");
// }
// int X = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter Y:");
// int Y = int.Parse(Console.ReadLine());