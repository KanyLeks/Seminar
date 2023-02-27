//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] array = FillArray(12,-9,9); // Заполняем массив

Console.WriteLine($"В массиве: [{string.Join(" , ", array)}] сумма положительных чисел равна {GetSumPossitiveByArray(array)}, сумма отрицательных равна {GetSumNegativeByArray(array)}");

int[] FillArray(int size, int min, int max) // FillArray - НАЗВАНИЕ ФУНКЦИИ
{
    int[] result = new int[size]; // Создадим новый массив

    Random rnd = new Random(); // Создание объекта rnd *
    
    for(int i = 0; i < result.Length; i++) // Создание цикла
    {
        result[i] = rnd.Next(min,max + 1); // * Заполняем массив
    }
    return result; // возвращаем массив
}
// Массив заполнен!


int GetSumPossitiveByArray(int[] inputArray) // Новый цикл
{
    int result = 0; // Определяем счетчик, куда складываться будет
    foreach(int element in inputArray) // Цикл перебора в коллекции
    {
        result += element > 0 ? element : 0;
        // if(element > 0) 
        //     result += element;
    }
    return result;
}

int GetSumNegativeByArray(int[] inputArray) // Новый метод для отрицательных
{
    int result = 0;
    foreach(int element in inputArray)
    {
        result += element < 0 ? element : 0;
        // if(element > 0) 
        //     result += element;
    }
    return result;
}