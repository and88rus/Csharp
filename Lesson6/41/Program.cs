void morethan0(int a) 
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
int k=0;
 for (int i=0; i<a; i++)
 {
   if (m[i]>0){
    k=k+1;
   };
 };
 Console.WriteLine($"Кол-во введенных чисел, больших 0: {k}");
};
Console.WriteLine(" ");
Console.WriteLine("Введите число M:");
Console.WriteLine(" ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Clear();
morethan0(m);
Console.WriteLine(" ");
