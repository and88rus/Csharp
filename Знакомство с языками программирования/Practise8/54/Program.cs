void CreatingOfAxBArray (int line, int col, int[,] m)
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

void OutPutOfAxBArray(int line, int col, int[,] m) {
Console.WriteLine(" ");
Console.WriteLine($"Созданный массив размера {line}x{col} следующий:");
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
}; 

void GrovingStyleOfLineOfAxBArray (int line, int col, int[,] m)
{
for (int i=0; i<line;i++)
{
  for (int t=1;t<col;t++)
   {
 for (int r=0;r<col-t;r++)
 {
  if 
  (m[i,r]>m[i,r+1])
     {
      int temp=m[i,r];
      m[i,r]=m[i,r+1];
      m[i,r+1]=temp;
     }
 }
}
}
};

void Result (int line, int col, int[,] m) 
{
  Console.WriteLine(" ");
Console.WriteLine("Результат вызова метода, упорядочивающего элементы каждой строки по убыванию:");
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
}; 

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
CreatingOfAxBArray (line,col,m);
OutPutOfAxBArray (line,col,m);
GrovingStyleOfLineOfAxBArray (line,col,m);
Result(line,col,m);
