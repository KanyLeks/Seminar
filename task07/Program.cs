// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Clear();
Console.Write("Enter the first num: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second num: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int remainder = firstNum % secondNum; // остаток от деления

if (remainder > 0)
    Console.WriteLine("Не кратно, остаток {0}", remainder);
else
    Console.WriteLine("Кратно");




