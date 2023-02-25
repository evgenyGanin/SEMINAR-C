// 17. Напишите программу, которая:
//     1. Принимает на вход координаты точки Х и У;
//     2. При чем Х не = 0 и У не = 0;
//     3. Выдает номер четверти плоскости, в которой находится эта точка

Console.Clear();
Console.WriteLine("Введите координаты: ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);
string res = quarter > 0 
? $"Указанные координаты соответствуют четверти {quarter}":"Введены некорректные координаты";
Console.WriteLine(res);

int Quarter(int xx, int yy)
{
    if (xx > 0 && yy > 0) return 1;
    if (xx < 0 && yy > 0) return 2;
    if (xx < 0 && yy < 0) return 3;
    if (xx > 0 && yy < 0) return 4;
    return 0;
}