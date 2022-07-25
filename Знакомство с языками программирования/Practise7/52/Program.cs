void AverageForColumnOfArray (int a,int b,int x1,int x2)
{
Random rand = new Random();
int [,] m = new int [a,b];
double [] mid = new double [b];
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
      m[i,j]=Convert.ToInt32(rand.Next(x1,x2));
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Созданный массив размера {a}x{b} из целых чисел следующий:");
Console.WriteLine(" ");
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
      Console.Write($"{m[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
Console.WriteLine($"Среднее арифмитическое");
Console.WriteLine(" ");
for (int i=0;i<b;i++)
{
    for (int j=0;j<a;j++)
    {
      mid[i]+=m[j,i];
    };
  Console.WriteLine (" ");
  Console.WriteLine ($"для {i+1}-го столбца: ");
  Console.WriteLine (Math.Abs(mid[i]/a));
  Console.WriteLine (" ");
}; 
}
Console.WriteLine(" ");
Console.WriteLine("Введите кол-во строк массива:");
Console.WriteLine(" ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("Введите кол-во столбцов массива:");
Console.WriteLine(" ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.Clear();
Console.WriteLine("Ввод диапозона значений (x1,x2), числа в пределах которого делятся на 10.0.");
Console.WriteLine(" ");
Console.WriteLine("(1) Введите число x1:");
Console.WriteLine(" ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("(2) Введите число x2:");
Console.WriteLine(" ");
int y4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
AverageForColumnOfArray (y1,y2,y3,y4);