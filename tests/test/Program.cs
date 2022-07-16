int [,] m = new int[3,5];
double [] mid = new double [5];
Random rand = new Random();
for (int i=0;i<3;i++)
{
    for (int j=0;j<5;j++)
    {
      m[i,j]=Convert.ToInt32(rand.Next(-100,100));
    }
}
for (int i=0;i<3;i++)
{
    for (int j=0;j<5;j++)
    {
      Console.Write($"{m[i,j]} ");
    }
  Console.WriteLine();
}
for (int i=0;i<5;i++)
{
    for (int j=0;j<3;j++)
    {
      mid[i]+=m[j,i];
    };
  Console.WriteLine (mid[i]/3);
}
for (int t=0;t<3;t++)
{
  Console.WriteLine(" ");
   
}