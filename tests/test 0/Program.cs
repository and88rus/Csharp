
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int [,] m1 = new int[a,b];
int [] m2 = new int [b];

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");

for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++) 
{
 m1[i,j]=Convert.ToInt32(Console.ReadLine());
}
}
Console.WriteLine (" ");

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");

for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++) 
{
   Console.Write($"{m1[i,j]} ");
}
Console.WriteLine();
}
Console.WriteLine (" "); 

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");

for (int i=0;i<b; i++)
{
  for (int j=0; j<b;j++)
  {
     m2[i]=m1[j,i];
      for (int t=0;t<b-1;t++)
      {
        for (int l=t+1; l<b; l++)
        {
         if (m2[t]>m2[l])
         {
            int temp=m2[t];
            m2[t]=m2[l];
            m2[l]=temp;
         }
        }
      };
  }
}

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");

Console.WriteLine (" ");
for (int i=0;i<a;i++)
{
Console.Write($"{m2[i]} ");
}
Console.WriteLine (" ");
for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++) 
{
   Console.Write($"{m1[i,j]} ");
}
Console.WriteLine();
}