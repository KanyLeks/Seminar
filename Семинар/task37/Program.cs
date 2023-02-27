// Поиск результирующего массива
Console.Clear();

int[] array = FillArray(5, 1, 10);

Console.WriteLine($"Массив: [{string.Join(" ", array)}]");
Console.WriteLine($"Результирующий массив: [{string.Join(" ", GetMultipleArray(array))}]");

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}

int[] GetMultipleArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 == 1) size++;

    int[] result = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];

    return result;
}