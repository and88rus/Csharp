int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d= Convert.ToInt32(Console.ReadLine());
int [,] m1 = new int [a,b];
int [,] m2 = new int [c,d];

for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++)
 { Console.Write ($"Введите {i},{j}-ый элемент:");
m1[i,j]=Convert.ToInt32(Console.ReadLine());
 }
Console.WriteLine (" ");
}
Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");
for (int i=0;i<c;i++) 
{
for (int j=0;j<d;j++)
 { Console.Write ($"Введите {i},{j}-ый элемент:");
m2[i,j]=Convert.ToInt32(Console.ReadLine());
 }
Console.WriteLine (" ");
}
for (int i=0;i<a;i++)
{
 for (int j=0;j<b;j++)
  { 
       Console.Write($"{m1[i,j]} "); 
  }
  Console.WriteLine (" ");
}
Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");
for (int i=0;i<c;i++)
{
 for (int j=0;j<d;j++)
  { 
       Console.Write($"{m2[i,j]} "); 
  }
  Console.WriteLine (" ");
}
if (b==c) 
{
int [,] m3 = new int [a,d];
Console.WriteLine (" ");
Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");
for (int i=0;i<a;i++)
{
 for (int j=0;j<d;j++)
  { 
       Console.Write($"{m3[i,j]} "); 
  }
  Console.WriteLine (" ");
}
Console.WriteLine (" ");
Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine (" ");
int sum=0;                                                          
  for (int x=0; x<a; x++) {
     sum=0;
    for (int y=0; y<d; y++)
    { 
     for (int r=0; r<b; r++) {

 sum+=m1[x,r]*m2[r,y];
    }
    m3[x,y]=sum;
    sum=0;
}
}
Console.WriteLine(" ... ");
for (int i=0;i<c;i++)
{
 for (int j=0;j<d;j++)
  { 
       Console.Write($"{m3[i,j]} "); 
  }
  Console.WriteLine (" ");
};
}
Console.WriteLine(" ... ");







