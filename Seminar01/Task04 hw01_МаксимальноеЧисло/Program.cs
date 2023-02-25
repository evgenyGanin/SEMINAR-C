// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 --> 7
// 44 5 78 --> 78
// 22 3 9 --> 22

Console.Clear();
void TaskText()
{
    System.Console.WriteLine(" ЗАДАЧА # 04: Напишите программу, которая принимает \n на вход три числа и выдаёт максимальное из этих чисел. \n 2, 3, 7 --> 7 \n 44, 5, 78 --> 78 \n 22, 3, 9 --> 22"); 
    }
TaskText();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) max = b; 
if (c > a) max = c;
Console.WriteLine($"Максимальное из введенных чисел: {max}");