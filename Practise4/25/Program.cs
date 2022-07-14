void ab(int a,int b) 
{ 
  int c=1;
 for (int i=1; i<b; i++)
 {
  c*=a;
 }
 Console.WriteLine($"{a}^{b}={d}");
}
Console.WriteLine(" ");
Console.WriteLine("Введите число a:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Введите число b:");
Console.WriteLine(" ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Clear();
ab(n,m);
Console.WriteLine(" ");
