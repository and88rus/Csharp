void thirdsymbol(int a) 
{
    int i=0;
    int ts=0;
    while ((a/10)>=1)
    {
     if ((a>=100) && (a<=999))
      {
        ts=a%10;
      }
      i=i+1;
      a=a/10;
    }
    if ((i<1)||(i==1))
     {
        Console.WriteLine(" ");
        Console.WriteLine("Третей цифры нет");
     }
    if (i>1)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Третья цифра:");
        Console.WriteLine(ts); 
    }
}
Console.WriteLine(" ");
Console.WriteLine("Введите число N:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
thirdsymbol(n);
Console.WriteLine(" ");