static int Akkerman (int m,int n) 
{
if (m==0) return n+1; else
if ((m>0)&&(n==0)) return Akkerman (m-1,n);
if ((m>0)&&(n>0)) return Akkerman (m-1,Akkerman(m,n-1));
return 0;
}
Console.WriteLine("Введите число M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите число N:");
int n=Convert.ToInt32(Console.ReadLine());
Console.Clear();
int A = Akkerman(m,n);
Console.WriteLine ($"A(m,n)={A}");