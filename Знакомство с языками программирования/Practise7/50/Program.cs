void MeaningOfPosOfElementsOfAxBArray (int a,int b,int x1,int x2, int x3, int x4)
{
Random rand = new Random();
int [,] m = new int [a,b];
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
      m[i,j]=Convert.ToInt32(rand.Next(x1,x2));
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Созданный массив размера {a}x{b} из целых чисел следующий:");
Console.WriteLine(" ");
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
      Console.Write($"{m[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("");
if ((x3<a)&(x4<b))
{
    Console.WriteLine($" Элемент с позициями {x3},{x4} в вышевыведенном массиве следующий:");  
    Console.WriteLine(" ");
    Console.WriteLine(m[x3,x4]);
    Console.WriteLine(" ");
} 
else 
{
  Console.WriteLine ($"Элемента с позициями {x3},{x4} не существует в вышевыведенном массиве.");
}
}
Console.WriteLine(" ");
Console.WriteLine("Введите кол-во строк массива:");
Console.WriteLine(" ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("Введите кол-во столбцов массива:");
Console.WriteLine(" ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.Clear();
Console.WriteLine("Ввод диапозона значений (x1,x2), числа в пределах которого делятся на 10.0.");
Console.WriteLine(" ");
Console.WriteLine("(1) Введите число x1:");
Console.WriteLine(" ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("(2) Введите число x2:");
Console.WriteLine(" ");
int y4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("Введите номер строки элемента:");
Console.WriteLine(" ");
int y5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
Console.WriteLine("Введите номер столбца элемента: ");
Console.WriteLine(" ");
int y6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Clear();
MeaningOfPosOfElementsOfAxBArray (y1,y2,y3,y4,y5,y6);
