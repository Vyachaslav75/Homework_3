static double enterNumber(string msg)
{
    double number;
    while (true)
    {
        Console.Write($"Введите {msg} ");
        if (double.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine("Введен неправильный символ");
    }
}

static void enterCoord(ref double[] arr)
{
    string[] message={"координату Х: ", "координату Y: ", "координату Z: "};
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = enterNumber(message[i]);
    }
}

static double distance(double[] arr1, double[] arr2)
{
    double res=0;
    for (int i = 0; i < 3; i++)
    {
        res=res+Math.Pow(arr2[i]-arr1[i], 2);
    }
    return Math.Sqrt(res);
}
double[] A = new double[3];
double[] B = new double[3];
Console.Clear();
Console.WriteLine("Введите координаты точки А");
enterCoord(ref A);
Console.WriteLine("Введите координаты точки В");
enterCoord(ref B);
Console.Write($"А({A[0]}, {A[1]}, {A[2]}); ");
Console.Write($"B({B[0]}, {B[1]}, {B[2]}) ");
string str=string.Format("{0:f2}", distance(A, B));
Console.WriteLine($" -> {str}");
