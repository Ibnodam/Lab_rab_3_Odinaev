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




////// Лабораторная работа 3, задание 2. Квадрат разности (a-b)^2
////int n = 1;
////Console.WriteLine("Введите число m: ");
////int m = int.Parse(Console.ReadLine());
////for (n = 1; n <= 1000; n++)
////{
////    Console.WriteLine($"Квадрат разности n и m: ({n}-{m})^2 = {((Math.Pow(n,2)) - (2*n*m) + (Math.Pow(m,2)))}");

////}



//// Лабораторная работа 3. Задание 3
//try
//{
//    Console.Write("Введите x: ");
//    double x = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите количество членов суммы ряда:");
//    int n = int.Parse(Console.ReadLine());
//    double sum = 0;
//    double i = 1;
//    int counter = 0;
//    while (counter < n)
//    {
//        sum = (sum + ((Math.Sin((x * i))) / i));
//        i = i + 2;
//        counter++;
//    }
//    Console.WriteLine($"Сумма {n} членов ряда равна {sum:F2}.");
//}
//catch (Exception ex)
//{ Console.WriteLine(ex.Message); }



