void SumOfSymb(int a) 
{
  int c=a;
  int size=1;
  while ((a>=10)) 
  {
    a=a/10;
    size=size+1;
  };
  int[] m = new int[size];
    for (int i=size-1; i>=0;i--)
    {
      m[i]=c%10;
      c=c/10;
    };
    int sum=0;
    for (int j=0;j<size;j++)
    {
     sum=sum+m[j];
    };
  Console.WriteLine("Сумма из чисел введенного числа следующая:");
  Console.WriteLine(" ");
  Console.WriteLine(sum);
   
};
Console.WriteLine(" ");
Console.WriteLine("Введите число N:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" ");
Console.WriteLine(n);
SumOfSymb(n);
Console.WriteLine(" ");