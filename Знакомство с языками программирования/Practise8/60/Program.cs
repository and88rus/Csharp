Random rnd = new Random ();
void GenerateOfM (int [,,] m, int line_of_m, int col_of_m, int page_of_m) 
{
for (int i=0;i<line_of_m;i++) 
{
for (int j=0;j<col_of_m;j++)
 { 
  for (int t=0; t<page_of_m;t++)
  {
m[i,j,t]=rnd.Next(9,100);
  }
 }
Console.WriteLine (" ");
}
}

void CopyMtoMcopy (int [,,] m, int[,,]mcopy, int line_of_m, int col_of_m, int page_of_m) {

for (int i=0;i<line_of_m;i++) 
{
for (int j=0;j<col_of_m;j++)
 { 
  for (int t=0; t<page_of_m;t++)
  {
mcopy[i,j,t]=m[i,j,t];
  }
 }
Console.WriteLine (" ");
};
}

void CoutOfM(int [,,] m, int[,,]mcout, int line_of_m, int col_of_m, int page_of_m)
{
for (int i=0;i<line_of_m;i++) 
{
for (int j=0;j<col_of_m;j++)
 { 
  for (int t=0; t<page_of_m;t++)
  {
    mcout[i,j,t]=0;
       for (int x=0;x<line_of_m;x++) 
       {
        for (int y=0;y<col_of_m;y++)
        { 
          for (int z=0; z<page_of_m;z++) {
            if (m[i,j,t]==m[x,y,z]) 
            {
               mcout[i,j,t]++;
            }
          
          }
        }
       }
  }
 }
Console.WriteLine (" ");
}
}

void OutPutOFm (int [,,] mcopy, int[,,]mcout, int line_of_m, int col_of_m, int page_of_m) {

for (int i=0;i<line_of_m;i++)
{
 for (int j=0;j<col_of_m;j++)
  { 
   for (int t=0; t<page_of_m; t++)
   {
     if ((mcout[i,j,t]==1)) {
       Console.Write($" {mcopy[i,j,t]}{(i,j,t)} "); 
     }
   }
    Console.WriteLine (" ");
  }
  Console.WriteLine (" ");
}
}

Console.WriteLine("Введоте кол-во строк массива m:");
int line_of_m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Введоте кол-во столбцов массива m:");
int col_of_m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Введоте кол-во страниц массива m:");
int page_of_m = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int [,,] m= new int [line_of_m,col_of_m,page_of_m];

int [,,] mcopy = new int [line_of_m,col_of_m,page_of_m];

int [,,] mcout = new int [line_of_m,col_of_m,page_of_m];

GenerateOfM (m,line_of_m,col_of_m,page_of_m);
CopyMtoMcopy (m, mcopy, line_of_m, col_of_m, page_of_m);
CoutOfM (m, mcout, line_of_m, col_of_m, page_of_m);
OutPutOFm (mcopy, mcout, line_of_m, col_of_m, page_of_m);


