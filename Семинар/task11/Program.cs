// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

// Console.Clear();

// Console.WriteLine("Enter Number Quarter:");

// int num = int.Parse(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("(X > 0 , Y > 0)");
// }

// if (num == 2)
// {
//     Console.WriteLine("(X < 0 , Y > 0)");
// }
// if (num == 3)
// {
//     Console.WriteLine("(X < 0 , Y < 0)");
// }

// if (num == 4)
// {
//     Console.WriteLine("(X > 0 , Y < 0)");
// }
// else
// {
//     Console.WriteLine("quarter does not exist");
// }


// 2 Способ, используя switch.
Console.WriteLine("Enter Number Quarter:");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("(X > 0 , Y > 0)");
    break;


    case 2:
        Console.WriteLine("(X < 0 , Y > 0)");
    break;

    case 3:
        Console.WriteLine("(X < 0 , Y < 0)");
    break;

    case 4:
        Console.WriteLine("(X > 0 , Y < 0)");
    break;

    default : Console.WriteLine ("Quarter undefined");
    break;
}
