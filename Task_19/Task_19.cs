static int enterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите целое пятизначное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 9999 && number < 100000)
            {
                return number;
            }

        }
        Console.WriteLine("Введено неправильное число");
    }
}

static void checkNum(int number1)
{
    string message = "Введенное число является палиндромом";
    int N = 1;
    int tmp = number1;
    while (tmp / 10 != 0)
    {
        tmp = tmp / 10;
        N++;
    }

    for (int i = 1; i <= N / 2; i++)
    {
        int a = (number1 / Convert.ToInt32(Math.Pow(10, N - i))) % 10;
        int b = (number1 / Convert.ToInt32(Math.Pow(10, i - 1))) % 10;
        if (a != b)
        {
            message = "Введенное число не является палиндромом";
        }

    }
    Console.WriteLine(message);
}

Console.Clear();
int number1 = enterNumber();
checkNum(number1);
