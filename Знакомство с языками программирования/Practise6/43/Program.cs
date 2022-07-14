// Задание можно переформулировать следующим образом: решите систему линенйых уравнений { (1) y=k1*x+b1 (2) y=k2*x+b2, которую 
// в свою очередь можно решить по формулам Крамера.
void Kramer(double b1, double k1, double b2, double k2)
{
 if (k1==k2)
 {
   Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2} при значениях  b1={b2},k1={k1}, b2={b2}, k2={k2} не имеют точку пересечения.");
 }
 else 
 {
 double x=(b1-b2)/(-k1+k2);
 double y=(-k1*b2+k2*b1)/(-k1+k2); 
  Console.WriteLine(" ");
 Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2} при значениях b1={b2},k1={k1}, b2={b2}, k2={k2} имеют точку пересечения: ({x}.{y})");
 };
};
Console.WriteLine(" ");
Console.WriteLine("Введите значение параметра b1:");
Console.WriteLine(" ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите значение параметра k1:");
Console.WriteLine(" ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите значение параметра b2:");
Console.WriteLine(" ");
double a3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите значение параметра k2:");
Console.WriteLine(" ");
double a4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Kramer(a1,a2,a3,a4);