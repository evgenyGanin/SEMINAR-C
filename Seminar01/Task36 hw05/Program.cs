// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] NewArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 101);
    }
    return array;
}

void ArrayOddNumSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

NewArray(array);
ArrayOddNumSum(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
