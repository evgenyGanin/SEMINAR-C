// ЗАДАЧА 25: Напишите цикл, который:
// Принимает на вход два числа (A и B) 
// Возводит число A в натуральную степень B.
// 3, 5 --> 243 (3⁵)
// 2, 4 --> 16

Console.Clear();

// ----РЕШЕНИЕ ЗАДАЧИ-----------------------
int numA = Input("Введите число А: ");
int numB = Input("Введите число В: ");
int degree = Degree(numA, numB);
if (numB > 0)
{
    Console.WriteLine($"{degree}");
}
else
{
    Console.WriteLine("Вы ввели некорректное число!");
}
// ----МЕТОД ВВОДА--------------------------
int Input(string msg)
{
    Console.WriteLine(msg);
    string x = Console.ReadLine();
    int res = Convert.ToInt32(x);
    return res;
}
// ----МЕТОД ВЫЧЕСЛЕНИЯ СТЕПЕНИ-------------
int Degree (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result = result * a;
        return result;
}
// ----МЕТОД ВЫВОДА УСЛОВИЯ-----------------
void TaskText()
{
    System.Console.WriteLine("ЗАДАЧА 25: Напишите цикл, который:\nПринимает на вход два числа (A и B) \nВозводит число A в натуральную степень B.\n3, 5 --> 243 (3⁵)\n2, 4 --> 16\n------------------------------------------");
}
TaskText();
