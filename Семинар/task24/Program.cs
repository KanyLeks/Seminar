// Задача 24. НАпишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 ->28
// 4 ->10
// 8 ->36

Console.Clear();

Console.WriteLine("Введите число А: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSumByNumber(a)}");

int GetSumByNumber(int limit) // это метод или функция !!!
{
    int result = 0;
    for (int i = 0; i <= limit; i++) // limit область вводимая, локальная переменная, т.е.  4, значит от 1 до 4
    {
        result = result + i; // result += i
    }
    return result;
}
