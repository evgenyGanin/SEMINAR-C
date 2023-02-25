// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] CrArrRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrArr(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CountElements(int[] array, int Min, int Max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= Min && array[i] <= Max)
        {
            count++;
        }
    }
    return count;
}

int[] array = CrArrRnd(10, -100, 100);
PrArr(array);

System.Console.WriteLine($"Количество элементов от 10 до 99 в массиве равно {CountElements(array, 10, 99)}");
