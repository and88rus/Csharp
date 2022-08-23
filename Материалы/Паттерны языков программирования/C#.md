Console . WriteLine ( " " );
Console . WriteLine ( " ... " );
Console . WriteLine ( " " );

Console . WriteLine  ( $"... " );

ВВОД ЦЕЛОГО ЧИСЛА A

int  a  = Convert . ToInt32 ( Console . ReadLine ());

ОПРЕДЕЛЕНИЕ ДВУМЕРНОГО МАССИВА РАЗМЕРА A СТРОК на B СТОЛБЦОВ

int [,] m = new int [line,col];

ВВОД ДВУМЕРНОГО МАССИВА

for (int i=0;i<a;i++) 
{
for (int j=0;j<b;j++)
 { Console.Write ($"Введите индекс {i},{j}-го элемента:");
m[i,j]=Convert.ToInt32(Console.ReadLine());
 }
Console.WriteLine (" ");
}

ВЫВОД ДВУМЕРНОГО МАССИВА

for  ( int  i = 0 ; i < b ; i ++ )
{
  for  ( int  j = 0 ; j < b ; j ++ )
  { 
        Console . Write ( $" { m [ i , j ]} " ); 
  }
   Console . WriteLine  ( " " );
}

ПУЗЫРЬКОВАЯ СОРТИРОВКА i-ОЙ СТРОКИ ДВУМЕРНОГО МАССИВА


for  ( int  i = 0 ;  i < a ; i ++ )
{
   for  ( int  t = 1 ; t < b ; t ++ )
   {
  for  ( int  r = 0 ; r < b - t ; r ++ )
 {
   if
  ( m [ i , r ] > m [ i , r + 1 ])
     {
       int  temp = m [ i , r ];
       m [ i , r ] = m [ i , r + 1 ];
       m [ i , r + 1 ] = temp ;
     }
 }
}
 }

ОПЕРАТОР GOTO 

m1:

// операторы
// ...

if (условие) goto m1;
CONSOLE.CLEAR()

Random  rnd  = new Random ();

m [ i , j , t ] = rnd . Next ( 9 , 100 );