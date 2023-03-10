// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Random rand = new Random();
int m = rand.Next(2, 11);
int n = rand.Next(2, 11);
double[,] matrix = NewMatrixNumbers(m, n);

PrintMatrix(matrix);

double[,] NewMatrixNumbers(int rows, int cols)
{
    Random rand = new Random();
    double[,] matr = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            double temp = Math.Round((rand.Next(-10, 10) + rand.NextDouble()), 2);
            matr[i, j] = temp;
        }
    }

    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 7}" + "\t");
        }
        Console.WriteLine();
    }
}
