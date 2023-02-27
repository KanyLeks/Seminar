/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();


Console.Write("Введите размер массива: ");
int Length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение в массиве: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение в массиве: ");
int max = int.Parse(Console.ReadLine());
int[] Array = GetArray(Length, min, max);
Console.WriteLine($"{String.Join(" , ", Array)}");
FindDifference(Array, max, min);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// честно подсмотрел в интернете и немного не пойму, как сделать эту задачу, по аналогии с предыдущими, не используя метод VOID.

void FindDifference(int [] inputArray, int minVal, int maxVal) 
{
    for(int i = 0; i< inputArray.Length; i++)
    {
        if(inputArray[i]< minVal)
        {
            minVal = inputArray[i];
        }
        if(inputArray[i]> maxVal)
        {
            maxVal = inputArray[i];
        }
    }
    Console.WriteLine($"Разница {maxVal - minVal}");
}









