/*Task01
a = 25, b = 5 -> yes
a = 2, b = 10 -> no
a = 9, b = -3 -> yes
a = -3, b =9 -> no*/

Console.Clear();

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

double c = Math.Pow(b, 2);
if (c == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
    


