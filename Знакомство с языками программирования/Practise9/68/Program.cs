static ulong Akkerman(ulong m,ulong n) 
{
Console.WriteLine();
if (m==0) return (n+1); 
else 
if (n==0) return Akkerman (m-1,n);
else 
return Akkerman(m-1,Akkerman(m,n-1));
}
Console.WriteLine("Введите число M:");
ulong m=Convert.ToUInt64(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите число N:");
ulong n=Convert.ToUInt64(Console.ReadLine());
Console.Clear();
ulong A = Akkerman(m,n);
Console.WriteLine ($"A(m,n)={A}");