void table(int a)
{
int[] m = new int[a];
for (int i=0;i<a;i++)
{
  m[i]=(i+1)*(i+1)*(i+1);
Console.WriteLine(m[i]);
}
}
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Таблица кубов чисел от 1 до {n}:");
table(n);