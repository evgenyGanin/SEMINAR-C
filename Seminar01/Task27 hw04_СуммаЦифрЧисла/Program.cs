// ----УСЛОВИЕ ЗАДАЧИ-----------------------
// Задача: Напишите программу, которая:
// Принимает на вход число 
// Выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// ----УСЛОВИЕ ЗАДАЧИ (КОНСОЛЬ)-------------
Console.Clear();
void TaskText()
{
    System.Console.WriteLine("ЗАДАЧА 27: Напишите программу, которая:\n1. Принимает на вход число \n2. Выдаёт сумму цифр в числе.\n452 -> 11\n82 -> 10\n9012 -> 12\n------------------------------------------");
}
TaskText();

// ----РЕШЕНИЕ ЗАДАЧИ-----------------------
int numA = Input("Введите число: ");
int res = Sum(numA);
Console.WriteLine($"Сумма цифр в числе {numA} = {res}");

// ----МЕТОД ВВОДА--------------------------
int Input(string msg)
{
    Console.WriteLine(msg);
    string x = Console.ReadLine();
    int res = Convert.ToInt32(x);
    return res;
}
  
int Sum(int a)
{
    int res = 0;
    while (a > 0)
    {
        res = res + (a %10);
        a = a/10;
    }
    return res;
}