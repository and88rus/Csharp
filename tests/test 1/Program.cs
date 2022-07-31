int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int [,] m=new int[a,b];
    for (int i=0;i<a;i++) 
{
  for (int j=0;j<b;j++)
  {  Console.Write ($"Введите индекс {i},{j}-го элемента:");
      m[i,j]=Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine (" ");
}
for (int i=0;i<a;i++)
{
 for (int j=0;j<b;j++)
  { 
       Console.Write($"{m[i,j]} "); 
  }
  Console.WriteLine (" ");
}
Console.WriteLine (" ");
for (int i=0; i<a;i++)
{
  for (int t=1;t<b;t++)
   {
 for (int r=0;r<b-t;r++)
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
Console.WriteLine (" ");
for (int i=0;i<a;i++)
{
 for (int j=0;j<b;j++)
  { 
       Console.Write($"{m[i,j]} "); 
  }
  Console.WriteLine (" ");
}
