void nechm(int a, int x1, int x2)
{
Random rand = new Random();
int[] m = new int[a];
for (int i=0; i<a;i++)
{
Console.WriteLine(" ");
   m[i] = rand.Next(x1,x2);
};
Console.WriteLine("Сгенерированный массив из случайных чисел:");
for (int i=0; i<a;i++)
{
Console.WriteLine(" ");
   Console.WriteLine(m[i]);
};
int sum=0;
int k=0;
for (int i=0; i<a;i++)
{
 if(i%2!=0)
 {
  sum=sum+m[i];
  k=sum;
 };
};
Console.WriteLine(" ");
Console.WriteLine("Сумма элементов, находящихся под нечетными индексами, в массиве:");
Console.WriteLine(" ");
Console.WriteLine(sum);
};
Console.WriteLine(" ");
Console.WriteLine("Введите размер массива:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите число x1:");
Console.WriteLine(" ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите число x2:");
Console.WriteLine(" ");
int y2 = Convert.ToInt32(Console.ReadLine());
nechm(n,y1,y2);
Console.WriteLine(" ");