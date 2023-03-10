// Задача 50. Напишите программу, 
// которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве 
// или же указание, что такого числа нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int number = InputNumber("Введите число: ");
Console.WriteLine();

Random rand = new Random();
int m = rand.Next(2, 6);
int n = rand.Next(2, 6);
int[,] matrix = FillMatrix(m, n);

PrintMatrix(matrix);
Console.WriteLine();
FindElementIndex(matrix, number);

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
    }
    return number;
}

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 11);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindElementIndex(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Индекс числа {number} в массиве: ({i},{j})");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine($"Числа {number} в массиве нет.");
}

