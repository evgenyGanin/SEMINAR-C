// ЗАДАЧА 23: Напишите программу, которая:
// 1. Принимает на вход число (N).
// 2. Выдаёт таблицу кубов чисел от 1 до N.
// 3 --> 1, 8, 27
// 5 --> 1, 8, 27, 64, 125

Console.Clear();
void TaskText()
{
    System.Console.WriteLine("ЗАДАЧА 23: Напишите программу, которая:\n1. Принимает на вход число (N)\n2. Выдаёт таблицу кубов чисел от 1 до N.\n3 --> 1, 8, 27\n5 --> 1, 8, 27, 64, 125");
}
TaskText();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square (int num)
{
    int index = 1;
    while (index <= num)
    {
    Console.WriteLine($"{index, 2} в кубе это ({index}x{index}x{index}) и равно: {index * index * index}");
    index++;
    }
}
