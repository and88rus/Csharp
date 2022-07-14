void DiffBetweenMaxAndMinElementsOfMassive(int a, int x1, int x2)
{
Random rand = new Random();
double[] m = new double[a];
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
double min=m[rand.Next(-1,a)]; 
double max=m[rand.Next(-1,a)];
for (int i=0; i<a;i++)
{
if (m[i]<=min)
{
   min=m[i];
};
if (m[i]>=max)
{
   max=m[i];
}
};
Console.WriteLine(" ");
Console.WriteLine("Максимальный элемент:");
Console.WriteLine(" ");
Console.WriteLine(max);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Минимальный элемент:");
Console.WriteLine(min);
Console.WriteLine(" ");
Console.WriteLine("Разность максимального и минимального элемента созданного массива:");
Console.WriteLine(" ");
Console.WriteLine(Math.Abs(max-min));
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
DiffBetweenMaxAndMinElementsOfMassive(n,y1,y2);
Console.WriteLine(" ");