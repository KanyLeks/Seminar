﻿//Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.


Console.Clear();
int[] startArray = GetArray(6, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue) // 1 Метод, заполнение нового массива
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] InversArray(int[] array) // 2 Метод, + на минус и наоборот
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;  
        //array[i] = array[i] * -1;
    }
    return array;
}