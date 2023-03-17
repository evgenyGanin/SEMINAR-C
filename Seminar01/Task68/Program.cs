//Задача 68.
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int m = EntDat("Введите значение m: ");
int n = EntDat("Введите значение n: ");
Console.WriteLine($"m={m}, n={n} -> A(m,n) = {AkkFunkcion(m, n)}");

int EntDat(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int AkkFunkcion(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n ==0) return AkkFunkcion (m - 1, 1);
    else
       return AkkFunkcion(m -1, AkkFunkcion(m, n - 1));  
}
