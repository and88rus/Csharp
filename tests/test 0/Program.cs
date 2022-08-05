int line_of_m = Convert.ToInt32(Console.ReadLine());

int col_of_m = Convert.ToInt32(Console.ReadLine());

int[,] m = new int[line_of_m, col_of_m];

for (int i = 0; i <= 0; i++)
 {
  for (int j = 0; j < 3; j++)
    {
     {
     m[i, j] = Convert.ToInt32(Console.ReadLine());
     }
    }
}

for (int i=0; i<3; i++)
{
    for (int j=3; j<=3; j++)
    {
       m[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i=3; i<=3; i++)
{
    for (int j=3; j>0; j--)
    {
       m[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i=3; i>=1;i--)
{
 for (int j=0; j>=0; j--)
 {
   m[i, j] = Convert.ToInt32(Console.ReadLine());
 }
}

for (int i=1; i>=1;i--)
{
 for (int j=1; j<3; j++)
 {
   m[i, j] = Convert.ToInt32(Console.ReadLine());
 }
}

for (int i=2; i>=2;i--)
{
 for (int j=2; j>0; j--)
 {
   m[i, j] = Convert.ToInt32(Console.ReadLine());
 }
}

for (int i = 0; i < line_of_m; i++)
   {
    for (int j = 0; j < col_of_m; j++)
    {
    Console.Write($" {m[i, j]} ");
    }
    Console.WriteLine(" ");
  }