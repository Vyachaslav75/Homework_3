static int enterNumber(string msg)
{
    int number;
    while (true)
    {
        Console.Write($"Введите {msg} ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number>9999 && number<100000)
            {
                return number;
            }
            
        }
        Console.WriteLine("Введено неправильное число");
    }
}
static int countNum(int num)
{
    int count = 0;
    while (num / 10 != 0)
    {
        num = num / 10;
        count++;
    }
    return count + 1;
}
static void checkPalindrom(int userNum)
{
    int N = countNum(userNum);
    string str = "да";
    for (int i = 0; i < N / 2; i++)
    {
        int a = Convert.ToInt32((userNum / Math.Pow(10, N - i)) % 10);
        int b = Convert.ToInt32((userNum / Math.Pow(10, i - 1)) % 10);
        if (a != b)
        {
            str = "нет";
            break;
        }
    }
    Console.WriteLine($"{userNum} -> {str}");
}

Console.Clear();
string userMessage = "пятизначное число для проверки на палиндром: ";
checkPalindrom(enterNumber(userMessage));
