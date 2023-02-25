// ЗАДАЧА 00
// Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя). 

// Например: 
//  4 --> 16 
// -3 --> 9 
// -7 --> 49
Console.Clear();
void Metod()
{
    System.Console.WriteLine(" ЗАДАЧА # 00\n Напишите программу, которая на вход принимает число и \n выдает его квадрат (число умноженное на само себя). \n Например: \n  4 --> 16 \n -3 --> 9 \n -7 --> 49");
}
Metod();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} равен {square} ({num}x{num}={square})");

