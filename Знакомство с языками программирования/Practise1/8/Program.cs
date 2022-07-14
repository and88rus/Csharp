Console.WriteLine("Введите число N:");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Четные числа в диапозоне от 1 до N следующие:");
for (int i=1; i<=n;i++)
{
    if (i%2==0)
    {
      Console.WriteLine(i);
    }
}