// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Random rand = new Random();
int number = rand.Next(1, 11);
PositiveNum((NewArray(number)), number);


int[] NewArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PositiveNum(int[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    System.Console.WriteLine($"{count} из {number} введённых чисел больше нуля.");
}


