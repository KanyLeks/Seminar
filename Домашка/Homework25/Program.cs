/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();

// int GetMultNum(int value, int mult) // 2 переменные А и В
// {
//     int spamValue = 1; // новая переменная 
//     for (int i = value; i <= mult; i++)
//     {
//         //int power = mult;
//         spamValue = int Math.Pow( i,  mult);
//         //Console.Write(Math.Pow(i, mult));
//         //int Math.Pow(int i, int mult);
//     }
    
    //A ^= B эквивалентно A = A ^ B
    //return spamValue;
// }
// Console.WriteLine($" в степени  равно {GetMultNum(1, 5)}");
// Console.WriteLine($" в степени  равно {GetMultNum(2, 5)}");


//int n = 10; int power = 2; for (int i = 0; i < n; i++) {Console.Write (Math.Pow (i, power)+"")


//int num1 = new Random().Next(1,5);
//int num1 = Convert.ToInt32(Console.ReadLine()); !
//int num2 = Convert.ToInt32(Console.ReadLine()); !
//int num2 = new Random().Next(1,5);
// Console.WriteLine(num1);
// Console.WriteLine(num2);
//int num3 = Convert.ToInt32( Math.Pow (num1, num2)); !
//int num3 = 1;
// for (int i = num1; i <= num2; i++)
// {
    //Console.Write (num3); !
//num3 = num1 ^= num2;
//Console.WriteLine(num3);
// }
// return ;



int Prompt (string message)
{
    Console.Write(message); // Выводим приглошение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result; // Возвращаем результат
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for(int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
    Console.WriteLine("Показательн не должен быть меньше нуля");
    return false;
    }
return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}