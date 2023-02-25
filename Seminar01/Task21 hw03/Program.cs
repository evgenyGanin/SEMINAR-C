// ЗАДАЧА №21: Напишите программу, которая:
// 1. Принимает на вход координаты двух точек; 
// 2. Находит расстояние между ними в 3D пространстве;
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
void TaskText()
{
    System.Console.WriteLine("Напишите программу, которая \n1. Принимает на вход координаты двух точек.\n2. Находит расстояние между ними в 3D пространстве.\nA (3,6,8); B (2,1,-7), -> 15.84\nA (7,-5, 0); B (1,-1,9) -> 11.53\n------------------------------------------");
}
TaskText();

System.Console.WriteLine("Введите координаты точки А");
System.Console.Write("x: "); int xx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y: "); int yy = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z: "); int zz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки В");
System.Console.Write("x: "); int aa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y: "); int bb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z: "); int cc = Convert.ToInt32(Console.ReadLine());

double result = Dist (aa, bb, cc, xx, yy, zz);
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве будет равно: {result}");

double Dist (int x, int y, int z, int a, int b, int c)
{
    double sqrt = Math.Sqrt(Math.Pow(a-x,2)+Math.Pow(b-y,2)+Math.Pow(c-z,2));
    double sqrtRnd = Math.Round(sqrt, 2, MidpointRounding.ToZero);
    return sqrtRnd;
}


