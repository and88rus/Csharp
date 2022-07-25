
using System;
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int [,] m1 = new int[a,b];
int [] m2 = new int [b];
for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++) 
{
 m1[i,j]=Convert.ToInt32(Console.ReadLine());
}
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
Console.WriteLine (" ");
for (int j=0;j<b; j++)
{
  for (int i=0; i<b;i++)
  {
     m2[i]=m1[j,i];
     int temp;
      for (int t=0;t<b-1;t++)
      {
        for (int l=0; l<b-t-1; l++)
        {
         if (m2[l+1]<m2[l])
         {
            temp=m2[l+1];
            m2[l+1]=m2[l];
            m2[2]=temp;
         }
        }
      };
  }
}
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