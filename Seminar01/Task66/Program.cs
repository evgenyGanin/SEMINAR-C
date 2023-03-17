// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NatNumSum(int minimal, int maximal)
{
    if (minimal == maximal) return maximal;
    else
    {
        int sum = minimal + NatNumSum(minimal + 1, maximal);
        return sum;
    }
}

Random rand = new Random();
int min = rand.Next(1, 11);
int max = rand.Next(10, 15);

if (min < max)
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {min} до {max} включительно = {NatNumSum(min, max)}.");
}
else if (min > max)
{
    Console.WriteLine($"Сумму натуральных чисел в промежутке от {min} до {max} вычислить невозможно, т.к. {min} больше {max}.");
}
else Console.WriteLine($"Сумма натуральных чисел в промежутке от {min} до {max} включительно: {min}.");
