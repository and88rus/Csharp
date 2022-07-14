void defdayofweek(int a) 
{
    if ((a>=1) && (a<=5))
     {
        Console.WriteLine(" ");
        Console.WriteLine("Это будний день.");
     }

    if ((a>=6) && (a<=7))
    {
        Console.WriteLine(" ");
        Console.WriteLine("Это выходной день.");
    }

}
label:
Console.WriteLine(" ");
Console.WriteLine("Введите число N:");
Console.WriteLine(" ");
int n = Convert.ToInt32(Console.ReadLine());
if (((n>7)||(n<1)))
{
Console.WriteLine(" Ошибка! Введенное число должно быть в диапозоне [1;7].");
goto label;
}
defdayofweek(n);
Console.WriteLine(" ");