void QuantityOfEvenNumbersInArray(int a)
{
Random rand = new Random();
int[] m = new int[a];
for (int i=0; i<a;i++)
{
Console.WriteLine(" ");
   m[i] = rand.Next(99,1000);
}
Console.WriteLine("Созданный массив из случайных чисел:");
for (int i=0; i<a;i++)
{
Console.WriteLine(" ");
   Console.WriteLine(m[i]);
}
int k=0;
for (int i=0; i<a;i++)
{
 if(m[i]%2==0)
 {
  k=k+1;
 };

}
Console.WriteLine(" ");
Console.WriteLine("Кол-во четных чисел в массиве:");
Console.WriteLine(" ");
Console.WriteLine(k);
};
Console.WriteLine(" ");
Console.WriteLine("Введите размер массива");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
QuantityOfEvenNumbersInArray(n);
Console.WriteLine(" ");