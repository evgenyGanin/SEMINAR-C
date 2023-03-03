﻿// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double temp = Math.Round((rand.Next(-10, 10) + rand.NextDouble()), 2);
        array[i] = temp;
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round((FindMax(array) - FindMin(array)), 2)}");
