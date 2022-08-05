void SpiralFillingOfArray(int [,] m,int line_of_m, int col_of_m)
{
for (int i = 0; i <= 0; i++)
 {
  for (int j = 0; j < 3; j++)
    {
     {
    Console.Write($"Введите {i},{j}-ый элемент массива:"); 
     m[i, j] = Convert.ToInt32(Console.ReadLine());
     Console.Clear();
     }
    }
}

for (int i=0; i<3; i++)
{
    for (int j=3; j<=3; j++)
    {
       Console.Write($"Введите {i},{j}-ый элемент массива:");
       m[i, j] = Convert.ToInt32(Console.ReadLine());
       Console.Clear();
    }
}

for (int i=3; i<=3; i++)
{
    for (int j=3; j>0; j--)
    {
       Console.Write($"Введите {i},{j}-ый элемент массива:");
       m[i, j] = Convert.ToInt32(Console.ReadLine());
       Console.Clear();
    }
}

for (int i=3; i>=1;i--)
{
 for (int j=0; j>=0; j--)
 {
   Console.Write($"Введите {i},{j}-ый элемент массива:");
   m[i, j] = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
 }
}

for (int i=1; i>=1;i--)
{
 for (int j=1; j<3; j++)
 {
   Console.Write($"Введите {i},{j}-ый элемент массива:");
   m[i, j] = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
 }
}

for (int i=2; i>=2;i--)
{
 for (int j=2; j>0; j--)
 {
   Console.Write($"Введите {i},{j}-ый элемент массива:");
   m[i, j] = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
 }
}
}

void OutPutOfArray (int [,] m,int line_of_m, int col_of_m) {
for (int i = 0; i < line_of_m; i++)
   {
    for (int j = 0; j < col_of_m; j++)
    {
    Console.Write($" {m[i, j]} ");
    }
    Console.WriteLine(" ");
  }
}

m:
Console.Write($"Введите кол-во строк массива:"); 
int line_of_m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write($"Введите кол-во столбцов массива:"); 
int col_of_m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] m = new int[line_of_m, col_of_m];

if ((line_of_m!=4)||(col_of_m!=4))
{
Console.Write("Ошибка! Кол-во строк/столбцов массива должно быть равно 4.");
Console.WriteLine(" ");
goto m;
}
SpiralFillingOfArray(m,line_of_m, col_of_m);
OutPutOfArray (m,line_of_m, col_of_m);


