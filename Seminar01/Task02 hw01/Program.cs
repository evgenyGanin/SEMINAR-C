// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
void TaskText()
{
    System.Console.WriteLine(" ЗАДАЧА # 02: \n Напишите программу, которая на вход принимает \n два числа и выдаёт, какое число большее, а какое меньшее.\n a = 5; b = 7 -> max = 7 \n a = 2 b = 10 -> max = 10 \n a = -9 b = -3 -> max = -3}");
}
TaskText();

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB) Console.WriteLine($"Число {numA} больше. Число {numB} меньше.");
else Console.WriteLine($"Число {numB} больше. Число {numA} меньше.");