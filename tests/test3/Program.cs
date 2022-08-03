
int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

int c = Convert.ToInt32(Console.ReadLine());

int [,,] m= new int [a,b,c];

for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++)
 { 
  for (int t=0; t<c;t++)
  {
  Console.Write ($"Введите {i},{j},{t}-ый элемент:");
m[i,j,t]=Convert.ToInt32(Console.ReadLine());
  }
 }
Console.WriteLine (" ");
}

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");

for (int i=0;i<a;i++)
{
 for (int j=0;j<b;j++)
  { 
   for (int t=0; t<c; t++)
   {
       Console.Write($" {m[i,j,t]}{(i,j,t)} "); 
   }
    Console.WriteLine (" ");
  }
  Console.WriteLine (" ");
}

Console.WriteLine(" ");
Console.WriteLine(" ... ");
Console.WriteLine(" ");














