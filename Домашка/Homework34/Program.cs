/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
int[] startArray = GetArray(4, 100, 999);
// Console.WriteLine(String.Join(" ", startArray));
// Console.WriteLine($"Количество четных чисел равно : {(String.Join(" ", GetEvenArray(startArray)))}");
Console.WriteLine($"В массиве: ({string.Join(" , ", startArray)}) количество четных чисел равно {GetEvenArray(startArray)}");

// Определяем массив.

int[] GetArray  (int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// Для поиска четных

int GetEvenArray(int[] inputArray) // Новый цикл
{
    int even = 0; // определяем счетчик
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] % 2 == 0) // inputArray[i] - т.к. нам нужен индекс элемента.
        {
            even = even + 1; // счетчик + 1 элемент, так как считаем кол-во.
        }
        
    }
    return even;
}