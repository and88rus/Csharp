int b=Convert.ToInt32(Console.ReadLine());
int [] m2=new int[b];
    for (int i=0;i<b;i++) 
{
 m2[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i=0;i<b;i++)
{
Console.Write($"{m2[i]} ");
}
Console.WriteLine (" ");
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
for (int i=0;i<b;i++)
{
Console.Write($"{m2[i]} ");
}

