void OutPutOfMtoNNumbers (int m, int n) {
for (int i=m;i<=n; i++)
{
 if (i==n)
{
  Console.Write($"{i}");
}
else
 {
 Console.Write($"{i},");
}
}
}
Console.WriteLine("Введите число M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите число N:");
int n=Convert.ToInt32(Console.ReadLine());
Console.Clear();
OutPutOfMtoNNumbers(m,n);