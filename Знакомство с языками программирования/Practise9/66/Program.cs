void OutPutOfSumOfMtoNNumbers (int m,int n) {
int sum=0;
for (int i=m;i<=n; i++)
{
 sum+=i;
}
Console.WriteLine($"Сумма чисел от {m} до {n}:");
Console.WriteLine(sum);
}
Console.WriteLine("Введите число M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите число N:");
int n=Convert.ToInt32(Console.ReadLine());
Console.Clear();
OutPutOfSumOfMtoNNumbers(m,n);