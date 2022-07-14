void massive(int a) 
{
 int [] m = new int [a];
 Console.WriteLine("Введите элементы:");
 for (int i=0; i<a; i++)
 {
   Console.WriteLine(" ");
   m[i] = Convert.ToInt32(Console.ReadLine());
 };
 Console.Clear();
 Console.WriteLine(" ");
Console.WriteLine("Введенные элементы следующие:");
 for (int i=0; i<a; i++)
 {
   Console.WriteLine(" ");
   Console.WriteLine(m[i]);
 };
};
label:
Console.WriteLine(" ");
Console.WriteLine("Введите число N:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if ((n>8)||(n<0))
{
Console.WriteLine(" Ошибка! Введенное число должно быть в диапозоне (0;8].");
goto label;
};
massive(n);
Console.WriteLine(" ");