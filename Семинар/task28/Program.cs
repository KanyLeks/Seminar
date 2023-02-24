/*
Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
2,4 -> 24
1,5 -> 120
*/

Console.Clear();

int GetMultNum(int value, int mult)
{

    // if (mult == 0 || value == 0) // если что-то 0, то все 0
    // {
    //     return 0;
    // }



    // вычисляет произведение 
    int spamValue = 1;
    for (int i = value; i <= mult; i++)
    {
        spamValue *= i;
    }
    return spamValue;
}

Console.WriteLine($"Произведение числе равно {GetMultNum(2, 4)}");
Console.WriteLine($"Произведение числе равно {GetMultNum(1, 5)}");
Console.WriteLine($"Произведение числе равно {GetMultNum(-5, -1)}");
Console.WriteLine($"Произведение числе равно {GetMultNum(-1, 5)}");