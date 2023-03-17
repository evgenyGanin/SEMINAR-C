//Задача 64.
//Задайте значения N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NatlNum(int n, int a)
{
    if(n == a) return n;
    else
    {
        Console.Write($"{NatlNum(n, a + 1)}, ");
        return a;
    }
}

int EntDat(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int n = EntDat("Введите число: ");
int a =1;
Console.WriteLine(NatlNum (n, a));
