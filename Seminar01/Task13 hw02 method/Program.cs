// Задача 13: 
// Напишите программу, которая:
// 1. Принимает на вход число;
// 2. Выводит третью цифру заданного числа;
// 2. Или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
void TaskText()
{
    System.Console.WriteLine("Задача 13:\nНапишите программу, которая:\n1. Принимает на вход число;\n2. Выводит третью цифру заданного числа;\n2. Или сообщает, что третьей цифры нет.\nНапример:\n645   --> 5\n78    --> третьей цифры нет\n32679 --> 6");
}
TaskText();
// -------Task 10 Homework 2 method-------------------------------------

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
int digNum = DigNum(number);
System.Console.WriteLine(number%10);
}
else if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}

int DigNum (int num)
{
    int res = 0;
    while (number > 999)
    {
        number = number/10;
        res++;
    }
    return res; 
}