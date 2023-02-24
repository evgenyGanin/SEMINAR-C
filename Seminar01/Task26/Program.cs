Console.Clear;

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumD(int a)
{
    int result=0;
    while (a>0)
    {
        result++;
        a /=10; //a=a/10;

    }
    return result;
}

int numD = NumD(num);

OutResult("Сумма цифр введенного числа: ", numD);

void OutResult(string msg, int b)
{
    System.Console.WriteLine(msg, b);
}

// int num = NumInp("Введите число: ");
// int NumInp(string msg)
// {
//     Console.WriteLine(msg);



// }
// --------------------РЕШЕНИЕ С РАЗБОРА
/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

//тело программы
int number = Prompt("Введите число ");
int diget = CheckDigit(number);
Console.WriteLine($"В числе {number}, {diget} ");

//методы
int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int CheckDigit(int num)
{
    int result = 0;
    if (num == 0) return 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    }
    return result;
}