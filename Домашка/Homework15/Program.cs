// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Enter the number of the day of the week: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());

if(numberDayOfWeek==1)
{
    Console.WriteLine("Monday, working day");
}
else if(numberDayOfWeek==2)
{
    Console.WriteLine("Tuesday, working day");
}
else if(numberDayOfWeek==3)
{
    Console.WriteLine("Wednesday, working day");
}
else if(numberDayOfWeek==4)
{
    Console.WriteLine("Thursday, working day");
}
else if(numberDayOfWeek==5)
{
    Console.WriteLine("Friday, working day");
}
else if(numberDayOfWeek==6)
{
    Console.WriteLine("Saturday, day off");
}
else if(numberDayOfWeek==7)
{
    Console.WriteLine("Sunday, day off");
}
else{
    Console.WriteLine("Wrong number entered");
}

