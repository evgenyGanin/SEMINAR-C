int Input(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
    }
    return number;
}

int number = Input ("Введите число: ");

