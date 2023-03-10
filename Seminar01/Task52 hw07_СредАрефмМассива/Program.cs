// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Random rand = new Random();
int m = rand.Next(2, 6);
int n = rand.Next(2, 6);
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
ColumnArithmeticMean(matrix);


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

void ColumnArithmeticMean(int[,] matr)
{
    double ArMean = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            ArMean = ArMean + matr[i, j];
        }
        ArMean = Math.Round((ArMean / matr.GetLength(0)), 2);
        Console.WriteLine($"Среднее арифметическое элементов в стобце {j}: {ArMean}");
        ArMean = 0;
    }
}

