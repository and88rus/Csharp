void pal(int a) 
{
    int[] m = new int[5];
    for (int i=4; i>=0;i--)
    {
      m[i]=a%10;
      a=a/10;
    };
    if ((m[0]==m[4]) && (m[1]==m[3]))
    {
       Console.WriteLine ("Введенное число - паллиндром.");
    }
    else 
    {
       Console.WriteLine ("Введенное число - не паллиндром."); 
    }
   
};
Console.WriteLine(" ");
Console.WriteLine("Введите число N:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine (" ");
pal(n);
Console.WriteLine(" ");