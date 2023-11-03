try
{
    Console.Write("Введите x:");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double P = 1;
    double S = 0;
    for (int k = 3; k <= n; k++)
    {
        if (k != 5 && x != 0) S += (Math.Pow((-2), (k - 1))) / ((k - 5) * Math.Pow(x, k));
        else Console.WriteLine("Ошибка! Недопустимые значиния для переменных!"); break;
        for (int i = 1; i <= k + 7; i++)
        {
            if (i != 7) P *= (Math.Pow(i, 3) - 27) / (i - 7);

        }
    }

    Console.WriteLine($"S={P * S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}