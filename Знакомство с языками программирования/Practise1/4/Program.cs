Console.WriteLine("Введите 1-ое число:");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 3-ое число:");
double C = Convert.ToDouble(Console.ReadLine());
double max=A;
if (A>max)
{
    max=A;
}
if (B>max)
{
    max=B;
}
if (C>max)
{
    max=C;
}
Console.WriteLine("Максимальное число следующее:");
Console.WriteLine(max);
