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
// -------Task 10 Homework 2-------------------------------------
Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number > 99) 
{
while (number > 999)
    {
        number = number/10;
        result++;
    }
System.Console.WriteLine(number%10);
}
else if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}

























//------Альтернативное решение-----------------
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numDig = NumDig(number);

// if (numDig < 2)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     if (numDig > 3)
//     {
//         number=number/Convert.ToInt32(Math.Pow(10, numDig -3));
//     }
//     number = number % 10;
//     System.Console.WriteLine($"Третья цифра {number}");
// }

// int NumDig(int num)
// {
//     int count = 0;
//     while (num >0)
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }
// ----------------------------------------------------
