static int enterNumber(string msg)
{
    int number;
    while (true)
    {
        Console.Write($"Введите {msg} ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine("Введен неправильный символ");
    }
}

static void printCube(int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i < num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.Write($"{Math.Pow(num, 3)}");
}

string str = "целое число: ";

printCube(enterNumber(str));
