Console.Clear();
// ------РЕШЕНИЕ--------------------
Random rand = new Random();
int[] array = new int[8];
Output(array);

// ------МЕТОД РЕШЕНИЯ--------------
void Output (int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=rand.Next(0,50);
    }
    Console.WriteLine("[" + string.Join(", ", array)+"]");
}

// ------УСЛОВИЕ ВЫВОД В КОНСОЛЬ-----
void TaskText()
{
    System.Console.WriteLine("ЗАДАЧА 25: Напишите программу, которая:\n1. Задаёт массив из 8 элементов \n2. Выводит их на экран.\n1, 2, 5, 7, 19, 6, 1, 33 --> [1, 2, 5, 7, 19, 6, 1, 33] 16\n------------------------------------------");
}
TaskText();
