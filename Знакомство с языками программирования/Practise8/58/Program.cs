void InPutOfArrays(int [,] a, int [,] b,int line_of_a, int line_of_b, int col_of_a, int col_of_b)  
{

for (int i=0;i<line_of_a;i++) 
{
for (int j=0;j<col_of_a;j++)
 { Console.Write ($"Введите {i},{j}-ый элемент матрицы A:");
a[i,j]=Convert.ToInt32(Console.ReadLine());
Console.Clear();
 }
Console.WriteLine (" ");
}

for (int i=0;i<line_of_b;i++) 
{
for (int j=0;j<col_of_b;j++)
 { Console.Write ($"Введите {i},{j}-ый элемент матрицы B:");
b[i,j]=Convert.ToInt32(Console.ReadLine());
Console.Clear();
 }
Console.WriteLine (" ");
}

}

void C(int [,] a, int [,] b, int [,] c, int line_of_a, int line_of_b, int col_of_a, int col_of_b)  
{
  int sum=0;                                                          
  for (int x=0; x<line_of_a; x++)
   {
     sum=0;
    for (int y=0; y<col_of_b; y++)
    { 
     for (int r=0; r<col_of_a; r++)
      {

 sum+=a[x,r]*b[r,y];
    }
    c[x,y]=sum;
    sum=0;
}
   }
}

void OutPutOfC(int [,] c,int line_of_a, int col_of_b)
{
Console.WriteLine("Произведение из матриц A и B (матрица С) следующее: "); 
   for (int i=0;i<line_of_a ;i++)
{
 for (int j=0;j<col_of_b;j++)
  { 
       Console.Write($"{c[i,j]} "); 
  }
  Console.WriteLine (" ");
};
}

start:
Console.Write ($"Введите кол-во строк матрицы A:");
int line_of_a = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write ($"Введите кол-во столбцов матрицы A:");
int col_of_a = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write ($"Введите кол-во строк матрицы B:");
int line_of_b = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write ($"Введите кол-во столбцов матрицы B:");
int col_of_b = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int [,] a = new int [line_of_a,col_of_a];
int [,] b = new int [line_of_b,col_of_b];

if (col_of_a==line_of_b) 
{
int [,] c = new int [line_of_a,col_of_b];
InPutOfArrays (a, b, line_of_a, line_of_b, col_of_a, col_of_b);
C(a, b, c, line_of_a, line_of_b, col_of_a, col_of_b);
OutPutOfC(c,line_of_a, col_of_b);
}
else 
{
Console.WriteLine ("Ошибка! Число столбцов матрицы А не равно числу строк матрицы B, а в таком случае операция умноженя для A и B не выполняется.");
 goto start;
}