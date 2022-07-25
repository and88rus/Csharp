void CreatingOfAxBArray (int line,int col,int[,] m)
{
for (int i=0;i<line;i++)
{
    for (int j=0;j<col;j++)
    {
      Console.WriteLine ($"Введите элемент {i},{j}:");
      m[i,j]=Convert.ToInt32(Console.ReadLine());
      Console.Clear();
    }
}
}
void OutPutOfAxBArray (int line,int col,int[,] m)
{
Console.WriteLine(" ");
Console.WriteLine($"Созданный массив размера {line}x{col} чисел следующий:");
Console.WriteLine(" ");
for (int i=0;i<line;i++)
{
    for (int j=0;j<col;j++)
    {
      Console.Write($"{m[i,j]} ");
    }
    Console.WriteLine();
}
Console.Write(" ");
}
int LeastSumOfLineOfAxBArray (int line, int col, int[,]m, int[]sum)
{
  int min_sum=sum[0];
  int index=0;
for (int i=0;i<line;i++)
{
    for (int j=0;j<col;j++)
    {
      sum[i]+=m[i,j];
    }
     if (sum[i]<=sum[0])
    {
      min_sum=sum[i];
      index=i;
    };
}
return index;
} 
Console.WriteLine(" ");
Console.WriteLine("Введите кол-во строк массива:");
Console.WriteLine(" ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("Введите кол-во столбцов массива:");
Console.WriteLine(" ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
int [,] m = new int [line,col];
int [] sum = new int[line];
CreatingOfAxBArray (line,col,m);
OutPutOfAxBArray (line ,col, m);
int lownumber = LeastSumOfLineOfAxBArray (line,col,m,sum);
Console.WriteLine(" ");
Console.WriteLine($"Для вышеописанного массива номер строки с наименьшей суммой элементов следующий: {lownumber+1}.");