/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] MyArray = GetArray(4, 1, 100);
Console.WriteLine(String.Join(" ", MyArray));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {(String.Join(" ", GetSumNotEvenArray(MyArray)))}");


Console.WriteLine();

// Massiv
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Поиск нечетной позиции, т.е index[i];

int GetSumNotEvenArray(int[] inputArray)
{
    int NotEven = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i % 2 == 0)
        {
         // немного не понял, почему можно оставить это условие пустым?
        }
        else 
        {
            NotEven += inputArray[i];
        }

    }
return NotEven;
}

