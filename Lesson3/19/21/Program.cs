static double dis(double a1, double b1, double c1, double a2, double b2, double c2)
{
int deg = 2;
double d=Math.Sqrt(Math.Pow((a2-a1),deg)+Math.Pow((b2-b1),deg)+Math.Pow((c2-c1),deg));
return d;
}
Console.WriteLine(" ");
Console.WriteLine("Введите координаты точки A:");
Console.WriteLine(" ");
Console.WriteLine("x1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите координаты точки B:");
Console.WriteLine(" ");
Console.WriteLine("x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z2:");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Расстояние между A и B следующее:");
Console.WriteLine(dis(x1,y1,z1,x2,y2,z2));
Console.WriteLine(" ");