// ДЗ 06: Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string k1 = "k1";
double num1 = NumberEntering(k1);
string b1 = "b1";
double num2 = NumberEntering(b1);
string k2 = "k2";
double num3 = NumberEntering(k2);
string b2 = "b2";
double num4 = NumberEntering(b2);

Intersection(num1, num2, num3, num4);

double NumberEntering(string stroke)
{
    Console.Write($"Введите число {stroke}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
}


