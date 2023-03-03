// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая: 
// 3. Покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
Console.Clear();
int[] NewArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ArrayEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
NewArray(arr);
PrintArray(arr);
ArrayEvenNumbers(arr);
